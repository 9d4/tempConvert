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
        static decimal input = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void textChanged()//text changed
        {
            decimal reminder;

            //dialog max var
            string iMaxNum = "You inserted the limit length!";
            string containSpace = "Don't Insert Space!";
            string wrongInput = "Wrong Input!";            
            string iMaxNumTtl = "Info";
            var icoInfo = MessageBoxIcon.Information;
            var icoWrong = MessageBoxIcon.Error;
            var button = MessageBoxButtons.OK;
            
            //first layer exception
            if (inputTemp.Text == "")
            {
                input = 0;
            }
            //space detector
            else if (inputTemp.Text.Contains(" "))
            {
                var result = MessageBox.Show(containSpace, iMaxNumTtl, button, icoInfo);
                inputTemp.Text = "";
                input = 0;
            }
            else if(!decimal.TryParse(inputTemp.Text, out reminder))
            {
                inputTemp.Text = "";
                MessageBox.Show(wrongInput, iMaxNumTtl, button, icoWrong);
                input = 0;
            }
            else
            {
                //convert from string to dec
                input = Convert.ToDecimal(inputTemp.Text);
            }

            
            //if input max
            if (inputTemp.Text.Length > 7)
            {
                var result = MessageBox.Show(iMaxNum, iMaxNumTtl, button, icoInfo);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    input = 0;
                    inputTemp.Text = "0";
                }
                else
                {
                    input = 0;
                    inputTemp.Text = "0";
                }
            }

            

            
           
            //test form checked and call suitable function
            if (fromCelcius.Checked)
            {
                celciusChecked();
            }
            else if (fromFahrn.Checked)
            {
                fahrnChecked();
            }
            else if (fromReamur.Checked)
            {
                reamurChecked();
            }
            else if (fromKelvin.Checked)
            {
                kelvinChecked();
            }

        }
        public void checkedChanged()//checked changed
        {
                textChanged();
        }

        public void celciusChecked()//celcius checked
        {
            outC.Text = input.ToString();
            outF.Text = func.CToF(input).ToString();
            outR.Text = func.CToR(input).ToString();
            outK.Text = func.CToK(input).ToString();
        }

        public void fahrnChecked()//fahrenheit checked
        {
            outC.Text = func.FToC(input).ToString();
            outF.Text = (input).ToString();
            outR.Text = func.FToR(input).ToString();
            outK.Text = func.FToK(input).ToString();
        }

        public void reamurChecked()//reamur checked
        {
            outC.Text = func.RToC(input).ToString();
            outF.Text = func.RToF(input).ToString();
            outR.Text = (input).ToString();
            outK.Text = func.RToK(input).ToString();
        }
        
        public void kelvinChecked()//kelvin checked
        {
            outC.Text = func.KToC(input).ToString();
            outF.Text = func.KToF(input).ToString();
            outR.Text = func.KToR(input).ToString();
            outK.Text = (input).ToString();
        }


        //form INPUT_CHANGED
        private void inputTemp_TextChanged(object sender, EventArgs e)
        {
            if (inputTemp.Text == "-")
            {

            }else if(inputTemp.Text.Contains("--"))
            {
                inputTemp.Text = "-";
            }
            else
            {
                textChanged();
            }
        }

        private void fromCelcius_CheckedChanged(object sender, EventArgs e)
        {
            checkedChanged();
        }

        private void fromFahrn_CheckedChanged(object sender, EventArgs e)
        {
            checkedChanged();
        }

        private void fromReamur_CheckedChanged(object sender, EventArgs e)
        {
            checkedChanged();
        }

        private void fromKelvin_CheckedChanged(object sender, EventArgs e)
        {
            checkedChanged();
        }

        //onForm load
        private void Form1_Load(object sender, EventArgs e)
        {
            inputTemp.Text = "0";
        }

        //clearButton Clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            inputTemp.Text = "";
        }
    }
}
