using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Framwork_Movement.Movement;
using Framwork.Core;
using System.Windows.Forms;

namespace Framwork.Movement
{
    public class OneTimeMovement : IMovement
    {
        Random rand = new Random();
        private int speed;
        private Point boundary;
        Game go ;

        public object Properties { get; private set; }

        public OneTimeMovement(int speed, Point boundary)
        {
            this.speed = speed;
            this.boundary = boundary;
        }
        public Point move(Point location)
        {
            location.Y += speed;
            if (location.Y > 350)
            {
                //go.removeonetimeMovement();
            }
            return location;
        }
    }
}
