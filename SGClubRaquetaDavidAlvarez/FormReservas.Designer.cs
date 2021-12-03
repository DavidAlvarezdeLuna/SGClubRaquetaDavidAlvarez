
namespace SGClubRaquetaDavidAlvarez
{
    partial class FormReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.combo_socios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.dgv_reserva = new System.Windows.Forms.DataGridView();
            this.idReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubraquetaDataSet1 = new SGClubRaquetaDavidAlvarez.clubraquetaDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_idpista = new System.Windows.Forms.Label();
            this.pic_pista = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_reservar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.nud_minuto = new System.Windows.Forms.NumericUpDown();
            this.nud_hora = new System.Windows.Forms.NumericUpDown();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.combo_pistas = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxt_ccc = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_dni_socio = new System.Windows.Forms.Label();
            this.sociosTableAdapter1 = new SGClubRaquetaDavidAlvarez.clubraquetaDataSetTableAdapters.sociosTableAdapter();
            this.pistasTableAdapter1 = new SGClubRaquetaDavidAlvarez.clubraquetaDataSetTableAdapters.pistasTableAdapter();
            this.reservasTableAdapter1 = new SGClubRaquetaDavidAlvarez.clubraquetaDataSetTableAdapters.reservasTableAdapter();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hora)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_socios
            // 
            this.combo_socios.FormattingEnabled = true;
            this.combo_socios.Location = new System.Drawing.Point(144, 27);
            this.combo_socios.Name = "combo_socios";
            this.combo_socios.Size = new System.Drawing.Size(208, 24);
            this.combo_socios.TabIndex = 12;
            this.combo_socios.SelectedIndexChanged += new System.EventHandler(this.combo_socios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Elige al socio:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btn_pagar);
            this.panel3.Controls.Add(this.dgv_reserva);
            this.panel3.Location = new System.Drawing.Point(45, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 173);
            this.panel3.TabIndex = 9;
            // 
            // btn_pagar
            // 
            this.btn_pagar.Enabled = false;
            this.btn_pagar.Location = new System.Drawing.Point(309, 116);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(83, 37);
            this.btn_pagar.TabIndex = 1;
            this.btn_pagar.Text = "PAGAR";
            this.btn_pagar.UseVisualStyleBackColor = true;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // dgv_reserva
            // 
            this.dgv_reserva.AutoGenerateColumns = false;
            this.dgv_reserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReservaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.pistaDataGridViewTextBoxColumn,
            this.socioDataGridViewTextBoxColumn,
            this.pagadoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dgv_reserva.DataSource = this.reservasBindingSource;
            this.dgv_reserva.Location = new System.Drawing.Point(24, 14);
            this.dgv_reserva.Name = "dgv_reserva";
            this.dgv_reserva.ReadOnly = true;
            this.dgv_reserva.RowHeadersWidth = 51;
            this.dgv_reserva.RowTemplate.Height = 24;
            this.dgv_reserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_reserva.Size = new System.Drawing.Size(676, 96);
            this.dgv_reserva.TabIndex = 0;
            // 
            // idReservaDataGridViewTextBoxColumn
            // 
            this.idReservaDataGridViewTextBoxColumn.DataPropertyName = "idReserva";
            this.idReservaDataGridViewTextBoxColumn.HeaderText = "idReserva";
            this.idReservaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idReservaDataGridViewTextBoxColumn.Name = "idReservaDataGridViewTextBoxColumn";
            this.idReservaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idReservaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "hora";
            this.horaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pistaDataGridViewTextBoxColumn
            // 
            this.pistaDataGridViewTextBoxColumn.DataPropertyName = "pista";
            this.pistaDataGridViewTextBoxColumn.HeaderText = "pista";
            this.pistaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pistaDataGridViewTextBoxColumn.Name = "pistaDataGridViewTextBoxColumn";
            this.pistaDataGridViewTextBoxColumn.ReadOnly = true;
            this.pistaDataGridViewTextBoxColumn.Width = 125;
            // 
            // socioDataGridViewTextBoxColumn
            // 
            this.socioDataGridViewTextBoxColumn.DataPropertyName = "socio";
            this.socioDataGridViewTextBoxColumn.HeaderText = "socio";
            this.socioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.socioDataGridViewTextBoxColumn.Name = "socioDataGridViewTextBoxColumn";
            this.socioDataGridViewTextBoxColumn.ReadOnly = true;
            this.socioDataGridViewTextBoxColumn.Width = 125;
            // 
            // pagadoDataGridViewTextBoxColumn
            // 
            this.pagadoDataGridViewTextBoxColumn.DataPropertyName = "pagado";
            this.pagadoDataGridViewTextBoxColumn.HeaderText = "pagado";
            this.pagadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pagadoDataGridViewTextBoxColumn.Name = "pagadoDataGridViewTextBoxColumn";
            this.pagadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pagadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataMember = "reservas";
            this.reservasBindingSource.DataSource = this.clubraquetaDataSet1;
            // 
            // clubraquetaDataSet1
            // 
            this.clubraquetaDataSet1.DataSetName = "clubraquetaDataSet";
            this.clubraquetaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lbl_idpista);
            this.panel2.Controls.Add(this.pic_pista);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btn_reservar);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.nud_minuto);
            this.panel2.Controls.Add(this.nud_hora);
            this.panel2.Controls.Add(this.dtp_fecha);
            this.panel2.Controls.Add(this.combo_pistas);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(45, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 139);
            this.panel2.TabIndex = 8;
            // 
            // lbl_idpista
            // 
            this.lbl_idpista.AutoSize = true;
            this.lbl_idpista.Location = new System.Drawing.Point(350, 22);
            this.lbl_idpista.Name = "lbl_idpista";
            this.lbl_idpista.Size = new System.Drawing.Size(54, 17);
            this.lbl_idpista.TabIndex = 16;
            this.lbl_idpista.Text = "label14";
            this.lbl_idpista.Visible = false;
            // 
            // pic_pista
            // 
            this.pic_pista.Location = new System.Drawing.Point(440, 16);
            this.pic_pista.Name = "pic_pista";
            this.pic_pista.Size = new System.Drawing.Size(228, 83);
            this.pic_pista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pista.TabIndex = 15;
            this.pic_pista.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(421, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Duración: 1h 30 minutos";
            // 
            // btn_reservar
            // 
            this.btn_reservar.Enabled = false;
            this.btn_reservar.Location = new System.Drawing.Point(292, 80);
            this.btn_reservar.Name = "btn_reservar";
            this.btn_reservar.Size = new System.Drawing.Size(112, 43);
            this.btn_reservar.TabIndex = 13;
            this.btn_reservar.Text = "RESERVAR";
            this.btn_reservar.UseVisualStyleBackColor = true;
            this.btn_reservar.Click += new System.EventHandler(this.btn_reservar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = ":";
            // 
            // nud_minuto
            // 
            this.nud_minuto.Enabled = false;
            this.nud_minuto.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nud_minuto.Location = new System.Drawing.Point(178, 82);
            this.nud_minuto.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nud_minuto.Name = "nud_minuto";
            this.nud_minuto.Size = new System.Drawing.Size(50, 22);
            this.nud_minuto.TabIndex = 10;
            // 
            // nud_hora
            // 
            this.nud_hora.Enabled = false;
            this.nud_hora.Location = new System.Drawing.Point(102, 82);
            this.nud_hora.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.nud_hora.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nud_hora.Name = "nud_hora";
            this.nud_hora.Size = new System.Drawing.Size(50, 22);
            this.nud_hora.TabIndex = 9;
            this.nud_hora.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Enabled = false;
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(102, 48);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(126, 22);
            this.dtp_fecha.TabIndex = 8;
            this.dtp_fecha.Value = new System.DateTime(2021, 11, 22, 19, 11, 33, 0);
            this.dtp_fecha.ValueChanged += new System.EventHandler(this.dtp_fecha_ValueChanged);
            // 
            // combo_pistas
            // 
            this.combo_pistas.Enabled = false;
            this.combo_pistas.FormattingEnabled = true;
            this.combo_pistas.Location = new System.Drawing.Point(102, 16);
            this.combo_pistas.Name = "combo_pistas";
            this.combo_pistas.Size = new System.Drawing.Size(208, 24);
            this.combo_pistas.TabIndex = 7;
            this.combo_pistas.SelectedIndexChanged += new System.EventHandler(this.combo_pistas_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Hora Inicio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Fecha:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pista:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mtxt_ccc);
            this.panel1.Controls.Add(this.mtxt_telefono);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.txt_apellidos);
            this.panel1.Controls.Add(this.txt_direccion);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(45, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 139);
            this.panel1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "CCC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Apellidos:";
            // 
            // mtxt_ccc
            // 
            this.mtxt_ccc.Location = new System.Drawing.Point(421, 60);
            this.mtxt_ccc.Mask = "ES99-9999-9999-9999-9999-9999";
            this.mtxt_ccc.Name = "mtxt_ccc";
            this.mtxt_ccc.ReadOnly = true;
            this.mtxt_ccc.Size = new System.Drawing.Size(279, 22);
            this.mtxt_ccc.TabIndex = 14;
            // 
            // mtxt_telefono
            // 
            this.mtxt_telefono.Location = new System.Drawing.Point(102, 102);
            this.mtxt_telefono.Mask = "999-999-999";
            this.mtxt_telefono.Name = "mtxt_telefono";
            this.mtxt_telefono.ReadOnly = true;
            this.mtxt_telefono.Size = new System.Drawing.Size(143, 22);
            this.mtxt_telefono.TabIndex = 13;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(421, 99);
            this.txt_email.Name = "txt_email";
            this.txt_email.ReadOnly = true;
            this.txt_email.Size = new System.Drawing.Size(279, 22);
            this.txt_email.TabIndex = 12;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(421, 23);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.ReadOnly = true;
            this.txt_apellidos.Size = new System.Drawing.Size(279, 22);
            this.txt_apellidos.TabIndex = 11;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(102, 63);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.ReadOnly = true;
            this.txt_direccion.Size = new System.Drawing.Size(177, 22);
            this.txt_direccion.TabIndex = 10;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(102, 23);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ReadOnly = true;
            this.txt_nombre.Size = new System.Drawing.Size(177, 22);
            this.txt_nombre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "DNI Socio:";
            // 
            // lbl_dni_socio
            // 
            this.lbl_dni_socio.AutoSize = true;
            this.lbl_dni_socio.Location = new System.Drawing.Point(482, 27);
            this.lbl_dni_socio.Name = "lbl_dni_socio";
            this.lbl_dni_socio.Size = new System.Drawing.Size(21, 17);
            this.lbl_dni_socio.TabIndex = 13;
            this.lbl_dni_socio.Text = "-1";
            // 
            // sociosTableAdapter1
            // 
            this.sociosTableAdapter1.ClearBeforeFill = true;
            // 
            // pistasTableAdapter1
            // 
            this.pistasTableAdapter1.ClearBeforeFill = true;
            // 
            // reservasTableAdapter1
            // 
            this.reservasTableAdapter1.ClearBeforeFill = true;
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.lbl_dni_socio);
            this.Controls.Add(this.combo_socios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReservas";
            this.Text = "FormReservas";
            this.Load += new System.EventHandler(this.FormReservas_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubraquetaDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_minuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hora)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_socios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.DataGridView dgv_reserva;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_reservar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nud_minuto;
        private System.Windows.Forms.NumericUpDown nud_hora;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.ComboBox combo_pistas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxt_ccc;
        private System.Windows.Forms.MaskedTextBox mtxt_telefono;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private clubraquetaDataSetTableAdapters.sociosTableAdapter sociosTableAdapter1;
        private clubraquetaDataSet clubraquetaDataSet1;
        private System.Windows.Forms.PictureBox pic_pista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_dni_socio;
        private clubraquetaDataSetTableAdapters.pistasTableAdapter pistasTableAdapter1;
        private clubraquetaDataSetTableAdapters.reservasTableAdapter reservasTableAdapter1;
        private System.Windows.Forms.Label lbl_idpista;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservasBindingSource;
    }
}