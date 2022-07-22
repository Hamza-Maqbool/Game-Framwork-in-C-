using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Framwork_Movement.Movement;
using Framwork.ENUM; 

namespace Framwork.Core
{
    public class GameObject
    {
        private PictureBox pb;
        Random rand = new Random();
        private ObjectTypes oType;
        private IMovement movement;
        public GameObject(Image img, ObjectTypes oType,int top,int left,IMovement movement)
        {
            Pb = new PictureBox();
            Pb.Image = img;
            Pb.Height = img.Height;
            Pb.Width = img.Width;
            pb.BackColor = Color.Transparent;
            pb.Top = top;
            pb.Left = left;
            this.Movement = movement;
            this.oType = oType;
        }
        public GameObject(Image img, int top, int left)
        {
            pb = new PictureBox();
            Pb.Image = img;
            Pb.Height = img.Height;
            Pb.Width = img.Width;
            pb.BackColor = Color.Transparent;
            pb.Top = top;
            pb.Left = left;
        }

        public PictureBox Pb { get => pb; set => pb = value; }
        public IMovement Movement { get => movement; set => movement = value; }
        public object Properties { get; private set; }
        public ObjectTypes OType { get => oType; set => oType = value; }

        public void TopUpdate(int speed)
        {
            Pb.Top += speed;
            if (pb.Top > 350)
            {
                //changeAI1(); // change the  car images once they left the scene
                pb.Left = rand.Next(4, 327);// random numbers where they appear on the left
                pb.Top = rand.Next(100, 200)* -1; // random numbers where they appear on top
            }
            pb.BringToFront();
        }
        public void GameObjectMove()
        {
            pb.Location = Movement.move(pb.Location);
            
            pb.Location = Movement.move(pb.Location);
            pb.BringToFront();
        }
        public void changeimg(Image img)
        {
            pb.Image = img;
        }
       
    }
}
