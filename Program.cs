using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - When you post a message on Facebook, depending on the number of people who like 
            //    your post, Facebook displays different information.

            //If no one likes your post, it doesn't display anything.
            //If only one person likes your post, it displays: [Friend's Name] likes your post.
            //If two people like your post, it displays:[Friend 1] and[Friend 2] like your post.
            //If more than two people like your post, it displays:[Friend 1], [Friend 2] 
            //and[Number of Other People] others like your post.

            //Write a program and continuously ask the user to enter different names, until the 
            //user presses Enter(without supplying a name). Depending on the number of names 
            //provided, display a message based on the above pattern.

            //var names = new List<string>();
            //while (true)
            //{
            //    Console.Write("Enter different names: ");
            //    var input = Console.ReadLine();

            //    if (String.IsNullOrEmpty(input))
            //    {
            //        break;
            //    } 
            //    else
            //    {
            //        names.Add(input);
            //        continue;
            //    } 
            //} 
            //if (names.Count == 1)
            //{
            //    Console.WriteLine(names[0] + " likes your post.");
            //} 
            //else if (names.Count == 2)
            //{
            //    Console.WriteLine(names[0] + " and " + names[1] + " likes your post.");
            //}
            //else if (names.Count > 2)
            //{
            //    var numOfRest = names.Count - 2;
            //    Console.WriteLine(names[0] + ", " + names[1] +  " and " + numOfRest + " others like your post.");
            //}


            //2 - Write a program and ask the user to enter their name. Use an array to reverse 
            //    the name and then store the result in a new string.Display the reversed name on the console.

            //Console.Write("Enter your name: ");
            //var input = Console.ReadLine();
            //var inputIntoArray = input.Split();
            //Array.Reverse(inputIntoArray);
            //var reverseName = String.Join(" ", inputIntoArray);
            //Console.WriteLine(reverseName);


            //3 - Write a program and ask the user to enter 5 numbers.If a number has been previously entered, 
            //    display an error message and ask the user to re-try. Once the user successfully enters 5 unique 
            //    numbers, sort them and display the result on the console.

            //Console.Write("Enter five unique numbers: ");
            //var input = Console.ReadLine();
            //var numArray = input.Split(' ');
            //var newNumArray = Array.ConvertAll(numArray, int.Parse);
            //var uniqueItems = newNumArray.Distinct<int>();
            while (true)
            {
                Console.Write("Enter five unique numbers: ");
                var input = Console.ReadLine();
                var numArray = input.Split(' ');
                var newNumArray = Array.ConvertAll(numArray, int.Parse);
                var uniqueItems = newNumArray.Distinct<int>();
                if (newNumArray.Length == uniqueItems.Count())
                {
                    Array.Sort(newNumArray);
                    var output = String.Join(", ", newNumArray);
                    Console.WriteLine(output);
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Unique values only.");
                    continue;
                }
            }
            //Array.Sort(newNumArray);
            //foreach (var num in newNumArray)
            //{
            //    Console.WriteLine(num);
            //}

            //bool hasUniqueNums = true;
            //for (var i = 0; i < newNumArray.Length; i++)
            //{
            //    if (newNumArray[i] == newNumArray[i + 1])
            //    {
            //        Console.WriteLine("Error: Unique values only. Try again.");
            //        hasUniqueNums = false;
            //        break;
            //    }

            //}
            
            //var output = String.Join(", ", newNumArray);
            //Console.WriteLine(output);



            //4 - Write a program and ask the user to continuously enter a number or type "Quit" 
            //    to exit. The list of numbers may include duplicates.Display the unique numbers 
            //    that the user has entered.
            //var list = new List<int>();
            //while (true)
            //{
            //    Console.Write("Continuosly enter numbers, or type \"Quit\" to exit. ");
            //    var input = Console.ReadLine();
            //    if (input.ToLower() == "quit")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        list.Add(Int32.Parse(input));
            //        continue;
            //    }
            //}
            //var uniqueNums = list.Distinct<int>();
            //var output = String.Join(", ", uniqueNums);
            //Console.WriteLine(output);


            //5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). 
            //    If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to 
            //    re-try; otherwise, display the 3 smallest numbers in the list.
            //while (true)
            //{
            //    Console.Write("Supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10): ");
            //    var input = Console.ReadLine();
            //    var array = input.Split(',');
            //    var newArray = Array.ConvertAll(array, int.Parse);
            //    if (newArray.Length < 5)
            //    {
            //        Console.WriteLine("Invalid list. Please try again.");
            //        continue;
            //    }
            //    else
            //    {
            //        Array.Sort(newArray);
            //        Console.WriteLine("Here are the 3 smallest numbers from your list: " + newArray[0] + " " + newArray[1] + " " + newArray[2]);
            //        break;
            //    }
            //}
            
        }
    }
}
