using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PracticeCsharp.LengthConverterIO {
    class ConversionMethods : Conversion {

        FileStream F = new FileStream("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\LengthConverterIO\\Conversions.txt", FileMode.Open, FileAccess.Read, FileShare.Read);

        public List<string> conversions = new List<string>();

        public string GetConversions() {
            using (var file = new StreamReader("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\LengthConverterIO\\Conversions.txt"))
            {
                foreach (var s in conversions)
                {
                    
                    Console.WriteLine(s);
                }

                F.Close();
                return File.ReadAllText("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\LengthConverterIO\\Conversions.txt");
            }
        }
        

        public bool SaveConversions(string FromUnit, string ToUnit, double ConversionRatio) {
            using (var file = new StreamWriter("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\LengthConverterIO\\Conversions.txt"))
                if (file != null)
                {
                   
                    NewConversion = ($"{conversions.Count} - {FromUnit} to {ToUnit}: {ConversionRatio}");
                        
                    conversions.Add(NewConversion);
                 

                    return true;
                }


                else
            return false;

        }
    }
}
