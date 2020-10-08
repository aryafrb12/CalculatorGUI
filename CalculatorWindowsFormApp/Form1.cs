using System;
using CalculatorMachine;
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
                var cal = new Calculator();

                if (cbOperasi.SelectedIndex == 0)
                {
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(string.Format("{2}", a, b, cal.Penambahan(a, b)));
                }
                else if (cbOperasi.SelectedIndex == 1)
                {
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(string.Format("{2}", a, b, cal.Pengurangan(a, b)));
                }
                else if (cbOperasi.SelectedIndex == 2)
                {
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(string.Format("{2}", a, b, cal.Perkalian(a, b)));
                }
                else if (cbOperasi.SelectedIndex == 3)
                {
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(string.Format("{2}", a, b, Calculator.Pembagian(a, b)));
                }
                else if (cbOperasi.SelectedIndex == 4)
                {
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(string.Format("{2}", a, b, cal.Pangkat(a, b)));
                }
                else if (cbOperasi.SelectedIndex == 5)
                {
                    lstHasil.Items.Clear();
                    lstHasil.Items.Add(string.Format("{2}", a, b, Calculator.Modulo(a, b)));
                }
            }
        }
    }
}
