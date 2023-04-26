using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class Bar : Obj{

        Random random = new Random();

        public Bar(double xp, double yp)
            : base(xp, yp, @"pic\bar.png") {

            int rndX = random.Next(-50, 50);
            MoveX = (rndX != 0 ? rndX : 1);
            int rndY = random.Next(-50, 50);
            MoveY = (rndY != 0 ? rndY : 1);
        }

        

        public override void Move() {

        }
    }
}
