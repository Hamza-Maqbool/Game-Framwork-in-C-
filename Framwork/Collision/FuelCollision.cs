using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framwork.ENUM;
using Framwork.Core;

namespace Framwork.Collision
{
    public class FuelCollision : ICollisionAction
    {
        public void performAction(Game game, GameObject source1, GameObject source2)
        {
            GameObject player;
            if (source1.OType == ObjectTypes.player)
            {
                // game.CaughtCollisionEvent(ObjectTypes.cars);
                player = source2;
            }
            else
            {
                player = source1;
            }
            game.RaisePlayerDieEvent2(player.Pb);
        }
    }
}
