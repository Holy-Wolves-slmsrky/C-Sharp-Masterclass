
/*
 * Many data types have been created. Developers choose the appropriate data type based on the purpose of the variable and perform operations.
 * In some cases, it may be necessary to convert one data type to another.
 * To address this issue, methods, operators, and classes have been created for type conversions.
 * Conversions are divided into two categories: explicit conversion (which may lead to data loss) and implicit conversion (safer conversion).
 * Some tools used for type conversion:
 * 1) Parse() Method
 * 2) TryParse() Method
 * 3) Convert Class

 * Birçok veri türü oluşturulmuştur. Geliştiriciler, değişkenin amacına göre veri türünü seçerek işlem yaparlar.
 * Bazı durumlarda bu veri türünün başka bir veri türüne dönüştürülmesi gerekilebilir.
 * Bu soruna çözüm olarak tür dönüşümleri için yöntemler, operatörler ve sınıflar oluşturulmuştur.
 * Dönüşümler, açık dönüşüm (veri kaybına yol açabilir) ve örtük dönüşüm (daha güvenli dönüşüm) olarak 2 guruba ayrılır.
 * Tür dönüşümü için kullanılan bazı araçlar:
 * 1) Parse() Yöntemi
 * 2) TryParse() Yöntemi
 * 3) Convert Sınıfı
 */

string myString;
char myChar;
double myDouble;
float myFloat;
int myInt;
byte myByte;
bool myBool;

#region Implicit Conversion - Örtük Dönüşüm
/*
 * Implicit Conversion
 * Implicit conversion from one type to a larger type is done automatically.
 * Example: byte -> int, char -> int, float -> double, etc.

 * Örtük Dönüşüm
 * Bir türden, daha büyük bir türe örtülü dönüşüm otamatik olarak yapılır.
 * Örnek: char -> int, byte -> int, int -> float, float -> double vb.
 */

myByte = 10;
myInt = myByte;
Console.WriteLine(myInt);

myChar = '$';
myInt = myChar;
Console.WriteLine(myInt);

myFloat = 10.5f;
myDouble = myFloat;
Console.WriteLine(myDouble);

/*
 * This code gives an error. Because there can be no implicit transformation from one species to a smaller species.
 * Bu kod hata verir. Çünkü bir türden, daha küçük bir türe örtülü dönüşüm yapılamaz.
 */
//myInt = myDouble;

myString = "10";
/*
 * This code will throw an error because an implicit conversion cannot be performed between a string value and a numeric value.
 * Bu kod hata verir. Çünkü string bir değer ile sayısal bir değer arasında örtülü dönüşüm yapılamaz.
 */
//myInt = myString;

myString = "False";
myInt = 0;
myBool = true;

/*
 * These codes will throw an error because an implicit conversion cannot be performed between a string or numeric value and a boolean value.
 * Bu kodlar hata verir. Çünkü string veya sayısal bir değer ile boolean bir değer arasında örtülü dönüşüm yapılamaz.
 */
//myBool = myString;
//myBool = myInt;
#endregion

Console.WriteLine();

#region Explicit Conversion - Açık Dönüşüm
/*
 * Explicit Conversion
 * When converting from one type to another, the developer explicitly specifies the conversion.

 * Açık Dönüşüm
 * Bir türden başka bir türe dönüşüm yapılırken, geliştirici dönüşümü açıkça belirtir.
 */

myFloat = 32.5f;
myInt = (int)myFloat;
Console.WriteLine(myInt);
/*
 * Output: 32
 * The integer data type stores only whole numbers. Therefore, when converting from the float type to the integer type, data loss occurred.

 * Çıktı: 32
 * Integer veri türü sadece tam sayıları saklar. Bu yüzden float türünden integer türüne veri dönüşümü yapılırken veri kaybı yaşandı.
 */

myInt = 300;
myByte = (byte)myInt;
Console.WriteLine(myByte);
/*
 * Output: 44
 * The byte data type stores whole numbers between 0 and 255. Therefore, when converting from the integer type to the byte type, data loss occurred.

 * Çıktı: 44
 * Byte veri türü 0 - 255 arası tam sayıları saklar. Bu yüzden integer türünden byte türüne veri dönüşümü yapılırken veri kaybı yaşandı.
 */

myDouble = 1.12345678;
myFloat = (float)myDouble;
Console.WriteLine(myFloat);
/*
 * Output: 1.1234568
 * The float data type stores smaller decimal numbers than the double data type.
 * Therefore, when converting from float to double, data loss occurred.
 * The value 1.12345678 was rounded to 1.1234568.

 * Çıktı: 1.1234568
 * Float veri türü, double veri türünden daha küçük ondalıklı sayıları saklar.
 * Bu yüzden float türünden double türüne veri dönüşümü yapılırken veri kaybı yaşandı.
 * 1.12345678 değeri 1.1234568 değerine yuvarlandı.
 */

myInt = 36;
myChar = (char)myInt;
Console.WriteLine(myChar);
/*
 * The ASCII code of the "$" character (36) was assigned to the integer variable.
 * Output: $

 * Integer değişkene "$" karakterinin ASCII kodu (36) atandı.
 * Çıktı: $
 */

/*
 * The ToString() method converts the corresponding value to a string. This operation is an explicit conversion.
 * ToString() yöntemi, ilgili değeri string değere dönüştürür. Bu işlem, bir açık dönüşümdür.
 */
myString = myChar.ToString();
myString = myInt.ToString();
myString = myFloat.ToString();
myString = myBool.ToString();

/*
 * This codes will throw an error because an explicit conversion cannot be performed between a string value and a numeric value.
 * Bu kodlar hata verir. Çünkü string bir değer ile sayısal bir değer arasında açık dönüşüm yapılamaz.
 */
//myString = (string)myInt;
//myInt = (int)myString;
#endregion;

Console.WriteLine();

/*
 * Parse() Method, TryParse() Method and Convert Class are Explicit Casts.
 * Parse() Metodu, TryParse() Metodu ve Convert Sınıfı Açık Dönüşümlerdir.
 */

// 2) Parse() Method - Parse() Yöntemi

/*
 * The Parse() method allows a string value to be converted to a specified data type.
 * Parse() metodu, bir string değerin belirli bir veri türüne dönüştürülmesini sağlar.
 */

myString = "14";

myInt = int.Parse(myString);
Console.WriteLine(myInt);

myByte = byte.Parse(myString);
Console.WriteLine(myByte);

myString = "14.12";

myDouble = double.Parse(myString, System.Globalization.CultureInfo.InvariantCulture);
Console.WriteLine(myDouble);

myFloat = float.Parse(myString, System.Globalization.CultureInfo.InvariantCulture);
Console.WriteLine(myFloat);

myString = "C";

myChar = char.Parse(myString);
Console.WriteLine(myChar);

myString = "True";

myBool = bool.Parse(myString);
Console.WriteLine(myBool);

Console.WriteLine();

// 3) TryParse() Method - TryParse() Yöntemi

/*
 * The TryParse() method safely converts a string value to a specified data type. If the conversion is successful, it returns "True"; otherwise, it returns "False".

 * TryParse() metodu, bir string değerin belirli bir veri türüne güvenli bir şekilde dönüştürülmesini sağlar. Dönüşüm başarılı olur ise "True" değer, başarısız olur ise "False" değer geri döndürür.
 */

myString = "41";

int.TryParse(myString, out myInt);
Console.WriteLine(myInt);

byte.TryParse(myString, out myByte);
Console.WriteLine(myByte);

myString = "12.14";

double.TryParse(myString, System.Globalization.CultureInfo.InvariantCulture, out myDouble);
Console.WriteLine(myDouble);

float.TryParse(myString, System.Globalization.CultureInfo.InvariantCulture, out myFloat);
Console.WriteLine(myFloat);

myString = "R";

char.TryParse(myString, out myChar);
Console.WriteLine(myChar);

myString = "False";
bool.TryParse(myString, out myBool);
Console.WriteLine(myBool);

Console.WriteLine();

/*
 * Difference Between Parse() Method and TryParse() Method:

 * 1) Error Handling:
 * Parse(): Throws an Exception (e.g., FormatException) when an invalid input is provided. Therefore, the input must always be in a valid format.
 * TryParse(): Does not throw an error when an invalid input is provided. Instead, it returns False. This method offers safer and more performance-friendly error handling.

 * 2) Safety:
 * Parse(): Less safe, as it can cause the application to crash if errors are not properly handled.
 * TryParse(): Safer, as it allows you to check whether the conversion was successful and does not throw errors.

 * 3) Ease of Use:
 * Parse(): Simpler for conversion, but requires additional error handling for invalid inputs.
 * TryParse(): Requires more code but provides a safer conversion process.

 * 4) Return Value:
 * Parse(): Directly returns the converted value or throws an error.
 * TryParse(): Returns the converted value via the out parameter and returns a boolean value indicating whether the conversion was successful or not.

 * Parse() Yönetimi ile TryParse() Yöntemi Arasındaki Fark:

 * 1) Hata Yönetimi:
 * Parse(): Geçersiz bir giriş sağlandığında bir Exception (örn. FormatException) fırlatır. Bu nedenle, girişin her zaman geçerli bir formatta olması gerekir.
 * TryParse(): Geçersiz bir giriş sağlandığında bir hata fırlatmaz, bunun yerine False döndürür. Bu yöntem, hata yönetimini daha güvenli ve performanslı hale getirir.

 * 2) Güvenlik:
 * Parse(): Daha az güvenlidir, çünkü hatalar yönetilmezse uygulamanın çökmesine neden olabilir.
 * TryParse(): Daha güvenlidir, çünkü dönüşümün başarılı olup olmadığını kontrol etmenizi sağlar ve hata fırlatmaz.

 * 3) Kullanım Kolaylığı:
 * Parse(): Dönüşüm işlemi için daha basittir ancak geçersiz girdiler için ek hata yönetimi gerektirir.
 * TryParse(): Daha fazla kod yazmayı gerektirse de, güvenli bir dönüşüm süreci sunar.

 * 4) Dönüş Değeri:
 * Parse(): Dönüştürülen değeri doğrudan döndürür veya hata fırlatır.
 * TryParse(): Dönüştürülen değeri out parametresi aracılığıyla döndürür ve dönüşümün başarılı olup olmadığını belirtmek için bir boolean değer döner.
 */

myString = "abc";

/*
 * This code will throw an error because the value "abc" is not an integer. This error will cause the program to crash.
 * Bu kod hata verir. Çünkü "abc" değeri bir integer değer değildir. Bu hata programın çökmesine neden olur.
 */
//myInt = int.Parse(myString);
Console.WriteLine(myInt);

/*
 * This code will not throw an error. The TryParse() method returns "False" and assigns the value "0" to the integer variable.
 * Bu kod hata vermez. TryParse() yöntemi "False" değer döndürür. Integer değişkene "0" değerini atar.
 */
Console.WriteLine(int.TryParse(myString, out myInt));
Console.WriteLine(myInt);

/*
 * This code will not throw an error. The TryParse() method returns "False" and assigns the value "0" to the float variable.
 * Bu kod hata vermez. TryParse() yöntemi "False" değer döndürür. Float değişkene "0" değerini atar.
 */
Console.WriteLine(float.TryParse(myString, out myFloat));
Console.WriteLine(myFloat);

/*
 * This code will not throw an error. The TryParse() method returns "False" and assigns the value "\0" (null character) to the char variable.
 * Bu kod hata vermez. TryParse() yöntemi "False" değer döndürür. Char değişkene "\0" (null karakteri) değerini atar.
 */
Console.WriteLine(char.TryParse(myString, out myChar));
Console.WriteLine(myChar);

/*
 * This code will not throw an error. The TryParse() method returns "False" and assigns the value "false" to the bool variable.
 * Bu kod hata vermez. TryParse() yöntemi "False" değer döndürür. Bool değişkene "false" değerini atar.
 */
Console.WriteLine(bool.TryParse(myString, out myBool));
Console.WriteLine(myBool);

/*
 * The default value of numeric variables is 0.
 * The default value of a boolean variable is false.
 * The default value of a char variable is "\0" (the null character).
 * The default value of a String variable is a "null" reference.

 * Sayısal değişkenlerin varsayılan değeri "0" değeridir.
 * Bool değişkeninin varsayılan değeri "false" değeridir.
 * Char değişkeninin varsayılan değeri "\0" (null karakteri) değeridir.
 * String değişkeninin varsayılan değeri "null" değeri referansıdır.
*/

Console.WriteLine();

// 4) Convert Class - Convert Sınıfı

/*
 * The Convert class is a class that allows conversions between different data types.
 * The Convert class simplifies conversions between primitive data types (such as int, double, bool, string) and works well with null values.
 * However, if the conversion fails, it typically throws a FormatException.
 * This class is used for explicit conversion operations and supports conversions between most primitive types.

 * Convert sınıfı, farklı veri türleri arasında dönüşüm yapmayı sağlayan bir sınıftır.
 * Convert sınıfı, temel veri türleri arasında (örneğin, int, double, bool, string) dönüşümleri kolaylaştırır ve null değerlerle de düzgün çalışır.
 * Ancak, dönüşümde başarısız olursa, genellikle FormatException hatası fırlatır.
 * Bu sınıf, açık dönüşüm işlemleri için kullanılır ve çoğu temel türde dönüşüm sağlar.
 */

/*
 * The following codes work without errors and no data loss.
 * Aşağıdaki kodlar hatasız ve veri kaybı olmadan çalışır.
 */

myString = "123.45";

myDouble = Convert.ToDouble(myString, System.Globalization.CultureInfo.InvariantCulture);
Console.WriteLine(myDouble);

myFloat = Convert.ToSingle(myString, System.Globalization.CultureInfo.InvariantCulture);
Console.WriteLine(myFloat);

myString = "123";

myInt = Convert.ToInt32(myString);
Console.WriteLine(myInt);

myByte = Convert.ToByte(myString);
Console.WriteLine(myByte);

myString = "#";

myChar = Convert.ToChar(myString);
Console.WriteLine(myChar);

myString = "false";

myBool = Convert.ToBoolean(myString);
Console.WriteLine(myBool);

Console.WriteLine();

myString = Convert.ToString(myDouble);
Console.WriteLine(myString);

myString = Convert.ToString(myInt);
Console.WriteLine(myString);

myString = Convert.ToString(myBool);
Console.WriteLine(myString);

Console.WriteLine();

myDouble = 1.12345678;

myFloat = Convert.ToSingle(myDouble);
Console.WriteLine(myFloat);
/*
 * Output: 1.1234568
 * The float data type stores smaller decimal numbers than the double data type.
 * Therefore, when converting from float to double, data loss occurred.
 * The value 1.12345678 was rounded to 1.1234568.

 * Çıktı: 1.1234568
 * Float veri türü, double veri türünden daha küçük ondalıklı sayıları saklar.
 * Bu yüzden float türünden double türüne veri dönüşümü yapılırken veri kaybı yaşandı.
 * 1.12345678 değeri 1.1234568 değerine yuvarlandı.
 */

myInt = Convert.ToInt32(myFloat);
Console.WriteLine(myInt);
/*
 * Output: 1
 * The integer data type stores only whole numbers. Therefore, when converting from the float type to the integer type, data loss occurred.

 * Çıktı: 1
 * Integer veri türü sadece tam sayıları saklar. Bu yüzden float türünden integer türüne veri dönüşümü yapılırken veri kaybı yaşandı.
 */

myByte = Convert.ToByte(myInt);
Console.WriteLine(myByte);

Console.WriteLine();

myString = null;

/*
 * If "null" value is assigned to numeric variables, the value of the variable will be "0".
 * Sayısal değişkenlere "null" değeri atanırsa, değişkenin değeri "0" olur.
 */

myFloat = Convert.ToSingle(myString);
Console.WriteLine(myFloat);

myInt = Convert.ToInt32(myString);
Console.WriteLine(myInt);

/*
 * If "null" value is assigned to bool variables, the value of the variable will be "false".
 * Bool değişkenlere "null" değeri atanırsa, değişkenin değeri "false" olur.
 */

myBool = Convert.ToBoolean(myString);
Console.WriteLine(myBool);

Console.WriteLine();

myString = "abc";

/*
 * Since this string value contains letters, it cannot be converted to a numeric value, char or bool.
 * Bu dize değeri harfler içerdiğinden, sayısal bir değere, char veya bool değerine dönüştürülemez.
 */
//myFloat = Convert.ToSingle(myString);
//myInt = Convert.ToInt32(myString);
//myChar = Convert.ToChar(myString);
//myBool = Convert.ToBoolean(myString);

myString = "256";

//myByte = Convert.ToByte(myString);
/*
 * This code throws an error. Byte data type stores integers from 0 to 255. Therefore 256 value cannot be assigned to the byte variable.
 * Bu kod hata verir. Byte veri türü 0 - 255 arası tam sayıları saklar. Bu nedenle byte değişkenine 256 değeri atanamaz.
 */

myString = "123.456.789";

//myDouble = Convert.ToDouble(myString, System.Globalization.CultureInfo.InvariantCulture);
/*
 * This code gives an error. Because there can be 1 "." sign in the decimal value. (Depending on the culture difference, "." or "," sign can be used.)
 * Bu kod hata verir. Çünkü ondalık değer içinde 1 adet "." işareti olabilir. (Kültür farklılığına bağlı olarak "." veya "," işareti kullanılabilir.)
 */

//myChar = Convert.ToChar(myString);
/*
 * This code gives an error. Because char data type does not store "null" value. It stores the null character (\0).
 * Bu kod hata verir. Çünkü char veri tipi "null" değerini saklamaz. Null karakterini (\0) saklar.
 */

Console.ReadKey();
