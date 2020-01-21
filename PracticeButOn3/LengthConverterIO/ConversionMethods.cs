using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PracticeCsharp.LengthConverterIO {
    class ConversionMethods : Conversion {

        FileStream F = new FileStream("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\LengthConverter\\Conversions.txt", FileMode.Open, FileAccess.Read, FileShare.Read);

        public List<Conversion> conversions = new List<Conversion>();

        public List<Conversion> GetConversions() {
            using (var file = new StreamReader("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\LengthConverter\\Conversions.txt"))
            {
                foreach (var s in conversions)
                {
                    Console.WriteLine(s);
                }
                return conversions;
            }
        }

        public bool SaveConversions(Conversion typesList) {
            using (var file = new StreamWriter("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\LengthConverter\\Conversions.txt"))
                if (file != null)
                {
                    conversions.Add(typesList);
                    return true;
                }
                else return false;
        }
    }
}
