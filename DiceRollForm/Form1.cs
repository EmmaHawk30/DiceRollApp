using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRollForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pbxDie.ImageLocation = "C:\\Users\\Emma\\Documents\\Programming\\Mini Projects\\DiceRollForm\\DiceRollWithImage";
            Image die1 = Image.FromFile(@"C:\\Users\\emmah\\Documents\\USB back up 14092021\\Programming\\Mini Projects\\DiceRollForm\\DiceRollWithImage\\DieOne.png");
            pbxDie.SizeMode = PictureBoxSizeMode.AutoSize;
            Image die2 = Image.FromFile(@"C:\\Users\\emmah\\Documents\\USB back up 14092021\\Programming\\Mini Projects\\DiceRollForm\\DiceRollWithImage\\DieTwo.png");
            Image die3 = Image.FromFile(@"C:\\Users\\emmah\\Documents\\USB back up 14092021\\Programming\\Mini Projects\\DiceRollForm\\DiceRollWithImage\\DieThree.png");
            Image die4 = Image.FromFile(@"C:\\Users\\emmah\\Documents\\USB back up 14092021\\Programming\\Mini Projects\\DiceRollForm\\DiceRollWithImage\\DieFour.png");
            Image die5 = Image.FromFile(@"C:\\Users\\emmah\\Documents\\USB back up 14092021\\Programming\\Mini Projects\\DiceRollForm\\DiceRollWithImage\\DieFive.png");
            Image die6 = Image.FromFile(@"C:\\Users\\emmah\\Documents\\USB back up 14092021\\Programming\\Mini Projects\\DiceRollForm\\DiceRollWithImage\\DieSix.png");

            Random r = new Random();
            int dieRoll = r.Next(1, 6);
            lblResult.Text = dieRoll.ToString();

            

            if(dieRoll == 1)
            {
                pbxDie.Image = die1;
            }
            else if(dieRoll == 2)
            {
                pbxDie.Image = die2;
            }
            else if(dieRoll == 3)
            {
                pbxDie.Image = die3;
            }
            else if(dieRoll == 4)
            {
                pbxDie.Image = die4;
            }
            else if(dieRoll == 5)
            {
                pbxDie.Image = die5;
            }
            else
            {
                pbxDie.Image = die6;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
