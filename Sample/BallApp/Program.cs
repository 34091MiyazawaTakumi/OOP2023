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
        private TennisBall tennisBall;
        private PictureBox pd;
        int ballcount = 0;

        private List<SoccerBall> sballs = new List<SoccerBall>();  //ボールインスタンス格納用
        private List<TennisBall> tballs = new List<TennisBall>();
        private List<PictureBox> pds = new List<PictureBox>();  //表示用
        private List<PictureBox> pdt = new List<PictureBox>();

        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {
            this.Size = new Size(800, 600);
            this.BackColor = Color.ForestGreen;
            this.Text = "BallGame" + ballcount;
            this.MouseClick += Program_MouseClick;

            moveTimer = new Timer();
            moveTimer.Interval = 1;  //タイマーのインターバル(ms)
            moveTimer.Tick += MoveTimer_Tick;  //デリゲート登録
        }

        //マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left){
                //ボールインスタンス生成
                soccerBall = new SoccerBall(e.X - 25, e.Y - 25);
                pd = new PictureBox();  //画像を表示宇するコントロール
                pd.Image = soccerBall.Image;
                pd.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);  //画像の位置
                pd.Size = new Size(50, 50);  //画像の表示サイズ
                pd.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
                pd.Parent = this;

                sballs.Add(soccerBall);
                pds.Add(pd);
                this.Text = "BallGame" + ++ballcount;
                moveTimer.Start();  //タイマースタート
            }else{
                tennisBall = new TennisBall(e.X - 25, e.Y - 25);
                pd = new PictureBox();  //画像を表示宇するコントロール
                pd.Image = tennisBall.Image;
                pd.Location = new Point((int)tennisBall.PosX, (int)tennisBall.PosY);  //画像の位置
                pd.Size = new Size(25, 25);  //画像の表示サイズ
                pd.SizeMode = PictureBoxSizeMode.StretchImage;  //画像の表示モード
                pd.Parent = this;

                tballs.Add(tennisBall);
                pdt.Add(pd);
                this.Text = "BallGame" + ++ballcount;
                moveTimer.Start();  //タイマースタート
            }
        }

        //タイマータイムアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < sballs.Count; i++)
            {
                sballs[i].Move();
                pds[i].Location = new Point((int)sballs[i].PosX, (int)sballs[i].PosY);  //画像の位置
            }
            for (int i = 0; i < tballs.Count; i++)
            {
                tballs[i].Move();
                pdt[i].Location = new Point((int)tballs[i].PosX, (int)tballs[i].PosY);  //画像の位置
            }
        }
    }
}
