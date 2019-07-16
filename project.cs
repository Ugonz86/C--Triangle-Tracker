using System;

class TriangleTracker
{
  static void Main()
  {
    Console.WriteLine("Enter the first angle:");
    string stringAngleX = Console.ReadLine();
    int angleX = int.Parse(stringAngleX);

    Console.WriteLine("Enter the second angle:");
    string stringAngleY = Console.ReadLine();
    int angleY = int.Parse(stringAngleY);

    Console.WriteLine("Enter the third angle:");
    string stringAngleZ = Console.ReadLine();
    int angleZ = int.Parse(stringAngleZ);

    if (angleX == angleY && angleX == angleZ)

    {
      Console.WriteLine("That is an equilateral triangle!");
    }
    else if ((angleX + angleY > angleZ && angleX + angleZ > angleY && angleY + angleZ > angleX) && (angleX == angleY || angleX == angleZ || angleY == angleZ))
    {
      Console.WriteLine("That is an isosceles triangle!");
    }
    else if ((angleX + angleY > angleZ && angleX + angleZ > angleY && angleY + angleZ > angleX) && !(angleX == angleY || angleX == angleZ || angleY == angleZ))
    {
      Console.WriteLine("This is a scalene triangle!");
    }
    else
    {
      Console.WriteLine("This is NOT a triangle!");
    }

    }
}
