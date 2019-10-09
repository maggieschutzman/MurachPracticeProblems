using PracticeButOn3;
using System;


namespace ConsoleApp2 {
    class Program {
        static void Main(string[] args) {

            // Registration Form

            //    Console.WriteLine("Student Registration Form");
            //    try {
            //        Console.WriteLine("Enter first name: ");
            //        string x = Console.ReadLine();
            //        bool fill = string.IsNullOrWhiteSpace(x);
            //        if (fill == true) 
            //            throw new Exception("Please enter a name");

            //        Console.WriteLine("Enter lastname: ");
            //        string y = Console.ReadLine();
            //        bool mustFill = string.IsNullOrWhiteSpace(y);
            //        if (mustFill == true)
            //            throw new Exception("Please enter a lastname");

            //        Console.WriteLine("Enter year of birth: ");
            //        string z = Console.ReadLine();
            //        bool enterDate = string.IsNullOrWhiteSpace(z);
            //        if (enterDate == true)
            //            throw new Exception("Please year of birth");

            //        Console.WriteLine($"Welcome " + x + " " + y);
            //        Console.WriteLine("Your registration is complete");
            //        Console.WriteLine("Your temporary password is : " + x + "*" + z);
            //    }
            //    catch (Exception e) {Console.WriteLine(e.Message);
            //    }
            //}


            //Rectangle Calculator

            //           Console.WriteLine("Welcome to the Area and Perimeter Calculator!");
            //           Console.WriteLine("Would you like to begin? y/n");
            //           try { 
            //           string c = Console.ReadLine();
            //               if (c is "y" == false || c is "n" == false) 
            //                   throw new Exception("Must enter Y or N");

            //               while (c == "y") {
            //               Console.WriteLine("Enter length: ");
            //               int x = Convert.ToInt32(Console.ReadLine());

            //               Console.WriteLine("Enter width: ");
            //               int y = Convert.ToInt32(Console.ReadLine());

            //               int z = x * y;
            //               Console.WriteLine("Area: " + z);

            //               int a = (2 * y) + (2 * x);
            //               Console.WriteLine("Perimeter: " + a);

            //               Console.WriteLine("Continue? (y/n)");
            //               Console.ReadLine();
            //           }

            //       }
            //               catch (Exception e) {Console.WriteLine(e.Message);
            //}


            //Temperature Converter

            //Console.WriteLine("Welcome to the Temperature Converter");
            //Console.WriteLine("Would you like to begin? y/n");
            //try {
            //    string c = Console.ReadLine();
            //    while (c == "y") {
            //        Console.WriteLine("Enter degrees in Fahrenheit: ");
            //        string fah = Console.ReadLine();
            //        int fahN = Convert.ToInt32(fah);
            //        int cel = (fahN - 32) * (5 / 9);
            //        if (cel == 0) throw new DivideByZeroException();
            //        Console.WriteLine("Degrees in Celsius: " + cel);

            //        Console.WriteLine("Would you like to continue? y/n ");
            //        c = Console.ReadLine();
            //    }
            //}
            //catch (DivideByZeroException e) {
            //    Console.WriteLine(e.Message);
            //}



            //Travel Time Calculator

            //Console.WriteLine("Welcome to the Travel Time Calculator");
            //Console.WriteLine("Would you like to begin? y/n");
            //try {
            //    string c = Console.ReadLine();
            //    while (c == "y") {
            //        Console.WriteLine("Enter miles: ");
            //        decimal yMiles = Convert.ToDecimal(Console.ReadLine());
            //        Console.WriteLine("Enter miles per hour: ");
            //        decimal yHours = Convert.ToDecimal(Console.ReadLine());
            //        decimal hours = Math.Round(yMiles / yHours);
            //        decimal minu = Math.Ceiling(hours / 60);
            //        Console.WriteLine("Estimated travel time \nHours: " + hours);
            //        Console.WriteLine("Minutes: " + minu);

            //        Console.WriteLine("Would you like to continue? (y/n)");
            //        c = Console.ReadLine();
            //    }
            //}
            //catch (Exception e) {
            //    Console.WriteLine(e.Message);
            //}


            //Interest Calculator

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Welcome to the Interest Calculator");
            //Console.WriteLine("Would you like to begin? y/n");

            //string c = Console.ReadLine();
            //while (c == "y") {
            //    Console.WriteLine("Enter loan amount: ");
            //    decimal loa = Convert.ToDecimal(Console.ReadLine());
            //    Console.WriteLine("Loan amount: $" + loa);

            //    Console.WriteLine("Enter the interest rate: ");
            //    decimal intr = Convert.ToDecimal(Console.ReadLine());
            //    Console.WriteLine("Interest rate: %" + Math.Round(intr, 3));

            //    decimal inter = loa / Math.Round(intr, 2);

            //    Console.WriteLine("Interest: $" + Math.Round(inter, 2));

            //    Console.WriteLine("Would you like to continue? (y/n)");
            //    c = Console.ReadLine();
            //}


            //Change Calculator

            //    Console.WriteLine("Welcome to the change calculator");
            //    Console.WriteLine("Enter the number of cents (0 - 99): ");

            //    int change = Convert.ToInt32(Console.ReadLine());
            //    try {
            //        if (change > 99) throw new ArgumentOutOfRangeException("Must choose a number between 0 - 99");

            //        int totalq = change / 25;
            //        Console.WriteLine("Quarters: " + totalq);

            //        if (totalq < 4) {
            //            int quartamount = totalq * 25;
            //            int totald = (change - quartamount) / 10;
            //            Console.WriteLine("Dimes: " + totald);
            //            if (totald < 10) {
            //                int dimeamount = totald * 10;
            //                int totaln = (change - dimeamount - quartamount) / 5;
            //                Console.WriteLine("Nickels: " + totaln);
            //                if (totaln < 20) {
            //                    int nickamount = totaln * 5;
            //                    int totalp = (change - dimeamount - quartamount - nickamount) / 1;
            //                    Console.WriteLine("Pennies: " + totalp);
            //                }
            //            }
            //        }
            //    }
            //    catch (ArgumentOutOfRangeException e) {
            //        Console.WriteLine(e.Message);
            //    }
            //}


            //Table of Powers

            //Console.WriteLine("Welcome to the Squares and Cubes Table \n Enter an Integer: ");
            //int userN = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine("\nSquared:\n");
            //for (int power = 0; userN <= power; userN++)
            //    Console.WriteLine("{0}^{1} = {2:N0} (0x{2:X})", userN, power, (long)Math.Pow(userN, power));
            //Console.WriteLine("\nCubed:\n");
            //for (int cube = 3; cube <= userN; userN++)
            //    Console.WriteLine("{0}^{1} = {2:N0} (0x{2:X})", userN, cube, (long)Math.Pow(userN, cube));



            //Factorial Calculator

            //Console.WriteLine("Welcome to the Factorial Cacluator\n\nEnter an interger that's greater than 0 and less than 10: ");
            //int fact = Convert.ToInt32(Console.ReadLine());
            //for (int i = fact - 1; i >= 1; i--) {
            //    fact = fact * i;               
            //}
            //Console.WriteLine($"The factorial  {fact}");


            //Tip Calculator

            //Console.WriteLine("Tip Calculator");
            //Console.WriteLine("Cost of the meal: ");
            //decimal cost = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("15%");
            //decimal tipA = cost * Convert.ToDecimal(.15);
            //Console.WriteLine("Tip Amount: $"+Math.Round(tipA, 2));
            //decimal total = Math.Round(cost + tipA, 2);
            //Console.WriteLine("Total amount: $"+total);


            //Console.WriteLine("20%");
            //decimal tipB = cost * Convert.ToDecimal(.20);
            //Console.WriteLine("Tip Amount: $"+Math.Round(tipB, 2));
            //decimal totalB = Math.Round(cost + tipB, 2);
            //Console.WriteLine("Total amount: $"+totalB);

            //Console.WriteLine("25%");
            //decimal tipC = cost * Convert.ToDecimal(.25);
            //Console.WriteLine("Tip Amount: $" + Math.Round(tipC, 2));
            //decimal totalC = Math.Round(cost + tipC, 2);
            //Console.WriteLine("Total amount: $"+totalC);


            //Dice Roller

            //Console.WriteLine("Dice Roller");
            //Console.WriteLine("Roll the dice? (y/n)");
            //string ans = Console.ReadLine();
            //while (ans == "y") {
            //    Random dice = new Random();
            //    int die1 = dice.Next(1, 7);
            //    int die2 = dice.Next(1, 7);
            //    int total = die1 + die2;
            //    Console.WriteLine("Die 1: "+die1);
            //    Console.WriteLine("Die 2: "+die2);
            //    Console.WriteLine("Total: "+total);
            //    Console.WriteLine("Roll again?");
            //    ans = Console.ReadLine();
            //}


            //Rectangle Calculator

            //Console.WriteLine("Welcome to the Area and Perimeter Calculator!");
            //    Console.WriteLine("Would you like to begin? y/n");
            //    string c = Console.ReadLine();

            //    while (c == "y") {
            //        Console.WriteLine("Enter length: ");
            //        int x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter width: ");
            //        int y = Convert.ToInt32(Console.ReadLine());

            //int z = x * y;
            //Console.WriteLine("Area: " + z);

            //        int a = (2 * y) + (2 * x);
            //Console.WriteLine("Perimeter: " + a);

            //        Console.WriteLine("Continue? (y/n)");
            //        Console.ReadLine();
            //    }


            // Guessing Game

            Console.WriteLine("Welcome to the Guess the Number Game");
            Console.WriteLine("Would you like to try it out? y/n");
            string c = Console.ReadLine();
            if (c == "y") {
                Console.WriteLine("I'm thinking of a number from 1 to 100 \nTry to guess it!");
                int guess = Convert.ToInt32(Console.ReadLine());
                int sf = GetRandomNumber();
                do {
                    if (guess > sf) {
                        Console.WriteLine("Too high! Try again");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                    if (guess < sf) {
                        Console.WriteLine("Too low! Try again");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                    if (guess == sf) {
                        Console.WriteLine($"You got it.\nGreat Work! You're a mathematical wizard!");
                    }
                }
                while (guess != sf);
            }
            Console.WriteLine("Try again? y/n");
            c = Console.ReadLine();
            if (c == "n") {
                Console.WriteLine("Bye - Come back soon!");
            }
        }
        public static int GetRandomNumber() {
            Random random = new Random();
            int rnd = random.Next(101);
            return rnd;
        }


        // Contact List

        //var contact = new Contacts();

        //Console.WriteLine("Welcome to the Contact list application");
        //Console.WriteLine("Enter first name: ");
        //string firstName = Console.ReadLine();
        //contact.setFristName(firstName);

        //Console.WriteLine("Enter last name: ");
        //string lastName = Console.ReadLine();
        //contact.setLastName(lastName);

        //Console.WriteLine("Enter email: ");
        //string eMail = Console.ReadLine();
        //contact.setEmail(eMail);

        //Console.WriteLine("Enter phone: ");
        //string phone = Console.ReadLine();
        //contact.setPhone(phone);

        //string newContact = contact.displayContact();
        //Console.WriteLine(newContact);


        //Grade Converter

        //try {
        //    var grades = new Grades();
        //    Console.WriteLine("Welcome to the grade converter!");
        //    Console.WriteLine("Enter numerical grade: ");
        //    int numgrade = Convert.ToInt32(Console.ReadLine());
        //    if (numgrade > 100) throw new Exception("You must enter a grade below %100");
        //    grades.setNumber(numgrade);
        //    Console.WriteLine("Letter grade: " + grades.getLetter(numgrade));
        //}

        //catch (Exception e) {Console.WriteLine(e.Message);
        //}








    }
    }
}











