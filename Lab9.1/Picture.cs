using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab9._1
{
    class Picture
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
                return collection[index];
            }
            set
            {
                collection[index] = value;
            }
        }
        public List<Shape> collection = new List<Shape>();
        public int CollectionLenght { get; set; }

        public int CollectionCount
        {
            get
            {
                return collection.Count;
            }
            private set
            {
                
            }
        }
        
        public void AddShape(Shape shape)
        {
            collection.Add(shape);
        }

        public void DeleteShape(string name)
        {
            try
            {
                collection.Remove(collection.SingleOrDefault(c => c.Name == name));
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
                collection.RemoveAll( c => c.GetType() == type);
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
                collection.RemoveAll(c => c.CalculateSquare() > maxSquare);
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
    }
}