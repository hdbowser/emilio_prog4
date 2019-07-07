namespace WFP1_2019
{
    partial class frmSecciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProfesorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicioDia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinDia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicioDia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinDia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cbbAsignatura = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNuevo.Location = new System.Drawing.Point(815, 27);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 24;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(778, 317);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 13);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total";
            // 
            // lblCantidad
            // 
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(815, 312);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(75, 23);
            this.lblCantidad.TabIndex = 21;
            this.lblCantidad.Text = "0";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfesorID,
            this.Profesor,
            this.Dia1,
            this.HoraInicioDia1,
            this.HoraFinDia1,
            this.Dia2,
            this.HoraInicioDia2,
            this.HoraFinDia2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(878, 226);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ProfesorID
            // 
            this.ProfesorID.DataPropertyName = "SeccionID";
            this.ProfesorID.FillWeight = 20.30457F;
            this.ProfesorID.HeaderText = "ID";
            this.ProfesorID.Name = "ProfesorID";
            this.ProfesorID.ReadOnly = true;
            this.ProfesorID.Visible = false;
            // 
            // Profesor
            // 
            this.Profesor.DataPropertyName = "Profesor";
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.Name = "Profesor";
            this.Profesor.ReadOnly = true;
            // 
            // Dia1
            // 
            this.Dia1.DataPropertyName = "Dia1";
            this.Dia1.HeaderText = "Día 1";
            this.Dia1.Name = "Dia1";
            this.Dia1.ReadOnly = true;
            // 
            // HoraInicioDia1
            // 
            this.HoraInicioDia1.DataPropertyName = "HoraInicioDia1";
            this.HoraInicioDia1.HeaderText = "H. Inicio día 1";
            this.HoraInicioDia1.Name = "HoraInicioDia1";
            this.HoraInicioDia1.ReadOnly = true;
            // 
            // HoraFinDia1
            // 
            this.HoraFinDia1.DataPropertyName = "HoraFinDia1";
            this.HoraFinDia1.HeaderText = "H. Fin día 1";
            this.HoraFinDia1.Name = "HoraFinDia1";
            this.HoraFinDia1.ReadOnly = true;
            // 
            // Dia2
            // 
            this.Dia2.DataPropertyName = "Dia2";
            this.Dia2.HeaderText = "Día 2";
            this.Dia2.Name = "Dia2";
            this.Dia2.ReadOnly = true;
            // 
            // HoraInicioDia2
            // 
            this.HoraInicioDia2.DataPropertyName = "HoraInicioDia2";
            this.HoraInicioDia2.HeaderText = "H. Inicio día 2";
            this.HoraInicioDia2.Name = "HoraInicioDia2";
            this.HoraInicioDia2.ReadOnly = true;
            // 
            // HoraFinDia2
            // 
            this.HoraFinDia2.DataPropertyName = "HoraFinDia2";
            this.HoraFinDia2.HeaderText = "H. Fin día 2";
            this.HoraFinDia2.Name = "HoraFinDia2";
            this.HoraFinDia2.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(279, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(734, 27);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cbbAsignatura
            // 
            this.cbbAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAsignatura.FormattingEnabled = true;
            this.cbbAsignatura.Location = new System.Drawing.Point(12, 29);
            this.cbbAsignatura.Name = "cbbAsignatura";
            this.cbbAsignatura.Size = new System.Drawing.Size(251, 21);
            this.cbbAsignatura.TabIndex = 30;
            //this.cbbAsignatura.SelectedIndexChanged += new System.EventHandler(this.cbbAsignatura_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Asignatura";
            // 
            // frmSecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 363);
            this.Controls.Add(this.cbbAsignatura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.Name = "frmSecciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cbbAsignatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfesorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicioDia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinDia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicioDia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinDia2;
    }
}