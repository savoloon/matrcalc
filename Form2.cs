using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Matrix R;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Matrix R0)
        {
            InitializeComponent();
            Form1.convertToDefaultView(MatrixR);
            R = R0;
            Form1.fillDataGridViewFromMatrix(MatrixR, R);
            N1.Text = Convert.ToString(R.n);
            M1.Text = Convert.ToString(R.m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
