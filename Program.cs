namespace Lesson_16___Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            // Names_Age();
            #endregion

            #region Task2
            //Console.WriteLine(" ========= TASK 2 =========");
            //Console.WriteLine(" Input the name of a European country");

            //string userCountry = Console.ReadLine();
            //Console.WriteLine($"The capital of your country is {EUCountries(userCountry)}");
            #endregion

            #region Task3Dictionary
            /*
            Console.WriteLine(" ========= TASK 3 =========");
            Dictionary<string, int> fruits = new Dictionary<string, int>
            {
                {"Orange",2 },
                {"Banana",1 },
                {"Apple", 3 },
            };
            PrintDictionary(fruits);
            ;

            Console.WriteLine("input a new fruit:");
            string newFruit = Console.ReadLine();
            Console.WriteLine("input the ammount:");
            int newFruitValue = Convert.ToInt32(Console.ReadLine());

            AddNewItem(newFruit, newFruitValue, fruits);
            Console.Write("New updated list is: ");
            PrintDictionary(fruits);
            */
            #endregion

            #region Task4
            Console.WriteLine(" ========= TASK 4 =========");
            Console.WriteLine(" Input a Lithuanian city");
            string userCity = Console.ReadLine();

            Console.WriteLine($" The population of {userCity} is {CityPopulations(userCity)}");

            #endregion

            #region Task5
            //Console.WriteLine(" ========= TASK 5 =========");
            //Console.WriteLine(" Input the name of the student");
            //string userStudentInput = Console.ReadLine();

            //Console.WriteLine($" The population of {userCity} is {CityPopulations(userCity)}");

            #endregion

            #region Theory

            /*
            //LIST example
            List<string> citiesList = new List<string> {
            "Vilnius",
            "Kaunas",
            "Siauliai",
            "Jonava"};

            Console.WriteLine("Printing cities List");
            foreach (string city in citiesList) { Console.WriteLine(city); }

            //--------------------------------------------
            Console.WriteLine();

            Dictionary<string, int> citiesDictionary = new Dictionary<string, int>
            {
                {"Vilnius", 7 },//turi buti pora
                {"Kaunas", 6 },
                {"Siauliai", 8 },
                {"Jonava", 6 }
            };


            // DISPLAY DICTIONARY
            Console.WriteLine("Printing cities Dictionary");
            foreach (var cityKeyValuePair in citiesDictionary)//reikia var
            {
                Console.WriteLine($"{cityKeyValuePair.Key} - {cityKeyValuePair.Value}");
            }


            Console.WriteLine();


            // COMPLEX DICTIONARY
            List<int> myPoints = new List<int>() { 5, 9, 12 };
            string myName = "Tomas";
            Dictionary<string, List<int>> playersPointsDictionary = new Dictionary<string, List<int>>()
            {
                {"Ieva", new List<int>() { 9, 8, 10} },
                {"Audrius", new List<int>() { 8, 10, 10, 10} },
                {"Veronika", new List<int>() { 10, 10, 10} },
                {myName, myPoints }
            };


            Console.WriteLine("Printing player points Dictionary");
            foreach (var playerPoints in playersPointsDictionary)//reikia var
            {
                Console.Write($"{playerPoints.Key} - ");

                foreach (var Point in playerPoints.Value)//gali buti nebe var, o int
                {
                    Console.Write(Point + " ");
                }
                Console.WriteLine();//new player from new line
            }
            //DISPLAY SPECIFIC ENTRY
            Console.WriteLine("Siauliai skaicius: " + citiesDictionary["Siauliai"]);

            //ADD SPECIFIC ENTRY
            citiesDictionary["Londonas"] = 20;


            Console.WriteLine("Printing cities Dictionary");
            foreach (var cityKeyValuePair in citiesDictionary)//reikia var
            {
                Console.WriteLine($"{cityKeyValuePair.Key} - {cityKeyValuePair.Value}");
            }

            //    if (citiesDictionary.ContainsKey("New York"))
            //    {
            //        Console.WriteLine("New York" + citiesDictionary["New York"]);
            //    }
            //}

            Console.WriteLine("Printing dictionary keys");
            foreach (var key in citiesDictionary.Keys)
            {

                Console.WriteLine(key);
            }
            Console.WriteLine("Printing dictionary values");
            foreach (var value in citiesDictionary.Values)
            {

                Console.WriteLine(value);
            }

            */
            #endregion





        }
        // ====================================================== METODS ======================================================
        public static int CityPopulations(string userCity)
        {
            Dictionary<string, int> TaskCities = new Dictionary<string, int> {
                { "Vilnius", 580020 },
                { "Kaunas", 289380 },
                { "Klaipeda", 149157 },
                { "Siauliai", 101514 },
                { "Panevezys", 85885 },
                { "Raseiniai",  12541}
            };

            if (TaskCities.ContainsKey(userCity))
            {
                return TaskCities[userCity];// Return population as integer 
            }
            else
            {
                throw new ArgumentException("You did not enter a proper LT city"); // Throw an exception for an unknown city.
            }
            //{
            //    string cityError = "You did not enter a proper LT city";
            //    return cityError; //nereikia Console.WriteLine nes returninam string, o ne komanda
            //}


        }
        //----------------- meth
        public static Dictionary<string, int> RemoveItem(string ItemToDelete, Dictionary<string, int> updatedDictionary)
        {
            updatedDictionary.Remove(ItemToDelete);
            return updatedDictionary;
        }

        //----------------- meth
        public static Dictionary<string, int> AddNewItem(string newItem, int newItemValue, Dictionary<string, int> updatedDictionary)
        {
            updatedDictionary[newItem] = newItemValue;
            return updatedDictionary;
        }
        //----------------- meth
        public static void PrintDictionary(Dictionary<string, int> dic)
        {
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }

        //----------------- meth
        public static string EUCountries(string userCountry)
        {
            Dictionary<string, string> euCountriesAndCapitals = new Dictionary<string, string> {
                { "Austria", "Vienna" },
                { "Belgium", "Brussels" },
                { "Bulgaria", "Sofia" },
                { "Croatia", "Zagreb" },
                { "Cyprus", "Nicosia" },
                { "Czech Republic", "Prague" },
                { "Denmark", "Copenhagen" },
                { "Estonia", "Tallinn" },
                { "Finland", "Helsinki" },
                { "France", "Paris" },
                { "Germany", "Berlin" },
                { "Greece", "Athens" },
                { "Hungary", "Budapest" },
                { "Ireland", "Dublin" },
                { "Italy", "Rome" },
                { "Latvia", "Riga" },
                { "Lithuania", "Vilnius" },
                { "Luxembourg", "Luxembourg City" },
                { "Malta", "Valletta" },
                { "Netherlands", "Amsterdam" },
                { "Poland", "Warsaw" },
                { "Portugal", "Lisbon" },
                { "Romania", "Bucharest" },
                { "Slovakia", "Bratislava" },
                { "Slovenia", "Ljubljana" },
                { "Spain", "Madrid" },
                { "Sweden", "Stockholm" },
            };

            if (euCountriesAndCapitals.ContainsKey(userCountry))
            {
                return euCountriesAndCapitals[userCountry];//userCountry yra tai ka metodas priima, user iveda key, metodas atiduoda value
            }
            else
            {
                string countryError = "You did not enter a proper EU country";
                return countryError; //nereikia Console.WriteLine nes returninam string, o ne komanda
            }


        }
        //----------------- meth
        public static void Names_Age()
        {
            Dictionary<string, int> nameAndAge = new Dictionary<string, int>()
            {
                { "Tomas", 30 },
                { "Laura", 30 },
                { "Virginija", 56 },
            };
            Console.WriteLine("Printing names and ages");
            foreach (var name in nameAndAge)
            {
                Console.WriteLine($"{name.Key} - {name.Value} ");//reikia naudoti var, o ne dictionary
            }
        }

        //----------------- meth
    }
}
