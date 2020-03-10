using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGame
{
    public class Laser
    {
        public int Speed { get; set; }
        private PictureBox laser;
        private frmSpaceGame form;

        public Laser(frmSpaceGame form)
        {                                                 
            this.form = form;
            Speed = 5;
            this.laser = new PictureBox();

            Init();
        }

        private void Init()
        {
            form.Controls.Add(new PictureBox()
            {
                BackColor = Color.Yellow,
                Height = 30,
                Width = 5,
                Visible = true,
            });
        }

        public void ShootLaser(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                laser.Top -= Speed;
        }
    }
}
