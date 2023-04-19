using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program : Form {

        private Timer moveTimer;  //タイマー用
        private SoccerBall soccerBall;
        private PictureBox pd;

        private List<SoccerBall> balls = new List<SoccerBall>();  //ボールインスタンス格納用
        private List<PictureBox> pds = new List<PictureBox>();  //表示用

        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {
            this.Size = new Size(800, 600);
            this.BackColor = Color.ForestGreen;
            this.Text = "BallGame";
            this.MouseClick += Program_MouseClick;

            moveTimer = new Timer();
            moveTimer.Interval = 1;  //タイマーのインターバル(ms)
            moveTimer.Tick += MoveTimer_Tick;  //デリゲート登録
        }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            //ボールインスタンス生成
            soccerBall = new SoccerBall(e.X,e.Y );
            pd = new PictureBox();  //画像を表示宇するコントロール
            pd.Image = soccerBall.Image;
            pd.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);  //画像の位置
            pd.Size = new Size(50, 50);  //画像の表示サイズ
            pd.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pd.Parent = this;

            balls.Add(soccerBall);
            pds.Add(pd);

            moveTimer.Start();  //タイマースタート
        }

        //タイマータイムアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Move();
                pds[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);  //画像の位置
            }
        }
    }
}
