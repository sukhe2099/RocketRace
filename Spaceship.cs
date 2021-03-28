using System;
using System.Windows.Forms;

namespace RocketRace
{
    public class Spaceship
    {
        //**************FIELDS
        public PictureBox MyPictureBox = null; // My PictureBox object
        public Random Randomizer; // An instance of Random

        //**************PROPERTIES
        public int StartingPosition { get; set; } // Where my PictureBox starts
        public int Location { get; set; } //My Location on the racetrack
        public string SpaceshipName { get; set; } // The name of the spaceship
        public int WinningShip { get; set; } // It shows the winningship
        public int ShipScreenValueLocation { get; set; } // it shows the spaceship location
    }
}
