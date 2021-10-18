using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MessageBox_Ass1

{
    public partial class Form1 : Form1    

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NameL Alice Jane M. Malacura", "Student's Full Name",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
