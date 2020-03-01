using System;

namespace MethodsAndrewGreen
{
    class Program
    {

        static double Calculation(double num1, double num2, int flag)
        {
            //Case Handling
            switch (flag)
            {
                //Addition
                case 1: return (num1 + num2);

                //Subtraction
                case 2: return (num1 - num2);

                //Multiplication
                case 3: return (num1 * num2);

                //Division
                case 4:
                    {
                        //Handling Divide by Zero case
                        if (num2 == 0)
                            Console.WriteLine("Division By Zero is not possible.");
                        else
                            return (num1 / num2);
                        break;
                    }
                default: break;
            }
            //When dividing by zero
            return double.NaN;
        }

        static void MyName()

        {

            Console.WriteLine("My name is Andrew Green.");
        }
        static void Main(string[] args)

        {
            double num1, num2;
            int flag;

            Console.WriteLine("Hello and welcome to your calculations");
            MyName();

            {
               
                {
                    //Input 1
                    Console.WriteLine("Enter number 1: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    //Input 2
                    Console.WriteLine("Enter number 2: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("1.Add\n2.Subtract\n3.Multiply\n4.Divide");
                    Console.WriteLine("Please select your choice ?");

                    //Input Flag
                    flag = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("The output for your calculation is: " + Calculation(num1, num2, flag));

                }
            }


        }
    }
}