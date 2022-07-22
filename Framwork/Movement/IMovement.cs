using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Framwork_Movement.Movement
{
    public interface IMovement
    {
        Point move(Point location);
    }
}
