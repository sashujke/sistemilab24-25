using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class compitoform : Form
    {
        public compitoform()
        {
            InitializeComponent();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtboxinput.Clear();
            txtboxoutput.Clear();


        }

        private void Controllatasti(string testo, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c > '0' && c < '9') || c == ' ')
            {
                e.Handled = true; //vieta l'inserimento
            }
        }




        private void txtboxoutput_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtboxinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcola_Click(object sender, EventArgs e)
        {
            


                // convertazione 

            string InputText = txtboxinput.Text;
            string Outputtext = "";

            foreach (char c in InputText)
            {
                int result = 0;
                int input = (int)c; // 99

                while (input > 0)
                {
                    result += input & 1; // 99 0101011  1 = 1 = 1          1 = 0 = 0
                    input = input >> 1; //48 010101 1 = 1 =1  // 24 0100 0 = 1 = 0  // 12 011 1 = 1 = 1  // 6 00 0 = 1 = 0  // 2  0 = 1 = 0
                }

                Outputtext += result & 1;


            }
            txtboxoutput.Text = Outputtext;
            Console.WriteLine(txtboxinput.Text);
            MessageBox.Show(txtboxoutput.Text);





        }
    }
}

