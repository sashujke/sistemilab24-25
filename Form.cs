// GUIDA 6 CLASSE FORMCOMBOBOX
// https://youtu.be/4IiupS7HMBU

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class FormColor : Form
    {
        public FormColor()
        {
            InitializeComponent();
        }

        private void btnColora_Click(object sender, EventArgs e)
        {
            int scelta = cbxColori.SelectedIndex;
                    switch (scelta) {
                case 0:
                    ColoraPanello(Color.Yellow);
                   break;
                case 1:
                    ColoraPanello(Color.Red);
                    break;
                case 2:
                    ColoraPanello(Color.Blue);
                    break;
                case 3:
                    ColoraPanello(Color.LightPink);
                    break;
                case -1:
                    MessageBox.Show("Seleziona colore giusto", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void ColoraPanello (Color colore)
        {
            pnlColore.BackColor = colore;
            pnlColore.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ColoraPanello(Color.White);
            cbxColori.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
