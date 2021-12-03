
namespace SGClubRaquetaDavidAlvarez
{
    partial class FormSocios
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_dni_socio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxt_ccc_socio = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_telefono_socio = new System.Windows.Forms.MaskedTextBox();
            this.txt_email_socio = new System.Windows.Forms.TextBox();
            this.txt_apellidos_socio = new System.Windows.Forms.TextBox();
            this.txt_direccion_socio = new System.Windows.Forms.TextBox();
            this.txt_nombre_socio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxt_dni_insert_socio = new System.Windows.Forms.MaskedTextBox();
            this.combo_dni_socios = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombre_insert_socio = new System.Windows.Forms.TextBox();
            this.txt_apellidos_insert_socio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_mostrar_todos = new System.Windows.Forms.Button();
            this.dgv_socios = new System.Windows.Forms.DataGridView();
            this.mtxt_telefono_insert_socio = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_direccion_insert_socio = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mtxt_ccc_insert_socio = new System.Windows.Forms.MaskedTextBox();
            this.txt_email_insert_socio = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_socios)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // lbl_dni_socio
            // 
            this.lbl_dni_socio.AutoSize = true;
            this.lbl_dni_socio.Location = new System.Drawing.Point(96, 19);
            this.lbl_dni_socio.Name = "lbl_dni_socio";
            this.lbl_dni_socio.Size = new System.Drawing.Size(16, 17);
            this.lbl_dni_socio.TabIndex = 1;
            this.lbl_dni_socio.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbl_dni_socio);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.mtxt_ccc_socio);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.mtxt_telefono_socio);
            this.panel1.Controls.Add(this.txt_email_socio);
            this.panel1.Controls.Add(this.txt_apellidos_socio);
            this.panel1.Controls.Add(this.txt_direccion_socio);
            this.panel1.Controls.Add(this.txt_nombre_socio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(34, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 237);
            this.panel1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "CCC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Apellidos:";
            // 
            // mtxt_ccc_socio
            // 
            this.mtxt_ccc_socio.Location = new System.Drawing.Point(418, 95);
            this.mtxt_ccc_socio.Mask = "ES99-9999-9999-9999-9999-9999";
            this.mtxt_ccc_socio.Name = "mtxt_ccc_socio";
            this.mtxt_ccc_socio.Size = new System.Drawing.Size(279, 22);
            this.mtxt_ccc_socio.TabIndex = 14;
            // 
            // mtxt_telefono_socio
            // 
            this.mtxt_telefono_socio.Location = new System.Drawing.Point(99, 137);
            this.mtxt_telefono_socio.Mask = "999999999";
            this.mtxt_telefono_socio.Name = "mtxt_telefono_socio";
            this.mtxt_telefono_socio.Size = new System.Drawing.Size(143, 22);
            this.mtxt_telefono_socio.TabIndex = 13;
            // 
            // txt_email_socio
            // 
            this.txt_email_socio.Location = new System.Drawing.Point(418, 134);
            this.txt_email_socio.Name = "txt_email_socio";
            this.txt_email_socio.Size = new System.Drawing.Size(279, 22);
            this.txt_email_socio.TabIndex = 12;
            // 
            // txt_apellidos_socio
            // 
            this.txt_apellidos_socio.Location = new System.Drawing.Point(418, 58);
            this.txt_apellidos_socio.Name = "txt_apellidos_socio";
            this.txt_apellidos_socio.Size = new System.Drawing.Size(279, 22);
            this.txt_apellidos_socio.TabIndex = 11;
            // 
            // txt_direccion_socio
            // 
            this.txt_direccion_socio.Location = new System.Drawing.Point(99, 98);
            this.txt_direccion_socio.Name = "txt_direccion_socio";
            this.txt_direccion_socio.Size = new System.Drawing.Size(177, 22);
            this.txt_direccion_socio.TabIndex = 10;
            // 
            // txt_nombre_socio
            // 
            this.txt_nombre_socio.Location = new System.Drawing.Point(99, 58);
            this.txt_nombre_socio.Name = "txt_nombre_socio";
            this.txt_nombre_socio.Size = new System.Drawing.Size(177, 22);
            this.txt_nombre_socio.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(481, 191);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(138, 33);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "BORRAR SOCIO";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(84, 193);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(269, 29);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "MODIFICAR DATOS DE SOCIO";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(293, 166);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(138, 28);
            this.btn_insert.TabIndex = 9;
            this.btn_insert.Text = "AÑADIR SOCIO";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Datos nuevo socio:";
            // 
            // mtxt_dni_insert_socio
            // 
            this.mtxt_dni_insert_socio.Location = new System.Drawing.Point(418, 16);
            this.mtxt_dni_insert_socio.Mask = "99999999-L";
            this.mtxt_dni_insert_socio.Name = "mtxt_dni_insert_socio";
            this.mtxt_dni_insert_socio.Size = new System.Drawing.Size(138, 22);
            this.mtxt_dni_insert_socio.TabIndex = 14;
            // 
            // combo_dni_socios
            // 
            this.combo_dni_socios.FormattingEnabled = true;
            this.combo_dni_socios.Location = new System.Drawing.Point(118, 12);
            this.combo_dni_socios.Name = "combo_dni_socios";
            this.combo_dni_socios.Size = new System.Drawing.Size(183, 24);
            this.combo_dni_socios.TabIndex = 15;
            this.combo_dni_socios.SelectedIndexChanged += new System.EventHandler(this.combo_dni_socios_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Socio:";
            // 
            // txt_nombre_insert_socio
            // 
            this.txt_nombre_insert_socio.Location = new System.Drawing.Point(105, 61);
            this.txt_nombre_insert_socio.Name = "txt_nombre_insert_socio";
            this.txt_nombre_insert_socio.Size = new System.Drawing.Size(171, 22);
            this.txt_nombre_insert_socio.TabIndex = 17;
            // 
            // txt_apellidos_insert_socio
            // 
            this.txt_apellidos_insert_socio.Location = new System.Drawing.Point(418, 61);
            this.txt_apellidos_insert_socio.Name = "txt_apellidos_insert_socio";
            this.txt_apellidos_insert_socio.Size = new System.Drawing.Size(279, 22);
            this.txt_apellidos_insert_socio.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "DNI:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nombre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(338, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Apellidos:";
            // 
            // btn_mostrar_todos
            // 
            this.btn_mostrar_todos.Location = new System.Drawing.Point(293, 540);
            this.btn_mostrar_todos.Name = "btn_mostrar_todos";
            this.btn_mostrar_todos.Size = new System.Drawing.Size(210, 31);
            this.btn_mostrar_todos.TabIndex = 22;
            this.btn_mostrar_todos.Text = "MOSTRAR TODOS";
            this.btn_mostrar_todos.UseVisualStyleBackColor = true;
            this.btn_mostrar_todos.Click += new System.EventHandler(this.btn_mostrar_todos_Click);
            // 
            // dgv_socios
            // 
            this.dgv_socios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_socios.Location = new System.Drawing.Point(37, 577);
            this.dgv_socios.Name = "dgv_socios";
            this.dgv_socios.ReadOnly = true;
            this.dgv_socios.RowHeadersWidth = 51;
            this.dgv_socios.RowTemplate.Height = 24;
            this.dgv_socios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_socios.Size = new System.Drawing.Size(717, 166);
            this.dgv_socios.TabIndex = 23;
            // 
            // mtxt_telefono_insert_socio
            // 
            this.mtxt_telefono_insert_socio.Location = new System.Drawing.Point(105, 117);
            this.mtxt_telefono_insert_socio.Mask = "999999999";
            this.mtxt_telefono_insert_socio.Name = "mtxt_telefono_insert_socio";
            this.mtxt_telefono_insert_socio.Size = new System.Drawing.Size(171, 22);
            this.mtxt_telefono_insert_socio.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Teléfono";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txt_direccion_insert_socio);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.mtxt_ccc_insert_socio);
            this.panel2.Controls.Add(this.txt_email_insert_socio);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_insert);
            this.panel2.Controls.Add(this.mtxt_telefono_insert_socio);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.mtxt_dni_insert_socio);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_nombre_insert_socio);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt_apellidos_insert_socio);
            this.panel2.Location = new System.Drawing.Point(34, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 207);
            this.panel2.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(339, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "Email:";
            // 
            // txt_direccion_insert_socio
            // 
            this.txt_direccion_insert_socio.Location = new System.Drawing.Point(105, 89);
            this.txt_direccion_insert_socio.Name = "txt_direccion_insert_socio";
            this.txt_direccion_insert_socio.Size = new System.Drawing.Size(171, 22);
            this.txt_direccion_insert_socio.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(339, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 17);
            this.label16.TabIndex = 20;
            this.label16.Text = "CCC:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 18;
            this.label14.Text = "Dirección:";
            // 
            // mtxt_ccc_insert_socio
            // 
            this.mtxt_ccc_insert_socio.Location = new System.Drawing.Point(418, 89);
            this.mtxt_ccc_insert_socio.Mask = "ES99-9999-9999-9999-9999-9999";
            this.mtxt_ccc_insert_socio.Name = "mtxt_ccc_insert_socio";
            this.mtxt_ccc_insert_socio.Size = new System.Drawing.Size(279, 22);
            this.mtxt_ccc_insert_socio.TabIndex = 19;
            // 
            // txt_email_insert_socio
            // 
            this.txt_email_insert_socio.Location = new System.Drawing.Point(418, 117);
            this.txt_email_insert_socio.Name = "txt_email_insert_socio";
            this.txt_email_insert_socio.Size = new System.Drawing.Size(279, 22);
            this.txt_email_insert_socio.TabIndex = 18;
            // 
            // FormSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 755);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_socios);
            this.Controls.Add(this.btn_mostrar_todos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combo_dni_socios);
            this.Controls.Add(this.panel1);
            this.Name = "FormSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSocios";
            this.Load += new System.EventHandler(this.FormSocios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_socios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_dni_socio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxt_ccc_socio;
        private System.Windows.Forms.MaskedTextBox mtxt_telefono_socio;
        private System.Windows.Forms.TextBox txt_email_socio;
        private System.Windows.Forms.TextBox txt_apellidos_socio;
        private System.Windows.Forms.TextBox txt_direccion_socio;
        private System.Windows.Forms.TextBox txt_nombre_socio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxt_dni_insert_socio;
        private System.Windows.Forms.ComboBox combo_dni_socios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nombre_insert_socio;
        private System.Windows.Forms.TextBox txt_apellidos_insert_socio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_mostrar_todos;
        private System.Windows.Forms.DataGridView dgv_socios;
        private System.Windows.Forms.MaskedTextBox mtxt_telefono_insert_socio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_direccion_insert_socio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mtxt_ccc_insert_socio;
        private System.Windows.Forms.TextBox txt_email_insert_socio;
    }
}