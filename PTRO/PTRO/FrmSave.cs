using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTRO
{
    public partial class FrmSave : Form
    {
        private int score=0;
        private int howlong=0;
        public FrmSave(int score, int howlong)
        {
            InitializeComponent();
            this.score = score;
            this.howlong = howlong;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmSave_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            

            this.savePanel.Top = (int)((this.Height / 2) - (this.savePanel.Height / 2));
            this.savePanel.Left = (int)((this.Width / 2) - ( this.savePanel.Width / 2));

            this.pHighscore.Top = (int)((this.Height / 2) - (this.pHighscore.Height / 2));
            this.pHighscore.Left = (int)((this.Width / 2) - (this.pHighscore.Width / 2));

            

            savePanel.Show();
            pHighscore.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveScoreToHighscore();
        }

        private void saveScoreToHighscore()
        {
            int rank = 0;
            bool askagain = true;
            int askagainzaehler = 0;
            if (tbNickname.Text.Trim().Equals(""))
            {
                tbNickname.Text = "NONAME";
            }
            while (askagain && askagainzaehler < 5)
            {
                try
                {
                    // Create a request for the URL. 		
                    WebRequest request = WebRequest.Create("http://www.kirchenaadorf.ch/chrischona/ptro/saveMySelfScore.php?code=funky&nickname=" + tbNickname.Text
                        + "&score=" + score.ToString() + "&howlong=" + howlong.ToString() + "&mobile=" + tbMobile.Text);
                    // If required by the server, set the credentials.
                    request.Credentials = CredentialCache.DefaultCredentials;
                    // Get the response.
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    // Display the status.
                    Console.WriteLine(response.StatusDescription);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        // Get the stream containing content returned by the server.
                        Stream dataStream = response.GetResponseStream();
                        // Open the stream using a StreamReader for easy access.
                        StreamReader reader = new StreamReader(dataStream);
                        // Read the content.
                        string responseFromServer = reader.ReadToEnd();
                        // Display the content.
                        Console.WriteLine(responseFromServer);

                        reader.Close();
                        dataStream.Close();


                        bool isNum = int.TryParse(responseFromServer, out rank);
                        if (isNum && rank > 0)
                        {
                            askagain = false;
                        }

                    }

                    response.Close();
                }
                catch (Exception ex)
                {
                    askagainzaehler++;
                }
            }
            if (!askagain)
            {
                labRang.Text = "Rang " + rank.ToString();
                pHighscore.Show();
                savePanel.Hide();
                

                if (rank < 10)
                {
                    SoundPlayer.play("woow.wav");
                }
                
                if (rank < 5)
                {
                    BoerdliManager. OutputAllAnalog(255, 0);
                    System.Threading.Thread.Sleep(3000);
                    BoerdliManager.OutputAllAnalog(0, 0);
                }
                
                
                if (rank > 20)
                {
                    SoundPlayer.play("mymother.wav");
                }
                                


            }
            else
            {
                MessageBox.Show("ERROR");
                String sqltxt = "Insert into scores (nickname,score,howlong,mobile) VAlUES('"
                     + tbNickname.Text + "','" + score.ToString() + "','" + howlong.ToString() + "','" + tbMobile.Text + "');";
                SimpleLogger.sqlLog(sqltxt);
                this.Close();
            }
        }

        private void labNickname_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void labRang_Click(object sender, EventArgs e)
        {

        }

        private void FrmSave_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue.ToString())
            {
                case "13":
                    if (savePanel.Visible)
                    {
                        saveScoreToHighscore();
                    }
                    break;
                case "27":
                    if (pHighscore.Visible)
                    {
                        this.Close();
                    }
                    

                    break;
                default:
                    break;
            }

        }

    }
}
