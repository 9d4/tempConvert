using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tempConvert
{
    public partial class Form1 : Form
    {
        Fungsi func = new Fungsi();
        public Form1()
        {
            InitializeComponent();
        }

        private void inputTemp_TextChanged(object sender, EventArgs e)
        {
            if (fromCelcius.Checked)
            {
                outCelcius.Text = func.CToF(Decimal.Parse(inputTemp.Text)).ToString();
            }
            
        }
    }
}
