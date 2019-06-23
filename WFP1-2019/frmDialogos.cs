using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFP1_2019.Clases;

namespace WFP1_2019
{
    public partial class frmDialogos : Form
    {
        public frmDialogos()
        {
            InitializeComponent();
            this.linkLabel1.Links.Add(3, 4,"http:\\www.uasd.edu");
            this.linkLabel1.Links.Add(14, 4,"http:\\www.ucne.edu");

           // System.Diagnostics.Process.Start((string)e.Link.LinkData);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                this.txtColor.ForeColor = colorDialog1.Color;
            }

        }

        private void btnColorFondo_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.AnyColor = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtColor.BackColor = colorDialog1.Color;
            }

        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtFuente.Text.Trim().Length==0)
            {
                errorProvider1.SetError(txtFuente, "No puede estar en blanco.");
                return;
            }

            fontDialog1.ShowApply = true;
            fontDialog1.ShowColor = true;
            fontDialog1.ShowEffects = true;
            if(fontDialog1.ShowDialog()==DialogResult.OK)
            {
                this.txtFuente.Font = fontDialog1.Font;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = "Imágenes | *.jpeg; *.jpg; *.gif; *.png | Todos los Archivos | *.*";
            openFileDialog1.Title = "Buscar Archivo";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                this.pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //guarda
            saveFileDialog1.FileName = string.Empty;
            saveFileDialog1.Filter = "Rich Text | *.rtf";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abre
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = "Rich Text | *.rtf";
            openFileDialog1.Title = "Buscar Archivo";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }
        private void btnNegrita_Click(object sender, EventArgs e)
        {
            FontStyle style = richTextBox1.SelectionFont.Style;
            if (richTextBox1.SelectionFont.Bold)
                style &= ~FontStyle.Bold;
            else
                style |= FontStyle.Bold;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }
        private void btnCursiva_Click(object sender, EventArgs e)
        {
            FontStyle style = richTextBox1.SelectionFont.Style;
            if (richTextBox1.SelectionFont.Italic)
                style &= ~FontStyle.Italic;
            else
                style |= FontStyle.Italic;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }
        private void btnSubrayado_Click(object sender, EventArgs e)
        {
            FontStyle style = richTextBox1.SelectionFont.Style;
            if (richTextBox1.SelectionFont.Underline)
                style &= ~FontStyle.Underline;
            else
                style |= FontStyle.Underline;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // System.Diagnostics.Process.Start("http://www.ucne.edu");
            System.Diagnostics.Process.Start((string)e.Link.LinkData);
        }

        private void frmDialogos_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // progressBar1.Value   = int.Parse(numericUpDown1.Value.ToString());
            // trackBar1.Value = Convert.ToInt32(numericUpDown1.Value);

            progressBar1.Value = numericUpDown1.Value.Entero();
            trackBar1.Value = numericUpDown1.Value.Entero();
        }
    }
}
