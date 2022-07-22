using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framwork.Core;
using Framwork.ENUM;

namespace Framwork.Collision
{
    public class CarCollision : ICollisionAction
    {
        public void performAction(Game game, GameObject source1, GameObject source2)
        {
            GameObject player;
            if (source1.OType == ObjectTypes.player)
            {
                // game.CaughtCollisionEvent(ObjectTypes.cars);
                player = source1;
            }
            else
            {
                player = source2;
            }
            game.RaisePlayerDieEvent(player.Pb);
        }
    }
}
