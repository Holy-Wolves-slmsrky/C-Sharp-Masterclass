
/*
 * String Concatenation
 * String concatenation is done using the "+" operator or tools like String.Concat/StringBuilder class.
 * Multiple string literals or variables are combined into a single string value.

 * String Birleştirme
 * String birleştirme, "+" operatörü veya String.Concat/StringBuilder sınıfı gibi araçlar kullanılarak yapılır.
 * Birden fazla string ifade veya değişken tek bir string değere dönüşür.
 */

string firstString = "C#";
string secondString = "Language";

// 1) "+"
string String1 = firstString + " " + secondString;
Console.WriteLine(" First String = " + firstString);
Console.WriteLine("Second String = " + secondString);
Console.WriteLine("  Full String = " + String1);

Console.WriteLine();

// 2) String.Concat()
string String2 = String.Concat(firstString, " ", secondString);
Console.WriteLine(" First String = " + firstString);
Console.WriteLine("Second String = " + secondString);
Console.WriteLine("  Full String = " + String2);

Console.WriteLine();

// 3) StringBuilder
string String3 = new System.Text.StringBuilder().Append(firstString).Append(" ").Append(secondString).ToString();
Console.WriteLine(" First String = " + firstString);
Console.WriteLine("Second String = " + secondString);
Console.WriteLine("  Full String = " + String3);

Console.WriteLine();

/*
 * String Interpolation
 * String interpolation is done using "$" and "{}" signs.
 * The string value is prefixed with "$" and the variables are placed in "{}".
 * Multiple string literals or variables are combined into a single string value.
 * String interpolation provides formatting options.

 * String Enterpolasyonu (String İçinde Değişken Kullanma)
 * String enterpolasyonu, "$" ve "{}" işaretleri kullanılarak yapılır.
 * String değerinin önüne "$" eklenir ve değişkenler "{}" içine yerleştirilir.
 * Birden fazla string ifade veya değişken tek bir string değere dönüşür.
 * String enterpolasyonu, formatlama seçenekleri sunar.
 */

// Single-line - Tek Satır
string String4 = $"{firstString} {secondString}";
Console.WriteLine($" First String = {firstString}");
Console.WriteLine($"Second String = {secondString}");
Console.WriteLine($"  Full String = {String4}");

Console.WriteLine();

/*
 * Multi-line
 * For multiple lines, the "+" operator or the "@" sign can be used.

 * Çoklu Satır
 * Birden fazla satır için "+" operatörü veya "@" işareti kullanılabilir.
 */

string String5 = $"{firstString}" +
    " " +
    $"{secondString}";
Console.WriteLine($" First String = {firstString}");
Console.WriteLine($"Second String = {secondString}");
Console.WriteLine($"  Full String = {String5}");

Console.WriteLine();

string string6 = $@" First String = {firstString}
Second String = {secondString}
  Full String = {firstString} {secondString}";
Console.WriteLine(string6);

Console.WriteLine();

/*
 * String Formatting
 * String formatting is done using placeholders or methods like string.Format method.
 * Multiple string literals or variables are combined into a single string value.

 * String Formatlama
 * String formatlama, yer tutucular veya string.Format metodu gibi metodlar kullanılarak yapılır.
 * Birden fazla string ifade veya değişken tek bir string değere dönüşür.
 */

// Placeholders - Yer Tutucular
Console.WriteLine(" First String = {0}", firstString);
Console.WriteLine("Second String = {0}", secondString);
Console.WriteLine("  Full String = {0} {1}", firstString, secondString);

Console.WriteLine();

// String.Format()
Console.WriteLine(string.Format(" First String = {0}", firstString));
Console.WriteLine(string.Format("Second String = {0}", secondString));
Console.WriteLine(string.Format("  Full String = {0} {1}", firstString, secondString));

Console.WriteLine();

/*
 * In C#, the string.Format() method can be used to format numbers, dates, and strings, and many format specifiers can be used for this purpose. 
 * The decimal number specifier is one of them.

 * C#'ta, string.Format() yöntemi kullanılarak; sayıları, tarihleri ve metinleri biçimlendirmek için birçok biçim belirticisi kullanılabilir.
 * Ondalık sayı belirticisi bunlardan bir tanesidir.
 */

/*
 * This code rounds the decimal part and displays it with two decimal places.
 * Bu kod, ondalıklı kısımı yuvarlar ve ondalıklı kısımı iki basamak olacak şekilde gösterir.
 */
Console.WriteLine(string.Format("Price = {0:F2}", 1234.5678));

/*
 * Additional Information!
 * This operation can also be done using the class called "Math".

 * Ek Bilgi!
 * Bu işlem, "Math" adlı sınıf kullanılarak da yapılabilir.
 */
Console.WriteLine("Price = {0}", Math.Round(1234.5678, 2));

Console.ReadKey();
