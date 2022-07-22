using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Framwork_Movement.Movement;
using Framwork.Movement;
using Framwork.ENUM;
using Framwork.Collision;

namespace Framwork.Core
{
    public class Game : IGame
    {
        private List<GameObject> GameObjects;
        private List<CollisionClass> collisions;
        int speed;

        internal List<CollisionClass> Collisions { get => collisions; set => collisions = value; }
        public List<GameObject> GameObjects1 { get => GameObjects; set => GameObjects = value; }

        public event EventHandler invokeGamecbject;
        //public event EventHandler invokeCreateObject;
        public event EventHandler OnPlayerDie;
        public event EventHandler OnPlayerDie2;
        public Game(int speed)
        {
            this.speed = speed;
            GameObjects1 = new List<GameObject>();
            Collisions = new List<CollisionClass>();
        }
        public void UpdateSpeed()
        {
            detectCollision();
            for (int i = 0;i<GameObjects1.Count;i++)
            {
                GameObjects1[i].GameObjectMove();
               // GameObjects[i].TopUpdate(speed);
              
                
            }
        }
        
        public void addGameObject(Image img,ObjectTypes otype, int top, int left,IMovement movement)
        {
            GameObject go = new GameObject(img,otype, top, left,movement);
            GameObjects1.Add(go);
            invokeGamecbject?.Invoke(go.Pb, EventArgs.Empty);
        }
        public void iskeypressed(Keys keycode)
        {
            foreach(GameObject go in GameObjects1)
            {
                //go.OType == ObjectTypes.player
                
                if (go.Movement.GetType() == typeof(Keyboard))
                {
                    Keyboard keymove = (Keyboard)go.Movement;
                    keymove.userkeyboard(keycode);
                }
            }
        }
        public void deleteObject()
        {
            
            foreach (GameObject g in GameObjects1)
            { 
                GameObjects1.Remove(g);
                //invokeCreateObject?.Invoke(null, EventArgs.Empty);
                
            }
        }
        public void RaisePlayerDieEvent(PictureBox playerGameobject)
        {
            OnPlayerDie?.Invoke(playerGameobject, EventArgs.Empty);
        }
        public void RaisePlayerDieEvent2(PictureBox playerGameobject)
        {
            OnPlayerDie2?.Invoke(playerGameobject, EventArgs.Empty);
        }
        public void detectCollision()
        {
            for (int i = 0; i < GameObjects1.Count; i++)
            {
                for (int j = 0; j < GameObjects1.Count; j++)
                {
                    if (GameObjects1[i].Pb.Bounds.IntersectsWith(GameObjects1[j].Pb.Bounds))
                    {
                        foreach (CollisionClass c in Collisions)
                        {
                            if ((GameObjects1[i].OType == c.G1 && GameObjects1[j].OType == c.G2) || (GameObjects1[i].OType == c.G2 && GameObjects1[j].OType == c.G1))
                            {
                                c.Behaviour.performAction(this, GameObjects1[i], GameObjects1[j]);
                            }
                        }
                    }
                }
            }
        }
        public void addCollisions(CollisionClass c)
        {
            collisions.Add(c);
        }
        public void removeonetimeMovement()
        {
            foreach(GameObject C in GameObjects)
            {
                if(C.GetType() == typeof(OneTimeMovement))
                {
                    GameObjects.Remove(C);
                }
            }
        }
    }
}
