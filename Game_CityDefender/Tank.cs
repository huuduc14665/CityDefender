using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_CityDefender
{
    public enum TrangThai
    {
        Up, Down, Right, Left
    }
    public class Tank
    {
        private Rectangle rect;
        private bool run;
        private int speed = 10;
        private int hp = 5;
        Bitmap BTank= new Bitmap(Game_CityDefender.Properties.Resources.tankup);
        public void Move()
        {

            if (Tt == TrangThai.Up)
            {
                rect.Y = Rect.Y - Speed;
                BTank = new Bitmap(Game_CityDefender.Properties.Resources.tankup);
            }
            if (Tt == TrangThai.Right)
            {
                rect.X = Rect.X + Speed;
                BTank = new Bitmap(Game_CityDefender.Properties.Resources.tankright);
            }
            if (Tt == TrangThai.Down)
            {
                rect.Y = Rect.Y + Speed;
                BTank = new Bitmap(Game_CityDefender.Properties.Resources.tankdown);
            }
            if (Tt == TrangThai.Left)
            {
                rect.X = Rect.X - Speed;
                BTank = new Bitmap(Game_CityDefender.Properties.Resources.tankleft);
            }

        }

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

        public bool Run
        {
            get
            {
                return run;
            }

            set
            {
                run = value;
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

        public Tank()
        {
            Rect = new Rectangle();
            rect.X = 930;
            rect.Y = 510;
            rect.Width = 50;
            rect.Height = 50;
        }

        public void Draw(Graphics myGp)
        {
            myGp.DrawImage(BTank, Rect);

        }
    }
}