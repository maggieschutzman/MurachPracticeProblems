using PracticeCsharp;
using PracticeCsharp.AccountBalance;
using PracticeCsharp.Roshambo;
using PracticeCsharp.Students;
using System;
using static PracticeCsharp.Roshambo.Player;

namespace ConsoleApp2 {
    class Program {
        static void Main() {

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
            //    Console.WriteLine("Die 1: " + die1);
            //    Console.WriteLine("Die 2: " + die2);
            //    Console.WriteLine("Total: " + total);
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
            //    try {
            //        var games = new Games();
            //        Console.WriteLine("Would you like to play a game? y/n: ");
            //        string cont = Console.ReadLine();
            //        while (cont == "y") {
            //            Console.WriteLine("Welcome to the Guess the Number Game");
            //            Console.WriteLine("I'm thinking of a number from 1 to 100 \nTry to guess it!");

            //            int guess = Convert.ToInt32(Console.ReadLine());
            //            if (guess > 100) throw new Exception("The number must be less than 100!");
            //            if (guess < 1) throw new Exception("The number must be greater than 1!");
            //            int rando = Games.getRandomNumber();
            //            games.evaluateGuess(guess, rando);
            //            Console.WriteLine("Try again? y/n");
            //            cont = Console.ReadLine();
            //        }
            //    }
            //    catch (Exception e) {
            //        Console.WriteLine(e.Message);
            //    }
            //}


            // Contact List

            //var contact = new Contacts();
            //Console.WriteLine("Welcome to the Contact list application");
            //Console.WriteLine("Enter first name: ");
            //string firstName = Console.ReadLine();
            //contact.SetFristName(firstName);

            //Console.WriteLine("Enter last name: ");
            //string lastName = Console.ReadLine();
            //contact.SetLastName(lastName);

            //Console.WriteLine("Enter email: ");
            //string eMail = Console.ReadLine();
            //contact.SetEmail(eMail);

            //Console.WriteLine("Enter phone: ");
            //string phone = Console.ReadLine();
            //contact.SetPhone(phone);

            //string newContact = contact.DisplayContact();
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


            // Number Checker
            //try {
            //    Console.WriteLine("Would you like to see if your number is odd or even? y/n");
            //    string cont = Console.ReadLine();
            //    while (cont == "y") {
            //        Console.WriteLine("Welcome to the Odd/Even Checker!");
            //        Console.WriteLine("Enter an integer: ");
            //        int ans = Convert.ToInt32(Console.ReadLine());
            //        if (ans < 1) throw new Exception("Please enter an integer greater than 0");
            //        int even = ans % 2;
            //        if (even != 0) { Console.WriteLine($"The number {ans} is odd"); }
            //        if (even == 0) { Console.WriteLine($"The number {ans} is even"); }
            //        Console.WriteLine("Again? y/n");
            //        cont = Console.ReadLine();
            //    }
            //}
            //catch (Exception e) { Console.WriteLine(e.Message); }


            //Person Manager
            //var customers = new Customers();
            //var employees = new Employees();

            //Console.WriteLine("Create customer or employee? (c/e): ");
            //string custemp = Console.ReadLine();
            //Console.WriteLine("First name: ");
            //string fn = Console.ReadLine();
            //Console.WriteLine("Last name: ");
            //string ln = Console.ReadLine();

            //if (custemp == "c") {
            //    customers.SetFirstName(fn);
            //    customers.SetLastName(ln);
            //    Console.WriteLine("You entered a new customer: \n" + customers.DisplayCustomer()); ;
            //}
            //if (custemp == "e") {
            //    employees.SetFirstName(fn);
            //    employees.SetLastName(ln);
            //    Console.WriteLine("Enter ssn: ");
            //    string ssn = Console.ReadLine();
            //    employees.SetSsn(ssn);
            //    Console.WriteLine("You entered a new employee: \n" + employees.DisplayEmployee()); ;
            //}


            //Area Calculator
            //var circles = new Circles();
            //var squares = new Squares();
            //var rectangles = new Rectangles();

            //Console.WriteLine("Welcome to the Area Calculator");
            //Console.WriteLine("Calculate the area of a circle, square, or rectangle? (c/s/r)");
            //string csr = Console.ReadLine();

            //if (csr == "c") {
            //    Console.WriteLine("Enter Radius: ");
            //    double rad = Convert.ToDouble(Console.ReadLine());
            //    circles.SetRadius(rad);
            //    Console.WriteLine("The area of the Circle you entered is " + circles.GetArea()); ;                    
            //}

            //if (csr == "s") {
            //    Console.WriteLine("Enter Width: ");
            //    double wid = Convert.ToDouble(Console.ReadLine());
            //    squares.SetWidth(wid);
            //    Console.WriteLine("The area of the Square you entered is " + squares.getArea()); ;
            //}

            //if (csr == "r") {
            //    Console.WriteLine("Enter Length: ");
            //    double len = Convert.ToDouble(Console.ReadLine());
            //    rectangles.SetLength(len);
            //    Console.WriteLine("Enter Width: ");
            //    double widt = Convert.ToDouble(Console.ReadLine());
            //    rectangles.SetLength(widt);
            //    Console.WriteLine("The area of the rectangle you entered is " + rectangles.getArea()); ;
            //}


            //Account Balance Calculator
            //Console.WriteLine("Welcome to the Account application");
            //Account a1 = new Account();
            //a1.CustFN = "Maggie";
            //a1.CustFN = "Schutzman";
            //a1.Name = "Checking";
            //a1.Balance = 1000;
            //a1.MonthlyFee = 1;           
            //Console.WriteLine("Starting Balances\nChecking: $" + a1.GetBalance()); ;
            //Console.WriteLine("Enter the transactions for the month");
            //Console.WriteLine("Withdrawl or deposit? (w/d)");
            //string resp = Console.ReadLine();
            //Console.WriteLine("Amount: ");
            //double amount = Convert.ToDouble(Console.ReadLine());
            //if (resp == "w") {
            //    a1.Withdraw(amount);          
            //}
            //if (resp == "d") {
            //    a1.Deposit(amount);
            //}
            //Console.WriteLine("Monthly Payments and Fees\nChecking fee: $"+a1.MonthlyFee);
            //Console.WriteLine("Final Balances\nChecking: $" + a1.Fees());

            //Roshambo
            //Console.WriteLine("Welcome to the game of Roshambo");
            //Console.WriteLine("Enter your name");
            //string thisPlayer = Console.ReadLine();
            //Player1 player = new Player1();
            //Lisa lisa = new Lisa();
            //Bart bart = new Bart();
            //player.Name = thisPlayer;
            //Console.WriteLine("Would you like to play? (y/n)");
            //string cont = Console.ReadLine();
            //while (cont == "y") { 
            //Console.WriteLine("Would you like to play against Bart or Lisa? (b/l)");
            //string sel = Console.ReadLine();

            //if (sel == "b") {
            //    Console.WriteLine("Rock, paper, or scissors? (r/p/s)");

            //    string opt = Console.ReadLine();
            //    var ro = bart.GenerateRoshambo();
            //    bart.SetRosh(ro);
            //    Console.WriteLine("Bart: " + ro);

            //    if (opt == "r") {
            //        player.Rosh = (Roshambo)1;
            //        Console.WriteLine($"{player.Name}: rock");
            //    }
            //    if (opt == "p") {
            //        player.Rosh = (Roshambo)2;
            //        Console.WriteLine($"{player.Name}: paper");
            //    }
            //    if (opt == "s") {
            //        player.Rosh = (Roshambo)3;
            //        Console.WriteLine($"{player.Name}: scissors");
            //    }

            //    //rock beats scissors
            //    if (player.Rosh == (Roshambo)1 && bart.Rosh == (Roshambo)3) {
            //        Console.WriteLine("Winner! Rock beats scissors!");
            //        player.Count++;
            //    }
            //    if (player.Rosh == (Roshambo)3 && bart.Rosh == (Roshambo)1) {
            //        Console.WriteLine("Sorry, you lose. Rock beats scissors.");
            //        bart.Count++;
            //    }
            //    //Paper beats rock
            //    if (player.Rosh == (Roshambo)2 && bart.Rosh == (Roshambo)1) {
            //        Console.WriteLine("Winner! Paper beats rock!");
            //        player.Count++;
            //    }
            //    if (player.Rosh == (Roshambo)1 && bart.Rosh == (Roshambo)2) {
            //        Console.WriteLine("Sorry, you lose. Paper beats rock.");
            //        bart.Count++;
            //    }
            //    //scissors beat paper
            //    if (player.Rosh == (Roshambo)3 && bart.Rosh == (Roshambo)2) {
            //        Console.WriteLine("Winner! Scissors beat paper!");
            //        player.Count++;
            //    }
            //    if (player.Rosh == (Roshambo)2 && bart.Rosh == (Roshambo)3) {
            //        Console.WriteLine("Sorry, you lose. Scissors beat paper.");
            //        bart.Count++;
            //    }
            //    if (player.Rosh == bart.Rosh) {
            //        Console.WriteLine("Draw! No one wins.");
            //    }
            //    Console.WriteLine($"{player.Name} has won {player.Count} times.");
            //    Console.WriteLine($"Bart has won {bart.Count} times.");
            //    Console.WriteLine("Play again? (y/n)");
            //    cont = Console.ReadLine();
            //}

            //    if (sel == "l") {
            //        Console.WriteLine("Rock, paper, or scissors? (r/p/s)");
            //        string opt = Console.ReadLine();
            //        var lis = lisa.GenerateRoshambo();
            //        lisa.SetRosh(lis);
            //        Console.WriteLine("Lisa: " + lis);

            //        if (opt == "r") {
            //            player.Rosh = (Roshambo)1;
            //            Console.WriteLine($"{player.Name}: rock");
            //        }
            //        if (opt == "p") {
            //            player.Rosh = (Roshambo)2;
            //            Console.WriteLine($" {player.Name}: paper");
            //        }
            //        if (opt == "s") {
            //            player.Rosh = (Roshambo)3;
            //            Console.WriteLine($"{player.Name}: scissors");
            //        }


            //        //rock beats scissors
            //        if (player.Rosh == (Roshambo)1 && lisa.Rosh == (Roshambo)3) {
            //            Console.WriteLine("Winner! Rock beats scissors!");
            //            player.Count++;
            //        }
            //        if (player.Rosh == (Roshambo)3 && lisa.Rosh == (Roshambo)1) {
            //            Console.WriteLine("Sorry, you lose. Rock beats scissors.");
            //            lisa.Count++;
            //        }
            //        //Paper beats rock
            //        if (player.Rosh == (Roshambo)2 && lisa.Rosh == (Roshambo)1) {
            //            Console.WriteLine("Winner! Paper beats rock!");
            //            player.Count++;
            //        }
            //        if (player.Rosh == (Roshambo)1 && lisa.Rosh == (Roshambo)2) {
            //            Console.WriteLine("Sorry, you lose. Paper beats rock.");
            //            lisa.Count++;
            //        }
            //        //scissors beat paper
            //        if (player.Rosh == (Roshambo)3 && lisa.Rosh == (Roshambo)2) {
            //            Console.WriteLine("Winner! Scissors beat paper!");
            //            player.Count++;
            //        }
            //        if (player.Rosh == (Roshambo)2 && lisa.Rosh == (Roshambo)3) {
            //            Console.WriteLine("Sorry, you lose. Scissors beat paper.");
            //            lisa.Count++;
            //        }
            //        if (player.Rosh == lisa.Rosh) {
            //            Console.WriteLine("Draw! No one wins.");
            //        }
            //        Console.WriteLine($"{player.Name} has won " + player.Count + " times.");
            //        Console.WriteLine($"Lisa has won {lisa.Count} times.");
            //        Console.WriteLine("Play again? (y/n)");
            //        cont = Console.ReadLine();
            //    }
            //}


            // Batting Statistics
            //    Console.WriteLine("Enter number of times at bat: ");
            //    string userInput = Console.ReadLine();
            //    int oneNumber = int.Parse(userInput);
            //    int[] bats = new int[oneNumber];
            //    int batters = 0;
            //    bats[batters] = oneNumber;
            //    int total = 0;
            //    Console.WriteLine("The number of times at bat is : " + bats[batters]);
            //    Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");
            //    foreach( int bat in bats) { 
            //        Console.WriteLine("Result for at-bat: ");
            //        bats[batters] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    total = total + bats[batters];
            //    int average = total / bats.Length;
            //    Console.WriteLine("Batting average: " + average);
            //}


            //Student Scores
            Students student = new Students();

            Console.WriteLine("Number of students: ");
            string userInput = Console.ReadLine();
            student.Number = int.Parse(userInput);
            string[] students = new string[student.Number];
            int total = student.Number - 1;
            
            foreach (string stud in students) {
                try {
                    Console.WriteLine("STUDENT\nFirst Name: ");
                    string firstname = Console.ReadLine();
                    student.SetFirstName(firstname);
                    bool fill = string.IsNullOrWhiteSpace(firstname);

                    Console.WriteLine("Last Name: ");
                    string lastname = Console.ReadLine();
                    student.SetLastName(lastname);
                    fill = string.IsNullOrWhiteSpace(lastname);
                    if (fill == true)
                        throw new Exception("Please enter a name");

                    Console.WriteLine("Score: ");
                    int score = Convert.ToInt32(Console.ReadLine());
                    student.SetScore(score);
                    if (score < 0 && score > 100) throw new Exception("Score must be greater than 0 and less than 100.");
                    total = student.Number--;
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
            Console.WriteLine("STUDENTS:");
            foreach (string stud in students) {
                Console.WriteLine(student.DisplayStudent(student.FirstName, student.LastName, student.Score));
            }







        }
    }
}


















