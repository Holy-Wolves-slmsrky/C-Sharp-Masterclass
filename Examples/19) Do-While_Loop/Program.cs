
/*
 *  The Do-While loop is ideal for situations where the code needs to be executed at least once, and then checked against a specific condition.
 *  In this loop, the code block is executed first, and then the condition is checked.
 *  As long as the condition is true, the loop continues to run.
 *  The Do-While loop is the post-test loop, while the While loop is the pre-test loop.

 * do
 * {
 *      Code to be executed.
 *      Within this code block, there should be a condition or code to stop the loop.
 *      If there is no mechanism to stop the loop, it will enter an infinite loop and may freeze the program.
 * }
 * while (condition to stop the loop)

 * Do-While döngüsü, en az bir kez çalıştırılacak ve ardından belirli bir koşula göre kontrol edilecek durumlar için idealdir.
 * Bu döngüde, ilk başta kod bloğu çalıştırılır ve sonra koşul kontrol edilir.
 * Koşul doğru olduğu sürece döngü devam eder.
 * Do-While döngüsü, son test döngüsüdür. While döngüsü ise ilk test döngüsüdür.

 * do
 * {
 *      Çalıştırılacak kodlar.
 *      Bu kod bloğu içinde, döngüyü durduracak bir koşul veya kod parçası olmalıdır.
 *      Eğer döngüyü durduracak bir mekanizma eklenmez ise, döngü sonsuz döngüye girer ve programı askıya alabilir.
 * }
 * while (döngüyü durduracak koşul)
*/

/*
 * Example 1:
 * Even if the condition is not met, the loop will still run.

 * Örnek 1:
 * Koşul sağlanmasa bile döngü yine de çalışacaktır.
 */

int number = new Random().Next(20, 31);
do
{
    Console.WriteLine($"Number is {number}.");
}
while (number <= 10);

Console.WriteLine();

/*
 * Example 2:
 * Example of validating that the entered data is in the desired format.
 * We have used this example in many places, but the most ideal usage is with the do-while loop.

 * Örnek 2:
 * Girilen verinin istenilen formatta olmasını doğrulama örneği.
 * Bu örneği birçok yerde kullandık, ancak en ideal kullanım do-while döngüsü ile yapılan kullanımıdır.
 */

int userNumber = 0;
string input = "";

do
{
    Console.Write("Enter a whole number: ");
    input = Console.ReadLine();
} while (!int.TryParse(input, out userNumber));

/*
 * The Not (!) operator was used because the int.TryParse() method returns 'false' if a valid integer is not entered, and 'true' if a valid integer is entered.
 * We reversed the returned value using the Not operator. This way, we set up the control mechanism.

 * Not -> Not (!) operatörü kullanıldı çünkü int.TryParse() metodu, tam sayı girilmez ise 'false', girilir ise 'true' değeri döndürür.
 * Not operatörü ile döndürülen değeri tersine çevirdik. Böylece kontrol mekanizmasını oluşturduk.
 */

Console.WriteLine();

/*
 * Example 3:
 * Average calculator.

 * Örnek 3:
 * Ortalama hesaplayıcı.
 */

int currentScore = 0;
int counter = 0;
int sum = 0;

input = "";

Console.WriteLine("Enter '-1' to calculate the average after entering all the grades.\n");

do
{
    Console.Write("Enter the score: ");
    input = Console.ReadLine();
    int.TryParse(input, out currentScore);

    if (currentScore != -1)
    {
        sum += currentScore;
        counter++;
    }
}
while (currentScore >= 0);

float average = 0;

if (counter != 0)
    average = sum / counter;

Console.WriteLine($"Average = {average}");

Console.WriteLine();

/*
 * The "continue" keyword is used to move to the next iteration of the loop.
 * "continue" anahtar kelimesi, döngünün bir sonraki adıma geçmesi için kullanılır.
 */

/*
 * Example 4:
 * Printing even numbers between 0 and 100 using the continue keyword.

 * Örnek 4:
 * Continue anahtar kelimesi ile 0 - 100 arası çift sayıları yazdırmak.
 */

int loopCounter = -1;
do
{
    loopCounter++;

    if (loopCounter % 2 == 0)
        Console.WriteLine($"Number is {loopCounter}.");
    else
        continue;
}
while (loopCounter <= 100);

/*
 * Example 5:
 * Infinite loop example.

 * Örnek 5:
 * Sonsuz döngü örneği.
 */

Console.WriteLine();

/*
 * do
 * {
 *      Console.WriteLine("This is an infinite loop.");
 * }
 * while(true);
 */

Console.ReadKey();
