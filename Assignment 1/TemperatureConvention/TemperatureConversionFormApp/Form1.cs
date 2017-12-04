using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversionFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnC2F_Click(object sender, EventArgs e)
        {
            FormWcfReference.Service1Client myProxy = new FormWcfReference.Service1Client();
            String inputC = this.txtInputC.Text;

            try
            {
                int tempC = Convert.ToInt32(inputC);
                int resultF = myProxy.c2f(tempC);
                this.labelResultF.Text = resultF.ToString();
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show("Invalid Entry :: " + exception.Message);
                this.txtInputC.Text = "";
                this.labelResultF.Text = "Shows result in F";

            }

        }

        private void btnF2C_Click(object sender, EventArgs e)
        {
            FormWcfReference.Service1Client myProxy = new FormWcfReference.Service1Client();
            String inputF = this.txtInputF.Text;

            try
            {
                int tempF = Convert.ToInt32(inputF);
                int resultC = myProxy.f2c(tempF);
                this.labelResultC.Text = resultC.ToString();
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show("Invalid Entry :: " + exception.Message);
                this.txtInputF.Text = "";
                this.labelResultC.Text = "Shows result in C";

            }
        }
    }
}
