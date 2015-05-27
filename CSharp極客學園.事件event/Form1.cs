using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp極客學園.事件event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Method
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Froms");
        }
    }
}
