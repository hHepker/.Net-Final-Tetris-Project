using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Layer
{
    public class Moves
    {
        public bool rightKey { get; set; }
        public bool leftKey { get; set; }

        public Moves()
        {
            rightKey = false;
            leftKey = false;
        }

        public void keyControls(Keys key, bool pressed)
        {
            if (key == Keys.Left)
                leftKey = pressed;
            else if (key == Keys.Right)
                rightKey = pressed;
        }
    }
}

