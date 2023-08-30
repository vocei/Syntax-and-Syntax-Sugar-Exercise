using System.Reflection.Metadata;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {

        static void Main(string[] args)
        {
            // Change The Following Code to implement: Inferred Typing, String Interpolation, The Ternany Operator
            //int answer = 4;
            //string response;
            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + " is greater than or equal to nine";

            var answer = 4;
            var response = (answer <= 9) ? $"{answer} is less than 9" : $"{answer} is greater than or equal 9";


            // App Form 
            //Console.WriteLine("Write 4 if that number is less than 9");
            //var userResponse = int.Parse(Console.ReadLine());
            //bool isItFour = userResponse == 4;
            //if (isItFour == true)
            //{
            //    Console.WriteLine("Give me your number");
            //    int answer = int.Parse(Console.ReadLine());


            //    var response = (answer <= 9) ? $"{answer} is less than 9" : $"{answer} is greater than or equal 9";
            //    Console.WriteLine(response);

            //}
            //else 
            //{
            //    Console.WriteLine("you did not write 4");

        }
    }
}



