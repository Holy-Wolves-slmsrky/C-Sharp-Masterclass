
/*
 * Random class is used to generate random numbers.
 * Random sınıfı rastgele sayılar üretmek için kullanılır.
 */

int wholeRandomNumber = 0;

wholeRandomNumber = new Random().Next();
Console.WriteLine($"Random number = {wholeRandomNumber}");

/*
 * The first value determines the starting number, and the second value determines the upper limit.
 * The second value is exclusive, meaning it is not included in the range.

 * İlk değer başlangıç sayısını, ikinci değer ise üst sınırı belirler.
 * İkinci değer dahil edilmez, yani üretilen sayılar bu sınırın altındadır.
 */
wholeRandomNumber = new Random().Next(1, 101);
Console.WriteLine($"Random number (1 to 100)= {wholeRandomNumber}");

/*
 * Generates a random floating-point number between 0.0 and 1.0.
 * 0.0 ile 1.0 arasında rastgele ondalıklı sayı üretir.
 */
double decimalRandomNumber = new Random().NextDouble();
Console.WriteLine($"Random number (0.0 to 1.0)= {decimalRandomNumber}");

Console.ReadKey();
