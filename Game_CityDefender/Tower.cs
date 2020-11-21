using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_CityDefender
{
    class Tower

    {
        private Rectangle rect;
        private int hp = 5;
        private Bitmap bt;
        private TrangThai tt;

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

        public int Hp
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
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

        public void draw(Graphics myGp)
        {
            myGp.DrawImage(bt, Rect);
            myGp.FillRectangle(new SolidBrush(Color.Red), Rect.X, Rect.Y - 10, hp * 10, 5);
        }
        public Tower(Point p, TrangThai Tt)
        {
            Rect = new Rectangle(p.X, p.Y, 50, 50);
            this.Tt = Tt;

            if (Tt == TrangThai.Up)
            {
                bt = new Bitmap(Game_CityDefender.Properties.Resources.towerup);
            }
            if (Tt == TrangThai.Right)
            {
                bt = new Bitmap(Game_CityDefender.Properties.Resources.towerright);
            }
            if (Tt == TrangThai.Down)
            {
                bt = new Bitmap(Game_CityDefender.Properties.Resources.towerdown);
            }
            if (Tt == TrangThai.Left)
            {
                bt = new Bitmap(Game_CityDefender.Properties.Resources.towerleft);
            }
        }

    }
}
