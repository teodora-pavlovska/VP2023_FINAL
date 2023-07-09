using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AblastFromThePast
{
    public class Road
    {

        public static int length { get; set; }
        public  int panelW { get; set; }
        public  int panelH { get; set; }
        public int lineSpace { get; set; }
        public int lineLength { get; set; }
        public int scroll { get; set; }
        public int scrollSpeed { get; set; }
        public Road(int screenWIdth, int screenHeight)
        {
            this.panelW = screenWIdth;
            this.panelH = screenHeight;
            lineSpace = 20;
            lineLength = 340;
            scroll = 0;
            scrollSpeed = 4;
        }

        public void Draw(Graphics g)
        {
            int temp = panelW / 3;
            int lineHeight = lineLength + lineSpace;

             int offsetY = scroll % lineHeight;
            g.Clear(Color.Gray);

            for (int i = offsetY - lineHeight; i < panelH + lineLength; i += lineHeight)
            {
                Point lineA = new Point(temp, i + 1); 
            
                  Point lineB = new Point(temp, i + lineLength + 1); 
                Point lineC = new Point(temp + temp, i); 
                  Point lineD = new Point(temp + temp, i + lineLength); 

                 Pen pen = new Pen(Color.White, 8);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLine(pen, lineA, lineB);
                  g.DrawLine(pen, lineC, lineD);
                pen.Dispose();
            }

        }

    }
}
