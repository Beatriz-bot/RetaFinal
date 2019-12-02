using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

          
             this.Hide();
             Form1 OutroForm = new Form1();
             OutroForm.ShowDialog();
             this.Close();
            
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
