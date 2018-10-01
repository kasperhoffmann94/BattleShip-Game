using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;  // allows us to create a debug log in the outputs window

namespace BattleShip_Game
{
    public partial class Form1 : Form
    {

        List<Button> playerPosition; // creates a list for the player position buttons
        List<Button> enemyPosition; // same as above for enemy
        Random rand = new Random();
        int totalShips = 3; // number of total player ships
        int totalEnemy = 3; // total number of enemy ships
        int rounds = 10; // total number of rounds to play, 5 each
        int playerTotalScore = 0; // default player score
        int enemyTotalScore = 0; // default enemy score
        public Form1()
        {
            InitializeComponent();
            loadButtons(); // load the buttons for the enemy adn the player to the system
            attackButton.Enabled = false; // disable the player attack button
            enemyLocationList.Text = null; // nullify the enemy location drop down box

        }

        private void playerPicksPosition(object sender, EventArgs e)
        {
            // this function will let the player pick 3 positions on the map
            // in the beginning of the game this is how we allow the player to pick 3 positions
            if (totalShips > 0)
            {
                var button = (Button)sender;
                button.Enabled = false;
                button.Tag = "playerShip";
                button.BackColor = System.Drawing.Color.Blue;
                totalShips--;
            }
            if (totalShips == 0)
            {
                attackButton.Enabled = true;
                attackButton.BackColor = System.Drawing.Color.Red;
                helpText.Top = 55;
                helpText.Left = 230;
                helpText.Text = "2) now pick a attack position from the drop down";
            }
        }

        private void attackEnemyPosition(object sender, EventArgs e)
        {
            if (enemyLocationList.Text != "")
            {
                var attackPos = enemyLocationList.Text;
                attackPos = attackPos.ToLower();
                int index = enemyPosition.FindIndex(a => a.Name == attackPos);


                if (enemyPosition[index].Enabled && rounds > 0)
                {
                    rounds--;

                    roundsText.Text = "Rounds " + rounds;

                    if (enemyPosition[index].Tag == "enemyShip")
                    {
                        enemyPosition[index].Enabled = false;
                        enemyPosition[index].BackgroundImage = Properties.Resources.fireIcon;
                        enemyPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                        playerTotalScore++;
                        playerScore.Text = "" + playerTotalScore;
                        enemyPlayTimer.Start();
                    }
                    else
                    {
                        enemyPosition[index].Enabled = false;
                        enemyPosition[index].BackgroundImage = Properties.Resources.missIcon;
                        enemyPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                        enemyPlayTimer.Start();

                    }
                }
            }

            else
            {
                MessageBox.Show("Choose a location from the drop down list. ");
            }
        }

        private void enemyAttackPlayer(object sender, EventArgs e)
        {
            if (playerPosition.Count > 0 && rounds > 0)
            {
                rounds--;
                roundsText.Text = "Rounds " + rounds;
                int index = rand.Next(playerPosition.Count);
                if (playerPosition[index].Tag == "playerShip")
                {
                    playerPosition[index].BackgroundImage = Properties.Resources.fireIcon;
                    enemyMoves.Text = "" + playerPosition[index].Text;
                    playerPosition[index].Enabled = false;
                    playerPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                    playerPosition.RemoveAt(index);
                    enemyTotalScore++;
                    enemyScore.Text = "" + enemyTotalScore;
                    enemyPlayTimer.Stop();
                }
                else
                {
                    playerPosition[index].BackgroundImage = Properties.Resources.missIcon;
                    enemyMoves.Text = "" + playerPosition[index].Text;
                    playerPosition[index].Enabled = false;
                    playerPosition[index].BackColor = System.Drawing.Color.DarkBlue;
                    playerPosition.RemoveAt(index);
                    enemyPlayTimer.Stop();
                }

            }

            if (rounds < 1 || playerTotalScore > 2 ||enemyTotalScore > 2)
            {
                if (playerTotalScore > enemyTotalScore)
                {
                    MessageBox.Show("You Win", "Winning");
                }

                if (playerTotalScore == enemyTotalScore)
                {
                    MessageBox.Show("No one wins this", "Draw");
                }

                if (enemyTotalScore > playerTotalScore)
                {
                    MessageBox.Show("Haha! i Sunk your Battle Ship", "Lost");
                }
            }
        }

        private void enemyPicksPositions(object sender, EventArgs e)
        {
            int index = rand.Next(enemyPosition.Count);

            if (enemyPosition[index].Enabled = true && enemyPosition[index].Tag == null)
            {
                enemyPosition[index].Tag = "enemyShip";
                totalEnemy--;
                Debug.WriteLine("Enemy Positiobn " + enemyPosition[index].Text);
            }
            else
            {
                index = rand.Next(enemyPosition.Count);
            }
            if (totalEnemy < 1)
            {
                enemyPositionPicker.Stop();
            }
        }

        private void loadButtons()
        {
            // this function wil load all of the buttons into the lists
            // we load all of the player and enemy buttons first
            playerPosition = new List<Button>{ w1, w2, w3, w4, x1, x2, x3, x4, y1, y2, y3, y4, z1, z2, z3, z4 };
            enemyPosition = new List<Button> { a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, c4, d1, d2, d3, d4 };
            // this loop will go through each og the enemy position button
            //then it will add them to the enemy location drop down list for us
            // it will also remove all tags from the enemy location buttons

            for (int i = 0; i < enemyPosition.Count; i++)
            {
                enemyPosition[i].Tag = null;
                enemyLocationList.Items.Add(enemyPosition[i].Text);
            }
        }
    }
}
