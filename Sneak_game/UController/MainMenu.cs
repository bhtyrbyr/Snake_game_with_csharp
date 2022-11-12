using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sneak_game.UController
{
    public partial class MainMenu : UserControl
    {
        private int GameDifficult = 1000;

        static MainMenu menu;

        public static MainMenu MainMenu_
        {
            get
            {
                if (menu == null)
                {
                    menu = new MainMenu();
                }
                return menu;
            }
        }

        public TrackBar Difficult
        {
            get { return DifficultSelect; }
            set { DifficultSelect = value; }
        }

        public Label Title
        {
            get { return DifficultTitle; }
            set { DifficultTitle = value; }
        }

        public MainMenu()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //DifficultSelect.BackColor = Color.Transparent;
            //DifficultTitle.BackColor = Color.Transparent;
        }

        public void setLabel(string i)
        {
            DifficultTitle.Text = i;
        }

        private void GameStartBtn_Click(object sender, EventArgs e)
        {
            
            if (!SnakeGameForm.spGame.GameScane.Controls.ContainsKey("PlayScane"))
            {
                PlayScane pScane = new()
                {
                    Dock = DockStyle.Fill
                };
                SnakeGameForm.spGame.GameScane.Controls.Clear();
                SnakeGameForm.spGame.GameScane.Controls.Add(pScane);
            }
            SnakeGameForm.spGame.GameTimeManager.Enabled = true;
            SnakeGameForm.spGame.GameTimeManager.Interval = GameDifficult;
        }

        private void DifficultSelect_ValueChanged(object sender, EventArgs e)
        {
            GameDifficult = 1000 / DifficultSelect.Value;
            switch (DifficultSelect.Value)
            {
                case 1: { 
                        DifficultTitle.Text = "Difficult = Child";
                        DifficultTitle.Location = new Point(118, 563);
                    } break;
                case 2: { 
                        DifficultTitle.Text = "Difficult = Teen";
                        DifficultTitle.Location = new Point(118, 492);
                    }
                    break;
                case 3: { 
                        DifficultTitle.Text = "Difficult = College Student";
                        DifficultTitle.Location = new Point(118, 420);
                    }
                    break;
                case 4: { 
                        DifficultTitle.Text = "Difficult = Grad Student";
                        DifficultTitle.Location = new Point(118, 349);
                    }
                    break;
                case 5: { 
                        DifficultTitle.Text = "Difficult = Expert";
                        DifficultTitle.Location = new Point(118, 278);
                    }
                    break;
            }
        }
    }
}
