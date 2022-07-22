using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Framwork_Movement.Movement;
using System.Windows.Forms;

namespace Framwork.Movement
{
    public class Keyboard : IMovement
    {
        private int speed;
        private Point boundary;
        private string ArrowAction;
        public Keyboard(int speed, Point boundary)
        {
            this.speed = speed;
            this.boundary = boundary;
        }
        public void userkeyboard(Keys keyCode)
        {
            if(keyCode == Keys.Up)
            {
                ArrowAction = "up";
            }
            else if(keyCode == Keys.Down)
            {
                ArrowAction = "down";
            }
            else if (keyCode == Keys.Left)
            {
                ArrowAction = "left";
            }
            else if (keyCode == Keys.Right)
            {
                ArrowAction = "right";
            }
        }
        public Point move(Point location)
        {
            if (ArrowAction != null)
            {
                if (ArrowAction == "up" && location.Y >= 10)
                {
                    location.Y -= speed;
                }
                if (ArrowAction == "down" && location.Y <= 340)
                {
                    location.Y += speed;
                }
                if (ArrowAction == "left" && location.X >= 10)
                {
                    location.X -= speed;
                }
                if (ArrowAction == "right" && location.X <= 340)
                {
                    location.X += speed;
                }
                ArrowAction = null;
            }
            return location;
        }
    }

}
