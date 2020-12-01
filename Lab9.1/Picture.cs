using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab9._1
{
    class Picture : IDraw
    {
        public Picture()
        {
            
        }

        public Picture(int collectionLenght)
        {
            CollectionLenght = collectionLenght;
        }

        public Shape this[int index]
        {
            get
            {
                return Collection[index];
            }
            set
            {
                Collection[index] = value;
            }
        }
        public List<Shape> Collection = new List<Shape>();
        public int CollectionLenght { get; set; }

        public int CollectionCount => Collection.Count;

        public void AddShape(Shape shape)
        {
            Collection.Add(shape);
        }

        public void DeleteShape(string name)
        {
            try
            {
                Collection.Remove(Collection.SingleOrDefault(c => c.Name == name));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void DeleteShape(Type type)
        {
            try
            {
                Collection.RemoveAll( c => c.GetType() == type);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void DeleteShape(int square, int maxSquare)
        {
            try
            {
                Collection.RemoveAll(c => c.CalculateSquare() > maxSquare);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void ShowShapes(List<Shape> collect)
        {
            foreach (var elem in collect)
            {
                Console.WriteLine($"Shape with name: {elem.Name}, color: {elem.Color}, type: {elem.GetType()}");
            }
        }

        public void Draw()
        {
            foreach (var elem in Collection)
            {
                elem.Draw();
            }
        }
    }
}