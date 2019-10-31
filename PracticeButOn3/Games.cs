using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCsharp {
    public class Games {

        public int guess { get; set; }
        public int generatedAnswer { get; set; }
        public int rando { get; set; }

        public static int getRandomNumber() {
            Random random = new Random();
            int rando = random.Next(101);
            int generatedAnswer = rando;
            return generatedAnswer;
        }

        public string evaluateGuess(int guess, int generatedAnswer) {
        do {   
            if (guess > generatedAnswer) {
                Console.WriteLine("Too high! Try again");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            if (guess < generatedAnswer) {
                Console.WriteLine("Too low! Try again");
                guess = Convert.ToInt32(Console.ReadLine());
            }
        }
         while (guess != generatedAnswer);
            if (guess == generatedAnswer) {
                Console.WriteLine($"You got it.\nGreat Work! You're a mathematical wizard!");
            }
            return ("");
         
        }
    }
}
