namespace WFP1_2019
{
    partial class frmEstudiante
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cbbTipoEstudiante = new System.Windows.Forms.ComboBox();
            this.cbbCarrera = new System.Windows.Forms.ComboBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTelefonoPersonal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefonoCasa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.rbtF = new System.Windows.Forms.RadioButton();
            this.rbtM = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(614, 41);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.ForeColor = System.Drawing.Color.Green;
            this.btnAceptar.Location = new System.Drawing.Point(614, 12);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 58);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tag = "*";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(125, 80);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(202, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.Tag = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(125, 36);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(117, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cbbEstadoCivil);
            this.groupBox1.Controls.Add(this.cbbTipoEstudiante);
            this.groupBox1.Controls.Add(this.cbbCarrera);
            this.groupBox1.Controls.Add(this.txtBalance);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTelefonoPersonal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTelefonoCasa);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.gbSexo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtxtCedula);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(107, 187);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 20);
            this.label20.TabIndex = 38;
            this.label20.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(107, 131);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(107, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 20);
            this.label18.TabIndex = 36;
            this.label18.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(107, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 20);
            this.label17.TabIndex = 35;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(107, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(107, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(107, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "*";
            // 
            // cbbEstadoCivil
            // 
            this.cbbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstadoCivil.FormattingEnabled = true;
            this.cbbEstadoCivil.Location = new System.Drawing.Point(125, 187);
            this.cbbEstadoCivil.Name = "cbbEstadoCivil";
            this.cbbEstadoCivil.Size = new System.Drawing.Size(202, 21);
            this.cbbEstadoCivil.TabIndex = 31;
            this.cbbEstadoCivil.Tag = " ";
            // 
            // cbbTipoEstudiante
            // 
            this.cbbTipoEstudiante.FormattingEnabled = true;
            this.cbbTipoEstudiante.Location = new System.Drawing.Point(125, 103);
            this.cbbTipoEstudiante.Name = "cbbTipoEstudiante";
            this.cbbTipoEstudiante.Size = new System.Drawing.Size(202, 21);
            this.cbbTipoEstudiante.TabIndex = 30;
            this.cbbTipoEstudiante.Tag = "*";
            // 
            // cbbCarrera
            // 
            this.cbbCarrera.FormattingEnabled = true;
            this.cbbCarrera.Location = new System.Drawing.Point(125, 130);
            this.cbbCarrera.Name = "cbbCarrera";
            this.cbbCarrera.Size = new System.Drawing.Size(263, 21);
            this.cbbCarrera.TabIndex = 30;
            this.cbbCarrera.Tag = "*";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(125, 289);
            this.txtBalance.MaxLength = 50;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(263, 20);
            this.txtBalance.TabIndex = 28;
            this.txtBalance.Tag = " ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Balance (RD$)";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(125, 323);
            this.txtObservaciones.MaxLength = 50;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(458, 47);
            this.txtObservaciones.TabIndex = 26;
            this.txtObservaciones.Tag = " ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Observaciones";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(125, 263);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 20);
            this.txtEmail.TabIndex = 24;
            this.txtEmail.Tag = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Email";
            // 
            // txtTelefonoPersonal
            // 
            this.txtTelefonoPersonal.Location = new System.Drawing.Point(125, 237);
            this.txtTelefonoPersonal.MaxLength = 50;
            this.txtTelefonoPersonal.Name = "txtTelefonoPersonal";
            this.txtTelefonoPersonal.Size = new System.Drawing.Size(161, 20);
            this.txtTelefonoPersonal.TabIndex = 22;
            this.txtTelefonoPersonal.Tag = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Telefono  Personal";
            // 
            // txtTelefonoCasa
            // 
            this.txtTelefonoCasa.Location = new System.Drawing.Point(125, 214);
            this.txtTelefonoCasa.MaxLength = 50;
            this.txtTelefonoCasa.Name = "txtTelefonoCasa";
            this.txtTelefonoCasa.Size = new System.Drawing.Size(161, 20);
            this.txtTelefonoCasa.TabIndex = 20;
            this.txtTelefonoCasa.Tag = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Telefono de Casa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Estado Civil";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(125, 160);
            this.txtMatricula.MaxLength = 50;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.ReadOnly = true;
            this.txtMatricula.Size = new System.Drawing.Size(161, 20);
            this.txtMatricula.TabIndex = 16;
            this.txtMatricula.Tag = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Matricula";
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.label21);
            this.gbSexo.Controls.Add(this.rbtF);
            this.gbSexo.Controls.Add(this.rbtM);
            this.gbSexo.Location = new System.Drawing.Point(458, 14);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(125, 49);
            this.gbSexo.TabIndex = 15;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(6, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 20);
            this.label21.TabIndex = 39;
            this.label21.Text = "*";
            // 
            // rbtF
            // 
            this.rbtF.AutoSize = true;
            this.rbtF.Location = new System.Drawing.Point(65, 19);
            this.rbtF.Name = "rbtF";
            this.rbtF.Size = new System.Drawing.Size(31, 17);
            this.rbtF.TabIndex = 0;
            this.rbtF.TabStop = true;
            this.rbtF.Text = "F";
            this.rbtF.UseVisualStyleBackColor = true;
            // 
            // rbtM
            // 
            this.rbtM.AutoSize = true;
            this.rbtM.Location = new System.Drawing.Point(24, 19);
            this.rbtM.Name = "rbtM";
            this.rbtM.Size = new System.Drawing.Size(34, 17);
            this.rbtM.TabIndex = 0;
            this.rbtM.TabStop = true;
            this.rbtM.Text = "M";
            this.rbtM.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Tag = "*";
            this.label1.Text = "Cédula";
            // 
            // mtxtCedula
            // 
            this.mtxtCedula.Location = new System.Drawing.Point(125, 14);
            this.mtxtCedula.Mask = "99999999999";
            this.mtxtCedula.Name = "mtxtCedula";
            this.mtxtCedula.Size = new System.Drawing.Size(87, 20);
            this.mtxtCedula.TabIndex = 0;
            this.mtxtCedula.Tag = "*";
            this.mtxtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "TipoEstudiante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Carrera";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(614, 70);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmEstudiante
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(695, 422);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmEstudiante";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Registro de Estudiantes";
            this.Load += new System.EventHandler(this.frmEstudiante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox mtxtCedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rbtM;
        private System.Windows.Forms.RadioButton rbtF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTipoEstudiante;
        private System.Windows.Forms.ComboBox cbbCarrera;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTelefonoPersonal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefonoCasa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbbEstadoCivil;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
    }
}