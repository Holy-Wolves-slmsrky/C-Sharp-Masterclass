namespace Calculating_Average_Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a simple C# program that calculates the average temperature from an array of temperatures.

             * The program should:
             * 1) Declare a method CalculateAverage that takes an array of doubles as a parameter.
             * 2) Implement the method to calculate the average of the temperatures in the array.
             * 3) Declare a method PrintAverage that takes an array of doubles as a parameter.
             * 4) Implement the method to call CalculateAverage and print the result to the console.

             * The result of execution for the default string should be:
             * "The average temperature is: 23.5"
             */

            double[] temperatures = { 23, 24 };
            new Program().PrintAverage(temperatures);

            Console.ReadKey();
        }

        public void PrintAverage(double[] temperatures)
        {
            // TODO
            Console.WriteLine($"The average temperature is: {CalculateAverage(temperatures)}");
        }

        public double CalculateAverage(double[] temperatures)
        {
            // TODO
            double sum = 0;
            int counter = 0;
            foreach (double item in temperatures)
            {
                sum += item;
                counter++;
            }
            return (sum / counter);
        }
    }
}
