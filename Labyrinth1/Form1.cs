using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinth1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = new Point(this.Location.X + 55, this.Location.Y + 60);
        }

        private void Form1_load(object sender, EventArgs e)
        {
            Cursor.Position = new Point(this.Location.X + 55, this.Location.Y + 60);
        }

        private void labelFinish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Victory!");
        }
    }
}
