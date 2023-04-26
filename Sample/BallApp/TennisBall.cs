using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class TennisBall : Obj {

        private static int count;

        Random random = new Random();

        public static int Count { get => count; set => count = value; }

        public TennisBall(double xp, double yp)
            : base(xp, yp, @"pic\tennis_ball.png") {

            int rndX = random.Next(-50, 50);
            MoveX = (rndX != 0 ? rndX : 1);
            int rndY = random.Next(-50, 50);
            MoveY = (rndY != 0 ? rndY : 1);

            Count++;
        }

        public override void Move() {
            PosX += MoveX;
            PosY += MoveY;
            if (PosX > 728 || 0 > PosX)
            {
                MoveX *= -1;
            }
            else if (PosY > 508 || 0 > PosY)
            {
                MoveY *= -1;
            }
        }

        public override void Move(Keys direction) {

        }
    }
}
