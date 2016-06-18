using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Resources;
using System.Reflection;

namespace Black_Jack {
    public partial class Form1 : Form {
        private PictureBox[,] cards;
        private PictureBox[] comCards, usrCards;
        private bool[,] isCardUsed = new bool[4, 13];
        private string[] cardType = new string[4];
        private int amountUsrCard, amountComCard;
        Random randType = new Random();
        Random randNumber = new Random();
        
        public int currComPoints { get; set; }
        public int currUsrPoints { get; set; }

        public string currPattern { get; set; }

        ResourceManager rm = Resource.ResourceManager;

        public Form1() {
            InitializeComponent();

            // Initial interface.
            currPattern = "Pattern_1";
            pictureBox_src.Image = (Image)rm.GetObject(currPattern);
            for (int i = 0; i < 4; ++i) {
                for (int j = 0; j < 13; ++j)
                    isCardUsed[i, j] = false;
            }
            amountUsrCard = amountComCard = 0;

            // Initial all cards.
            cardType[0] = "D";
            cardType[1] = "C";
            cardType[2] = "H";
            cardType[3] = "S"; 

            cards = new PictureBox[4, 13];
            for (int i = 0; i < 4; ++i) {
                string cardName = cardType[i] + "_";
                for (int j = 0; j < 13; ++j) {
                    cards[i, j] = new PictureBox();
                    string cardNum = Convert.ToString(j + 1);
                    cards[i, j].Image = (Image)rm.GetObject(cardName + cardNum);
                }
            }

            // Initial pictueBox for computer and user.
            comCards = new PictureBox[6];
            usrCards = new PictureBox[6];
            for (int i = 0; i < 6; ++i) {
                comCards[i] = new PictureBox();
                comCards[i].SizeMode = PictureBoxSizeMode.Zoom;

                usrCards[i] = new PictureBox();
                usrCards[i].SizeMode = PictureBoxSizeMode.Zoom;
            }

            comCards[0] = pb_com1;
            comCards[1] = pb_com2;
            comCards[2] = pb_com3;
            comCards[3] = pb_com4;
            comCards[4] = pb_com5;

            usrCards[0] = pb_usr1;
            usrCards[1] = pb_usr2;
            usrCards[2] = pb_usr3;
            usrCards[3] = pb_usr4;
            usrCards[4] = pb_usr5;
        }

        private void Form1_Load(object sender, EventArgs e) {
            button_get.Hide();
            button_pass.Hide();

            button_new.Hide();
            label_status.Hide();
            
            button_get.Enabled = false;
            button_pass.Enabled = false;
            button_new.Enabled = false;

            pictureBox_init.Hide();
        }

        /* Start button */
        private void button_start_Click(object sender, EventArgs e) {
            // Initial buttons.
            button_pass.Enabled = true;
            button_get.Enabled = true;

            button_pass.Show();
            button_get.Show();

            // Get card to user.
            RandomCards(usrCards[amountUsrCard], 1);
            RandomCards(usrCards[amountUsrCard], 1);

            // Get card to computer.
            RandomCards(comCards[amountComCard], 0);
            RandomCards(comCards[amountComCard], 0);

            button_start.Enabled = false;
            button_start.Hide();

            pictureBox_init.Show();
        }

        private void button_get_Click(object sender, EventArgs e) {
            RandomCards(usrCards[amountUsrCard], 1);
            checkLose();
        }

        private void button_pass_Click(object sender, EventArgs e) {
            button_get.Hide();
            button_pass.Hide();

            button_get.Enabled = false;
            button_pass.Enabled = false;

            if (isComputerGet()) {
                RandomCards(comCards[amountComCard], 0);
                checkLose();
            }
            else {
                checkResult();

                button_new.Enabled = true;
                button_new.Show();
            }
        }

        private void checkLose() {
            label_comPoints.Text = Convert.ToString(currComPoints);

            if (currUsrPoints > 21) {
                button_get.Hide();
                button_pass.Hide();

                comCards[0].Show();

                button_get.Enabled = false;
                button_pass.Enabled = false;

                label_status.ForeColor = Color.Red;
                label_status.Text = "You lose!";
                label_status.Show();

                button_new.Enabled = true;
                button_new.Show();
            }
        }

        private void checkResult() {
            label_comPoints.Text = Convert.ToString(currComPoints);

            if (amountUsrCard == 4) {
                if (currUsrPoints <= 21) {
                    label_status.ForeColor = Color.Blue;
                    label_status.Text = "You win!";
                    label_status.Show();
                }
                else {
                    label_status.ForeColor = Color.Red;
                    label_status.Text = "You lose!";
                    label_status.Show();
                }
            }
            else {
                if (currUsrPoints != 21) {
                    if (currComPoints < currUsrPoints) {
                        label_status.ForeColor = Color.Blue;
                        label_status.Text = "You win!";
                        label_status.Show();
                    }
                    else if (currComPoints == currUsrPoints) {
                        label_status.ForeColor = Color.Yellow;
                        label_status.Text = "Tie!";
                        label_status.Show();
                    }
                    else if (currComPoints > currUsrPoints) {
                        label_status.ForeColor = Color.Red;
                        label_status.Text = "You lose!";
                        label_status.Show();
                    }
                }
                else {
                    label_status.ForeColor = Color.Blue;
                    label_status.Text = "You win!";
                    label_status.Show();
                }
            }
        }

        private void button_new_Click(object sender, EventArgs e) {
            label_status.Hide();
            label_status.Enabled = false;

            button_new.Hide();
            button_new.Enabled = false;

            newGameToolStripMenuItem_Click(sender, e);
        }

        /* New game */
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) {
            button_start.Enabled = true;
            button_start.Show();

            button_get.Hide();
            button_pass.Hide();

            button_get.Enabled = false;
            button_pass.Enabled = false;

            for (int i = 0; i < 5; ++i) {
                usrCards[i].Image = null;
                comCards[i].Image = null;
            }

            amountUsrCard = amountComCard = 0;
            currComPoints = currUsrPoints = 0;

            label_comPoints.Text = Convert.ToString(currComPoints);
            label_usrPoints.Text = Convert.ToString(currUsrPoints);

            for (int i = 0; i < 4; ++i) {
                for (int j = 0; j < 13; ++j)
                    isCardUsed[i, j] = false;
            }
        }

        /* Exit */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        /* Random new cards. */
        private void RandomCards(PictureBox currCard, int status) {
            int currType, currNumber;

            do {
                currType = randType.Next(0, 4);
                currNumber = randNumber.Next(0, 13);
            } while (isCardUsed[currType, currNumber]);

            if (status == 0) {
                amountComCard += 1;

                currCard.Image = getCurrCard(cardType[currType], currNumber, status);

                currComPoints = pointCount(currComPoints, currNumber + 1);
                label_comPoints.Text = Convert.ToString(currComPoints);
            }
            else {
                amountUsrCard += 1;
                currCard.Image = getCurrCard(cardType[currType], currNumber, status);
                currUsrPoints = pointCount(currUsrPoints, currNumber + 1);
                label_usrPoints.Text = Convert.ToString(currUsrPoints);
            }

            isCardUsed[currType, currNumber] = true;
        }

        private bool isComputerGet() {
            if (currComPoints < 19)
                return true;
            return false;
        }

        private int pointCount(int currAmount, int number) {
            if (number == 1) {
                if (currAmount > 11)
                    return currAmount + number;
                else
                    return currAmount + 10;
            }
            else if (number > 10)
                return currAmount + 10;
            else
                return currAmount + number;
        }

        /* Get current new card. */
         private Image getCurrCard(string type, int number, int status) {
            string cardName = type + "_" + Convert.ToString(number + 1);
            Image image = (Image)rm.GetObject(cardName);
            return image;
        }
    }
}
