namespace WFP1_2019
{
    partial class frmInscripcion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDetalleSeccion = new System.Windows.Forms.Button();
            this.btnEliminarSeccion = new System.Windows.Forms.Button();
            this.btnAgregarSeccion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.SeccionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicioDia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinDia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicioDia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinDia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 375);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(810, 298);
            this.panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(810, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secciones";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(790, 227);
            this.panel5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeccionID,
            this.Asignatura,
            this.Aula,
            this.Dia1,
            this.HoraInicioDia1,
            this.HoraFinDia1,
            this.Dia2,
            this.HoraInicioDia2,
            this.HoraFinDia2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(790, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDetalleSeccion);
            this.panel4.Controls.Add(this.btnEliminarSeccion);
            this.panel4.Controls.Add(this.btnAgregarSeccion);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(790, 38);
            this.panel4.TabIndex = 0;
            // 
            // btnDetalleSeccion
            // 
            this.btnDetalleSeccion.Enabled = false;
            this.btnDetalleSeccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDetalleSeccion.Location = new System.Drawing.Point(617, 7);
            this.btnDetalleSeccion.Name = "btnDetalleSeccion";
            this.btnDetalleSeccion.Size = new System.Drawing.Size(75, 23);
            this.btnDetalleSeccion.TabIndex = 2;
            this.btnDetalleSeccion.Text = "Detalle";
            this.btnDetalleSeccion.UseVisualStyleBackColor = true;
            this.btnDetalleSeccion.Click += new System.EventHandler(this.btnDetalleSeccion_Click);
            // 
            // btnEliminarSeccion
            // 
            this.btnEliminarSeccion.Enabled = false;
            this.btnEliminarSeccion.ForeColor = System.Drawing.Color.DarkRed;
            this.btnEliminarSeccion.Location = new System.Drawing.Point(536, 7);
            this.btnEliminarSeccion.Name = "btnEliminarSeccion";
            this.btnEliminarSeccion.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarSeccion.TabIndex = 1;
            this.btnEliminarSeccion.Text = "Eliminar";
            this.btnEliminarSeccion.UseVisualStyleBackColor = true;
            this.btnEliminarSeccion.Click += new System.EventHandler(this.btnEliminarSeccion_Click);
            // 
            // btnAgregarSeccion
            // 
            this.btnAgregarSeccion.Enabled = false;
            this.btnAgregarSeccion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgregarSeccion.Location = new System.Drawing.Point(698, 7);
            this.btnAgregarSeccion.Name = "btnAgregarSeccion";
            this.btnAgregarSeccion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarSeccion.TabIndex = 0;
            this.btnAgregarSeccion.Text = "Agregar";
            this.btnAgregarSeccion.UseVisualStyleBackColor = true;
            this.btnAgregarSeccion.Click += new System.EventHandler(this.btnAgregarSeccion_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFecha);
            this.panel2.Controls.Add(this.btnAnular);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnSeleccionar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtEstudiante);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 77);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(455, 30);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(218, 20);
            this.txtFecha.TabIndex = 8;
            // 
            // btnAnular
            // 
            this.btnAnular.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAnular.Location = new System.Drawing.Point(707, 42);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(75, 23);
            this.btnAnular.TabIndex = 7;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Location = new System.Drawing.Point(707, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSeleccionar.Location = new System.Drawing.Point(358, 30);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estudiante";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(12, 31);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.ReadOnly = true;
            this.txtEstudiante.Size = new System.Drawing.Size(339, 20);
            this.txtEstudiante.TabIndex = 3;
            // 
            // SeccionID
            // 
            this.SeccionID.DataPropertyName = "SeccionID";
            this.SeccionID.HeaderText = "ID";
            this.SeccionID.Name = "SeccionID";
            this.SeccionID.ReadOnly = true;
            // 
            // Asignatura
            // 
            this.Asignatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Asignatura.DataPropertyName = "Asignatura";
            this.Asignatura.HeaderText = "Asignatura";
            this.Asignatura.Name = "Asignatura";
            this.Asignatura.ReadOnly = true;
            this.Asignatura.Width = 82;
            // 
            // Aula
            // 
            this.Aula.DataPropertyName = "Aula";
            this.Aula.HeaderText = "Aula";
            this.Aula.Name = "Aula";
            this.Aula.ReadOnly = true;
            // 
            // Dia1
            // 
            this.Dia1.DataPropertyName = "Dia1";
            this.Dia1.HeaderText = "Dia 1";
            this.Dia1.Name = "Dia1";
            this.Dia1.ReadOnly = true;
            // 
            // HoraInicioDia1
            // 
            this.HoraInicioDia1.DataPropertyName = "HoraInicioDia1";
            this.HoraInicioDia1.HeaderText = "Inicio dia 1";
            this.HoraInicioDia1.Name = "HoraInicioDia1";
            this.HoraInicioDia1.ReadOnly = true;
            // 
            // HoraFinDia1
            // 
            this.HoraFinDia1.DataPropertyName = "HoraFinDia1";
            this.HoraFinDia1.HeaderText = "Fin dia 1";
            this.HoraFinDia1.Name = "HoraFinDia1";
            this.HoraFinDia1.ReadOnly = true;
            // 
            // Dia2
            // 
            this.Dia2.DataPropertyName = "Dia2";
            this.Dia2.HeaderText = "Dia 2";
            this.Dia2.Name = "Dia2";
            this.Dia2.ReadOnly = true;
            // 
            // HoraInicioDia2
            // 
            this.HoraInicioDia2.DataPropertyName = "HoraInicioDia2";
            this.HoraInicioDia2.HeaderText = "Inicio dia 2";
            this.HoraInicioDia2.Name = "HoraInicioDia2";
            this.HoraInicioDia2.ReadOnly = true;
            // 
            // HoraFinDia2
            // 
            this.HoraFinDia2.DataPropertyName = "HoraFinDia2";
            this.HoraFinDia2.HeaderText = "Fin dia 2";
            this.HoraFinDia2.Name = "HoraFinDia2";
            this.HoraFinDia2.ReadOnly = true;
            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 375);
            this.Controls.Add(this.panel1);
            this.Name = "frmInscripcion";
            this.Text = "Inscripción";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDetalleSeccion;
        private System.Windows.Forms.Button btnEliminarSeccion;
        private System.Windows.Forms.Button btnAgregarSeccion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeccionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicioDia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinDia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicioDia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinDia2;
    }
}