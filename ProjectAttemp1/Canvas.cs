using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AblastFromThePast
{

    public class Canvas
    {
        public List<Ball> balls { get; set; }
        public static Color userColor { get; set; } = Color.Red;
        public static int level = 0;
        public Road road { get; set; }
    
        public int panelH { get; set; }
        public int panelW { get; set; }
        public bool newFaces { get; set; }
        public Random random { get; set; }
        public bool canIntroduceNewCars;
        public bool collision { get; set; }

         Random randomC = new Random();
      
        public  bool moveLeft = false;
        public  bool moveRight = false;
        public bool sppedUp = false;

     
        public Canvas(int panelH, int panelW)
        {
            this.panelH = panelH;
            this.panelW = panelW;
            road = new Road(panelW, panelH);
            balls = new List<Ball>();
      
            random = new Random();
            newFaces = false;
            canIntroduceNewCars= false;
            collision = false;
             moveLeft = false;
            moveRight = false;
            sppedUp = false;
    }

        public void addBall(Ball b)
        {
    
            balls.Add(b);


        }
        public void isHit(Point p)
        {
            Ball mainB = player();
            foreach (Ball b in balls)
            {
                if (b.MainBall && !mainB.MainBall && mainB.collisiionCheck(b))
                {
                    collision = true;
                    mainB.isHit = true;
                    break;
                }
            }
        }


        public void createCircles()
        {
            
            int laneWidth = panelW / 3 - 1; 
            int laneHeight = panelH;      
            int b = laneHeight - Ball.radius;
            int minPadding = Ball.radius-5;
            int maxPadding = laneWidth - minPadding;

            // Create the main ball
            int player = random.Next(5, laneWidth - Ball.radius);
            int playerVelocity = 7;
            int num = random.Next(1, 10);
            int velocity = random.Next(2, 8);
            random = new Random();
            Random randomHelp = new Random();
            if (level == 1)
            {
                 playerVelocity = 10;
                
                num=random.Next(7, 12);
           
                 velocity = randomHelp.Next(4, 9);

            }
            else if(level == 2)
            {
                 playerVelocity = 12;
           
                num = random.Next(1, 8);
          
                velocity = randomHelp.Next(2, 8);
            }
            else if (level == 3)
            {
                playerVelocity = 17;

                num = random.Next(10, 17);

                velocity = randomHelp.Next(12,25);
            }
    
            Ball playerBall = new Ball(new Point(player, b), userColor, playerVelocity);
            playerBall.MainBall = true;
            addBall(playerBall);

           

            for (int i = 0; i < num; i++)
            {
                Color randomColor = Color.FromArgb(randomC.Next(256), randomC.Next(256), randomC.Next(256));
                if (randomColor == userColor)
                {
                    randomColor = Color.CornflowerBlue;
                }
                int n = random.Next(1, 4);
                int laneIndex = n;
                int laneX = (laneIndex - 1) * laneWidth;

           
                int x = random.Next(laneX + minPadding, laneX + maxPadding);
                int y = random.Next(Ball.radius * 2, panelH - Ball.radius * 2);
                Point position = new Point(x, y);

      
                bool intersects = balls.Any(bl => IsIntersecting(bl.center, position, Ball.radius * 2));
                if (intersects)
                {
                   
                    continue;
                }

                Ball computerBall = new Ball(position, randomColor, velocity);
                computerBall.LaneIndex = laneIndex;
                addBall(computerBall);
            }
        }


        private void deleteAfter(Point p)
        {
            
                balls.RemoveAll(ball => !ball.MainBall && ball.center.Y > p.Y);
            


        }

        /// <summary>
        /// Proveruva Funkcijata Dali koe bilo od kopcinjata A,W,D 
        /// se pritisnati za da moze da go pridvizi topceto vo potrebnata nasoka
        /// </summary>
        internal void moveMain()
        {
            if (moveLeft && player().center.X>5)
            {
                player().moveLeft();
                
            }
            if(moveRight && Ball.radius*2 < panelW)
            {
                player().moveRight();
            }
            if (sppedUp)
            {
                player().moveUp();
            }
        }
       
        /// <summary>
        /// gi pridvizuva site topcinjinja pravo 
        /// 
        /// </summary>
        public void moveBalls()
        {
              int laneWidth = panelW / 3;  

            foreach (Ball ball in balls)
            {
                if (!ball.MainBall)
                {
                    if (ball.center.Y -( Ball.radius*2) <= 0)
                    {
                      
                        ball.cantMove = true;
                        continue;
                    }

                    

                    foreach (Ball otherBall in balls)
                    {
                        if (!otherBall.MainBall && otherBall != ball && otherBall.center.Y < ball.center.Y && Math.Abs(otherBall.center.X - ball.center.X) <= Ball.radius * 2)
                        {
                            if (otherBall.cantMove)
                            {
                                ball.cantMove = true;
                            }
                          
                       
                            break;
                        }
                    }

                   

                    ball.center = new Point(ball.center.X, ball.center.Y - ball.velocity);

                }
                else if(ball.MainBall)
                { 
                    if(ball.center.Y -5 <= 0)
                    {
                       
                        newFaces = !newFaces;
                        deleteAfter(ball.center);
                        
                        if (!canIntroduceNewCars)
                        {
                            canIntroduceNewCars = true;
                            ball.velocity--;
                            return;
                           
                        }
                      
                        this.GenerateRandomBallPositions();
                    
                        
                        ball.center = new Point(ball.center.X, (panelH + Ball.radius-5));
                        canIntroduceNewCars = false;
                        break;
                    }
                    else
                    {
                        
                        ball.center = new Point(ball.center.X, ball.center.Y - ball.velocity);
                        
                    }
                    
                  
                }

                
         
            }

            removeLosers();
            
        }
        /// <summary>
        /// gi otstranuva site topki koi se sudrile
        /// </summary>
        private void removeLosers()
        {
            for(int i = 0; i < balls.Count-1; i++)
            {
                for(int j = i+1;j< balls.Count; j++)
                {
                    if (balls[i].collisiionCheck(balls[j])){
                      
                        balls[i].isDead = true;
                        balls[j].isDead = true;
                    }
                }
            }
            if (player().isDead)
            {
                collision = true;
            }
            for (int i = balls.Count - 1; i >= 0; i--)
            {
                if (balls[i].isDead)
                {
                    balls.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// od koga ke se pomine panelot mora odnovno da se izgeneriraat
        /// topcinja koi se pred glavniot igrac
        /// </summary>
        private void GenerateRandomBallPositions()
        {
            List<Point> positions = new List<Point>();
            Random random = new Random();
            int minPadding = Ball.radius * 2;
            int maxPadding = panelW / 3 - Ball.radius * 2;
            int numBalls = random.Next(3, 10);
            random = new Random();
            if (level == 1)
            {
               
                numBalls = random.Next(6, 9);
            }
            else if(level == 2)
            {
                numBalls = random.Next(5, 10);
            }
            else if (level == 3)
            {
                numBalls = random.Next(10, 18);
            }

            for (int i = 0; i < numBalls; i++)
            {
                bool intersect = true;
                Point position = Point.Empty;

                while (intersect)
                {
                    int laneIndex = random.Next(1, 4);
                    int laneWidth = panelW / 3;
                    int laneX = (laneIndex - 1) * laneWidth;
                    int x = random.Next(laneX + minPadding, laneX + maxPadding);
                    int y = random.Next(Ball.radius * 2, panelH - Ball.radius * 2);
                    position = new Point(x, y);

               
                    intersect = positions.Any(p => IsIntersecting(p, position, Ball.radius * 2));
                }

                positions.Add(position);

                Color randomColor = Color.FromArgb(randomC.Next(256), randomC.Next(256), randomC.Next(256));
                if (randomColor == userColor)
                {
                    randomColor = Color.CornflowerBlue;
                }
                int tmp = random.Next(2, 7);
                random = new Random();
                if (level == 1)
                {
                    tmp = random.Next(7, 9);
                }
                else if(level==2){
                    tmp = random.Next(2, 8);
                }
                else if (level == 3)
                {
                    tmp = random.Next(2, 25);
                }
              

                balls.Add(new Ball(position, randomColor, tmp));
            }
        }

       
        private bool IsIntersecting(Point position1, Point position2, int radius)
        {
            int distanceSquared = (position1.X - position2.X) * (position1.X - position2.X) +
                                  (position1.Y - position2.Y) * (position1.Y - position2.Y);
            int radiusSquared = radius * radius;

            return distanceSquared < radiusSquared;
        }


        public void Draw(Graphics g)
        {
            road.Draw(g);
            foreach (Ball b in balls)
            {
                b.Draw(g);
            }



        }
        public Ball player()
        {
            foreach(Ball b in balls)
            {
                if (b.MainBall)
                {
                    return b;
                }
            }
            return null;
        }

     

    }
    

    }

    
