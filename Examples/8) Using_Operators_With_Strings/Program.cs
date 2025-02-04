
/*
 * Basic mathematical operators (except "-") can be used with string expressions.
 * The "+" operator concatenates the left and right values and converts them into a string. It does not perform a mathematical operation.
 * The "-" operator cannot be used with string expressions.
 * The "*", "/" and "%" operators perform mathematical operations and append the result to the string expression.

 * Operation Evaluation Order
 * 1) () - Parentheses
 * 2) "*" or "/" - Multiplication or Division
 * 3) "+" or "-" - Addition or Subtraction

 * When using the "+" and "-" operators, mathematical operations must be enclosed in parentheses "()".

 * Temel Matematik Operatörleri ("-" hariç), string ifadeler ile birlikte kullanılabilir.
 * "+" operatörü, sol değer ile sağ değeri birleştirir ve bir string ifadeye çevirir. Matematik işlemini yapmaz.
 * "-" operatörü, string ifadeler ile kullanılamaz.
 * "*", "/"  ve "%" operatörü, matematik işlemini yapar ve string ifadeye işlemin değerini ekler.

 * İşlem Değerlendirme Sırası
 * 1) () - parantezler
 * 2) "*" veya "/" - çarpma veya bölme
 * 3) "+" veya "-" - toplama veya çıkarma

 * "+" ve "-" operatörü kullanılacağı zaman matematiksel işlem parantez "()" içine alınmalıdır.
 */

int num1 = 5;
int num2 = 13;

/*
 * This code converts each expression into a single string.
 * Bu kod, her bir ifadeyi tek bir string ifadeye çevirir.

 * Output - Çıktı:
 * num1 + num2 = 513
 */
Console.WriteLine("num1 + num2 = " + num1 + num2);

/*
 * This code will result in a compilation error.
 * Bu kod derleme hatası verir.
 */
//Console.WriteLine("num1 - num2 = " + num1 - num2);

/*
 * The following 3 codes do not give any errors.
 * Aşağıdaki 3 kod herhangi bir hata vermez.

 * Output - Çıktı:
 * num1 * num2 = 65
 * num1 / num2 = 0
 * num1 % num2 = 5
 */
Console.WriteLine("num1 * num2 = " + num1 * num2);
Console.WriteLine("num1 / num2 = " + num1 / num2);
Console.WriteLine("num1 % num2 = " + num1 % num2);

/*
 * For the reasons I explained above and to increase the readability of the code; In the C# language, codes are written according to the order of evaluation of operations.
 * Yukarıda açıkladığım sebeplerden dolayı ve kodun okunabilirliğini arttırmak için; C# dilinde kodlar, işlemlerin değerlendirilme sırasına göre yazılır.
 */

Console.WriteLine("num1 + num2 = " + (num1 + num2));
Console.WriteLine("num1 - num2 = " + (num1 - num2));
Console.WriteLine("num1 * num2 = " + (num1 * num2));
Console.WriteLine("num1 / num2 = " + (num1 / num2));
Console.WriteLine("num1 % num2 = " + (num1 % num2));

/*
 * Output - Çıktı:
 * num1 + num2 = 18
 * num1 - num2 = -8
 * num1 * num2 = 65
 * num1 / num2 = 0
 * num1 % num2 = 5
 */

Console.ReadKey();
