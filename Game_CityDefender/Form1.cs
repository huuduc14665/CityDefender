using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_CityDefender
{
    public partial class Form1 : Form
    {

        List<Bullet> listTankB = new List<Bullet>();
        List<Bullet> listTowerB = new List<Bullet>();
        int tTower;
        bool gun;
        int time;
        Bitmap bmp;
        Tank myTank;
        Map playMap;
        Keys tankMove;
        int Score = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void ReLoad()
        {
            listTankB = new List<Bullet>();
            listTowerB = new List<Bullet>();
            tTower = 0;
            gun = false;
            time = 0;
            myTank = new Tank();
            playMap = new Map(Game_CityDefender.Properties.Resources.ToaDo_Map1, Game_CityDefender.Properties.Resources.ToaDoTru_Map1);
            Score = 0;
            myTank.Tt = TrangThai.Up;
            Bitmap bt = new Bitmap(Game_CityDefender.Properties.Resources.maptest);
            pbGame.BackgroundImage = bt;
            btPause.Enabled = true;
            pbControl.Refresh();
            pbGame.Refresh();
            tm.Start();
            btPause.Text = "Pause";
            pbGame.Focus();

            lbGameOver.Visible = false;
            lbPause.Visible = false;
            this.KeyPreview = true;
        }

        private void tm_Tick(object sender, EventArgs e)

        {
            playMap.TMrd(ref time);
            time++;
            tTower++;
            if (gun)
            {
                Bullet TankBullet = new Bullet(myTank);
                //TankBullet.tank = true;
                listTankB.Add(TankBullet);
                gun = false;
            }

            if (tTower == 50)
            {
                for (int i = 0; i < playMap.ListTower.Count; i++)
                {
                    Bullet TowerBullct = new Bullet(playMap.ListTower[i]);
                    listTowerB.Add(TowerBullct);

                }
                tTower = 0;
            }
            for (int i = 0; i < listTankB.Count; i++)// đạn cd
            {
                listTankB[i].Move();
            }
            for (int i = 0; i < listTowerB.Count; i++)
            {
                listTowerB[i].Move();
            }
            for (int i = 0; i < listTankB.Count; i++)// va chạm 2 đạn
                for (int j = 0; j < listTowerB.Count; j++)
                {
                    if (VaCham.even(listTankB[i], listTowerB[j]))
                    {
                        listTankB.Remove(listTankB[i]);
                        listTowerB.Remove(listTowerB[j]);
                        i--;
                        break;
                    }
                }
            for (int i = 0; i < listTankB.Count; i++)
            {
                if (VaCham.even(listTankB[i], playMap.ListTower))// găm mục tiêu
                {
                    listTankB.Remove(listTankB[i]);
                    i--;
                    Score = Score + 60;
                }
                else if (!playMap.move(listTankB[i].Tt, listTankB[i].Rect, 0))//găm tường
                {
                    listTankB.Remove(listTankB[i--]);
                }

            }
            for (int i = 0; i < listTowerB.Count; i++)
            {

                if (VaCham.even(listTowerB[i], myTank))// găm mục tiêu
                {
                    if (myTank.Hp == 0)
                    {
                        break;
                    }
                    listTowerB.Remove(listTowerB[i]);
                    i--;
                }
                else if (!playMap.move(listTowerB[i].Tt, listTowerB[i].Rect, 0))//găm tường
                {
                    listTowerB.Remove(listTowerB[i--]);
                }
            }
            pbGame.Refresh();
            pbControl.Refresh();
            if (myTank.Hp == 0)
            {
                tm.Stop();
                btPause.Enabled = false;
                lbGameOver.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReLoad();
            lbPause.Visible = false;
            lbGameOver.Visible = false;
        }

        private void pbGame_Paint(object sender, PaintEventArgs e)
        {
            bmp = new Bitmap(pbGame.Width, pbGame.Height);
            Graphics gp = Graphics.FromImage(bmp);
            myTank.Draw(gp);
            for (int i = 0; i < listTankB.Count; i++)
                listTankB[i].Draw(gp);
            for (int i = 0; i < listTowerB.Count; i++)
                listTowerB[i].Draw(gp);
            playMap.Draw(gp);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(btPause.Text=="Pause")
            {
                tankMove = e.KeyData;
                tmTankMove.Start();
            }
         
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            tmTankMove.Stop();
        }

        private void pbControl_Click(object sender, EventArgs e)
        {

        }

        private void pbControl_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bm = new Bitmap(pbControl.Width, pbControl.Height);
            Graphics gp = Graphics.FromImage(bm);
            Bitmap logo = new Bitmap(Game_CityDefender.Properties.Resources.logo);
            gp.DrawImage(logo, 15, 30);
            for (int i = 0; i < myTank.Hp; i++)
            {
                Bitmap hp = new Bitmap(Game_CityDefender.Properties.Resources.hp);
                gp.DrawImage(hp, 25 + i * 30, 130);
            }
            lbScore.Text = Score.ToString();
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void tmTankMove_Tick(object sender, EventArgs e)
        {
            if (tankMove == Keys.W)
            {
                myTank.Tt = TrangThai.Up;
                myTank.Run = true;
            }
            else if (tankMove == Keys.D)
            {
                myTank.Tt = TrangThai.Right;
                myTank.Run = true;
            }
            else if (tankMove == Keys.S)
            {
                myTank.Tt = TrangThai.Down;
                myTank.Run = true;
            }
            else if (tankMove == Keys.A)
            {
                myTank.Tt = TrangThai.Left;
                myTank.Run = true;
            }
            if (playMap.move(myTank.Tt, myTank.Rect, myTank.Speed) && myTank.Run == true)//xác định vật cản phía trc
            {
                myTank.Move();
                myTank.Run = false;
            }
        }

        private void pbGame_MouseDown(object sender, MouseEventArgs e)
        {
            gun = true;
            myTank.Run = true;
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            
            if(btPause.Text=="Pause")
            {
                btPause.Text = "Continue";
                lbPause.Visible = true;
                tm.Stop();
            }
            else if(btPause.Text=="Continue")
            {
                btPause.Text = "Pause";
                lbPause.Visible = false;
                tm.Start();
            }
        }

        private void btNewGame_Click(object sender, EventArgs e)
        {
            tm.Stop();
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn chơi lại", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                ReLoad();
            else
                tm.Start();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
