using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaDavidAlvarez
{
    public partial class FormReservas : Form
    {
        public FormReservas()
        {
            InitializeComponent();
        }

        ArrayList listaDNI = new ArrayList();

        private void combo_socios_SelectedIndexChanged(object sender, EventArgs e)
        {
            clubraquetaDataSet1.socios.Clear();
            sociosTableAdapter1.FillByDNI(clubraquetaDataSet1.socios, listaDNI[combo_socios.SelectedIndex].ToString()); //debe aparecer el nombre y apellidos, y utilizar el valor del dni en el combobox

            this.txt_nombre.Text = clubraquetaDataSet1.socios[0].nombre.ToString();
            this.txt_apellidos.Text = clubraquetaDataSet1.socios[0].apellidos.ToString();
            this.txt_direccion.Text = clubraquetaDataSet1.socios[0].domicilio.ToString();
            this.mtxt_ccc.Text = clubraquetaDataSet1.socios[0].cuentaCorriente.ToString();
            this.mtxt_telefono.Text = clubraquetaDataSet1.socios[0].telefono .ToString();
            this.txt_email.Text = clubraquetaDataSet1.socios[0].email.ToString();
            this.lbl_dni_socio.Text = clubraquetaDataSet1.socios[0].DNI.ToString();

            if(lbl_dni_socio.Text != "-1")
            {
                combo_pistas.Enabled = true;
                dtp_fecha.Enabled = true;
                nud_hora.Enabled = true;
                nud_minuto.Enabled = true;
                //btn_reservar.Enabled = true;
                btn_pagar.Enabled = true;
            }

            clubraquetaDataSet1.reservas.Clear();
            reservasTableAdapter1.FillBySocio(clubraquetaDataSet1.reservas, this.lbl_dni_socio.Text);

        }

        private void FormReservas_Load(object sender, EventArgs e)
        {
            //cargamos los socios
            clubraquetaDataSetTableAdapters.sociosTableAdapter taSocios = new clubraquetaDataSetTableAdapters.sociosTableAdapter();
            taSocios.Fill(clubraquetaDataSet1.socios);

            for (int i = 0; i < clubraquetaDataSet1.socios.Count; i++)
            {
                //combo_socios.Items.Add(clubraquetaDataSet1.socios[i].nombre + " " + clubraquetaDataSet1.socios[i].apellidos);
                combo_socios.Items.Add(clubraquetaDataSet1.socios[i].apellidos + ", " + clubraquetaDataSet1.socios[i].nombre);
                listaDNI.Add(clubraquetaDataSet1.socios[i].DNI);
            }

            //cargamos las pistas
            clubraquetaDataSetTableAdapters.pistasTableAdapter taPistas = new clubraquetaDataSetTableAdapters.pistasTableAdapter();
            taPistas.FillByNombreAsc(clubraquetaDataSet1.pistas);

            for (int i = 0; i < clubraquetaDataSet1.pistas.Count; i++)
            {
                //combo_socios.Items.Add(clubraquetaDataSet1.socios[i].nombre + " " + clubraquetaDataSet1.socios[i].apellidos);
                combo_pistas.Items.Add(clubraquetaDataSet1.pistas[i].nombre);
            }

            //hacer que el datetimepicker no pueda coger fechas anteriores a la actual
            dtp_fecha.MinDate = DateTime.Today;

        }

        private void combo_pistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            clubraquetaDataSet1.pistas.Clear();
            pistasTableAdapter1.FillByNombrePista(clubraquetaDataSet1.pistas, this.combo_pistas.Text);

            if(clubraquetaDataSet1.pistas.Rows.Count > 0)
            {
                //inicializar una fila
                DataRow myRow = clubraquetaDataSet1.pistas.Rows[0];

                //almacenar campo foto en array de bytes
                byte[] MyData = (byte[])myRow["foto"];

                //Se inicializa un flujo de memoria en el array de bytes
                MemoryStream stream = new MemoryStream(MyData);

                //mostrar en el picture box
                pic_pista.Image = Image.FromStream(stream);


                lbl_idpista.Text = clubraquetaDataSet1.pistas[0].idPista.ToString();
            }

            if (combo_pistas.Text.ToString() == "")
            {
                btn_reservar.Enabled = false;
            }
            else
            {
                btn_reservar.Enabled = true;
            }

            

        }

        private void btn_reservar_Click(object sender, EventArgs e)
        {
            bool sinPagar = false;

            clubraquetaDataSet1.reservas.Clear();
            reservasTableAdapter1.FillBySocio(clubraquetaDataSet1.reservas, this.lbl_dni_socio.Text);

            //Primero comprobar que el cliente no tiene reservas sin pagar

            for (int i = 0; i < clubraquetaDataSet1.reservas.Count; i++)
            {
                if(clubraquetaDataSet1.reservas[i].pagado.ToLower().Equals("no")){
                    sinPagar = true;
                }
            }

            if (sinPagar)
            {
                DialogResult dr = MessageBox.Show("Este cliente tiene reservas sin pagar", "RESERVAS SIN PAGAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //comprobar que la pista no has ido reservada 1h 30min antes y despues
                clubraquetaDataSet1.reservas.Clear();
                reservasTableAdapter1.FillByPistaFecha(clubraquetaDataSet1.reservas, int.Parse(this.lbl_idpista.Text.ToString()),dtp_fecha.Text.ToString());

                TimeSpan horaReserva_Anterior;
                TimeSpan hora_Reserva_Nueva_y_Rango;
                bool ocupado = false;

                //Console.WriteLine(clubraquetaDataSet1.reservas.Count.ToString());

                for (int j = 0; j < clubraquetaDataSet1.reservas.Count; j++)
                {
                    //SACO LA HORA DE LA RESERVA QUE YA EXISTIA EN LA BASE DE DATOS
                    horaReserva_Anterior = clubraquetaDataSet1.reservas[j].hora;

                    //SACAR LA INFO DE LOS NUMERIC UPDOWN
                    TimeSpan horaNumerics = new TimeSpan(int.Parse(nud_hora.Value.ToString()), int.Parse(nud_minuto.Value.ToString()),0);
                    //Console.WriteLine("saco de los nud " + horaComp.ToString());

                    //ESTE FOR COMPARA LA HORA DE RESERVA OBTENIDA EN LA QUERY CON LA HORA DE LOS NUMERIC UPDOWN CON UN RANGO DE UNA HORA
                    for (int k =-60; k <= 60; k = k + 30)
                    {
                        hora_Reserva_Nueva_y_Rango = horaNumerics.Add(TimeSpan.FromMinutes(k));

                        //Console.WriteLine(hora_Reserva_Nueva_y_Rango.ToString());
                        //Console.WriteLine(clubraquetaDataSet1.reservas[j].hora);

                        if (horaReserva_Anterior == hora_Reserva_Nueva_y_Rango)
                        {
                            ocupado = true;
                        }

                    }

                }

                if (ocupado)
                {
                    DialogResult dr = MessageBox.Show("No se puede reservar la pista a esa hora porque ya esta reservada", "HORA NO VALIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Pista libre. ¿Reservar?", "HORA VALIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (dr == DialogResult.OK)
                    {
                        //INSERTAR RESERVA EN BBDD

                        reservasTableAdapter1.InsertQueryReserva(
                            dtp_fecha.Text.ToString(), 
                            new TimeSpan(int.Parse(nud_hora.Value.ToString()), int.Parse(nud_minuto.Value.ToString()), 0).ToString(), 
                            int.Parse(lbl_idpista.Text),
                            lbl_dni_socio.Text,
                            "No",
                            Decimal.Multiply(clubraquetaDataSet1.pistas[0].precioHora, Decimal.Parse("1,5")));

                        MessageBox.Show("Pista reservada correctamente", "HORA VALIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clubraquetaDataSet1.reservas.Clear();
                        reservasTableAdapter1.FillBySocio(clubraquetaDataSet1.reservas, this.lbl_dni_socio.Text);

                    }
                }
                
            }
        
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            if(dgv_reserva.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una reserva");
            }
            else
            {
                if (dgv_reserva.SelectedRows[0].Cells[5].Value.ToString() == "No")
                {
                    reservasTableAdapter1.UpdateQueryReservaSiPagada(int.Parse(dgv_reserva.SelectedRows[0].Cells[0].Value.ToString()));

                    clubraquetaDataSet1.reservas.Clear();
                    reservasTableAdapter1.FillBySocio(clubraquetaDataSet1.reservas, this.lbl_dni_socio.Text);

                    MessageBox.Show("Reserva pagada, gracias");
                }
                else
                {
                    MessageBox.Show("Ya pagaste esa reserva");
                }
            }
        }

        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
