namespace WFP1_2019
{
    partial class frmConflictoSecciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicioDia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinDia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicioDia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinDia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMensaje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 63);
            this.panel1.TabIndex = 3;
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.SystemColors.Control;
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.ForeColor = System.Drawing.Color.Red;
            this.txtMensaje.Location = new System.Drawing.Point(5, 8);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(775, 46);
            this.txtMensaje.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 180);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Aula,
            this.Dia1,
            this.HoraInicioDia1,
            this.HoraFinDia1,
            this.Dia2,
            this.HoraInicioDia2,
            this.HoraFinDia2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(784, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "SeccionID";
            this.ID.FillWeight = 50F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Aula
            // 
            this.Aula.DataPropertyName = "Aula";
            this.Aula.FillWeight = 85.27919F;
            this.Aula.HeaderText = "Aula";
            this.Aula.Name = "Aula";
            this.Aula.ReadOnly = true;
            // 
            // Dia1
            // 
            this.Dia1.DataPropertyName = "Dia1";
            this.Dia1.FillWeight = 85.27919F;
            this.Dia1.HeaderText = "Dia1";
            this.Dia1.Name = "Dia1";
            this.Dia1.ReadOnly = true;
            // 
            // HoraInicioDia1
            // 
            this.HoraInicioDia1.DataPropertyName = "HoraInicioDia1";
            this.HoraInicioDia1.FillWeight = 85.27919F;
            this.HoraInicioDia1.HeaderText = "Hora inicio dia 1";
            this.HoraInicioDia1.Name = "HoraInicioDia1";
            this.HoraInicioDia1.ReadOnly = true;
            // 
            // HoraFinDia1
            // 
            this.HoraFinDia1.DataPropertyName = "HoraFinDia1";
            this.HoraFinDia1.FillWeight = 85.27919F;
            this.HoraFinDia1.HeaderText = "Hora fin dia 1";
            this.HoraFinDia1.Name = "HoraFinDia1";
            this.HoraFinDia1.ReadOnly = true;
            // 
            // Dia2
            // 
            this.Dia2.DataPropertyName = "Dia2";
            this.Dia2.FillWeight = 85.27919F;
            this.Dia2.HeaderText = "Dia 2";
            this.Dia2.Name = "Dia2";
            this.Dia2.ReadOnly = true;
            // 
            // HoraInicioDia2
            // 
            this.HoraInicioDia2.DataPropertyName = "HoraInicioDia2";
            this.HoraInicioDia2.FillWeight = 85.27919F;
            this.HoraInicioDia2.HeaderText = "Hora inicio dia 2";
            this.HoraInicioDia2.Name = "HoraInicioDia2";
            this.HoraInicioDia2.ReadOnly = true;
            // 
            // HoraFinDia2
            // 
            this.HoraFinDia2.DataPropertyName = "HoraFinDia2";
            this.HoraFinDia2.FillWeight = 85.27919F;
            this.HoraFinDia2.HeaderText = "Hora fin dia 2";
            this.HoraFinDia2.Name = "HoraFinDia2";
            this.HoraFinDia2.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAceptar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 43);
            this.panel3.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(705, 8);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmConflictoSecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 243);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConflictoSecciones";
            this.Text = "frmConflictoAulas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicioDia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinDia1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicioDia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinDia2;
    }
}