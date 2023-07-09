using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AblastFromThePast
{
    public class Ball
    {
        public static int IDSeq  =1;
        public bool Goodbye { get; set; } = false;
        public int LaneIndex { get; set; }
        public  bool MainBall { get; set; } = false;
        public int id { get; set; }
        public bool isHit { get; set; } = false;
        public bool cantMove = false;
        public bool isDead { get; set; } = false;
        public int increasedVel = 0;
            
        public Point center { get; set; }
        public static int radius = 15;
        public int velocity { get; set; }
        public Color Color { get; set; }

        public Ball(Point center,Color color, int velocity)
        {
            
            this.center = center;
            id= IDSeq++;
            this.Color = color;
            this.velocity = velocity;
             Goodbye = false;
     
        MainBall = false;
     
          isHit  = false;
         cantMove = false;
         isDead=false;
         increasedVel = 0;





    }

   

        private int distance(Point tmp)
        {
            return (int)Math.Sqrt(Math.Pow(center.X - tmp.X, 2) + Math.Pow(center.Y - tmp.Y, 2));
            
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            Pen p = new Pen(Color.Black, 3);
            g.FillEllipse(b, center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
            g.DrawEllipse(p, center.X - radius, center.Y - radius, 2 * radius, 2 * radius);

            Font font = new Font("Arial", 12, FontStyle.Bold);
            Brush textBrush = new SolidBrush(Color.Black);
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString(id.ToString(), font, textBrush, center.X, center.Y, stringFormat);

            b.Dispose();
            p.Dispose();
            font.Dispose();
            textBrush.Dispose();
        }
        internal bool collisiionCheck( Ball p)
        {
            return distance(p.center) <= Ball.radius *2;
        }
        public void moveUp()
        {
            if (increasedVel != 3)
            {
                velocity += 1;
                increasedVel++;
                increasedVel++;

            }
            else
            {
                increasedVel = 0;
                velocity = 4;
            }
           

        }
        public void moveRight()
        {
            center = new Point(center.X+velocity, center.Y);
        }
        public void moveLeft()
        {
            center = new Point(center.X -velocity, center.Y);
        }
    }
}
