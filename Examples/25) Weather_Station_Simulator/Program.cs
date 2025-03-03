namespace Weather_Station_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int days = 0;

            do
            {
                Console.Write("Enter the number of days to be simulated: ");
                userInput = Console.ReadLine();
            }
            while (!int.TryParse(userInput, out days));

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Cloudy", "Rainy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int counter = 0; counter < days; counter++)
            {
                temperature[counter] = random.Next(-10, 40);

                /*
                 * This code generates a random integer between 0 and the size of the array called "conditions."
                 * This integer is used to add the corresponding element from the "conditions" array as a new value to the "weatherConditions" array.

                 * Bu kod, 0 ile "conditions" adlı dizinin boyutu arasında bir rastgele tam sayı üretir.
                 * Bu tam sayı ile "conditions" adlı dizinin ilgili elemanı, weatherConditions adlı diziye yeni bir değer olarak eklenir.
                 */
                //int randomNumber = random.Next(conditions.Length);
                //weatherConditions[counter] = conditions[randomNumber];

                if (temperature[counter] > 20 && temperature[counter] < 41)
                    weatherConditions[counter] = conditions[0];

                else if (temperature[counter] > 10 && temperature[counter] < 21)
                    weatherConditions[counter] = conditions[1];

                else if (temperature[counter] > 0 && temperature[counter] < 11)
                    weatherConditions[counter] = conditions[2];

                else
                    weatherConditions[counter] = conditions[3];   
            }

            Console.WriteLine();

            for (int counter = 0; counter < days; counter++)
                Console.WriteLine($"Day = {counter + 1} | Temperature = {temperature[counter]} | Conditions = {weatherConditions[counter]}");

            Console.WriteLine($"\nAverage Temperature = {CalculateAverage(temperature)}\n");

            /*
             * In C#, there are methods to find the smallest and largest elements of an array.
             * The Min() method is used to find the smallest element, and the Max() method is used to find the largest element.

             * C#'ta; bir dizinin en küçük ve en büyük elemanını bulan metodlar vardır.
             * En küçük elemanı bulmak için Min() metodu, en büyük elemanı bulmak için Max() metodu kullanılır.
             */
            //Console.WriteLine($"Max Temperature = {temperature.Max()}");
            //Console.WriteLine($"Min Temperature = {temperature.Min()}");

            Console.WriteLine($"Max Temperature = {MaxTemperature(temperature)}");
            Console.WriteLine($"Min Temperature = {MinTemperature(temperature)}");

            Console.WriteLine();

            Console.WriteLine($"Most Condition = {MostCondition(conditions, weatherConditions)}");

            Console.ReadKey();
        }

        static double CalculateAverage(int[] temperature)
        {
            /*
             * If this variable is defined as "int", the result will be an integer (integer / integer = integer).
             * If it is defined as double, the result will be a double (double / integer = double).

             * Eğer bu değişken "int" tipinde tanımlanır ise, sonuç integer olur (integer / integer = integer).
             * Double ile tanımlar isek, sonuç double olur (double / integer = double).
             */
            double sum = 0;

            foreach (int item in temperature)
                sum += item;

            return (sum / temperature.Length);
        }

        static int MinTemperature(int[] temperature)
        {
            int tempTemperature = temperature[0];

            foreach (int item in temperature)
            {
                if (item < tempTemperature)
                    tempTemperature = item;
            }

            return tempTemperature;
        }

        static int MaxTemperature(int[] temperature)
        {
            int tempTemperature = temperature[0];

            foreach (int item in temperature)
            {
                if (item > tempTemperature)
                    tempTemperature = item;
            }

            return tempTemperature;
        }

        static string MostCondition(string[] conditions, string[] weatherConditions)
        {
            string condition = "";

            int[] counters = new int[conditions.Length];

            for (int itemCounter = 0; itemCounter < conditions.Length; itemCounter++)
            {
                foreach (string item in weatherConditions)
                {
                    if (item == conditions[itemCounter])
                        counters[itemCounter]++;
                }
            }

            int maxCounter = MaxTemperature(counters);

            for (int counter = 0; counter < counters.Length; counter++)
            {
                bool isAlreadyAdded = condition.Contains(conditions[counter]);

                if (!isAlreadyAdded && counters[counter] == maxCounter)
                {
                    if (condition != "")
                        condition += ", " + conditions[counter];
                    else
                        condition += conditions[counter];
                }
            }

            return condition;
        }
    }
}
