using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormApp
{
    public partial class Layout : Form
    {
        public Layout()
        {
            InitializeComponent();
        }

        private float Penambahan(float a, float b)
        {
            return a + b;
        }

        private float Pengurangan(float a, float b)
        {
            return a - b;
        }

        private float Perkalian(float a, float b)
        {
            return a * b;
        }

        private float Pembagian(float a, float b)
        {
            return a / b;
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (txtNilaiA.Text == "" || txtNilaiB.Text == "" || cbOperasi.SelectedIndex == -1)
            {
                string message = "Silahkan Inputkan Nilai dan Pilih Operasi Terlebih Dahulu";
                string title = "Error";
                MessageBox.Show(message, title);
            }
            else
            {
                var a = float.Parse(txtNilaiA.Text); 
                var b = float.Parse(txtNilaiB.Text); 

                if (cbOperasi.SelectedIndex == 0)
                {
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(string.Format("{2}", a, b, Penambahan(a, b)));
                }
                else if (cbOperasi.SelectedIndex == 1)
                {
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(string.Format("{2}", a, b, Pengurangan(a, b)));
                }
                else if (cbOperasi.SelectedIndex == 2)
                {
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(string.Format("{2}", a, b, Perkalian(a, b)));
                }
                else if (cbOperasi.SelectedIndex == 3)
                {
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(string.Format("{2}", a, b, Pembagian(a, b)));
                }
            }
        }
    }
}
