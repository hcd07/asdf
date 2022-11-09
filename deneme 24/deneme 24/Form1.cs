using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void işlemyap_Click(object sender, EventArgs e)
        {
            int ilksayı = Convert.ToInt32(textBox1.Text);
            int sonsayı =Convert.ToInt32(textBox2.Text);
            for (int i =ilksayı; i<=sonsayı; i++)
            {
                if(i%3==0 && i%5==0 )
                {
                    listBox1.Items.Add( i.ToString());
                }
            } 
        }
    }
}
