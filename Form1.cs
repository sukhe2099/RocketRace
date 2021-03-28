using System;
using System.Drawing;
using System.Windows.Forms;

namespace RocketRace
{
    public partial class Form1 : Form
    {
        private Punter[] myguy = new Punter[3];
        private Spaceship[] MySpaceship = new Spaceship[4];
        private Spaceship myWinningSpaceship = new Spaceship();

        public Form1()
        {
            InitializeComponent();
            myguy[0] = new Sukhman();
            myguy[1] = new Anil();
            myguy[2] = new Al();
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            Random myrandom = new Random();
            LoadSpaceships();

            bool End = false;

            while (End == false)
            {
                for (int i = 0; i < 4; i++)
                {
                    MySpaceship[i].MyPictureBox.Left += myrandom.Next(0, 30); // create a random number from 0 to 30 and added to each picturebox to move it forward

                    if (MySpaceship[i].MyPictureBox.Left > 800) // the first picturebox to hit 800
                    {
                        End = true; // return true if i won the race
                        // set winningship name to display in messagebox
                        var myText = MySpaceship[i].SpaceshipName;
                        //calculates winning spaceship Pass winning spaceship to winningship property
                        myWinningSpaceship.WinningShip = MySpaceship[i].ShipScreenValueLocation;

                        MessageBox.Show(myText + " won the race!");
                    }
                }
            }
            //pass int value to winning details list
            WinningDetails(myWinningSpaceship.WinningShip);
        }

        private void WinningDetails(int WinningSpace)
        {
            for (int i = 0; i < 3; i++)
            {
                if (WinningSpace == myguy[i].Spaceship) //comparing the winning ship with the ship that the punter chosen
                {
                    myguy[i].Cash += myguy[i].Amount; // if he wins his selected bet amount is added to punter cash amount

                    switch (i)
                    {
                        case 0:
                            txtSukhman.Text = string.Format("{0} " + "Won and now has got ${1} ", myguy[0].Name, myguy[0].Cash);
                            break;

                        case 1:
                            txtAnil.Text = string.Format("{0} " + "Won and now has got ${1} ", myguy[1].Name, myguy[1].Cash);
                            break;
                        case 2:
                            txtAl.Text = string.Format("{0} " + "Won and now has got ${1} ", myguy[2].Name, myguy[2].Cash);
                            break;
                    }
                }
                else
                {
                    myguy[i].Cash -= myguy[i].Amount; // if he losts his selected bet amount is subtracted to punter cash amount

                    switch (i)
                    {
                        case 0:
                            txtSukhman.Text = string.Format("{0} " + "Lost and now has got ${1} ", myguy[0].Name, myguy[0].Cash);
                            break;

                        case 1:
                            txtAnil.Text = string.Format("{0} " + "Lost and now has got ${1} ", myguy[1].Name, myguy[1].Cash);
                            break;
                        case 2:
                            txtAl.Text = string.Format("{0} " + "Lost and now has got ${1} ", myguy[2].Name, myguy[2].Cash);
                            break;
                    }
                }

                if (myguy[i].Cash == 0) // if guys don't have money at all
                {
                    myguy[i].Busted = true;
                    myguy[i].Amount = 0;
                    myguy[i].Spaceship = 0;
                    switch (i)
                    {
                        case 0:
                            SukhmanRadioButton.Enabled = false;
                            txtSukhman.ForeColor = Color.Red;
                            txtSukhman.Text = "BUSTED";
                            break;
                        case 1:
                            AnilRadioButton.Enabled = false;
                            txtAnil.ForeColor = Color.Red;
                            txtAnil.Text = "BUSTED";
                            break;
                        case 2:
                            AlRadioButton.Enabled = false;
                            txtAl.ForeColor = Color.Red;
                            txtAl.Text = "BUSTED";
                            break;
                    }
                }

                if (SukhmanRadioButton.Enabled == false && AnilRadioButton.Enabled == false && // Each of Radiobuttons are inactiv
                   AlRadioButton.Enabled == false)
                {
                    btnReset.Enabled = false; // if guys lost his money totally then the reset button doesn't work
                    MessageBox.Show("Game over!");
                }
            }
        }


        private void LoadSpaceships()
        {
            MySpaceship[0] = new Spaceship()
            {
                Location = 112, // starting position
                MyPictureBox = Spaceship1, // this is the first spaceship picturebox
                StartingPosition = 112, // this is the starting position at the first spaceship
                SpaceshipName = "Apollo-Spaceship 1", // the name of the spaceship
                ShipScreenValueLocation = 1 // this is the first spaceship
            };
            MySpaceship[1] = new Spaceship()
            {
                Location = 112,
                MyPictureBox = Spaceship2,
                StartingPosition = 112,
                SpaceshipName = "Explorer-Spaceship 2",
                ShipScreenValueLocation = 2
            };
            MySpaceship[2] = new Spaceship()
            {
                Location = 112,
                MyPictureBox = Spaceship3,
                StartingPosition = 112,
                SpaceshipName = "Sputnik-Spaceship 3",
                ShipScreenValueLocation = 3
            };
            MySpaceship[3] = new Spaceship()
            {
                Location = 112,
                MyPictureBox = Spaceship4,
                StartingPosition = 112,
                SpaceshipName = "Discovery-Spaceship 4",
                ShipScreenValueLocation = 4
            };
        }
        private void btnReset_Click(object sender, EventArgs e) // when click the reset button the spaceship will be on the starting position
        {
            Spaceship1.Left = 112;
            Spaceship2.Left = 112;
            Spaceship3.Left = 112;
            Spaceship4.Left = 112;
        }

        private void AllRadioButton_CheckedChanged(object sender, EventArgs e)
        {   //create a fake RB to pass the sender data to
            RadioButton FakeRB = new RadioButton();
            //pass across all the data of the radiobutton that you clicked on
            FakeRB = (RadioButton)sender;
            //take the name of the radiobutton and pass it to the method and get back the ID number, 1, 2, 3


            if (FakeRB.Checked)  //only run for the guy being checked
            {
                Factory.GetNameId(FakeRB.Text);

                UDBet.Maximum = myguy[Factory.GuyNumber].Cash; // this is the maximum that guys can bet

                lblBettor.Text = myguy[Factory.GuyNumber].Name + " Bets ... "; //label shows the names with bets

                lblmax.Text = "Max bet is $" + myguy[Factory.GuyNumber].Cash; //This is the max he can bet
            }
        }

        private void btnPlaceBet_Click_1(object sender, EventArgs e)
        {
            myguy[Factory.GuyNumber].Spaceship = Convert.ToInt32(UDSpaceShip.Value); // convert the spaceship from string to Int and we added a value
            myguy[Factory.GuyNumber].Amount = Convert.ToInt32(UDBet.Value); // convert the amount from string to Int and we added a value

            if (myguy[Factory.GuyNumber].Name == "Sukhman")
            {
                //we can see the name, amount and the spaceship number on Sukhman's textbox 
                txtSukhman.Text = string.Format("{0} bets $ {1} on Spaceship Number {2}",
                myguy[Factory.GuyNumber].Name, myguy[Factory.GuyNumber].Amount, myguy[Factory.GuyNumber].Spaceship);
            }
            else if (myguy[Factory.GuyNumber].Name == "Anil")
            {
                //we can see the name, amount and the spaceship number on Anil's textbox 
                txtAnil.Text = string.Format("{0} bets $ {1} on Spaceship Number {2}",
                myguy[Factory.GuyNumber].Name, myguy[Factory.GuyNumber].Amount, myguy[Factory.GuyNumber].Spaceship);
            }
            else
            {
                //we can see the name, amount and the spaceship number on Al's textbox 
                txtAl.Text = string.Format("{0} bets $ {1} on Spaceship Number {2}",
                myguy[Factory.GuyNumber].Name, myguy[Factory.GuyNumber].Amount, myguy[Factory.GuyNumber].Spaceship);
            }
        }
    }
}
