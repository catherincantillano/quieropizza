﻿using QuieroPizza.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuieroPizza.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var productoBL = new ProductosBL();
            var listadeProductos = productoBL.ObtenerProductos();

            listadeProductosBindingSource.DataSource = listadeProductos; 
        }

        private void listadeProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
