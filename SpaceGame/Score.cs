using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SpaceGame
{


    public static class Score
    {
        private static int TotalScore { get; set;  }
        public static int GetScore { get { return TotalScore; } }
        public static bool GameOver { get; set; }

        public static void CalculateScore(PictureBox enemy, frmSpaceGame form)
        {
            if (enemy.BackColor == Color.Blue)
            {
                TotalScore += 1;
            }
            else if (enemy.BackColor == Color.Red)
            {
                TotalScore += 2;
            }

            form.Text = "Score: " + TotalScore;
        }
    }

    


}
