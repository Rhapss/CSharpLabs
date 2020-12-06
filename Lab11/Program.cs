using System;

namespace Lab11
{
    public delegate void ActionDelegate(Visitor a);

    public delegate void AllActionDelegate(Visitor a);
    public class AmusementPark
    {
        
        public void VisitRollerCoaster(Visitor visitor)
        {
            visitor.RollerCoaster = true;
        }

        public void VisitInShootingRange(Visitor visitor)
        {
            visitor.ShootingRange = true;
        }

        public void VisitRoomOfFear(Visitor visitor)
        {
            visitor.RoomOfFear = true;
        }

        public void VisitRoomOfCrookedMirrors(Visitor visitor)
        {
            visitor.RoomOfCrookedMirrors = true;
        }

        public void EatPopcorn(Visitor visitor)
        {
            visitor.Popcorn = true;
        }

        public void VisitFerrisWheel(Visitor visitor)
        {
            visitor.FerrisWheel = true;
        }
    }

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
            Console.WriteLine($"------------------------------------------------------\n" +
                              $"RollerCoaster - {RollerCoaster}\n" +
                              $"Shooting Range - {ShootingRange}\n" +
                              $"Room of Fear - {RoomOfFear}\n" +
                              $"Room of Crooked Mirrors- {RoomOfCrookedMirrors}\n" +
                              $"Popcorn - {Popcorn}\n" +
                              $"Ferris Wheel - {FerrisWheel}\n" +
                              $"------------------------------------------------------\n");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var james = new Visitor();
            var thePark = new AmusementPark();
            
            ActionDelegate rollerCoaster = new ActionDelegate(thePark.VisitRollerCoaster);
            ActionDelegate shootingRange = new ActionDelegate(thePark.VisitInShootingRange);
            ActionDelegate roomOfFear = new ActionDelegate(thePark.VisitRoomOfFear);
            ActionDelegate roomOfCrookedMirrors = new ActionDelegate(thePark.VisitRoomOfCrookedMirrors);
            ActionDelegate eatPopcorn = new ActionDelegate(thePark.EatPopcorn);
            ActionDelegate ferrisWheel = new ActionDelegate(thePark.VisitFerrisWheel);

            AllActionDelegate allAction = new AllActionDelegate
                (rollerCoaster + shootingRange + roomOfFear + roomOfCrookedMirrors + eatPopcorn + ferrisWheel);
            
            
            james.ShowAttended();
            
            shootingRange(james);
            
            eatPopcorn(james);
            
            james.ShowAttended();
            
            allAction(james);
            
            james.ShowAttended();
        }
    }
}