using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGame
{
    public class Player
    {
        public int Speed { get; set; }
        public List<PictureBox> PlayerShips { get; set; }
        
        private frmSpaceGame form;
        
        public Player(frmSpaceGame form)
        {
            this.form = form;
            Speed = 5;
            PlayerShips = new List<PictureBox>();
            
            Init();
            
        }

        private void Init()
        {
            PlayerShips.Add(new PictureBox()
            {
                BackColor = Color.Orange,
                Height = 30,
                Width = 30,
                Visible = true,
                Top = form.ClientSize.Height - 30,
                Left = (form.ClientSize.Width -30) / 2

            });

            form.Controls.Add(PlayerShips[0]);



        }

        public void PlayerMove(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                PlayerShips[0].Left -= Speed;
            if (e.KeyCode == Keys.Right)
                PlayerShips[0].Left += Speed;

            PlayerAtEdge();
        }

        public void PlayerFire(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                PlayerShips[0].Left -= Speed;
            

            PlayerAtEdge();
        }
        private void PlayerAtEdge()
        {
            if (PlayerShips[0].Left <= 0)
            {
                PlayerShips[0].Left = 0;
            }
            else if (PlayerShips[0].Right >= form.ClientSize.Width)
            {
                PlayerShips[0].Left = form.ClientSize.Width - PlayerShips[0].Width;
            }
        }
        
    }  
}
