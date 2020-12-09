using System;
using System.Collections.Generic;

namespace Lab11
{
    public delegate void ActionDelegate(Visitor a);

    public delegate void AllActionDelegate(Visitor a);

    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
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

            List<Student> studs = new List<Student>();
            studs.Add(new Student("Nick", "Topson", rand.Next(10, 30)));
            studs.Add(new Student("Andrew", "Moreno", rand.Next(10, 30)));
            studs.Add(new Student("Adam", "Sandler", rand.Next(10, 30)));
            studs.Add(new Student("Dolly", "Alderson", rand.Next(10, 30)));
            studs.Add(new Student("Albert", "Enstein", rand.Next(10, 30)));
            studs.Add(new Student("Julia", "Lan", rand.Next(10, 30)));
            studs.Add(new Student("Alexander", "The First", rand.Next(10, 30)));
            studs.Add(new Student("Olha", "Kischuk", rand.Next(10, 30)));
            studs.Add(new Student("Michael", "Grishchuk", rand.Next(10, 30)));
            studs.Add(new Student("Eve", "Mitsuri", rand.Next(10, 30)));
            studs.Add(new Student("Nikita", "Reshetnik", rand.Next(10, 30)));
            studs.Add(new Student("Elliot", "Troelsen", rand.Next(10, 30)));
            
            Console.WriteLine("Age > 18");
            studs.FindStudents(Student.IsAdult).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("First letter of First name \"А\"");
            studs.FindStudents(Student.FNameStartsWithA).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Last Name is Longer then 3");
            studs.FindStudents(Student.LNameLongerThanThree).ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Age > 18");
            studs.FindStudents(s => s.Age >= 18).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("First letter of First name \"А\"");
            studs.FindStudents(s => s.FirstName?[0] == 'A').ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Last Name is Longer then 3");
            studs.FindStudents(s => s.LastName?.Length > 3).ForEach(Console.WriteLine);
            Console.WriteLine();
            //Anonymous methods
            Console.WriteLine("Age betwewn 20 and 25");
            studs.FindStudents(s => s.Age >= 20 && s.Age <= 25).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Name \"Andrew\"");
            studs.FindStudents(s => s.FirstName.Equals("Andrew")).ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("Surname \"Troelsen\"");
            studs.FindStudents(s => s.LastName.Equals("Troelsen")).ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}