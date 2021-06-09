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
            var rand = new Random();
            var james = new Visitor();
            var thePark = new AmusementPark();

            ActionDelegate rollerCoaster = thePark.VisitRollerCoaster;
            ActionDelegate shootingRange = thePark.VisitInShootingRange;
            ActionDelegate roomOfFear = thePark.VisitRoomOfFear;
            ActionDelegate roomOfCrookedMirrors = thePark.VisitRoomOfCrookedMirrors;
            ActionDelegate eatPopcorn = thePark.EatPopcorn;
            ActionDelegate ferrisWheel = thePark.VisitFerrisWheel;

            var allAction = new AllActionDelegate
                (rollerCoaster + shootingRange + roomOfFear + roomOfCrookedMirrors + eatPopcorn + ferrisWheel);


            james.ShowAttended();

            shootingRange(james);

            eatPopcorn(james);

            james.ShowAttended();

            allAction(james);

            james.ShowAttended();

            var studs = new List<Student>();
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