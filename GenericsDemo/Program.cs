using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> stringList = new List<string>();
            //List<int> intList = new List<int>();
            //intList.Add(1);
            //intList.Add("one");
            //string result = FizzBuzz("tests");
            //Console.WriteLine($"Tests: { result }");
            //result = FizzBuzz(123);
            //Console.WriteLine($"123: {result}");
            //result = FizzBuzz(true);
            //Console.WriteLine($"bool: {result}");
            //result = FizzBuzz(new PersonModel { FirstName = "Tim", LastName = "Corey" } );
            //Console.WriteLine($"PersonModel: {result}");

            GenericHelper<PersonModel> peopleHelper = new GenericHelper<PersonModel>();
            peopleHelper.CheckItemAndAdd(new PersonModel { FirstName = "Tim", HasError = true });

            foreach (var item in peopleHelper.RejectedItems)
            {

                Console.Write($"{ item.FirstName } {item.LastName} was rejected");
            }

            Console.ReadLine();

        }

        private static string FizzBuzz<T>(T item)
        {
            //3 - fizz, 5 - buzz, 3&5 - FizzBuzz
            int itemLength = item.ToString().Length;

            string output = "";

            if (itemLength % 3 == 0)
            {
                output += "Fizz";
            }

            if (itemLength % 5 == 0)
            {
                output += "Buzz";
            }

            return output;
        }
    }
}