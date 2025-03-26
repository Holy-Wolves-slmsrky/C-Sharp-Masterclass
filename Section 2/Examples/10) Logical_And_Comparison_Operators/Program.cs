
#region English - Click
/*
 * Logical and Comparison Operators
 * In programming, logical and comparison operators are used to evaluate specific conditions and ensure that the code runs under certain circumstances.

 * There are three main logical operators:
 * 1) AND Operator (&&): The result is true if both conditions are true.
 * 2) OR Operator (||): The result is true if at least one of the conditions is true.
 * 3) NOT Operator (!): Reverses the condition. If the condition is true, the result becomes false. If the condition is false, the result becomes true.

 * There are six main comparison operators:
 * 1) Equal to Operator (==): The result is true if both values are equal.
 * 2) Not Equal to Operator (!=): The result is true if both values are different.
 * 3) Greater than Operator (>): The result is true if the left value is greater than the right value.
 * 4) Less than Operator (<): The result is true if the left value is less than the right value.
 * 5) Greater than or Equal to Operator (>=): The result is true if the left value is greater than or equal to the right value.
 * 6) Less than or Equal to Operator (<=): The result is true if the left value is less than or equal to the right value.
 */
#endregion

#region Türkçe - Tıkla
/*
 * Mantıksal ve Karşılaştırma Operatörleri
 * Programlamada mantıksal ve karşılaştırma operatörleri, belirli koşulların değerlendirilmesinde ve kodun belirli durumlarda çalışmasını sağlamak için kullanılır.

 * Üç temel mantıksal operatör vardır:
 * 1) Ve Operatörü (&&): İki koşuldan her ikisi de doğru ise sonuç doğru olur.
 * 2) Veya Operatörü (||): İki koşuldan en az biri doğru ise sonuç doğru olur.
 * 3) Değil Operatörü (!): Bir koşulun tersini alır. Eğer koşul doğru ise sonuç yanlış olur. Eğer koşul yanlış ise sonuç doğru olur.

 * Altı temel karşılaştırma operatörü vardır:
 * 1) Eşittir Operatörü (==): İki değer eşit ise sonuç doğru olur.
 * 2) Eşit Değildir Operatörü (!=): İki değer farklı ise sonuç doğru olur.
 * 3) Büyüktür Operatörü (>): Soldaki değer, sağdaki değerden büyük ise sonuç doğru olur.
 * 4) Küçüktür Operatörü (<): Soldaki değer, sağdaki değerden küçük ise sonuç doğru olur.
 * 5) Büyük Eşittir Operatörü (>=): Soldaki değer, sağdaki değerden büyük ve eşit ise sonuç doğru olur.
 * 6) Küçük Eşittir Operatörü (<=): Soldaki değer, sağdaki değerden küçük ve eşit ise sonuç doğru olur.
 */
#endregion

/*
 *         |   &&  |
 * | value | value | result |
 * | true  | true  | true   |
 * | true  | false | false  |
 * | false | true  | false  |
 * | false | false | false  |

 *         |   ||  |
 * | value | value | result |
 * | true  | true  | true   |
 * | true  | false | true   |
 * | false | true  | true   |
 * | false | false | false  |

 *     |   !   |
 * | value | result |
 * | true  | false  |
 * | false | true   |
 */

bool myBoolOne = true;
bool myBoolTwo = false;

Console.WriteLine("{0,30} {1}", "myBoolOne =", myBoolOne);
Console.WriteLine("{0,30} {1}", "myBoolTwo =", myBoolTwo);

Console.WriteLine();

Console.WriteLine("{0,30} {1}", "myBoolOne && myBoolTwo =", myBoolOne && myBoolTwo);
Console.WriteLine("{0,30} {1}", "myBoolOne || myBoolTwo =", myBoolOne || myBoolTwo);
Console.WriteLine("{0,30} {1}", "!myBoolOne =", !myBoolOne);
Console.WriteLine("{0,30} {1}", "!myBoolTwo =", !myBoolTwo);

Console.WriteLine();

int myNumberOne = 10;
int myNumberTwo = 100;

Console.WriteLine("{0,30} {1}", "myNumberOne =", myNumberOne);
Console.WriteLine("{0,30} {1}", "myNumberTwo =", myNumberTwo);

Console.WriteLine();

Console.WriteLine("{0,30} {1}", "myNumberOne == myNumberTwo =", myNumberOne == myNumberTwo);
Console.WriteLine("{0,30} {1}", "myNumberOne != myNumberTwo =", myNumberOne != myNumberTwo);
Console.WriteLine("{0,30} {1}", "myNumberOne > myNumberTwo =", myNumberOne > myNumberTwo);
Console.WriteLine("{0,30} {1}", "myNumberOne < myNumberTwo =", myNumberOne < myNumberTwo);
Console.WriteLine("{0,30} {1}", "myNumberOne >= myNumberTwo =", myNumberOne >= myNumberTwo);
Console.WriteLine("{0,30} {1}", "myNumberOne <= myNumberTwo =", myNumberOne <= myNumberTwo);

Console.ReadKey();
