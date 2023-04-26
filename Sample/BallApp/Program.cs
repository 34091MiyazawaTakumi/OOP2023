using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program : Form {

        Bar bar;  //Barインスタンス格納
        PictureBox pbBar;  //Bar表示用

        private Timer moveTimer;  //タイマー用
        
        private List<Obj> balls = new List<Obj>();  //ボールインスタンス格納用
        private List<PictureBox> pds = new List<PictureBox>();  //表示用

        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {

            //Form
            this.Size = new Size(800, 600);
            this.BackColor = Color.ForestGreen;
            this.Text = "BallGame  SoccerBall:0 TennisBall:0";

            this.MouseClick += Program_MouseClick;
            this.KeyDown += Program_KeyDown;

            //Barインスタンス生成
            bar = new Bar(330, 520);
            pbBar = new PictureBox();
            pbBar.Image = bar.Image;
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
            pbBar.Size = new Size(150, 10);
            pbBar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBar.Parent = this;

            //タイマー生成
            moveTimer = new Timer();
            moveTimer.Interval = 1;  //タイマーのインターバル(ms)
            moveTimer.Tick += MoveTimer_Tick;  //デリゲート登録
        }

        //キーが押された時のイベントハンドラ
        private void Program_KeyDown(object sender, KeyEventArgs e) {
            bar.Move(e.KeyData);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
        }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            Obj ballObj;

            PictureBox pd = new PictureBox();  //画像を表示宇するコントロール
            if (e.Button == MouseButtons.Left){
                //ボールインスタンス生成
                ballObj = new SoccerBall(e.X - 25, e.Y - 25);
                
                pd.Size = new Size(50, 50);  //画像の表示サイズ
            }
            else{
                ballObj = new TennisBall(e.X - 10, e.Y - 10);
                
                pd.Size = new Size(20, 20);  //画像の表示サイズ
            }
            
            pd.Image = ballObj.Image;
            pd.Location = new Point((int)ballObj.PosX, (int)ballObj.PosY);  //画像の位置
            pd.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
            pd.Parent = this;

            balls.Add(ballObj);
            pds.Add(pd);

            this.Text = "BallGame  SoccerBall:" + SoccerBall.Count + " TennisBall:" + TennisBall.Count;

            moveTimer.Start();  //タイマースタート
        }

        //タイマータイムアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Move(pbBar, pds[i]);
                pds[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);  //画像の位置
            }
        }
    }
}
