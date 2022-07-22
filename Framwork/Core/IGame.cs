using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Framwork.Collision
{
    public interface IGame
    {
        void RaisePlayerDieEvent(PictureBox pb);
    }
}
