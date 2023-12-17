using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoChart
{
    
    
    internal class MoveControl
    {
        //
        public int speed = 1;
        private int distanceMove = 3;
        private Point point1, point2;
        private Control control = null;
        Timer timerAscX = new Timer();
        Timer timerDescX = new Timer();
        Timer timerConstX = new Timer();
        //
        //private int xDestination = 0, yDestination = 0;
        //Timer timerMoveDown = new Timer();
        //Timer timerMoveRight = new Timer();
        //Timer timerMoveLeft = new Timer();
        Algorithm algorithm = null;
        public MoveControl(Algorithm algorithm)
        {
            this.algorithm = algorithm;
        }
        public void move(Control control, Point destination)
        {
            this.control = control;
            point2 = destination;
            point1 = control.Location;
            //
            if(point2.X > point1.X)
            {
                timerAscX.Interval = speed;
                timerAscX.Tick += timer_stick_ascX;
                timerAscX.Start();
            }
            else if(point2.X < point1.X)
            {
                timerDescX.Interval = speed;
                timerDescX.Tick += timer_stick_descX;
                timerDescX.Start();
            }
            else
            {

            }
        }
        //public MoveControl moveRight(Control control, int d)
        //{
        //    this.control = control;
        //    xDestination = control.Location.X + d;
        //    //

        //    timerMoveRight.Interval = speed;
        //    timerMoveRight.Tick += timer_stick_moveRight;
        //    timerMoveRight.Start();

        //    return this;
        //}
       
        //public MoveControl moveLeft(Control control, int d)
        //{
        //    this.control = control;
        //    xDestination = control.Location.X - d;
        //    //

        //    timerMoveLeft.Interval = speed;
        //    timerMoveLeft.Tick += timer_stick_moveLeft;
        //    timerMoveLeft.Start();

        //    return this;
        //}
       
     

        //private void timer_stick_moveDown(object sender, EventArgs e)
        //{
        //    if (control != null)
        //    {
        //        if(control.Location.Y < yDestination)
        //            control.Location = new Point(control.Location.X, control.Location.Y + 1);
        //        else
        //        {
        //            timerMoveDown.Stop();
        //        }

        //    }
        //}
        //private void timer_stick_moveRight(object sender, EventArgs e)
        //{
        //    if (control != null)
        //    {
        //        if (control.Location.X < xDestination)
        //            control.Location = new Point(control.Location.X + 1, control.Location.Y);
        //        else
        //        {
        //            timerMoveDown.Stop();
        //        }

        //    }
        //}
        //private void timer_stick_moveLeft(object sender, EventArgs e)
        //{
        //    if (control != null)
        //    {
        //        if (control.Location.X > xDestination)
        //            control.Location = new Point(control.Location.X - 1, control.Location.Y);
        //        else
        //        {
        //            timerMoveDown.Stop();
        //        }

        //    }
        //}
        // 
        private int getY(int x)
        {
            if(point1 != null && point2 != null)
            {
                return (x - point1.X)*(point2.Y - point1.Y) / (point2.X - point1.X) + point1.Y;
            }
            return 0;
        }
        private void timer_stick_ascX(object sender, EventArgs e)
        {
            if (control != null)
            {
                if (control.Location.X < point2.X)
                    control.Location = new Point(control.Location.X + distanceMove, getY(control.Location.X + distanceMove));
                else
                {
                    timerAscX.Stop();
                    algorithm.showResult();
                }

            }
        }
        private void timer_stick_descX(object sender, EventArgs e)
        {
            if (control != null)
            {
                if (control.Location.X > point2.X)
                    control.Location = new Point(control.Location.X - distanceMove, getY(control.Location.X - distanceMove));
                else
                {
                    timerDescX.Stop();
                    algorithm.showResult();

                }

            }
        }
        private void timer_stick_constX(object sender, EventArgs e)
        {
            if (control != null)
            {
                if (control.Location.X > point2.X)
                    control.Location = new Point(control.Location.X - distanceMove, getY(control.Location.X - distanceMove));
                else
                {
                    timerDescX.Stop();
                }

            }
        }


    }

}
