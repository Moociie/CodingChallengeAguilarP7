using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Challenges
{


    public static void Main(string[] args)
    {
        //Welcome the user to my program
        Console.WriteLine("Welcome to my coding challenge program! I will be making a variety of functions for you to use! \n Please pick one.");

        Console.WriteLine(" Sum \n Convert \n Increase \n CircuitPower \n AgeConvert \n TriArea \n lessThanOrEqualToZero \n lessThan100 \n IsEqual");

        //Challenge23
        Console.WriteLine("I will now return the sum of the numbers you input. Insert your first number.");
        var number28 = Console.ReadLine();
        int numberUse28 = int.Parse(number28);
        Console.WriteLine("Insert your second number.");
        var number29 = Console.ReadLine();
        int numberUse29 = int.Parse(number29);
        Console.WriteLine("Insert your third number.");
        var number30 = Console.ReadLine();
        int numberUse30 = int.Parse(number30);
        Console.WriteLine("getAbsSum(" + number28 + ", " + number29 + ", " + number30 + ") --> " + getAbsSum(numberUse28, numberUse29, numberUse30));


        //challenge22
        Console.WriteLine("Give me a set of numbers and I will arrange them in order from minimum to  maximum.");
       



        //Challenge18
        Console.WriteLine("Write any name and I will return a greeting.");
        var input5 = Console.ReadLine();
        string input5Use = (input5);
        Console.WriteLine("HelloName(" + input5 + ") --> " + HelloName(input5Use));

        //Challenge19
        Console.WriteLine("I will count how many legs ther are in total regarding chickens, pigs, and cows. \n Insert the amount of chickens.");
        var number22 = Console.ReadLine();
        int numberUse22 = int.Parse(number22);
        Console.WriteLine("Insert the number of cows.");
        var number23 = Console.ReadLine();
        int numberUse23 = int.Parse(number23);
        Console.WriteLine("Insert the amount of pigs.");
        var number24 = Console.ReadLine();
        int numberUse24 = int.Parse(number24);
        Console.WriteLine("animals(" + number22 + ", " + number23 + ", " + number24 + ") --> " + animals(numberUse22,numberUse23, numberUse24));


        //Challenge20
        Console.WriteLine("I will now calculate the total football points with losses, winns, and draws. \n Insert the number of wins.");
        var number25 = Console.ReadLine();
        int numberUse25 = int.Parse(number25);
        Console.WriteLine("Insert the number of cows.");
        var number26 = Console.ReadLine();
        int numberUse26 = int.Parse(number26);
        Console.WriteLine("Insert the amount of pigs.");
        var number27 = Console.ReadLine();
        int numberUse27 = int.Parse(number27);
        Console.WriteLine("FootballPoints(" + number25 + ", " + number26 + ", " + number27 + ") --> " + FootballPoints(numberUse25, numberUse26, numberUse27));


        //Challenge 13
        Console.WriteLine("Now I will calculate the sum of a polygon. Choose a number greater than 3.");
        var number17 = Console.ReadLine();
        int numberToUse17 = int.Parse(number17);
        Console.WriteLine("The sum of the polygon will be" + SumPolygon(numberToUse17)); 

        //Challenge 14
        Console.WriteLine("I will now add Edabit to your word of choice. Enter any word.");
        var input2 = Console.ReadLine();
        string input2ToUse = (input2);
        Console.WriteLine("Got it. Your result should now be " + nameString(input2ToUse)); 

        //Challenge15
        Console.WriteLine("I will now check if your statement is true or false depending on your two inputs. \n Please insert true or false. ");
        var input3 = Console.ReadLine();
        bool a= bool.Parse(input3);
        Console.WriteLine("Now enter true or false for your second input.");
        var input4 = Console.ReadLine();
        bool b = bool.Parse(input4);
        Console.WriteLine(And(a, b));
        Console.WriteLine("And(" + a + "," + b + ") --> "  + And(a, b));

        //Challenge 16
        Console.WriteLine("I will now count up the total points for a basketball game with 2-pointers and 3-pointers.\n Insert any number");
        var number18 = Console.ReadLine();
        int numberUse18 = int.Parse(number18);
        Console.WriteLine("Insert your second number");
        var number19 = Console.ReadLine();
        int numberUse19 = int.Parse(number19);
        Console.WriteLine("points(" + number18 + ", " + number19 + ") --> " + points(numberUse18, numberUse19));

        //Challenge17
        Console.WriteLine("I will calculate the perimeter of a rectangle. \n First, give me a length.");
        var number20 = Console.ReadLine();
        int numberUse20 = int.Parse(number20);
        Console.WriteLine("Perfect. Give me a width.");
        var number21 = Console.ReadLine();
        int numberUse21 = int.Parse(number21);
        Console.WriteLine("FindPerimeter(" + number20 + ", " + number21 + ") --> " + FindPerimeter(numberUse20, numberUse21));


        //Challenge1
        Console.WriteLine("We are going to use the number adder today called sum. Please give me two numbers.");
            var number1 = Console.ReadLine();
            int numberToUse1 = int.Parse(number1);
            Console.WriteLine("Got it, give me your second number.");
            var number2 = Console.ReadLine();
            int numberToUse2 = int.Parse(number2);
            Console.WriteLine("The sum of the number: " + number1 + " and the number " + number2 + " is equal to " + Sum(numberToUse1, numberToUse2));
       
            //Challenge2
            Console.WriteLine("I am going to convert minutes to seconds. \n Please enter a number to convert.");
            var number3 = Console.ReadLine();
            int numberToUse3 = int.Parse(number3);
            Console.WriteLine("If I convert " + number3 + " minutes to seconds, I get " + Convert(numberToUse3) + " seconds");
      
       

       

       

        Console.WriteLine("Please insert a number. I will add 1 to that number.");

        var number4 = Console.ReadLine();
        int numberToUse4 = int.Parse(number4);

        Console.WriteLine("The number " + number4 + " plus 1 is equal to " + Increase(numberToUse4));

        Console.WriteLine("I am going to calculate the circuit power. Please give me your voltage number.");

        var number5 = Console.ReadLine();
        int voltage = int.Parse(number5);

        Console.WriteLine("Alright. Give me your current number.");

        var number6 = Console.ReadLine();
        int current = int.Parse(number6);

        Console.WriteLine("Your circuit power will be " + CircuitPower(voltage, current));

        Console.WriteLine("I will now convert an age to days. Please insert a number of your choice.");

        var number7 = Console.ReadLine();
        int Age = int.Parse(number7);

        Console.WriteLine("If your age is " + number7 + " you would have been alive for " + AgeConvert(Age));

        Console.WriteLine("I will now calculate the area of a triangle. \n Please give me a number for the base of the triangle.");

        var number8 = Console.ReadLine();
        int Base = int.Parse(number8);

        Console.WriteLine("Great! Now give me a number for the triangle's height.");

        var number9 = Console.ReadLine();
        int Height = int.Parse(number9);

        Console.WriteLine("Based on the information, the area of your triangle with the base of " + number8 + " and the height of " + number9 + " will be " + TriArea(Base, Height));

        Console.WriteLine("I will now determine whether a number is less than or equal to zero. \n Insert any number of your choice.");
        var number10 = Console.ReadLine();
        int numberToUse10 = int.Parse(number10);
        Console.WriteLine("I have come to the conclusion that the solution is " + LessThanOrEqualToZero(numberToUse10));

        Console.WriteLine("I will now determine if the sum of two numbers is less than 100. \n Insert your first number.");
        var number11 = Console.ReadLine();
        int numberToUse11 = int.Parse(number11);
        Console.WriteLine("Alright, give me your second number.");
        var number12 = Console.ReadLine();
        int numberToUse12 = int.Parse(number12);
        Console.WriteLine("I have determined that the solution is " + lessThan100(numberToUse11, numberToUse12));

        Console.WriteLine("I will now determine if two integers are equal to eachother. \n Insert your first number.");
        var number13 = Console.ReadLine();
        int numberToUse13 = int.Parse(number13);
        Console.WriteLine("Insert your next number.");
        var number14 = Console.ReadLine();
        int numberToUse14 = int.Parse(number14);
        Console.WriteLine("I have determined that the solution is " + IsEqual(numberToUse13, numberToUse14));

        //Challenge21
        Console.WriteLine("Give me a number from 1 through 12 and I will return the corresponding month of that number.");
        var input6 = Console.ReadLine();
        int monthnumber = int.Parse(input6);
        Console.WriteLine("MonthName(" + input6 + ") --> " + MonthName(monthnumber));








    }

    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }
    public static int Convert(int minutes)
    {
        return minutes * 60;
    }
    public static int Increase(int number4)
    {
        return number4 + 1;
    }
    public static int CircuitPower(int number5, int number6)
    {
        return number5 * number6;
    }
    public static int AgeConvert(int Age)
    {
        return Age * 365;
    }
    public static float TriArea(int Base, int Height)
    {
        return ((Base * Height) / 2);
    }
    public static bool LessThanOrEqualToZero(int number10)
    {
        if (number10 <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool lessThan100(int number11, int number12)
    {
        if (number11 + number12 <= 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool IsEqual(int number13, int number14)
    {
        return number13 == number14;

    }
    public static int howManySeconds(int hours)
    {
        return hours * 3600;
    }
    public static int SumPolygon(int number17)
    {
        return (number17 - 2) * 180;
        
    }
    public static string nameString(string input2)
    {
        return input2 + "Edabit";
    }
    public static bool And(bool a, bool b)
    {
        if (a == true && b == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static int points(int number18, int number19)
    {
        return number18 * 2 + number19 * 3;
    }
    public static int FindPerimeter(int number20, int number21)
    {
        return (number20 + number21) * 2;
    }
    public static string HelloName(string input5)
    {
        return "Hello " + input5 + "!";
    }
    public static int animals(int number22, int number23, int number24)
    {
        return number22 * 2 + number23 * 4 + number24 * 4;
    }
    public static int FootballPoints(int number25, int number26, int number27)
    {
        return number25 * 3 + number26 * 1 + number27 * 0;
    }
    public static string MonthName(int monthnumber)
    {  
        if ( monthnumber >= 1 && monthnumber <= 12)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthnumber);
        }
        else
        {
            return "Invalid Number! Insert a valid number between 1 through 12.";
        }
    }

    public static int getAbsSum(int number28, int number29, int number30)
    {
        return number28 + number29 + number30;
    }
}


