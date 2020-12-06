namespace Lab11
{
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
}