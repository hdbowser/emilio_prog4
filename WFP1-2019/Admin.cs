﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFP1_2019
{
    public partial class Admin : Form
    {
        public Admin(string nombre)
        {
            InitializeComponent();
            lblMensajeAdmin.Text = nombre;
        }
    }
}
