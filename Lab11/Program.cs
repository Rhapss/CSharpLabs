namespace Lab11
{
    public delegate void ActionDelegate(Visitor a);

    public delegate void AllActionDelegate(Visitor a);

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