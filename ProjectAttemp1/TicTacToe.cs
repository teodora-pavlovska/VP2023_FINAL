using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AblastFromThePast
{
    public partial class TicTacToe : Form

    {
        public static string firstPlayerSym { get; set; } 
        public static string secondPlayerSym { get; set; }
        public static int player1 { get; set; } =1;
        public static int player2 { get; set; } =0;
     

        
        public List<CustomButtonClass> tiles { get; set; } = new List<CustomButtonClass>(); 

        public int turn { get; set; } = 0;
        public bool againtsAI { get; set; } 
        public bool gameStarted { get; set; }
     
        public bool playerWon { get; set; }

        public bool computerWon { get; set; }

        public bool playerEnabled { get; set; }
        public static bool switchXO { get; set; } 
        public bool change { get; set; }
        public Button lastClickedButton = null;
        public static int player1Score { get; set; }
        public static int player2Score { get; set; }
        public bool tie { get; set; }

        public Random random { get; set; }


        public TicTacToe()
        {
            this.Height = 971;
            this.Width = 1197;
            InitializeComponent();
        
            resetGame(); 
       

        }
        public void resetGame()
        {


           
            turn = 0;
            player1Score = 0;
            player1 = 1;
            player2 = 0;
            player2Score = 0;
            againtsAI = true;
            gameStarted = false;
            firstPlayerSym = "X";
            secondPlayerSym = "O";
            disableXOFIelds();

            playerWon = false;
            computerWon = false;
            playerEnabled = true;
            change = false;
            tie = false;
            random = new Random();
            btnMulti.Enabled = true;
            kopceEden.Enabled = true;
            updateStatus();
       

            foreach (CustomButtonClass buttonClass in tiles)
            {
                resetXOFields();

            }

            tiles = new List<CustomButtonClass>();


        }
        public void restartGame()
        {
            updateStatus();
            foreach (CustomButtonClass buttonClass in tiles)
            {
                resetXOFields();

            }


            turn = 0;


            disableXOFIelds();

            playerWon = false;
            computerWon = false;
            playerEnabled = true;

            tie = false;
            random = new Random();
            btnMulti.Enabled = true;
            kopceEden.Enabled = true;
            tiles = new List<CustomButtonClass>();
           
        }





        public void updateStatus()
        {
            
            label3.Text = player1Score.ToString();
            label4.Text = player2Score.ToString();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Не е превземен,но бидејќи  не знаев да работам со панели имаше неколку кодови според кои се водев како да го направам
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            var table = (TableLayoutPanel)sender;
            var g = e.Graphics;
            var penColor = Color.Black;
            var penWidth = 2;

            for (int i = 1; i < table.RowCount; i++)
            {
                var y = table.GetRowHeights().Take(i).Sum();
                g.DrawLine(new Pen(penColor, penWidth), 0, y, table.Width, y);
            }

            for (int i = 1; i < table.ColumnCount; i++)
            {
                var x = table.GetColumnWidths().Take(i).Sum();
                g.DrawLine(new Pen(penColor, penWidth), x, 0, x, table.Height);
            }

        }

        public CustomButtonClass findCustomButton(int n)
        {
            return tiles.ElementAt(n - 1);
        }


        // Направен според повеќе кодови на интернет за пребарување на специфични елементи во панелот


        public void disableXOFIelds()
        {
            foreach (Control container in this.Controls)
            {
                if (container is Panel) 
                {
                    foreach (Control control in container.Controls)
                    {
                        if (control is Button button)
                        {
                     
                            control.Enabled = false;
                            control.ForeColor = Color.Red;
                            control.BackColor = Color.Transparent;


                            
                        }
                    }
                }
            }
        }

      public void enableXOFields()
        {
            foreach (Control container in this.Controls)
            {
                if (container is Panel) 
                {
                    foreach (Control control in container.Controls)
                    {
                        if (control is Button button)
                        {

                            control.Enabled = true;
                            control.BackColor = SystemColors.Control;

                        }
                    }
                }
            }
        }


        public void resetXOFields()
        
        {
           
            if (tiles.Count > 0)
            {
                foreach (CustomButtonClass c in tiles)
                {

                    c.field.Text = "";
                    c.field.Enabled = false;
                    c.field.BackColor = SystemColors.Control;              
                   

                }
            }
            
          
            foreach (Control container in this.Controls)
            {
                if (container is Panel) 
                {
                    foreach (Control control in container.Controls)
                    {
                        if (control is Button button)
                        {

                            control.Text = "";
                           control.BackColor = SystemColors.Control;
                            control.Enabled = false;
                            


                            

                        }
                    }
                }
            }


            if(lastClickedButton != null)
            {
                lastClickedButton.BackColor = SystemColors.Control;
                lastClickedButton = null;
            }

        }




        public void startGame()
        {
          
            
            gameStarted = true;
            turn = 0;
          
            random = new Random();
           
            tiles = new List<CustomButtonClass>{new CustomButtonClass(button1, -1), new CustomButtonClass(button2, -1), new CustomButtonClass(button3, -1), new CustomButtonClass(button4, -1)
                , new CustomButtonClass(button5, -1), new CustomButtonClass(button6, -1), new CustomButtonClass(button7, -1), new CustomButtonClass(button8, -1), new CustomButtonClass(button9, -1) };
            enableXOFields();
        }

      
   

        private void btnSingle_Click(object sender, EventArgs e)
        {
            startGame();
            if (!againtsAI)
            {
                label2.Text = "AI";
                change = true;
                player2Score = 0;
                player1Score = 0;
               
            }
            againtsAI = true;
           
            
           
            kopceEden.Enabled = false;
            btnMulti.Enabled = false;
            
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            startGame();
                      
     
            if (againtsAI)
            {
                label2.Text = "Player B";
                change = true;
                player2Score = 0;
                player1Score = 0;
            
            }
             againtsAI = false;
           
            kopceEden.Enabled = false;
            btnMulti.Enabled = false;
        }

        public void checkWin()
        {
            if (tiles[0].value == player1 && tiles[1].value == player1 && tiles[2].value == player1 ||
     tiles[3].value == player1 && tiles[4].value == player1 && tiles[5].value == player1 ||
     tiles[6].value == player1 && tiles[7].value == player1 && tiles[8].value == player1 ||
     tiles[0].value == player1 && tiles[4].value == player1 && tiles[8].value == player1 ||
     tiles[2].value == player1 && tiles[4].value == player1 && tiles[6].value == player1 ||
     tiles[0].value == player1 && tiles[3].value == player1 && tiles[6].value == player1 ||
     tiles[1].value == player1 && tiles[4].value == player1 && tiles[7].value == player1 ||
     tiles[2].value == player1 && tiles[5].value == player1 && tiles[8].value == player1



)
            {


                playerWon = true;
                




}
            else if (tiles[0].value == player2 && tiles[1].value == player2 && tiles[2].value == player2 ||
                    tiles[3].value == player2 && tiles[4].value == player2 && tiles[5].value == player2 ||
                    tiles[6].value == player2 && tiles[7].value == player2 && tiles[8].value == player2 ||
                    tiles[0].value == player2 && tiles[4].value == player2 && tiles[8].value == player2 ||
                     tiles[2].value == player2 && tiles[4].value == player2 && tiles[6].value == player2 ||
                      tiles[0].value == player2 && tiles[3].value == player2 && tiles[6].value == player2 ||
                     tiles[1].value == player2 && tiles[4].value == player2 && tiles[7].value == player2 ||
                        tiles[2].value == player2 && tiles[5].value == player2 && tiles[8].value == player2)
                {





                computerWon = true;




            }

            else
            {

                int i = 0;
                foreach(CustomButtonClass cbc in tiles)
                {
                    if (cbc.value !=-1)
                    {
                        i++;
                    }
                }
                if (i == 9 && !computerWon && !playerWon)
                {
                    tie = true;
                }

            }
        }
  
        private void computerMove()
        {
            
         
          
            playerEnabled = false;

           
                    foreach(CustomButtonClass cb in tiles)
            {
                if (cb.value == -1) 

                 {
                    cb.value = player2;

                    
                    checkWin();
                    if (computerWon)
                    {
                        cb.field.Text = secondPlayerSym.ToString();
                        cb.field.Enabled = false;
                        playerEnabled = true;
                        cb.value = player2;
                        cb.field.BackColor = Color.Transparent;
                       cb.field.FlatAppearance.BorderSize = 0;
                      
                        return;

                    }
                    cb.value = -1;
                    
                }
            }

       
            foreach (CustomButtonClass cb in tiles)
            {
                if (cb.value == -1) 

                {
                    cb.value = player1;

                    checkWin();
                    if (playerWon)
                    {
                       
                        cb.field.Text = secondPlayerSym.ToString();
                        
                        cb.value = player2;
                        cb.field.Enabled = false;
                        playerEnabled = true;

                        cb.field.BackColor = Color.Transparent;
                        playerWon = false;
                        cb.field.FlatAppearance.BorderSize = 0;
                        
                        return;

                    }
                    cb.value= -1;

                }
            }

       

            foreach (CustomButtonClass cb in tiles)
            {
                if (cb.value == -1) 

                {
                    cb.value = player2;
                    cb.field.Text = secondPlayerSym.ToString();
                    cb.field.BackColor = Color.Transparent;
                    playerEnabled = true;
                    cb.field.Enabled = false;
             
                    cb.field.FlatAppearance.BorderSize = 0;
                    return;

                }
            }




        }

        public void DrawXO(CustomButtonClass b)
        {
            

            if (againtsAI)  
            {
                

                    b.field.Text = firstPlayerSym.ToString();
                    b.value = player1;

               


                checkWin();
                if (playerWon)
                {
                   
                   
                    MessageBox.Show("You won!");
                    player1Score+=15;
                    gameOver();
                    restartGame();
                    btnMulti.Enabled = false;
                    kopceEden.Enabled = false;
                    disableXOFIelds();
                    return;

                }
                else
                {
                   
                    computerMove();
                    
                    if (computerWon)
                    {
                        MessageBox.Show("You Lost!");
                        player2Score+=15;
                        gameOver();
                        restartGame();
                        btnMulti.Enabled = false;
                        kopceEden.Enabled = false;
                        disableXOFIelds();
                        return;

                    }
                }
     

                checkWin();
                if (tie)
                {
                    lastClickedButton = b.field;
                    disableXOFIelds();
                    MessageBox.Show("It seems that we've reached a stalemate...");
                    gameOver();
                    restartGame();
                    btnMulti.Enabled = false;
                    kopceEden.Enabled = false;
                    disableXOFIelds();
                    return;
                }


               
            }else
            {

                

                if (turn % 2 == 0 )
                {
                    b.field.Text = firstPlayerSym.ToString();
                    b.value = player1;
               
                    checkWin();
                    if (playerWon)
                    {
                        lastClickedButton = b.field;
                        disableXOFIelds();
                        player1Score += 15;
                        MessageBox.Show("Player 1 Wins!");
                        gameStarted = false;
                        gameOver();
                        restartGame();
                        btnMulti.Enabled = false;
                        kopceEden.Enabled = false;
                        disableXOFIelds();
                        return;
                    }
                }
                else
                {
                    b.field.Text = secondPlayerSym.ToString();
                    b.value = player2;
                   
                    checkWin();
                    if (computerWon)
                    {
                        player2Score += 15;
                        lastClickedButton = b.field;
                        

                        MessageBox.Show("Player 2 Wins!");
                        gameStarted = false;
                        gameOver();
                        restartGame();
                        btnMulti.Enabled = false;
                        kopceEden.Enabled = false;
                        disableXOFIelds();
                        return;
                    }
                   
                }

                checkWin();
                if (tie)
                {

                    
                    disableXOFIelds();
                    gameStarted = false;
                    MessageBox.Show("Well I guess you both lost! That's rough buddy!");
                    player1Score += 5;
                    player2Score += 5;
                    gameOver();
                    restartGame();
                    btnMulti.Enabled = false;
                    kopceEden.Enabled = false;
                    disableXOFIelds();
                    return;
                }




                turn++;



            }
    
            



        }

     







        private void button3_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button3.Enabled == true && playerEnabled)
            {
                DrawXO(findCustomButton(3));
                button3.Enabled = false;
                button3.BackColor = Color.Transparent;
       
            }
            
            return;
       
        }

        private void aboutUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button1.Enabled == true && playerEnabled)
            {
                DrawXO(findCustomButton(1));
                button1.Enabled = false;
              button1.BackColor = Color.Transparent;
           

            }

        }
  
              private void button2_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button2.Enabled == true && playerEnabled)
            {
                DrawXO(findCustomButton(2));
                button2.Enabled = false;
                button2.BackColor = Color.Transparent;
           
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button4.Enabled == true && playerEnabled)
            {
                DrawXO(findCustomButton(4));
                button4.Enabled = false;
               button4.BackColor = Color.Transparent;
            
            }
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button5.Enabled == true && playerEnabled)
            {
                DrawXO(findCustomButton(5));
                button5.BackColor = Color.Transparent;
                button5.Enabled = false;
           
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button6.Enabled == true && playerEnabled)
            {
                DrawXO(findCustomButton(6));
                button6.BackColor = Color.Transparent;
                button6.Enabled = false;
       
            }
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button7.Enabled == true && playerEnabled) 
            {
                DrawXO(findCustomButton(7));
                button7.Enabled = false;
               button7.BackColor = Color.Transparent;

            }
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button8.Enabled == true && playerEnabled)
            {
                DrawXO(findCustomButton(8));
                button8.Enabled = false;
                button8.BackColor = Color.Transparent;
               
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button9.Enabled == true && playerEnabled)
            {
                DrawXO(findCustomButton(9));
                button9.Enabled = false;
                button9.BackColor = Color.Transparent;
          
            }
         
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Tic Tac Toe!\nTo play the game, follow these steps:\nYou have two options for playing:\nPlay against the computer: Choose the Play against AI option.\nPlay against your friends: Choose the Play against a friend option.\n" +
                "The first player to start is randomly determined. If playing against the computer, you will always go first.\nThe symbols used in the game are X and O.Each player takes turns placing their symbol on an empty spot on the grid.You can assign the symbols in the Settings option\n" +
                "To make a move, simply click on the desired cell on the grid. Your symbol will appear in that cell.\nThe goal is to get three of your symbols in a row, either horizontally, vertically, or diagonally, before the other player does.\n" +
                "If playing against the computer, it will automatically make its moves after you make yours.\nThe game keeps track of the score on the side of the board.Each players score increases when they win a game.\nYou can customize the colors of the game by using the provided options.Make it visually appealing to your liking!\n" +
                "Keep playing and enjoy the classic game of Tic Tac Toe!\n\nHave fun and may the best player win!");




 
 




















        }

        private void scoreBoard_Paint(object sender, PaintEventArgs e)
        {
            var table = (TableLayoutPanel)sender;
            var g = e.Graphics;
        
            var penColor = Color.Black;
            var penWidth = 3;

  
           
                var y = table.GetRowHeights().Take(1).Sum();
                g.DrawLine(new Pen(penColor, penWidth), 0, y, table.Width, y);
            
            penWidth = 2;
 
          
                var x = table.GetColumnWidths().Take(1).Sum();
                g.DrawLine(new Pen(penColor, penWidth), x, 0, x, table.Height);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        public void gameOver()
        {
            updateStatus();
            gameStarted = false;
            foreach (CustomButtonClass buttonClass in tiles)
            {
                resetXOFields();

            }
            btnMulti.Enabled = true;
            kopceEden.Enabled = true;

            turn = 0;

            disableXOFIelds();

            playerWon = false;
            computerWon = false;
            playerEnabled = true;
            tie = false;
            random = new Random();
            tiles = new List<CustomButtonClass>();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = "AI";
           resetGame();
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rateUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void player1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color fin = colorDialog.Color;
             
                }
            }
         
        }

        private void player2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void playOXInsteadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!gameStarted)
            {
                int a = player1;
                player1 = player2;
                player2 = a;

                String tm = firstPlayerSym;
                firstPlayerSym = secondPlayerSym;
                secondPlayerSym = tm;
            }
           
                
            
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void TicTacToe_MouseDown(object sender, MouseEventArgs e)
        {
            

        }

      


        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inputYourNamesHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
