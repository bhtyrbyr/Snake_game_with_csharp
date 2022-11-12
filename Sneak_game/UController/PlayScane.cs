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
    public partial class PlayScane : UserControl
    {
        static PlayScane PlayScn;

        public static PlayScane spPlayScane
        {
            get
            {
                if(PlayScn == null)
                {
                    PlayScn = new();
                }
                return PlayScn;
            }
        }

        public Label title
        {
            get { return label1; }
            set { label1 = value; }
        }

        public PlayScane()
        {
            InitializeComponent();
        }
    }
}
