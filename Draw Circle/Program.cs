﻿using System;


namespace CircleDraw
{
    class Circle
    {

        static void Main(string[] args)
        {
        back:
            double radius;
            double thickness = 0.2;
            Console.WriteLine("Please enter an integer radius greater than 0: ");

            if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                goto back;

            Console.WriteLine();
            double innerCircle = radius - thickness;
            double outerCircle = radius + thickness;

           
            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < outerCircle; x += 0.5)
                {
                    
                    double value = x * x + y * y;
                    if (value >= innerCircle * innerCircle && value <= outerCircle * outerCircle)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();




        }
    }
}