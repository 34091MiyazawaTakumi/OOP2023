using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program :Form {

        private Timer moveTimer;  //タイマー用
        private SoccerBall soccerBall;
        private PictureBox pd;

        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {
            this.Size = new Size(800, 600);
            this.BackColor = Color.ForestGreen;
            this.Text = "BallGame";

            //ボールインスタンス生成
            soccerBall = new SoccerBall();
            pd = new PictureBox();  //画像を表示宇するコントロール
            pd.Image = soccerBall.Image;
            pd.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);  //画像の位置
            pd.Size = new Size(50, 50);  //画像の表示サイズ
            pd.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pd.Parent = this;

            moveTimer = new Timer();
            moveTimer.Interval = 1;  //タイマーのインターバル(ms)
            moveTimer.Start();  //タイマースタート
            moveTimer.Tick += MoveTimer_Tick;
        }

        private void MoveTimer_Tick(object sender, EventArgs e) {
            soccerBall.Move();  //移動
            pd.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);  //画像の位置
        }
    }
}
