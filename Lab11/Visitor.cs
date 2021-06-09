using System;

namespace Lab11
{
    public class Visitor
    {
        public Visitor()
        {
            RollerCoaster = false;
            ShootingRange = false;
            RoomOfFear = false;
            RoomOfCrookedMirrors = false;
            Popcorn = false;
            FerrisWheel = false;
        }

        public bool RollerCoaster { get; set; }
        public bool ShootingRange { get; set; }
        public bool RoomOfFear { get; set; }
        public bool RoomOfCrookedMirrors { get; set; }
        public bool Popcorn { get; set; }
        public bool FerrisWheel { get; set; }

        public void ShowAttended()
        {
            Console.WriteLine("------------------------------------------------------\n" +
                              $"RollerCoaster - {RollerCoaster}\n" +
                              $"Shooting Range - {ShootingRange}\n" +
                              $"Room of Fear - {RoomOfFear}\n" +
                              $"Room of Crooked Mirrors- {RoomOfCrookedMirrors}\n" +
                              $"Popcorn - {Popcorn}\n" +
                              $"Ferris Wheel - {FerrisWheel}\n" +
                              "------------------------------------------------------\n");
        }
    }
}