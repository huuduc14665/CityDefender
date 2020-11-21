using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Game_CityDefender
{
    static class VaCham
    {
        public static bool even(Bullet TowerB, Tank Tk)
        {
            Rectangle Location = TowerB.Rect;
            int x1, x2;
            if (Location.X < Tk.Rect.X)
                x1 = Tk.Rect.X + Tk.Rect.Width - Location.X;
            else
                x1 = Location.X + Location.Width - Tk.Rect.X;
            x2 = Location.Width + Tk.Rect.Width;
            int y1, y2;
            if (Location.Y < Tk.Rect.Y)
                y1 = Tk.Rect.Y + Tk.Rect.Height - Location.Y;
            else
                y1 = Location.Y + Location.Height - Tk.Rect.Y;
            y2 = Location.Height + Tk.Rect.Height;
            if (x2 > x1 && y2 > y1)
            {
                Tk.Hp--;
                return true;
            }
            return false;
        }
        public static bool even(Bullet TankB,  List<Tower> listTower)
        {
            Rectangle Location = TankB.Rect;
            for (int i = 0; i < listTower.Count; i++)
            {
                int x1, x2;
                if (Location.X < listTower[i].Rect.X)
                    x1 = listTower[i].Rect.X + listTower[i].Rect.Width - Location.X;
                else
                    x1 = Location.X + Location.Width - listTower[i].Rect.X;
                x2 = Location.Width + listTower[i].Rect.Width;
                int y1, y2;
                if (Location.Y < listTower[i].Rect.Y)
                    y1 = listTower[i].Rect.Y + listTower[i].Rect.Height - Location.Y;
                else
                    y1 = Location.Y + Location.Height - listTower[i].Rect.Y;
                y2 = Location.Height + listTower[i].Rect.Height;
                if (x2 > x1 && y2 > y1)
                {

                    listTower[i].Hp--;
                    if (listTower[i].Hp == 0)
                    {
                        listTower[i].Hp = 5;
                        listTower.RemoveAt(i);
                    }
                    return true;
                }

            }
            return false;
        }
        public static bool even(Bullet BTank, Bullet BTower)
        {
            Rectangle Location1 = BTank.Rect;
            Rectangle Location2 = BTower.Rect;
            int x1, x2;
            if (Location1.X < Location2.X)
                x1 = Location2.X + Location2.Width - Location1.X;
            else
                x1 = Location1.X + Location1.Width - Location2.X;
            x2 = Location1.Width + Location2.Width;
            int y1, y2;
            if (Location1.Y < Location2.Y)
                y1 = Location2.Y + Location2.Height - Location1.Y;
            else
                y1 = Location1.Y + Location1.Height - Location2.Y;
            y2 = Location1.Height + Location2.Height;
            if (x2 > x1 && y2 > y1)
            {

                return true;
            }
            return false;
        }
    }
}
