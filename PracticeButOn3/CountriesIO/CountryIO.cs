using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PracticeCsharp {
    public class CountryIO {

        FileStream F = new FileStream("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\CountriesIO\\Countries.txt", FileMode.Open, FileAccess.Read, FileShare.Read);


        public List<string> countries = new List<string>();


        public void AddCountry(string newCountry) {

            using (var file = new StreamWriter("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\CountriesIO\\Countries.txt"))
            {
                countries.Add(newCountry);
                
            }  
                
            F.Close();
        }

        public string GetCountries() {
            {
                using (var file = new StreamReader("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\CountriesIO\\Countries.txt"))
                {                 
                        foreach (var s in countries)
                        {
                            Console.WriteLine(s);
                        }
                }
                F.Close();
                return File.ReadAllText("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\CountriesIO\\Countries.txt");
            }
        }

        public void DeleteCountry(string country) {
            using (var file = new StreamReader("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\CountriesIO\\Countries.txt"))
            {
                countries.Remove(country.ToLower());
            
            }
        }


    }
}
    

