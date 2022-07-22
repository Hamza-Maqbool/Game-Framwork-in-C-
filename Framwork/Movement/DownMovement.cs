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
    public class DownMovement:IMovement
    {
     
        Random rand = new Random();
        private int speed;
        private Point boundary;

        public object Properties { get; private set; }

        public DownMovement(int speed, Point boundary)
        {
            this.speed = speed;
            this.boundary = boundary;
        }
        public Point move(Point location)
        {
            location.Y += speed;
            if (location.Y > 350)
            {
                 // change the  car images once they left the scene
                location.X = rand.Next(4, 327);// random numbers where they appear on the left
                location.Y = rand.Next(100, 200) * -1; // random numbers where they appear on top
            }
            return location;
        }
        private void change(Image img, GameObject g)
        {
            g.changeimg(img);
            
        }
 
        
    }
}
