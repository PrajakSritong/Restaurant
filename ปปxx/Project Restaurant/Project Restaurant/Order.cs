using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Restaurant
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.ShowDialog();
        }

        private void fastfoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menufood menufood = new Menufood();
            menufood.ShowDialog();
        }

        private void thaifoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menufood menufood = new Menufood();
            menufood.ShowDialog();
        }
    }
}
