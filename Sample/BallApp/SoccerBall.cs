using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class SoccerBall : Obj{

        private static int count;

        Random random = new Random();

        public static int Count { get => count; set => count = value; }

        //コンストラクター
        public SoccerBall(double xp, double yp)
            :base(xp, yp, @"pic\soccer_ball.png") {

            int rndX = random.Next(-15, 15);
            MoveX = (rndX != 0 ? rndX : 1);
            int rndY = random.Next(-15, 15);
            MoveY = (rndY != 0 ? rndY : 1);

            Count++;
        }

        //メソッド
        public override void Move(PictureBox pbBar, PictureBox pbBall) {

            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y, pbBar.Width, pbBar.Height);

            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y, pbBall.Width, pbBall.Height);

            
            if (PosX > 728 || 0 > PosX || rBar.IntersectsWith(rBall))
            {
                MoveX *= -1;
            }else if(PosY > 508 || 0 > PosY){
                MoveY *= -1;
            }
            PosX += MoveX;
            PosY += MoveY;
        }

        public override void Move(Keys direction) {

        }
    }
}
