using Supplement_P1_5;

namespace ShapeContainerConsole
{
    /// <summary>
    /// This class allow the user to create shapes with dimensions they define.
    /// Also users can get and delete shapes they created from the list.
    /// </summary>
    public class Program
    {
        static void Main()
        {
            ShapeContainer container = new ShapeContainer();

            while (true)
            {
                Console.Write("Enter command (0: Create, 1: Get, 2: Delete, 3: Exit): ");
                string command = Console.ReadLine().Trim();

                if (command == "0")
                {
                    Console.Write("Enter shape type (cube, sphere, or cylinder): ");
                    string shapeType = Console.ReadLine().Trim().ToLower();

                    Shape3D shape = null;
                    if (shapeType == "cube")
                    {
                        Console.Write("Enter side length: ");
                        double side = double.Parse(Console.ReadLine());
                        shape = new Cube(side);
                    }
                    else if (shapeType == "sphere")
                    {
                        Console.Write("Enter radius: ");
                        double radius = double.Parse(Console.ReadLine());
                        shape = new Sphere(radius);
                    }
                    else if (shapeType == "cylinder")
                    {
                        Console.Write("Enter radius: ");
                        double radius = double.Parse(Console.ReadLine());
                        Console.Write("Enter height: ");
                        double height = double.Parse(Console.ReadLine());
                        shape = new Cylinder(radius, height);
                    }
                    else
                    {
                        Console.WriteLine("WRONG! Invalid shape type!\n");
                        continue;
                    }

                    container.Create(shape);
                    Console.WriteLine("\nCreated: \n" + shape.Dump() + "\n");
                }
                else if (command == "1")
                {
                    Console.Write("Please enter index of the shape you want to get: ");
                    int index = int.Parse(Console.ReadLine());
                    Shape3D shape = container.Get(index);
                    Console.WriteLine(shape != null ? "Retrieved: \n" + shape.Dump() + "\n" : "Check your input. Invalid index!\n");
                }
                else if (command == "2")
                {
                    Console.Write("Please enter index of the shape you want to delete: \n");
                    int index = int.Parse(Console.ReadLine());
                    Console.WriteLine(container.Delete(index) ? "Shape " + index + " deleted successfully. RIP\n" : "Check your input. Invalid index!\n");
                }
                else if (command == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Command is invalid. Try Again!");
                }
            }
        }
    }

}
