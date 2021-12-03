using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClubRaquetaDavidAlvarez
{
    public partial class FormSocios : Form
    {
        public FormSocios()
        {
            InitializeComponent();
        }

        private void combo_dni_socios_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {

                var qDatosSocios = from c in objBD.socios
                                   where c.DNI == this.combo_dni_socios.SelectedItem.ToString()
                              select new { c.DNI, c.nombre, c.apellidos, c.domicilio, c.email, c.cuentaCorriente, c.telefono };

                var listaSoc = qDatosSocios.ToList();

                //CARGAR DATOS DEL SOCIO EN LOS TXT
                this.lbl_dni_socio.Text = listaSoc[0].DNI.ToString();
                this.txt_nombre_socio.Text = listaSoc[0].nombre.ToString();
                this.txt_apellidos_socio.Text = listaSoc[0].apellidos.ToString();
                this.txt_direccion_socio.Text = listaSoc[0].domicilio.ToString();
                this.txt_email_socio.Text = listaSoc[0].email.ToString();
                this.mtxt_ccc_socio.Text = listaSoc[0].cuentaCorriente.ToString();
                this.mtxt_telefono_socio.Text = listaSoc[0].telefono.ToString();

            }
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            using(clubraquetaEntities objBD = new clubraquetaEntities()) {

                var qSocios = from c in objBD.socios
                                  select new { c.DNI };

                var listaSoc = qSocios.ToList();

                for (int i = 0; i < listaSoc.Count; i++)
                {
                    //combo_socios.Items.Add(clubraquetaDataSet1.socios[i].nombre + " " + clubraquetaDataSet1.socios[i].apellidos);
                    this.combo_dni_socios.Items.Add(listaSoc[i].DNI);
                }

            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                //COMPROBAR PRIMERO QUE EL DNI NO EXISTE
                bool dni_unico = true;

                for(int i = 0; i< combo_dni_socios.Items.Count; i++)
                {
                    if(combo_dni_socios.Items[i].ToString() == mtxt_dni_insert_socio.Text)
                    {
                        dni_unico = false;
                    }
                }


                if (!mtxt_dni_insert_socio.MaskFull || !dni_unico || txt_nombre_insert_socio.Text == "" || txt_apellidos_insert_socio.Text == "" || !mtxt_telefono_insert_socio.MaskFull || !mtxt_ccc_insert_socio.MaskFull || txt_email_insert_socio.Text == "" || txt_email_insert_socio.Text == "")
                {
                    MessageBox.Show("ERROR. Asegurate de que el DNI es correcto y es unico, y se han rellenado el nombre y apellidos");
                }
                else
                {
                    //creamos el objeto socio
                    socios objSoc = new socios(); //objSoc es objeto de la clase socio que sirve para mapear los elementos
                    objSoc.DNI = mtxt_dni_insert_socio.Text.ToUpper();
                    objSoc.nombre = txt_nombre_insert_socio.Text;
                    objSoc.apellidos = txt_apellidos_insert_socio.Text;
                    objSoc.domicilio = txt_direccion_insert_socio.Text;
                    objSoc.email = txt_email_insert_socio.Text;
                    objSoc.cuentaCorriente = mtxt_ccc_insert_socio.Text;
                    objSoc.telefono = mtxt_telefono_insert_socio.Text;

                    //se añade el objeto a la tabla, para incluirlo
                    objBD.socios.Add(objSoc);

                    //guardar cambios
                    objBD.SaveChanges(); //aqui se guarda en la base de datos
                    MessageBox.Show("Socio añadido correctamente");
                    mtxt_dni_insert_socio.Text = "";
                    txt_nombre_insert_socio.Text = "";
                    txt_apellidos_insert_socio.Text = "";
                    txt_direccion_insert_socio.Text = "";
                    txt_email_insert_socio.Text = "";
                    mtxt_ccc_insert_socio.Text = "";
                    mtxt_telefono_insert_socio.Text = "";

                    //cargar el combobox con el nuevo añadido
                    cargar_combo_socios();

                    //mostrar el datagridview actualizado
                    mostrar_socios_datagridview();

                }
                
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                socios objSoc = objBD.socios.Find(combo_dni_socios.SelectedItem.ToString());

                if (objSoc != null)
                {
                    if (txt_nombre_socio.Text != "")
                    {
                        objSoc.nombre = txt_nombre_socio.Text;
                    }

                    if (txt_apellidos_socio.Text != "")
                    {
                        objSoc.apellidos = txt_apellidos_socio.Text;
                    }

                    if (txt_email_socio.Text != "")
                    {
                        objSoc.email = txt_email_socio.Text;
                    }
                        
                    if(txt_direccion_socio.Text != "")
                    {
                        objSoc.domicilio = txt_direccion_socio.Text;
                    }

                    if (!mtxt_telefono_socio.MaskFull)
                    {
                        MessageBox.Show("No se puede actualizar el telefono si no esta relleno correctamente");
                    }
                    else
                    {
                        objSoc.telefono = mtxt_telefono_socio.Text;
                    }

                    if (!mtxt_ccc_socio.MaskFull)
                    {
                        MessageBox.Show("No se puede actualizar la cuenta corriente si no esta rellena correctamente");
                    }
                    else
                    {
                        objSoc.cuentaCorriente = mtxt_ccc_socio.Text;
                    }

                    //guardar cambios
                    objBD.SaveChanges(); //aqui se guarda en la base de datos
                    MessageBox.Show("Datos del socio actualizados correctamente");

                    //modificar el datagridview
                    mostrar_socios_datagridview();

                }
                else
                {
                    MessageBox.Show("No se ha encontrado al socio");
                }

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                socios objSoc = objBD.socios.Find(lbl_dni_socio.Text);

                //COMPROBAR QUE EL SOCIO TIENE RESERVA
                var qReservasSocio = from c in objBD.reservas
                                     //where c.socio == this.combo_dni_socios.SelectedItem.ToString()
                                     where c.socio == this.lbl_dni_socio.Text
                                     select new { c.socio };

                var listaSoc = qReservasSocio.ToList();

                if (listaSoc.Count > 0)
                {
                    MessageBox.Show("No se puede eliminar ese socio tiene reservas", "ERROR AL ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (objSoc != null)
                    {
                        objBD.socios.Remove(objSoc);

                        //guardar cambios
                        objBD.SaveChanges(); //aqui se guarda en la base de datos
                        MessageBox.Show("Socio eliminado correctamente");

                        lbl_dni_socio.Text = "";
                        txt_nombre_socio.Text = "";
                        txt_apellidos_socio.Text = "";
                        txt_direccion_socio.Text = "";
                        txt_email_socio.Text = "";
                        mtxt_ccc_socio.Text = "";
                        mtxt_telefono_socio.Text = "";

                        //cargar el combobox sin el socio eliminado
                        this.combo_dni_socios.Text = "";
                        cargar_combo_socios();

                        //cargar el datgridview
                        mostrar_socios_datagridview();
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado al socio");
                    }
                }
                
            }
        }

        private void cargar_combo_socios()
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {
                var qSocios = from c in objBD.socios
                              select new { c.DNI };

                var listaSoc = qSocios.ToList();
                this.combo_dni_socios.Items.Clear();

                for (int i = 0; i < listaSoc.Count; i++)
                {
                    this.combo_dni_socios.Items.Add(listaSoc[i].DNI);
                }
            }
        }

        private void btn_mostrar_todos_Click(object sender, EventArgs e)
        {
            mostrar_socios_datagridview();
        }

        private void mostrar_socios_datagridview()
        {
            using (clubraquetaEntities objBD = new clubraquetaEntities())
            {

                var qTodosSocios = from c in objBD.socios
                                   orderby c.apellidos, c.nombre
                                   select new { c.DNI, c.nombre, c.apellidos, c.telefono, c.email };

                //cargar datagridview con la informacion obtenida
                dgv_socios.DataSource = qTodosSocios.OrderBy(c => c.apellidos).ToList();
                Refresh();
            }
        }

    }
}
