using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class frmSpaceGame : Form
    {
        List<Enemy> enemies;
        const int NumOfEnemies = 35;
        Player player;

        public frmSpaceGame()
        {
            InitializeComponent();
            enemies = new List<Enemy>();
            player = new Player(this);
            //Laser = new Laser(this);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < NumOfEnemies; i++)
            {
                enemies.Add(new Enemy(this));
            }

            //player.PlayerShips[0].Location;



        }

        private void Key_Down(object sender, KeyEventArgs e)
        {
            player.PlayerMove(e);
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}
