using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winMySQL.Clases;

namespace winMySQL
{
    public partial class FrmReporte : Form
    {
        public FrmReporte()
        {
            InitializeComponent();
        }
        BindingSource mySql = new BindingSource();

        private void frmReporte_Load(object sender, EventArgs e)
        {
            DataSet ds = Datos.ejecutar("SELECT * FROM productos");
            mySql.DataSource = ds.Tables[0];
            dataGridView1.DataSource = mySql;
        }
    }
}
