using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebase3
{
    class Box 

    
        
    {
        // Write a class Box that has Length and breadth as its members.Write a function that adds 2 box objects and stores in the 3rd.Display the 3rd object details. Create a Test class to execute the above.
        

        public double length { get; set; }
        public double breadth { get; set; }

        public Box(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public static  Box Add(Box box1, Box box2)
        {
            double newLength = box1.length + box2.length;
            double newBreadth = box1.breadth + box2.breadth;
            return new Box(newLength, newBreadth);

        }
        public void display()
        {
            Console.WriteLine("length of the box :" + length, "breadth of the box :" + breadth);
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dimensions of the first box:");
            Console.Write("Length: ");
            double length1 = double.Parse(Console.ReadLine());
            Console.Write("Breadth: ");
            double breadth1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the dimensions of the second box:");
            Console.Write("Length: ");
            double length2 = double.Parse(Console.ReadLine());
            Console.Write("Breadth: ");
            double breadth2 = double.Parse(Console.ReadLine());

            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);

            Box resultBox = Box.Add(box1, box2);

           

            Console.WriteLine("\nResultant Box (Box 1 + Box 2):");
            resultBox.display();
        }
    }  
}

