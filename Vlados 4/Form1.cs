using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vlados_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            War_ship ship = new War_ship(richTextBox3.Text,
                Int32.Parse(richTextBox1.Text),
                Int32.Parse(richTextBox2.Text));
            richTextBox5.Text = ship.get_Q().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ship_spees leader = new Ship_spees(richTextBox3.Text,
               Int32.Parse(richTextBox1.Text),
               Int32.Parse(richTextBox2.Text), Int32.Parse(richTextBox6.Text));
            richTextBox5.Text = leader.get_Q().ToString();
        }
    }
}
