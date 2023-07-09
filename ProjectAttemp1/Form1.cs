using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AblastFromThePast
{
    public partial class Form1 : Form
    {
        public int points { get; set; } = 0;
        public bool firstClick { get; set; } = true;
        public Road road { get; set; }
        public bool newGame = true;
        public Canvas canvasRace { get; set; }
        public int timerTick { get; set; } = 0;
        public bool gamePaused = false;
        public int lastPoints = 0;
        public int maxPoints = 0;
        int cc = 0;
        public  bool isOngoing { get; set; } = false;
        public Form1()
        {
            this.Width = 1053;
            this.Height = 1038;
            this.Size = new Size(1053,1038);
         
            InitializeComponent();
           
         
       
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
           
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
             | BindingFlags.Instance | BindingFlags.NonPublic, null,
             racePanel, new object[] { true }); // PREVZEMENO OD 
            timer1 = new Timer();
            int heig = racePanel.Height;
            int width = racePanel.Width;
            this.KeyPreview = true;
            gameTimer = new Timer();

            canvasRace = new Canvas(heig, width);
            Canvas.level = 0;
            Canvas.userColor = Color.Red;
            updateStrip();
            this.DoubleBuffered = true;
            setGameModeToolStripMenuItem.Checked = false;
            mediumToolStripMenuItem.Checked = false;
            dIfficultToolStripMenuItem.Checked = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void updateStrip()
        {
            tsPoints.Text = $"Points: {points}";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            canvasRace.Draw(e.Graphics);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
       

            if (newGame)
            {
                Ball.IDSeq = 1;
                timer1 = new Timer();
                gameTimer = new Timer();
                timer1.Start();
                gameTimer.Start();
                canvasRace.createCircles();
                timer1.Interval = 50; 
                timer1.Tick += timer1_Tick;

                gameTimer.Interval = 1000;
                gameTimer.Tick += gameTimer_Tick;
                newGame = false;
                return;
          
            }
            else
            {
                gamePaused = !gamePaused;
                if (gamePaused)
                {

                    pauseGame();


                }
                else
                {
                    resumeGame();
                }
            }



            racePanel.Invalidate();

        }
        public void pauseGame()
        {
         
            if (gamePaused)
            {
                timer1.Stop();
                gameTimer.Stop();
                btnStart1.Text = "RESUME";
       
                racePanel.Invalidate();
            }
            else
            {
                return;
            }
        }
        public void resumeGame()
        {
            btnStart1.Text = "P A U S E";
            gameTimer.Start();
            timer1.Start();

        }
        public void gameOver()
        {
            if (!newGame)
            {
             
                timer1.Stop();
                gameTimer.Stop();

                pbTime.Value = 60;

                if (points > maxPoints)
                {
                    maxPoints = points;
                }

                MessageBox.Show($"Points: {points}\nLast Score: {lastPoints}\nHighest Score: {maxPoints}","SCORES");
                if(maxPoints > 0)
                {
                    lbScore.Text = $"HIGH SCORE: {maxPoints}";
                }
                else
                {
                    lbScore.Text = "";
                }
          
                btnStart1.Text = "S T A R T";
                    lastPoints = points;

                    points = 0;
                    updateStrip();
                    timerTick = 0;
                    cc = 0;
                    newGame = true;
                    gamePaused = false;
           
                canvasRace.balls.Clear();
                canvasRace = new Canvas(racePanel.Height, racePanel.Width);
                timer1=new Timer();
                gameTimer = new Timer();
                isOngoing = false;

                racePanel.Invalidate();
             


            }
         
       
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (canvasRace.collision)
            {
                gameOver();
            }

            canvasRace.road.scroll += canvasRace.road.scrollSpeed; 
            timerTick += timer1.Interval;
            cc++;
            if (cc % 2 == 0)
            {
                canvasRace.canIntroduceNewCars = true;
            }
            if (canvasRace.balls.Count > 0)
            {
                canvasRace.moveMain();
            }

            if ((timerTick + 7) % 3 == 0)
            {
                if (canvasRace.balls.Count > 0)
                    canvasRace.moveBalls();

                if (canvasRace.collision)
                {
                    gameOver();
                }
                
                updateStrip();
                points += 15;
            }

            racePanel.Invalidate();

        }
        public void changeSurrondings()
        {

        }




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.A)
            {
                canvasRace.moveLeft = true;
            }
            else if (e.KeyCode == Keys.D)
            {
                canvasRace.moveRight = true;
            }
            else if (e.KeyCode == Keys.W)
            {
                canvasRace.sppedUp = true;
            }





        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                canvasRace.moveLeft = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                canvasRace.moveRight = false;
            }
            else if (e.KeyCode == Keys.W)
            {
                canvasRace.sppedUp
                    = false;
            }




        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            pbTime.Value -= 1;
            if (pbTime.Value == 0)
            {
               pbTime.Value = 60;
       
                gameOver();
            }

            racePanel.Invalidate();


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorOfTheMainBallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isOngoing)
            {
                ColorDialog cd = new ColorDialog();
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    Canvas.userColor = cd.Color;
                }
            }
          
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pbTime_Click(object sender, EventArgs e)
        {

        }

        private void pickTheGeneralSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void setGameModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isOngoing)
            {
                Ball.radius = 15;
                Canvas.level = 0;
                setGameModeToolStripMenuItem.Checked = true;
                mediumToolStripMenuItem.Checked = false;
                dIfficultToolStripMenuItem.Checked = false;
                veryHardToolStripMenuItem.Checked = false;
                veryHardToolStripMenuItem.Checked = false;
                return;
            }
          
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isOngoing)
            {
                Ball.radius = 20;
                Canvas.level = 1;
                setGameModeToolStripMenuItem.Checked = false;
                mediumToolStripMenuItem.Checked = true;
                dIfficultToolStripMenuItem.Checked = false;
                veryHardToolStripMenuItem.Checked = false;
                return;
            }
        
        }

        private void dIfficultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isOngoing)
            {
                Ball.radius = 25;
                Canvas.level = 2;
                setGameModeToolStripMenuItem.Checked = false;
                mediumToolStripMenuItem.Checked = false;
                dIfficultToolStripMenuItem.Checked = true;
                veryHardToolStripMenuItem.Checked = false;
                return;
            }
          
        }

        private void veryHardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isOngoing)
            {
                Ball.radius = 15;
                Canvas.level = 3;
                setGameModeToolStripMenuItem.Checked = false;
                mediumToolStripMenuItem.Checked = false;
                dIfficultToolStripMenuItem.Checked = false;
                veryHardToolStripMenuItem.Checked = true;
                return;
            }
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to AblastFromThePast Game!\nTo play the game:\n- Choose a difficulty mode: easy, medium, or hard.\n- Use the 'A' key to move left, 'D' key to move right, and 'W' key to speed up.\n- Avoid collision with obstacles on the road.\n- Earn points for surviving and passing obstacles.\n- Beat your previous high score to set a new record!\n\nEnjoy playing Ball Race and aim for the highest score!");
        }
    }
}