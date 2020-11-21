using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Game_CityDefender
{
    class Map

    {
        private List<Rectangle> wall = new List<Rectangle>();
        private List<Tower> listTower = new List<Tower>();
        private List<Tower> listFile = new List<Tower>();
        private int time = 0;
        private int timeAppear = 120;
        
        int k = -1;

        public List<Rectangle> Wall
        {
            get
            {
                return wall;
            }

            set
            {
                wall = value;
            }
        }

        public List<Tower> ListTower
        {
            get
            {
                return listTower;
            }

            set
            {
                listTower = value;
            }
        }

        public List<Tower> ListFile
        {
            get
            {
                return listFile;
            }

            set
            {
                listFile = value;
            }
        }



        public Map(string fMap, string fTower)
        {
            Rectangle a = new Rectangle();
            string str="";
            foreach(char c in fMap)
            {
                if (c == ' ')
                {
                    a.X = Convert.ToInt32(str);
                    str = "";
                }
                else if(c=='\r')
                {

                }
                else if (c == '\n')
                {
                    a.Y = Convert.ToInt32(str);
                    a.Width = 30;
                    a.Height = 30;
                    Wall.Add(new Rectangle(a.X, a.Y, a.Width, a.Height));
                    str = "";

                }
                else
                {
                    str = str + c.ToString();
                }
   
            }
            a.Y = Convert.ToInt32(str);
            a.Width = 30;
            a.Height = 30;
            Wall.Add(new Rectangle(a.X, a.Y, a.Width, a.Height));
            str = "";



            Point p = new Point();
            TrangThai Tt = TrangThai.Down;
            Random rd = new Random();
            bool x = false;
            foreach (char c in fTower)
            {
                if (c == ' ' && !x)
                {
                    p.X = Convert.ToInt32(str);
                    str = "";
                    x = true;
                }
                else if (c == ' ' && x)
                {
                    p.Y = Convert.ToInt32(str);
                    str = "";
                    x = false;
                }
                else if(c=='\r')
                {

                }
                else if(c == '\n')
                {
                    Tt = (TrangThai)(Convert.ToInt32(str));
                    ListFile.Add(new Tower(p, Tt));
                    str = "";
                }
                else
                {
                    str = str + c.ToString();
                }
            }
            Tt = (TrangThai)(Convert.ToUInt32(str));
            ListFile.Add(new Tower(p, Tt));

        }
        public bool move(TrangThai Tt, Rectangle Location, int speed)
        {
            if (TrangThai.Up == Tt)
            {
                Location.Y = Location.Y - speed;
            }
            else if (TrangThai.Down == Tt)
            {
                Location.Y = Location.Y + speed;
            }
            else if (TrangThai.Right == Tt)
            {
                Location.X = Location.X + speed;
            }
            else if (TrangThai.Left == Tt)
            {
                Location.X = Location.X - speed;
            }
            for (int i = 0; i < Wall.Count; i++)
            {
                int x1, x2;
                if (Location.X < Wall[i].X)
                    x1 = Wall[i].X + Wall[i].Width - Location.X;
                else
                    x1 = Location.X + Location.Width - Wall[i].X;
                x2 = Location.Width + Wall[i].Width;
                int y1, y2;
                if (Location.Y < Wall[i].Y)
                    y1 = Wall[i].Y + Wall[i].Height - Location.Y;
                else
                    y1 = Location.Y + Location.Height - Wall[i].Y;
                y2 = Location.Height + Wall[i].Height;
                if (x2 > x1 && y2 > y1)
                    return false;
            }
            for (int i = 0; i < ListTower.Count; i++)
            {
                int x1, x2;
                if (Location.X < ListTower[i].Rect.X)
                    x1 = ListTower[i].Rect.X + ListTower[i].Rect.Width - Location.X;
                else
                    x1 = Location.X + Location.Width - ListTower[i].Rect.X;
                x2 = Location.Width + ListTower[i].Rect.Width;
                int y1, y2;
                if (Location.Y < ListTower[i].Rect.Y)
                    y1 = ListTower[i].Rect.Y + ListTower[i].Rect.Height - Location.Y;
                else
                    y1 = Location.Y + Location.Height - ListTower[i].Rect.Y;
                y2 = Location.Height + ListTower[i].Rect.Height;
                if (x2 > x1 && y2 > y1)
                {
                    return false;
                }

            }
            return true;
        }
        public void Draw(Graphics gp)
        {
            for (int i = 0; i < ListTower.Count; i++)
            {
                ListTower[i].draw(gp);
            }
            if (time % 10 < 5 && time > (timeAppear-30) && time < timeAppear && ListFile.Count > ListTower.Count)
            {
                ListFile[k].draw(gp);
            }

        }
        public void TMrd(ref int time)
        {
            Random rd = new Random();
            bool t = true;
            if (ListFile.Count > ListTower.Count && time == (timeAppear-30))
            {
                while (t)
                {
                    k = rd.Next(0, ListFile.Count);
                    t = ListTower.Contains(ListFile[k]);
                }

            }
            else if(listFile.Count==ListTower.Count)
            {
                time = 0;
            }
            else if (time == timeAppear)
            {
                if (ListFile.Count > ListTower.Count)
                {
                    ListTower.Add(ListFile[k]);
                    if ((timeAppear - 3) > 60)
                        timeAppear = timeAppear - 3;
                }                
                time = 0;
            }
            this.time = time;

        }
    }
}
