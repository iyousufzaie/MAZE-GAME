using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Maze";
            this.BackColor = Color.Tan;
            this.label1.BackColor = Color.DarkGreen;
            this.label41.Text = "Start";
            this.label42.Text = "Finish";
            this.Cursor = Cursors.Hand;
            this.button1.Text = "Exit";
        }

        private void label42_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have crossed the MAZE");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
