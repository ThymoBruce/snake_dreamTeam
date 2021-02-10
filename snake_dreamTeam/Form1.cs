using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_dreamTeam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int snakesize = 3;
            Label[] snake = new Label[snakesize];
            var snakeVar = new snake_remake(snake, snakesize, 15, this, Color.Red);
        }
    }
}
