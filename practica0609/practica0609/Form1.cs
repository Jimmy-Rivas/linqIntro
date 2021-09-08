using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica0609
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Programacion computacional"); 

        }
        private void btnClic_Click( object sender, EventArgs e)
        {
            int[] nums = new int[] { 8, 9, 4, 6, 7,10,7,8 };

            var num = from n in nums select n;
            foreach (int i in num)
                lstData.Items.Add(i);
        }
    }
}
