using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;


namespace PTRO
{
    public class Player
    {
        List<IScreencast> screenlist = new List<IScreencast>();
        List<Level> levels = new List<Level>();
        FrmMain buehne;
        Random random = new Random();
        IScreencast screencast;
        Timer timer = new Timer();
        private int anzahl = 0;
        private int score = 0;
        private Level level;
        private bool gameNOTFinished = false;
        private int vergangenezeit = 0;
        private int messezeit=5;
        private Stopwatch stopWatch = new Stopwatch();
        private BoerdliManager boerdliManager = new BoerdliManager();
        private int actualScreencastID = 0;
        private Timer gameOverTimer = new Timer();
       
        

        public Player(FrmMain buehne)
        {
            levels.Add(new Level(1, 100, 8000, 5,0,3));
            levels.Add(new Level(2, 100, 8000, 10, 4, 7));  
            levels.Add(new Level(3, 100, 5000, 15, 0, 7));
            levels.Add(new Level(4, 200, 5000, 20, 8, 11));
            levels.Add(new Level(5, 200, 3000, 25, 0, 11));
            levels.Add(new Level(6, 300, 2000, 30, 0, 11));
            levels.Add(new Level(7, 300, 1000, 35, 0, 11));
            levels.Add(new Level(8, 400, 800, 40, 0, 11));
            levels.Add(new Level(9, 400, 700, 45, 0, 11));
            levels.Add(new Level(10, 700, 600, 50, 0, 11));
            levels.Add(new Level(11, 700, 500, 55, 0, 11));
            levels.Add(new Level(12, 800, 400, 60, 0, 11));
            levels.Add(new Level(13, 800, 300, 65, 0, 11));
            levels.Add(new Level(14, 900, 200, 70, 0, 11));
            levels.Add(new Level(15, 1000, 100, 75, 0, 11));
            levels.Add(new Level(16, 1000, 100, 1000, 0, 11));



            screenlist.Add(new TextScreencast(1,"1"));
            screenlist.Add(new TextScreencast(2, "2"));
            screenlist.Add(new TextScreencast(3, "3"));
            screenlist.Add(new TextScreencast(4, "4"));

            screenlist.Add(new ColorScreencast(1, Color.Red));
            screenlist.Add(new ColorScreencast(2, Color.Yellow));
            screenlist.Add(new ColorScreencast(3, Color.Green));
            screenlist.Add(new ColorScreencast(4, Color.Blue));

            screenlist.Add(new FotoScreencast(1, "ameisli.png"));
            screenlist.Add(new FotoScreencast(2, "jungschar.png"));
            screenlist.Add(new FotoScreencast(3, "tc.png"));
            screenlist.Add(new FotoScreencast(4, "refresh.png"));


           

            this.buehne = buehne;
        }

        public void getNextScreencast(){
            //Random korrektur
            int screencastNR=random.Next(level.ScreencastRangeStart, level.ScreencastRangeEnd);
            if (screencastNR == actualScreencastID)
            {
                screencastNR++;
                if(screencastNR>level.ScreencastRangeEnd){
                    screencastNR=level.ScreencastRangeStart;
                }
            }
            screencast = screenlist[screencastNR];
            actualScreencastID = screencastNR;
            
            
            screencast.showScreencast(buehne);
        }

        public bool getGameNOTFinished()
        {
            return gameNOTFinished;
        }

        public void Start()
        {
           
            boerdliManager.IsAvaiable();
            SoundPlayer.play("intro.wav");
            System.Threading.Thread.Sleep(2800);
            level=levels[0];
            score=0;
            anzahl=0; 
            gameNOTFinished = true;

            changeScreencast();

            timer.Tick += new EventHandler(ticker);
            timer.Interval = messezeit; ; 
            timer.Enabled = true;
            stopWatch.Start();
        }

        public void ticker(object sender, EventArgs e)
        {
            timer.Enabled = false;
            boerdliAnwser(boerdliManager.getButton());
            vergangenezeit += messezeit;
             buehne.nextPBarStep();
            if (level.TickTime <= vergangenezeit)
            {
                timeEnd();
            }
            
            if (gameNOTFinished)
            {
                timer.Enabled = true;
            }
        }

        public void timeEnd()
        {
           
            finishGame(); 
        }

        public void finishGame()
        {
            gameNOTFinished = false;
            stopWatch.Stop();
            timer.Enabled = false;
            timer.Stop();
            gameOverTimer.Interval = 20;
            gameOverTimer.Tick += new EventHandler(gameOverAnimation);
            gameOverTimer.Start();
            SoundPlayer.play("theend.wav");
            //level = levels[level.LevelNr-1];


            
            
            
           
        }

        public void gameOverAnimation(object sender, EventArgs e)
        {
            gameOverTimer.Enabled = false;
            if (buehne.gameOverAnimationStep())
            {
                gameOverTimer.Stop();
                
                FrmSave frms = new FrmSave(score, (int)stopWatch.Elapsed.TotalMilliseconds);
                frms.ShowDialog(buehne);
                buehne.getReady();
            }
            else
            {
                gameOverTimer.Enabled = true;                
            }
            
        }

        public void boerdliAnwser(int anwser)
        {
            if (anwser == 0)
            {
            }
            else if (anwser == 4)
            {
                getAnwser(3);
            }
            else if (anwser == 8)
            {
                getAnwser(4);
            }
            else
            {
                getAnwser(anwser);
            }

        }


        public void getAnwser(int answer)
        {
            
            if (screencast.ButtonID == answer)
            {
                SimpleLogger.log("ANWESER"+answer.ToString() + " BUTTON" + screencast.ButtonID);
                
                changeScreencast();
            }
            else
            {
                SimpleLogger.log("ANWESER" + answer.ToString() + " BUTTON" + screencast.ButtonID);
                finishGame();

                
            }
        }

        public void changeScreencast()
        {

            if (gameNOTFinished)
            {
                timer.Stop();
                System.Threading.Thread.Sleep(400);                
                vergangenezeit = 0;
                score += level.LevelScore;
                buehne.setLabScore(score);            
                anzahl++;
                if (anzahl >= level.Anzahl)
                {
                    SoundPlayer.play("levelup.wav");
                    level = levels[level.LevelNr];
                }
                this.getNextScreencast();
                buehne.setLabLevel(level.LevelNr);
                buehne.makePBarReady(level.TickTime,messezeit);
                timer.Start();
            }
            
        }


    }
}
