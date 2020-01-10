using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PracticeCsharp {
    public class CountryIO {


        public FileStream F = new FileStream("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\CountriesIO\\Countries.txt", FileMode.Open, FileAccess.Read, FileShare.Read);

        public List<string> countries = new List<string>();

        public string[] SaveCountries(List<string> countries) {
            using (var file = new StreamReader("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\CountriesIO\\Countries.txt"))
            {
                var line = string.Empty;

                while ((line = file.ReadLine()) != null)
                {
                    countries.Add(Convert.ToString(line));
                }
            }

            return (countries.ToArray());
        }





        public string GetCountries() {

            //print the list
            foreach (var s in countries)
            {
              Console.WriteLine(s);
            }
            return "";
        }
    }
}
    

