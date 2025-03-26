
#region English - Click
/*
 * Conditional statements allow a code or a block of code to execute based on a specific condition.

 * 1) If - else if - else
 * If the condition is true, the "if" block executes; if false, the "else" block executes.
 * If another condition needs to be checked after an "if" block, the "else if" block is used.
 * If a conditional statement executes only one line of code, the "{}" characters are not required.
 * If a conditional statement executes multiple lines of code, the "{}" characters must be used.
 * If variables are being defined inside conditional statements, the "{}" characters should be used.
 * The scope of a variable is limited to the code block ("{}") in which it is defined.

 * 2) Switch
 * The switch statement allows you to execute one of several blocks of code based on the value of a variable or expression.
 * It provides a way to replace complex if - else if - else chains with a cleaner, more readable structure.

 * switch: This keyword begins the switch statement, which evaluates an expression and compares its value against different cases.

 * case: Each case represents a potential match for the value of the expression in the switch.
 * When a match is found, the corresponding code block will execute.

 * break: The break keyword is used to exit the switch block once a matching case has been executed.
 * Without break, the program continues to execute the subsequent case statements, even if their conditions do not match.
 * This behavior is called fall-through.

 * default: The default block is an optional section that will execute if none of the case values match the expression.
 * It's typically used as a fallback or error-handling mechanism.
 */
#endregion

#region Türkçe - Tıkla
/*
 * Koşul ifadeleri, bir kodun veya bir kod bloğunun belirli bir koşula göre çalışmasını sağlar.

 * 1) If - else if - else
 * Eğer koşul doğruysa "if" bloğu, yanlışsa "else" bloğu çalışır.
 * Eğer "if" bloğundan sonra başka bir koşul kontrolü yapılması gerekiyorsa, "else if" bloğu kullanılır.
 * Koşul ifadeleri bir satır kod çalıştıracak ise "{}" karakterlerinin kullanılması gerekmez.
 * Koşul ifadeleri birden fazla satır kod çalıştıracak ise "{}" karakterlerinin kullanılması gerekir.
 * Koşul ifadelerinin içerisinde değişken tanımlanıyor ise "{}" karakterlerinin kullanılması gerekir.
 * Bir değişkenin kapsama alanı, tanımlandığı kod bloğu ("{}") ile sınırlıdır.

 * 2) Switch
 * Switch deyimi, bir değişkenin veya ifadenin değerine bağlı olarak birden fazla kod bloğundan birinin çalıştırılmasını sağlar.
 * Bu, karmaşık if - else if - else zincirlerini daha temiz ve okunabilir bir yapıya dönüştürmek için kullanılır.

 * switch: Bu anahtar kelime, switch deyimini başlatır ve bir ifadeyi değerlendirerek değerini farklı caselerle karşılaştırır.

 * case: Her bir case, switch ifadesinin değerine potansiyel olarak uyan bir durumu temsil eder.
 * Bir eşleşme bulunduğunda, ilgili kod bloğu çalıştırılır.

 * break: break anahtar kelimesi, bir case durumu eşleştiğinde switch bloğundan çıkmak için kullanılır.
 * Eğer break kullanılmazsa, program, koşulu eşleşmeyen sonraki case bloklarını da çalıştırmaya devam eder.
 * Bu duruma fall-through (düşüş) denir.

 * default: default bloğu, case değerlerinden hiçbiri eşleşmediğinde çalışacak olan isteğe bağlı bir bölümdür.
 * Genellikle bir yedekleme veya hata işleme mekanizması olarak kullanılır.
 */
#endregion

#region if - else if - else

bool myBoolOne = true;
bool myBoolTwo = true;

/*
 * Even though the value of the "myBoolTwo" variable is "true", the "else if" block does not execute.
 * The reason for this is that the "if" block has already been executed.
 * If the first condition in a control structure is met, the program does not check the other conditions and executes only that condition.

 * myBoolTwo değişkeninin değeri "true" olmasına rağmen "else if" bloğu çalışmaz.
 * Bunun nedeni "if" bloğunun zaten çalıştırılmış olmasıdır.
 * Eğer bir kontrol yapısındaki ilk koşul sağlanır ise, program diğer koşullara bakmaz ve yalnızca o koşulu çalıştırır.
 */
if (myBoolOne)
    Console.WriteLine($"myBoolOne = {myBoolOne}");
else if (myBoolTwo)
    Console.WriteLine($"myBoolTwo = {myBoolTwo}");
else
    Console.WriteLine($"Both myBoolOne and myBoolTwo variables are false.");

Console.WriteLine();

myBoolOne = false;
myBoolTwo = true;

/*
 * If the first condition is not met, it checks the other conditions.
 * Eğer ilk koşul sağlanmaz ise diğer koşulları kontrol eder.
 */
if (myBoolOne)
    Console.WriteLine($"myBoolOne = {myBoolOne}");
else if (myBoolTwo)
    Console.WriteLine($"myBoolTwo = {myBoolTwo}");
else
    Console.WriteLine($"Both myBoolOne and myBoolTwo variables are false.");

Console.WriteLine();

myBoolOne = false;
myBoolTwo = false;

/*
 * If none of the conditions are met and an "else" block is written, then the "else" block is executed.
 * Hiçbir koşul sağlanmaz ise ve "else" bloğu yazılmış ise, o zaman "else" bloğu çalıştırılır.
 */
if (myBoolOne)
    Console.WriteLine($"myBoolOne = {myBoolOne}");
else if (myBoolTwo)
    Console.WriteLine($"myBoolTwo = {myBoolTwo}");
else
    Console.WriteLine($"Both myBoolOne and myBoolTwo variables are false.");

Console.WriteLine();

myBoolOne = false;
myBoolTwo = false;

/*
 * If none of the conditions are met and no "else" block is written, the program continues executing the code outside the conditional statement.
 * Eğer koşulların hiçbirisi sağlanmaz ve "else" bloğu yazılmamış ise, program koşul ifadesinin dışındaki kodlardan çalışmaya devam eder.
 */
if (myBoolOne)
    Console.WriteLine($"myBoolOne = {myBoolOne}");
else if (myBoolTwo)
    Console.WriteLine($"myBoolTwo = {myBoolTwo}");
Console.WriteLine("The code worked because the else block was not written.");

/*
 * This code gives an error because conditional statements must be written as connected blocks.
 * If another line of code or a block is inserted between them, the last written conditional statement loses its connection to the previous ones.

 * Bu kod hata verir. Çünkü koşul ifadeleri birbirine bağlı bloklar şeklinde yazılmalıdır.
 * Araya başka bir satır kod veya kod bloğu yazılırsa, en son yazılan koşul ifadesi kendisinden önce yazılanlarla olan bağlantısını kaybeder.

else
    Console.WriteLine($"Both myBoolOne and myBoolTwo variables are false.");
 */

Console.WriteLine();

/*
 * The "else" block only executes if the "if(myBoolTwo)" block is false.
 * The false condition of the "if (myBoolOne)" block does not affect the execution of the "else" block.
 * "if" and "else" blocks are a unit; each "else" block is part of the "if" block that precedes it.

 * "else" bloğu sadece "if(myBoolTwo)" bloğu yanlış ise çalışır.
 * "if (myBoolOne)" bloğunun yanlış olması, "else" bloğunun çalışmasını etkilemez.
 * "if" ve "else" blokları bir bütündür; her "else" bloğu yalnızca kendisinden önceki "if" bloğunun parçasıdır.
 */

if (myBoolOne)
    Console.WriteLine($"myBoolOne = {myBoolOne}");

if (myBoolTwo)
    Console.WriteLine($"myBoolTwo = {myBoolTwo}");

else
    Console.WriteLine("myBoolTwo variable is false.");

char myCharOne;

/*
 * This code will result in an error. The "{}" characters must be used.
 * Bu kod hata verir. "{}" karakterlerinin kullanılması gerekir.

if (true)
    int myCharTwo;
 */

if (true)
{
    char myCharTwo = 'B';
}

myCharOne = 'A';

/*
 * This code will result in an error.
 * In this project, the scope of the variable named "myCharOne" is the entire code page.
 * The scope of the variable named "myCharTwo" is the if block in which it was created.
 * Therefore, the variable "myCharOne" is accessible, while the variable "myCharTwo" is not.

 * Bu kod hata verir.
 * Bu projede, "myCharOne" adlı değişkenin kapsama alanı tüm kod sayfasıdır.
 * "myCharTwo" adlı değişkenin kapsama alanı ise oluşturulduğu if bloğudur.
 * Bu yüzden "myCharOne" adlı değişkene erişilebilirken "myCharOne" adlı değişkene erişilemez.

myCharTwo = 'B';
 */

/*
 * If this code is used, the if block will cause an error because the variable name in the if block is the same as the variable name.
 * Although the variable inside the block has been previously defined, the scope is limited to the if block, so an error occurs.
 * The compiler treats the variable with the larger scope as the main variable.

 * Bu kod kullanılır ise if bloğu bir hata verir. Çünkü if bloğundaki değişkenin adı ile bu değişkenin adı aynıdır.
 * Bloğun içinde bulunan değişken daha önce tanımlanmış olmasına rağmen kapsama alanı if bloğu ile sınırlı olduğu için hata oluşur.
 * Derleyici kapsama alanı geniş olan değişkeni ana değişken olarak sayar.

char myCharTwo = 'C';
 */

int myIntOne = 10;
int myIntTwo = 20;

myBoolOne = myIntOne > myIntTwo;
myBoolTwo = (myIntOne * 2) == myIntTwo;

Console.WriteLine();

Console.WriteLine($"myIntOne = {myIntOne}");
Console.WriteLine($"myIntTwo = {myIntTwo}");

Console.WriteLine();

/*
 * Nested conditional blocks can be used. However, each conditional block adds extra load to the program and can make it more complex.
 * Therefore, care should be taken when using nested conditional statements.

 * İç içe koşul blokları kullanılabilir. Ama her koşul bloğu kullanımında programa ek bir yük biner ve daha karmaşık bir hale gelebilir.
 * Bu yüzden iç içe koşul ifadeleri kullanırken dikkat edilmesi gerekir.
 */
if (myBoolOne)
{
    Console.WriteLine($"{myIntOne} > {myIntTwo}");
}
else
{
    Console.WriteLine($"{myIntOne} < {myIntTwo}");

    if(myBoolTwo)
    {
        Console.WriteLine($"{myIntOne} * 2 == {myIntTwo}");
    }
    else
    {
        Console.WriteLine($"{myIntOne} * 2 != {myIntTwo}");
    }
}

Console.WriteLine();

/*
 * This code snippet is a conditional expression.
 * It is called a "Ternary Conditional".
 * It is used in the form:
 * Condition ? (value if true) : (value if false)

 * Bu kod parçası bir koşullu ifadedir.
 * "Üçlü koşul" olarak adlandırılır.
 * Kullanım şekli:
 * Koşul ? (Koşul doğru ise alacağı değer) : (Koşul yanlış ise alacağı değer)
 */
bool myBoolControl = true;
Console.WriteLine(myBoolControl ? "True" : "False");

Console.WriteLine();

#endregion

#region switch
int level = 0;

switch (level)
{
    case 1:
        Console.WriteLine("Simple level was chosen.");
        break;
    case 2:
        Console.WriteLine("The middle level was selected.");
        break;
    case 3:
        Console.WriteLine("Difficult level was chosen.");
        break;
    default:
        Console.WriteLine("The level entered is unknown.");
        break;
}
#endregion

Console.ReadKey();
