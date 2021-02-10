using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace snake_dreamTeam
{
    class snake_remake
    {
        /* Properties */
        Label[] snake; //the body
        int snakeBodySize = 3; // amount of labels in 1 snake
        int bodyMeasures = 10; //the size of the labels of a snake
        
        /// <summary>
        /// create the snake
        /// </summary>
        public snake_remake(Label[] snake, int snakeBodySize, int snakeBodyWidthHeight, Control ctrl, Color headcolor)
        {
            //create the head
            snake[0] = new Label();
            snake[0].Size = new Size(snakeBodyWidthHeight, snakeBodyWidthHeight);
            snake[0].BackColor = headcolor;
            snake[0].Location = new Point(200, 100);
            ctrl.Controls.Add(snake[0]);
            for (int i = 1; i < snake.Length; i++)
            {
                snake[i] = new Label();
                snake[i].Size = snake[0].Size;
                snake[i].BackColor = Color.Black;
                snake[i].Location = new Point(snake[0].Location.X - i * snakeBodyWidthHeight, snake[0].Location.Y);
                ctrl.Controls.Add(snake[i]);
            }
        }
    }
}
