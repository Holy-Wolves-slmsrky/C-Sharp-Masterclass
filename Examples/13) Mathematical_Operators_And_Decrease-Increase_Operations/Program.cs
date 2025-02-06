
/*
 * Mathematical operators are used for addition, subtraction, multiplication, division, and modulo operations.
 * The modulo operation is used to find the remainder when a number is divided by another number.
 * The order of operations is as follows:
 * 1) Parentheses ()
 * 2) Multiplication, division, and modulo (*, /, %)
 * 3) Addition and subtraction (+, -)

 * Matematik operatörleri; toplama, çıkarma, çarpma, bölme ve mod alma işlemleri için kullanılır.
 * Mod alma işlemi, bir sayıyının başka bir sayıya bölümünden kalan değeri bulmak için kullanılır.
 * İşlem öncelik sırası şu şekildedir:
 * 1) Parantezler ()
 * 2) Çarpma, bölme ve mod alma(*, /, %)
 * 3) Toplama ve çıkarma (+, -)
 */

int result = (10 * 10 + 20) / 20 + 20 * 10 * ((10 * 2 - 10) % 3);
Console.WriteLine($"(10 * 10 + 20) / 20 + 20 * 10 * ((10 * 2 - 10) % 3) = {result}");

Console.WriteLine();

Console.WriteLine("1) (10 * 10 + 20) = 100 + 20 = 120");
Console.WriteLine("2) ((10 * 2 - 10) % 3) = ((20 - 10) % 3) = (10 % 3) = 1");
Console.WriteLine("3) 120 / 20 + 20 * 10 * 1 = 6 + 20 * 10 * 1 = 6 + 200 * 1 = 6 + 200 = 206");

Console.WriteLine();

Console.WriteLine("Classic Example - Klasik örnek:");

int myNumberOne = 10;
int myNumberTwo = 3;

Console.WriteLine($"{myNumberOne} + {myNumberTwo} = {myNumberOne + myNumberTwo}");
Console.WriteLine($"{myNumberOne} - {myNumberTwo} = {myNumberOne - myNumberTwo}");
Console.WriteLine($"{myNumberOne} * {myNumberTwo} = {myNumberOne * myNumberTwo}");
Console.WriteLine($"{myNumberOne} / {myNumberTwo} = {myNumberOne / myNumberTwo}");
Console.WriteLine($"{myNumberOne} % {myNumberTwo} = {myNumberOne % myNumberTwo}");

Console.WriteLine();

/*
 * Addition, subtraction, multiplication, division, and modulo operations can be performed in two different ways.
 * Toplama, çıkarma, çarpma, bölme ve mod işlemleri 2 farklı şekilde yapılabilir.
 */

int myResult = 0;

Console.WriteLine("1) Simple - Basit:");

myResult = myResult + 10;
Console.WriteLine(myResult);

myResult = myResult - 9;
Console.WriteLine(myResult);

myResult = myResult * 8;
Console.WriteLine(myResult);

myResult = myResult / 4;
Console.WriteLine(myResult);

myResult = myResult % 1;
Console.WriteLine(myResult);

Console.WriteLine();

myResult = 0;

Console.WriteLine("2) Shortened - Kısaltılmış:");

myResult += 10;
Console.WriteLine(myResult);

myResult -= 9;
Console.WriteLine(myResult);

myResult *= 8;
Console.WriteLine(myResult);

myResult /= 4;
Console.WriteLine(myResult);

myResult %= 1;
Console.WriteLine(myResult);

Console.WriteLine();

/*
 * Increment and decrement operations can be performed in two ways: basic operations and shorthand operations.
 * Additionally, special operators (++, --) can be used for increment and decrement operations.
 * These operations are divided into two types: prefix and postfix.
 * If prefix increment / decrement is used, the variable's value is changed first, then the operation is performed.
 * If postfix increment / decrement is used, the operation is performed first, then the variable's value is changed.

 * Arttırma ve azaltma işlemleri, basit işlem ve kısaltılmış işlem olmak üzere iki şekilde yapılabilir.
 * Ayrıca, arttırma ve azaltma işlemleri için özel operatörler (++, --) kullanılabilir.
 * Bu işlemler, ön ek ve son ek olmak üzere ikiye ayrılır.
 * Ön ek arttırma / azaltma kullanılırsa, önce değişkenin değeri değiştirilir, sonra işlem gerçekleştirilir.
 * Son ek arttırma / azaltma kullanılırsa, önce işlem gerçekleştirilir, ardından değişkenin değeri değiştirilir.
 */

myResult = 0;

// Output - Çıktı = 0
Console.WriteLine(myResult);

// Output - Çıktı = 0
/*
 * Because the operation is performed first, then the variable's value is changed.
 * The value was printed to the screen first, then the variable's value was incremented by one.

 * Çünkü önce işlem yapılır sonra değişken değeri değiştirilir.
 * Ekrana değer yazdırıldı. Ardından değişken değeri bir arttırıldı.
 */
Console.WriteLine(myResult++);

// Output - Çıktı = 1
Console.WriteLine(myResult);

// Output - Çıktı = 2
/*
 * Because the variable's value is changed first, then the operation is performed.
 * The variable's value was incremented by one first, then the value was printed to the screen.

 * Çünkü önce değişken değeri değiştirilir sonra işlem yapılır.
 * Değişken değeri bir arttırıldı. Ardından ekrana değer yazdırıldı.
 */
Console.WriteLine(++myResult);

// Output - Çıktı = 2
Console.WriteLine(myResult);

Console.WriteLine();

myResult = 0;

// Output - Çıktı = 0
Console.WriteLine(myResult);

// Output - Çıktı = 0
Console.WriteLine(myResult--);

// Output - Çıktı = -1
Console.WriteLine(myResult);

// Output - Çıktı = -2
Console.WriteLine(--myResult);

// Output - Çıktı = -2
Console.WriteLine(myResult);

Console.ReadKey();
