using Sneak_game.UController;

namespace Sneak_game
{
    public partial class SnakeGameForm : Form
    {

        static SnakeGameForm Game;

        public static SnakeGameForm spGame { 
            get 
            {
                if (Game == null)
                {
                    Game = new();
                }
                return Game;
            }
        }

        public Panel GameScane {
            get { return MainScane; }
            set { MainScane = value; } 
        }

        public SnakeGameForm()
        {
            InitializeComponent();
        }

        private void SnakeGameForm_Load(object sender, EventArgs e)
        {
            Game = this;

            MainMenu menu = new()
            {
                Dock = DockStyle.Fill
            };
            GameScane.Controls.Add(menu);

        }
        int i = 0;
        private void GameTimeManager_Tick(object sender, EventArgs e)
        {
            i++;
            if (this.GameScane.Controls.ContainsKey("MainMenu"))
            {
                var controller = this.GameScane.Controls["MainMenu"] as MainMenu;

            }
            if (this.GameScane.Controls.ContainsKey("PlayScane"))
            {
                var controller = this.GameScane.Controls["PlayScane"] as PlayScane;
                controller.title.Text = i.ToString();
            }
        }
    }
}