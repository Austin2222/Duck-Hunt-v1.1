using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck_Hunt_1._1
{
        class Duck
        {
            public Rectangle duck;
            Random random = new Random();
            public int pos_x = 950 / 2;
            public int pos_y = 599;
            public int counter = 0;
            public int speed;
            public bool movingLeft = true;
            public bool movingUp = true;

            public void Spawn(Canvas canvas)
            {
                duck = new Rectangle();
                ///BitmapImage bitmapImage = new BitmapImage(new Uri());
                ///ImageBrush img = new ImageBrush(bitmapImage);
                ///duck.Fill = img;
                duck.Fill = Brushes.Aqua;
                duck.Height = 50;
                duck.Width = 50;
                speed = random.Next(8, 15);
                //assigns a starting direction
                if (speed % 2 == 0) { movingLeft = true; }
                if (speed % 2 != 0) { movingLeft = false; }

                canvas.Children.Add(duck);
                pos_x = 950 / 2;
                pos_y = 599;
            }

            public void Move(int counter)
            {
                //moves it per tick
                /*Canvas.SetLeft(duck, pos_x + counter*speed);
                Canvas.SetTop(duck, pos_y + counter*speed);*/
                //checks if it has hit an edge and defines a new direction if it has
                if (pos_x <= 1)
                {
                    movingLeft = true;
                }
                else if (pos_x >= 949)
                {
                    movingLeft = false;
                }
                if (pos_y <= 1)
                {
                    movingUp = true;
                }
                else if (pos_y >= 599)
                {
                    movingUp = false;
                }
                //sends a change direction command
                if (movingLeft == false & movingUp == true)
                {
                    ChangeDirection(0);
                }
                else if (movingLeft == true & movingUp == true)
                {
                    ChangeDirection(1);
                }
                else if (movingLeft == false & movingUp == false)
                {
                    ChangeDirection(2);
                }
                else if (movingLeft == true & movingUp == false)
                {
                    ChangeDirection(3);
                }

                //moves the duck
                if (movingLeft == true)
                {
                    pos_x = pos_x + speed;
                    Canvas.SetLeft(duck, pos_x);
                }
                else if (movingLeft == false)
                {
                    pos_x = pos_x - speed;
                    Canvas.SetLeft(duck, pos_x);
                }
                if (movingUp)
                {
                    pos_y = pos_y + speed;
                    Canvas.SetTop(duck, pos_y);
                }
                else
                {
                    pos_y = pos_y - speed;
                    Canvas.SetTop(duck, pos_y);
                }
            }

            public void Kill(Canvas canvas)
            {
                canvas.Children.Remove(duck);
            }

            public void ChangeDirection(int direction)
            {
                if (direction == 0)
                {
                    //duck.Fill = //duck facing NE
                }
                else if (direction == 1)
                {
                    //duck.Fill = //duck facing NW
                }
                else if (direction == 2)
                {
                    //duck.Fill = //duck facing SE
                }
                else if (direction == 3)
                {
                    //duck.Fill = //duck facing SW
                }
            }
        }
    }
