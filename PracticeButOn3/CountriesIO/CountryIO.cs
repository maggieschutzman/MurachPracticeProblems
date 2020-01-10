using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PracticeCsharp {
    public class CountryIO {

        FileStream F = new FileStream("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\CountriesIO\\Countries.txt", FileMode.Open, FileAccess.Read, FileShare.Read);


        public List<string> countries = new List<string>();

        //public string[] SaveCountries(List<string> countries) {

        //    using (var file = new StreamReader("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\CountriesIO\\Countries.txt"))
        //    {
        //        var line = string.Empty;

        //        while ((line = file.ReadLine()) != null)
        //        {
        //            countries.Add(Convert.ToString(line));
        //        }
        //    }
        //    F.Close();

        //    return (countries.ToArray());
        //}

        public void AddCountry(string newCountry) {

            using (var file = new StreamWriter("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\CountriesIO\\Countries.txt"))
                if (file != null)
                {
                    file.NewLine.
                }
                else file.WriteLine(newCountry);
            F.Close();
        }



        public string GetCountries() {
            {
                using (var file = new StreamReader("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\CountriesIO\\Countries.txt"))
                {
                    var line = string.Empty;

                    while ((line = file.ReadLine()) != null)
                        foreach (var s in countries)
                        {
                            Console.WriteLine(s);
                        }
                }
                F.Close();
                return File.ReadAllText("C:\\Users\\maggi\\Source\\Repos\\MurachPracticeProblems\\PracticeButOn3\\CountriesIO\\Countries.txt");
            }
        }
    }
}
    

