namespace MethodsExerciseDemo
{
    internal class Program
    {
        static string favName = "";

        static void Main(string[] args)
        {
            //Defining a method - Parameters
            //Calling a method - Arguments

            Console.WriteLine("What is your favorite name?");
            //Setting the local variable favoriteName
            string favoriteName = Console.ReadLine();

            //Below is setting the field favName
            favName = Console.ReadLine();

            Console.WriteLine(favoriteName);

            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();

            Console.WriteLine("Favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"In a galaxy far far away, {favoriteName} is in " +
                $"space battle with the evil {favAnimal}s, and we are shooting {favColor} " +
                "watermelons at them.");

            string something = $"Hello {favName}"; //String Interpolation
            string somethingElse = "Hello " + favName; //String Concatenation
            Console.WriteLine("Hello {0}", favName); //String.Format placeholders
        }
    }
}