using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framwork.Core;

namespace Framwork.Collision
{
    public interface ICollisionAction
    {
        void performAction(Game game, GameObject source1, GameObject source2);
    }
}
