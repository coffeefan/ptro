using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTRO
{
    public partial class FrmMain : Form
    {
        Player player;
        public FrmMain()
        {
            InitializeComponent();
        }

        public void setLabScore(int score){
            labScore.Text = score.ToString();
        }

        public void setLabLevel(int level)
        {
            labLevel.Text = "Level "+level.ToString();
        }

        public void makePBarReady(int maximum, int step)
        {
            pBar.Value = step;
            pBar.Maximum = maximum - 300;
            pBar.Minimum = step;
            pBar.Step = step;

        }

        public void nextPBarStep()
        {
            pBar.PerformStep();
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
            getReady();

        }

        public bool gameOverAnimationStep()
        {
            pbGameOver.Show();
            labGameOverBackground.Show();

            if (pbGameOver.Top < this.Height)
            {
                labGameOverBackground.Height += 10;
                pbGameOver.Top += 10;
                return false;
            }else{
                return true;
            }
        }

        public void getReady()
        {
             //Fullscreeen
            
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            labtop.Width = this.Width;

            labGameOverBackground.Width = this.Width;
            labGameOverBackground.Height = 1;
            labGameOverBackground.Hide();
            pbGameOver.Top = -(this.Height/2);
            pbGameOver.Left = (int)((this.Width / 2) - (this.pbGameOver.Width / 2));
            pbGameOver.Hide();
            
            pBoxStartscreen.Width = this.Width;
            pBoxStartscreen.Height = this.Height;
            pBoxStartscreen.Show();

            pBar.Top = (this.Height - 100);
            pBar.Left = 300;
            pBar.Width = this.Width - 600;

            player = new Player(this);
           // labScore.BackColor = Color.Transparent;

        }

        public void clearScreen(){
            pictureBox.Visible = false;
            labText.Visible = false;
            this.BackColor = Color.Black;
        }


        public PictureBox getPicBox()
        {
            return pictureBox;
        }

        public Label getTextLabel() {
            return labText;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void StartGame()
        {
            player.Start();
            pBoxStartscreen.Hide();

        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyValue.ToString())
            {
                case "13":
                    if (player.getGameNOTFinished() == false)
                    {
                        StartGame();
                    }
                    else
                    {
                        this.Close();
                    }
                    
                    break;
                case "27":
                    this.Close();
                    
                    break;
                case "65":
                    player.getAnwser(1);
                    break;
                case "83":
                    player.getAnwser(2);
                    break;
                case "68":
                    player.getAnwser(3);
                    break;
                case "70":
                    player.getAnwser(4);
                    break;
                default:
                     break;
            }

        }

        private void labScore_Click(object sender, EventArgs e)
        {

        }


    }
}
