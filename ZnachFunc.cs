using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr2._1_Коршикова
{
    public partial class ZnachFunc : Form
    {
        public ZnachFunc()
        {
            InitializeComponent();
        }

        private void btnPusk_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);
            double z = Convert.ToDouble(txtZ.Text);

            txtVivod.Text = "Результат работы программы " + Environment.NewLine + "студента Коршиковой Э.П." + Environment.NewLine;
            txtVivod.Text += "При X = " + txtX.Text + Environment.NewLine;
            txtVivod.Text += "При Y = " + txtY.Text + Environment.NewLine;
            txtVivod.Text += "При Z = " + txtZ.Text + Environment.NewLine;

            double u;
            if ((z - x) == 0)
                u = y * Math.Sin(x) * Math.Sin(x) + z;
            else
                if ((z - x) < 0)
                u = y * Math.Exp(Math.Sin(x)) - z;
            else
                u = y * Math.Sin(Math.Sin(x)) + z;

            txtVivod.Text += "U = " + u.ToString() + Environment.NewLine;

        }

        private void btnOchistit_Click(object sender, EventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            txtZ.Clear();
            txtVivod.Clear();
        }
    }
}
