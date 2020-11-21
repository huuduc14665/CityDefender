using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Game_CityDefender
{
    class Bullet

    {
        Point P = new Point();

        private TrangThai tt;
        private Rectangle rect;
        private Bitmap bt = new Bitmap(Game_CityDefender.Properties.Resources.towerbullet);
        private int speed;

        public Rectangle Rect
        {
            get
            {
                return rect;
            }

            set
            {
                rect = value;
            }
        }

        public TrangThai Tt
        {
            get
            {
                return tt;
            }

            set
            {
                tt = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public Bullet(Tank tank)
        {
            if (tank.Tt == TrangThai.Up)
            {
                P.X = tank.Rect.X + tank.Rect.Width / 2;
                P.Y = tank.Rect.Y;
                bt = new Bitmap(Game_CityDefender.Properties.Resources.tbulletup);
            }
            else if (tank.Tt == TrangThai.Right)
            {
                P.X = tank.Rect.X + tank.Rect.Width;
                P.Y = tank.Rect.Y + tank.Rect.Height / 2;
                bt = new Bitmap(Game_CityDefender.Properties.Resources.tbulletright);
            }
            else if (tank.Tt == TrangThai.Down)
            {
                P.X = tank.Rect.X + tank.Rect.Width / 2;
                P.Y = tank.Rect.Y + tank.Rect.Height;
                bt = new Bitmap(Game_CityDefender.Properties.Resources.tbulletdown);
            }
            else if (tank.Tt == TrangThai.Left)
            {
                P.X = tank.Rect.X;
                P.Y = tank.Rect.Y + tank.Rect.Height / 2;
                bt = new Bitmap(Game_CityDefender.Properties.Resources.tbulletleft);
            }
            Rect = new Rectangle(P.X - 15, P.Y - 15, 30, 30);
            Tt = tank.Tt;
            Speed = 20;
        }
        public Bullet(Tower tower)
        {
            if (tower.Tt == TrangThai.Up)
            {
                P.X = tower.Rect.X + tower.Rect.Width / 2;
                P.Y = tower.Rect.Y;
            }
            else if (tower.Tt == TrangThai.Right)
            {
                P.X = tower.Rect.X + tower.Rect.Width;
                P.Y = tower.Rect.Y + tower.Rect.Height / 2;
            }
            else if (tower.Tt == TrangThai.Down)
            {
                P.X = tower.Rect.X + tower.Rect.Width / 2;
                P.Y = tower.Rect.Y + tower.Rect.Height;
            }
            else if (tower.Tt == TrangThai.Left)
            {
                P.X = tower.Rect.X;
                P.Y = tower.Rect.Y + tower.Rect.Height / 2;
            }
            Rect = new Rectangle(P.X - 10, P.Y - 10, 20, 20);

            Tt = tower.Tt;
            Speed = 10;
        }
        public void Move()
        {
            if (Tt == TrangThai.Up)
            {
                rect.Y = Rect.Y - Speed;
            }
            else if (Tt == TrangThai.Down)
            {
                rect.Y = Rect.Y + Speed;
            }
            else if (Tt == TrangThai.Left)
            {
                rect.X = Rect.X - Speed;
            }
            else if (Tt == TrangThai.Right)
            {
                rect.X = Rect.X + Speed;
            }
        }
        public void Draw(Graphics gp)
        {
            gp.DrawImage(bt, Rect);
        }
    }
}
