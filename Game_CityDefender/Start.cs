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
    public partial class Start : Form
    {
        Bitmap bm = new Bitmap(Game_CityDefender.Properties.Resources.background);
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = bm;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn muốn thoát", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            Form1 game = new Game_CityDefender.Form1();
            this.Hide();
            game.Show();
            game.FormClosed += Game_FormClosed; 
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
