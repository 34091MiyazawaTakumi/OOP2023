using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Bar : Obj{

        public Bar(double xp, double yp)
            : base(xp, yp, @"pic\bar.png") {
            base.MoveX = 10;
            base.MoveY = 0;
        }        

        public override void Move() {

        }

        public override void Move(Keys direction) {
            if(direction == Keys.Right)
            {
                if (PosX < 640)
                {
                    PosX += 10;
                }
            }
            else if (direction == Keys.Left)
            {
                if (PosX > 0)
                {
                    PosX += -10;
                }
            }
           
        }
    }
}
