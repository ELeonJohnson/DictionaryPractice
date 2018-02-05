using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //Like List, Dictionary are mutable
            //Example of a Dictionary with Student Grades
            //The key is student's name
            //The value is student's grades

            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                {"Kary", 90 }, //"Kary" is the key, 90 is the value
                {"Barry", 85 },
                {"Michelle", 100 }
            };

            Dictionary<string, string> vendingMachine = new Dictionary<string, string>()
            {
                { "A1", "Snicker Candy Bar" },
                { "A2", "Sweedish Fish"},
                { "A3", "Sour Patch Kids"},
                { "A4", "Funyuns"}
            };

            //Creating an empty Dictionary
            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //Using the Add method, we are adding drinks to our drinkMachine
            //This machine uses just a number to vend an item
            //instead of a letter-number pair.

            drinkMachine.Add(10, "Ginger Ale"); //10 is the key, "Ginger Ale" is the value
            drinkMachine.Add(11, "Pepsi");
            drinkMachine.Add(12, "Mountain Dew");
            drinkMachine.Add(13, "Sprite");
            drinkMachine.Add(14, "Grape Crush");
            drinkMachine.Add(15, "Orange Crush");


            //Printing out how many drinks are in the drinkMachine (The Size of the Dictionary)
            //Count is a Property
            Console.WriteLine(drinkMachine.Count);



            //Another Property: .Key
            //This is printing out the Keys in the Dictionary
            //In our case, the button numbers you would push 
            foreach(KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
            }

            //Property .Value
            //This is printing out the Values in the Dictionary
            //In our case, the name of the drinks
            foreach(KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value);
            }


            //Create a Dictionary for a theatre Coat Check
            //Ten Elements
            //key is number, value coat style
            //Print all values to the console

            Dictionary<int, string> coatCheck = new Dictionary<int, string>();
            {
               coatCheck.Add(1, "Leather jacket");
            coatCheck.Add(2, "Bomber Jacket");
            coatCheck.Add(3, "Top Coat");
            coatCheck.Add(4, "Fur Coat");
            coatCheck.Add(5, "Denim Jacket");
            coatCheck.Add(6, "Mac Coat");
            coatCheck.Add(7, "Hoodie");
            coatCheck.Add(8, "Hooded Bomber");
            coatCheck.Add(9, "Pilot Jacket");
            coatCheck.Add(10, "Suede Jacket");



        }

           

            foreach(KeyValuePair<int, String> coat in coatCheck)
            
            {
                Console.WriteLine(coat.Value);
            }

            //Create a Dictionary for a car valet service
            //10 Cars
            //Key: Customers Last name
            //Value: car make
            //print all keys to the console

            Dictionary<string, string> carValet = new Dictionary<string, string>()
            {
                { "Johnson", "Jeep"},
                { "Jones", "Honda"},
                { "Williams", "Mercedes"},
                { "Lamar", "Tesla"},
                { "Smith", "Benz" },
                { "Ford", "Ford"},
                { "Thomas", "Mustang"},
                { "Drew", "Station Wagon"},
                { "Brown", "Toyota"},
                { "Towns", "Impala"}


            };

            foreach (KeyValuePair<string, string> cars in carValet)
            {
                Console.WriteLine(cars.Key);
            }


            //Create a Dictionary with 10 zoo animals
            //the animal type and the value will be the number of that
            //animal type at the zoo.
            //print the animal with the highest quantity to the console

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
            {
                {"Giraffe", 5 },
                {"Gorilla", 10 },
                {"Chimpanzee", 15 },
                {"Otter", 20 },
                {"Tiger", 25 },
                {"Lion", 30},
                {"Shark", 35 },
                {"Black Bear", 40 },
                {"Snake", 45 },
                {"Cheetah", 50 }
            };


            //Need to print out the highest value by sorting
            //creating a highest int
            //foreach loop that checks to see which animals value
            //is the highest

            //if the animal's value is equal to the highest
            //print out the key of that value

            int highest = 0;

            foreach (KeyValuePair<string, int> animals in zooAnimals)
            {
                if(animals.Value > highest)
                {
                    highest = animals.Value;
                }
            }
            
            foreach(KeyValuePair<string, int> animals in zooAnimals)
            {
                if (animals.Value == highest)
                {
                    Console.WriteLine(animals.Key);
                }
            }

            
            

            

              
              
              
              
              
              
              
              
              //Homework: Research other properties and methods
              //Also, do the rest of the exercises on the last slide of Dictionaries
                
        }
    }
}
