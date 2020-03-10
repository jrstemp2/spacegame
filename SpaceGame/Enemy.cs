using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGame
{
    class Enemy
    {
        private Random rand;
        private PictureBox enemy;
        private frmSpaceGame form;
        private List<PictureBox> enemies;

        public Enemy(frmSpaceGame form)
        {
            rand = new Random();
            this.form = form;
            enemies = new List<PictureBox>();
            
            enemy = new PictureBox()
            {
                BackColor = GetColor(rand.Next(1, 3)),
                Width = rand.Next(30, 50),
                Height = rand.Next(30, 50),
                Tag = "Enemy",
                Visible = true

            };

            Init();
        }

        private Color GetColor(int c)
        {
            
            if (c == 1)
            {
                return Color.Blue;
            }
            else if (c ==2) 
            {
                return Color.Red;
            }
            else
            {
                return Color.Black;
            }

            
        }

        private void Init()
        {
            GetAllEnemies();
            SetEnemyLeftTop();
            form.Controls.Add(enemy);
        }
        private void SetEnemyLeftTop()
        {
            do
            {
                enemy.Left = rand.Next(0, (form.ClientSize.Width - enemy.Width));
                enemy.Top = rand.Next(0, (form.ClientSize.Height / 2));
            } while (!CheckIntersect());

            //adds last brick to the list. 
            enemies.Add(enemy);
        }

        private bool CheckIntersect()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                if (this.enemy.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    return false;
                }
            }
            return true;
        }

        private void GetAllEnemies()
        {
            foreach (var item in form.Controls.OfType<PictureBox>().Where(t => t.Tag == "Enemy"))
            {
                enemies.Add(item);
            }
        }
    }
}
