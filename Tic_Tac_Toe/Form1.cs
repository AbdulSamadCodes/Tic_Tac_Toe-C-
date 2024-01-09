using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;

        void Enable_False()
        {
            btntic1.Enabled = false;
            btntic2.Enabled = false;
            btntic3.Enabled = false;
            btntic4.Enabled = false;
            
            btntic5.Enabled = false;
            btntic6.Enabled = false;
            btntic7.Enabled = false;
            btntic8.Enabled = false;
            btntic9.Enabled = false;
        }
        void Score()
        {
            if (btntic1.Text == "X" && btntic2.Text == "X" && btntic3.Text == "X")
            {
                btntic1.BackColor = System.Drawing.Color.Yellow;
                btntic2.BackColor = System.Drawing.Color.Yellow;
                btntic3.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("The winner is Player X", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerX.Text);
                LblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btntic1.Text == "X" && btntic4.Text == "X" && btntic7.Text == "X")
            {
                btntic1.BackColor = System.Drawing.Color.Blue;
                btntic4.BackColor = System.Drawing.Color.Blue;
                btntic7.BackColor = System.Drawing.Color.Blue;
                MessageBox.Show("The winner is Player X", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerX.Text);
                LblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btntic3.Text == "X" && btntic5.Text == "X" && btntic7.Text == "X")
            {
                btntic3.BackColor = System.Drawing.Color.Violet;
                btntic5.BackColor = System.Drawing.Color.Violet;
                btntic7.BackColor = System.Drawing.Color.Violet;
                MessageBox.Show("The winner is Player X", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerX.Text);
                LblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btntic2.Text == "X" && btntic5.Text == "X" && btntic8.Text == "X")
            {
                btntic2.BackColor = System.Drawing.Color.Green;
                btntic5.BackColor = System.Drawing.Color.Green;
                btntic8.BackColor = System.Drawing.Color.Green;
                MessageBox.Show("The winner is Player X", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerX.Text);
                LblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btntic3.Text == "X" && btntic6.Text == "X" && btntic9.Text == "X")
            {
                btntic3.BackColor = System.Drawing.Color.Red;
                btntic5.BackColor = System.Drawing.Color.Red;
                btntic7.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("The winner is Player X", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerX.Text);
                LblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btntic4.Text == "X" && btntic5.Text == "X" && btntic6.Text == "X")
            {
                btntic4.BackColor = System.Drawing.Color.Azure;
                btntic5.BackColor = System.Drawing.Color.Azure;
                btntic6.BackColor = System.Drawing.Color.Azure;
                MessageBox.Show("The winner is Player X", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerX.Text);
                LblPlayerX.Text = Convert.ToString(plusone +1);
                Enable_False();
            }
            if (btntic7.Text == "X" && btntic8.Text == "X" && btntic9.Text == "X")
            {
                btntic7.BackColor = System.Drawing.Color.MediumSeaGreen;
                btntic8.BackColor = System.Drawing.Color.MediumSeaGreen;
                btntic9.BackColor = System.Drawing.Color.MediumSeaGreen;
                MessageBox.Show("The winner is Player X", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerX.Text);
                LblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btntic1.Text == "X" && btntic5.Text == "X" && btntic9.Text == "X")
            {
                btntic1.BackColor = System.Drawing.Color.NavajoWhite;
                btntic5.BackColor = System.Drawing.Color.NavajoWhite;
                btntic9.BackColor = System.Drawing.Color.NavajoWhite;
                MessageBox.Show("The winner is Player X", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerX.Text);
                LblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            //==============================================================================
            if (btntic1.Text == "O" && btntic2.Text == "O" && btntic3.Text == "O")
            {
                btntic1.BackColor = System.Drawing.Color.AliceBlue;
                btntic2.BackColor = System.Drawing.Color.AliceBlue;
                btntic3.BackColor = System.Drawing.Color.AliceBlue;
                    ;
                MessageBox.Show("The winner is Player 0", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerY.Text);
                LblPlayerY.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btntic1.Text == "O" && btntic4.Text == "O" && btntic7.Text == "O")
            {
                btntic1.BackColor = System.Drawing.Color.LemonChiffon;
                btntic4.BackColor = System.Drawing.Color.LemonChiffon;
                btntic5.BackColor = System.Drawing.Color.LemonChiffon;
                MessageBox.Show("The winner is Player O", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerY.Text);
                LblPlayerY.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btntic3.Text == "O" && btntic5.Text == "O" && btntic7.Text == "O")
            {
                btntic3.BackColor = System.Drawing.Color.SandyBrown;
                btntic5.BackColor = System.Drawing.Color.SandyBrown;
                btntic7.BackColor = System.Drawing.Color.SandyBrown;
                MessageBox.Show("The winner is Player O", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerY.Text);
                LblPlayerY.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btntic2.Text == "O" && btntic5.Text == "O" && btntic8.Text == "O")
            {
                btntic2.BackColor = System.Drawing.Color.BlueViolet;
                btntic5.BackColor = System.Drawing.Color.BlueViolet;
                btntic8.BackColor = System.Drawing.Color.BlueViolet;
                MessageBox.Show("The winner is Player O", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerY.Text);
                LblPlayerY.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btntic3.Text == "O" && btntic6.Text == "O" && btntic9.Text == "O")
            {
                btntic3.BackColor = System.Drawing.Color.DarkBlue;
                btntic6.BackColor = System.Drawing.Color.DarkBlue;
                btntic9.BackColor = System.Drawing.Color.DarkBlue;
                MessageBox.Show("The winner is Player O", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerY.Text);
                LblPlayerY.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btntic4.Text == "O" && btntic5.Text == "O" && btntic6.Text == "O")
            {
                btntic4.BackColor = System.Drawing.Color.SeaGreen;
                btntic5.BackColor = System.Drawing.Color.SeaGreen;
                btntic6.BackColor = System.Drawing.Color.SeaGreen;
                MessageBox.Show("The winner is Player O", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerY.Text);
                LblPlayerY.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btntic7.Text == "O" && btntic8.Text == "O" && btntic9.Text == "O")
            {
                btntic7.BackColor = System.Drawing.Color.Maroon;
                btntic8.BackColor = System.Drawing.Color.Maroon;
                btntic9.BackColor = System.Drawing.Color.Maroon;
                MessageBox.Show("The winner is Player O", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerY.Text);
                LblPlayerY.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
            if (btntic1.Text == "O" && btntic5.Text == "O" && btntic9.Text == "O")
            {
                btntic1.BackColor = System.Drawing.Color.Brown
                    ;
                btntic5.BackColor = System.Drawing.Color.Brown;
                btntic9.BackColor = System.Drawing.Color.Brown
                    ;
                MessageBox.Show("The winner is Player O", "TIc Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(LblPlayerY.Text);
                LblPlayerY.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }



        }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btntic1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic1.Text = "X";
                checker = true;

            }
            else
            {
                btntic1.Text = "O";
                checker = false;
            }
            Score();
            btntic1.Enabled = false;
        }

        private void btntic2_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btntic2.Text = "X";
                checker = true;

            }
            else
            {
                btntic2.Text = "O";
                checker = false;
            }
            Score();
            btntic2.Enabled = false;

        }

        private void btntic3_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btntic3.Text = "X";
                checker = true;

            }
            else
            {
                btntic3.Text = "O";
                checker = false;
            }
            Score();
            btntic3.Enabled = false;
        }

        private void btntic4_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btntic4.Text = "X";
                checker = true;

            }
            else
            {
                btntic4.Text = "O";
                checker = false;
            }
            Score();
            btntic4.Enabled = false;
        }

        private void btntic5_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btntic5.Text = "X";
                checker = true;

            }
            else
            {
                btntic5.Text = "O";
                checker = false;
            }
            Score();
            btntic5.Enabled = false;

        }

        private void btntic6_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btntic6.Text = "X";
                checker = true;

            }
            else
            {
                btntic6.Text = "O";
                checker = false;
            }
            Score();
            btntic6.Enabled = false;
        }

        private void btntic7_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btntic7.Text = "X";
                checker = true;

            }
            else
            {
                btntic7.Text = "O";
                checker = false;
            }
            Score();
            btntic7.Enabled = false;
        }

        private void btntic8_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btntic8.Text = "X";
                checker = true;

            }
            else
            {
                btntic8.Text = "O";
                checker = false;
            }
            Score();
            btntic8.Enabled = false;
        }

        private void btntic9_Click(object sender, EventArgs e)
        {

            if (checker == false)
            {
                btntic9.Text = "X";
                checker = true;

            }
            else
            {
                btntic9.Text = "O";
                checker = false;
            }
            Score();
            btntic9.Enabled = false;
        }

        private void btnNewgame_Click(object sender, EventArgs e)
        {
            try
            {
                btntic1.Enabled = true;
                btntic2.Enabled = true;
                btntic3.Enabled = true;
                btntic4.Enabled = true;

                btntic5.Enabled = true;
                btntic6.Enabled = true;
                btntic7.Enabled = true;
                btntic8.Enabled = true;
                btntic9.Enabled = true;

                btntic1.Text = "";
                btntic2.Text = "";
                btntic3.Text = "";
                btntic4.Text = "";
                btntic5.Text = "";
                btntic6.Text = "";
                btntic7.Text = "";
                btntic8.Text = "";
                btntic9.Text = "";

                LblPlayerX.Text = "0";
                LblPlayerY.Text = "0";

                btntic1.BackColor = Color.WhiteSmoke;
                btntic2.BackColor = Color.WhiteSmoke;
                btntic3.BackColor = Color.WhiteSmoke;
                btntic4.BackColor = Color.WhiteSmoke;
                btntic5.BackColor = Color.WhiteSmoke;

                btntic6.BackColor = Color.WhiteSmoke;
                btntic7.BackColor = Color.WhiteSmoke;
                btntic8.BackColor = Color.WhiteSmoke;
                btntic9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                btntic1.Enabled = true;
                btntic2.Enabled = true;
                btntic3.Enabled = true;
                btntic4.Enabled = true;

                btntic5.Enabled = true;
                btntic6.Enabled = true;
                btntic7.Enabled = true;
                btntic8.Enabled = true;
                btntic9.Enabled = true;


                btntic1.Text = "";
                btntic2.Text = "";
                btntic3.Text = "";
                btntic4.Text = "";
                btntic5.Text = "";
                btntic6.Text = "";
                btntic7.Text = "";
                btntic8.Text = "";
                btntic9.Text = "";

                btnNewgame.Enabled = true;

                btntic1.BackColor = Color.WhiteSmoke;
                btntic2.BackColor = Color.WhiteSmoke;
                btntic3.BackColor = Color.WhiteSmoke;
                btntic4.BackColor = Color.WhiteSmoke;
                btntic5.BackColor = Color.WhiteSmoke;

                btntic6.BackColor = Color.WhiteSmoke;
                btntic7.BackColor = Color.WhiteSmoke;
                btntic8.BackColor = Color.WhiteSmoke;
                btntic9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show(" Confirm you want to Exit ", "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Tic Tac Toe",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }
    }
}
