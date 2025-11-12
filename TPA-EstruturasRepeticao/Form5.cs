using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPA_EstruturasRepeticao
{
    public partial class FrmEx2 : Form
    {
        public FrmEx2()
        {
            InitializeComponent();
        }

        private void btnconverter_Click(object sender, EventArgs e)
        {
            double f;
            int c, i;
            i = 1;
            c = 0;

            while (i <= 10) 
            {
                c = c + 10;
                f = c * 1.8 + 32;
                i++;
                lstresult.Items.Add($"{c} graus C° em Fahrenheit é: {f}");
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            lstresult.Items.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            Hide();
            menu.Show(this);
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            double f;
            int c, i;
            i = 1;
            c = 0;
            do
            {
                c = c + 10;
                f = c * 1.8 + 32;
                i++;
                lstresult.Items.Add($"{c} graus C° em Fahrenheit é: {f}");
            }
            while (i <= 10);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            double f;
            int c, i;
            c = 0;

            for (i = 1; i <= 10; i++)
            {
                c = c + 10;
                f = c * 1.8 + 32;
                lstresult.Items.Add($"{c} graus C° em Fahrenheit é:{f}");
            }
        }
    }
}
