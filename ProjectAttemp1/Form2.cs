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
    public partial class Form2 : Form
    {
        public Form1 raceB { get; set; }
       public TicTacToe ticTacToe = new TicTacToe();
        public Form1 form1 { get; set; }
        public Form2()
        {
            this.Width = 874;
            this.Height = 557;
            InitializeComponent();
           
            ballRace.BackColor = Color.Transparent;
    

        }

        private void ballRace_Click(object sender, EventArgs e)
        {
             form1 = new Form1();
            form1.Show();
            ticTacToe.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ticTacToe = new TicTacToe();     
            ticTacToe.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Resize(object sender, EventArgs e)
        {

        }
    }
}
