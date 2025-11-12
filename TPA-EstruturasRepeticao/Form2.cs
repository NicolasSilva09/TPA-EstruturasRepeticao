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
    public partial class FrmEx1 : Form
    {
        public FrmEx1()
        {
            InitializeComponent();
        }

        private void btngerar_Click(object sender, EventArgs e)
        {
            lstresult.Items.Clear();
            int i, num, mult;
            i = 1;
            num=Convert.ToInt32(txtNumero.Text);
            while (i <= 10)
            {
                mult = num * i;
                lstresult.Items.Add($"{num} x {i} = {mult}"); // adiciona no ListBox
                i++;
            };
        }

        private void FrmEx1while_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            lstresult.Items.Clear();
            txtNumero.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            FrmMenu menu= new FrmMenu();
            Hide();
            menu.Show(this);
        }

        private void btndowhile_Click(object sender, EventArgs e)
        {
            lstresult.Items.Clear();
            int i, num, mult;
            i = 1;
            num = Convert.ToInt32(txtNumero.Text);
            do
            {
                mult = num * i;
                lstresult.Items.Add($"{num} x {i} = {mult}"); // adiciona no ListBox
                i++;
            }
            while (i <= 10);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lstresult.Items.Clear();
            int i, num, mult;

            num = Convert.ToInt32(txtNumero.Text);
            for (i = 1; i <= 10; i++)
            {
                mult = num * i;
                lstresult.Items.Add($"{num} x {i} = {mult}"); // adiciona no ListBox
                ;
            }
            ;
        }
    }
}
