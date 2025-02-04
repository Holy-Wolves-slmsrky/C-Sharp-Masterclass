
# region English - Click
/*
 * A variable is a memory space that stores a value. Variables consist of three parts: type, name, and value.
 * variable_type variable_name = variable_value

 * Variables are categorized into 2 groups based on their structure:
 * 1) Value Type Variables
 * 2) Reference Type Variables

 * Variables are also categorized into 2 groups based on their declaration:
 * 1) Explicitly Declared Variables
 * 2) Implicitly Declared Variables

 * ~ Value Type Variables ~
 * A value type variable directly stores the assigned value and creates an independent copy when copied.
 * Stored on the "stack" in memory.
 * Examples: Bool, Char, Byte, Short, Long, Int, Float, Double, Decimal, Struct, Enum, etc.

 * ~ Reference Type Variables ~
 * A reference type variable stores the address of the data and refers to the same data when copied. Any changes affect all references.
 * Stored on the "heap" in memory, while the variable itself holds a reference (address) in the "stack".
 * Examples: String, Array, Object, Delegate, Class, Interface, etc.

 * ~ Explicitly Declared Variables ~
 * The variable type (e.g., string, int, etc.) is explicitly specified.
 * Prevents compile-time errors because type mismatches are immediately detected.

 * ~ Implicitly Declared Variables ~
 * An implicit variable is declared using the var keyword. The variable type is determined by the assigned value.
 * When using implicit variables, the variable must be assigned an initial value.
 * Useful for complex types (e.g., LINQ queries).

 * Some Data Types:
 * 1) String Type: Used for text.
 * 2) Bool Type: Used for logical expressions, taking True or False values.
 * 3) Char Type: Used for characters.
 * 4) Byte Type: Used for integers, with a value range of 0 to 255.
 * 5) Short Type: Used for small numbers.
 * 6) Long Type: Used for large numbers.
 * 7) Int Type: Used for integers.
 * 8) Float Type: Used for small decimal numbers.
 * 9) Double Type: Used for large decimal numbers. It is the default decimal type.
 * 10) Decimal Type: Used for high-precision financial or scientific calculations.

 * "E": Scientific notation, making it easier to represent very large or very small numbers.
 * "f" Suffix: Indicates that the number is of type float. Otherwise, the compiler treats the number as a double.
 * "m" Suffix: Indicates that the number is of type decimal. Otherwise, the compiler treats the number as a double.
 */
#endregion

#region Türkçe - Tıkla
/*
 * Değişken, bir değeri saklayan bir bellek alanıdır. Değişkenler üç bölümden oluşur: tür, ad ve değer.
 * değişken_türü değişken_adı = değişken_değeri

 * Değişken, yapısına göre 2 gruba ayrılır:
 * 1) Değer Tipi Değişken
 * 2) Referans Tipi Değişken

 * Değişken, tanımlanmasına göre 2 gruba ayrılır:
 * 1) Açıkça Tanımlanmış Değişken
 * 2) Örtülü Tanımlanmış Değişken

 * ~ Değer Tipi Değişken ~
 * Değer tipi değişken, atanan değeri doğrudan saklar ve kopyalandığında bağımsız bir kopya oluşturur.
 * Bellekte "stack" üzerinde saklanır.
 * Bool, Char, Byte, Short, Long, Int, Float, Double, Decimal, Struct, Enum vb.

 * ~ Referans Tipi Değişken ~
 * Referans tipi değişken, verinin adresini saklar ve kopyalandığında aynı veriye referans verir. Bir değişiklik tüm referansları etkiler.
 * Bellekte "heap" üzerinde saklanır ve değişkenin kendisi "stack"'te bir referans (adres) tutar.
 * String, Array, Object, Delegate, Class, Interface vb.

 * ~ Açıkça Tanımlanmış Değişken ~
 * Değişken türü (string, int vb.) net bir şekilde belirtilir.
 * Derleme zamanı hatalarını önler, çünkü tür uyuşmazlıkları hemen fark edilir.

 * ~ Örtülü Tanımlanmış Değişken ~
 * Örtülü değişken, "var" anahtar kelimesi kullanılarak belirtilir. Değişken türünü, atanan değer belirler.
 * Örtülü değişken kullanıldığında değişkene ilk değer atanması zorunludur.
 * Karmaşık türler (LINQ Sorguları vb.) için kullanışlıdır.

 * Bazı veri türleri:
 * 1) String türü, metinler için kullanılır.
 * 2) Bool türü, mantık ifadeleri için kullanılır. "True" veya "False" değerlerini alır.
 * 3) Char türü, karakterler için kullanılır.
 * 4) Byte türü, tam sayılar için kullanılır. Değer aralığı 0 ile 255 arasındadır.
 * 5) Short türü, küçük sayılar için kullanılır.
 * 6) Long türü, büyük sayılar için kullanılır.
 * 7) Int türü, tam sayılar için kullanılır.
 * 8) Float türü, küçük ondalıklı sayılar için kullanılır.
 * 9) Double türü, büyük ondalıklı sayılar için kullanılır. Varsayılan ondalıklı sayı türüdür.
 * 10) Decimal türü, yüksek hassasiyet gerektiren finansal veya bilimsel hesaplamalar için kullanılır.

 * "E" bilimsel gösterimdir ve büyük/küçük sayıları ifade etmeyi kolaylaştırır.
 * "f" soneki, bu sayının float türünde olduğunu belirtir. Aksi takdirde derleyici bu sayıyı double türü olarak kabul eder.
 * "m" soneki, bu sayının decimal türünde olduğunu belirtir. Aksi takdirde derleyici bu sayıyı double türü olarak kabul eder.
 */
#endregion

#region ~ Examples of Declaring and Using Variables ~ - ~ Değişken Bildirme ve Değişken Kullanma Örnekleri ~
/*
 * This code declares a variable.
 * Bu kod bir değişken bildirir.
 */
string myFriendName;

/*
 * This code assigns a value to the variable.
 * Bu kod değişkene bir değer atar.
 */
myFriendName = "C Sharp";

/*
 * This code assigns a new value to the variable.
 * Bu kod değişkene yeni bir değer atar (üzerine yazar).
 */
myFriendName = "C#";

/*
 * This code defines a variable and assigns a value to it.
 * Bu kod bir değişken bildirir ve değişkene bir değer atar.
 */
string myFriendName2 = "C#";

/*
 * This code uses / accesses a variable.
 * Bu kod bir değişken kullanır / değişkene erişir.
 */
Console.WriteLine(myFriendName);
#endregion

#region ~ Examples of Variable Data Types ~ - ~ Değişken Veri Türü Örnekleri ~
// This is a string variable.
// Bu bir string değişkenidir.
string myString = "C Sharp Language";
Console.WriteLine(myString);

// These are bool variables.
// Bu bir bool değişkenidir.
bool myBoolOne = true;
bool myBoolTwo = false;
Console.WriteLine(myBoolOne);
Console.WriteLine(myBoolTwo);

// This is a char variable.
// Bu bir char değişkenidir.
char myCharOne = '$';
Console.WriteLine(myCharOne);

// The char type uses UTF-16 encoding. A variable of type char can also be assigned UTF-16 codes.
// Char türü, UTF-16 kodlamasını kullanır. Char türündeki bir değişkene UTF-16 kodları da atanabilir.
char myCharTwo = '\u0024';
Console.WriteLine(myCharTwo);

// This is a byte variable.
// Bu bir byte değişkenidir.
byte myByte = 255;
Console.WriteLine(myByte);

// This is a short variable.
// Bu bir short değişkenidir.
short myShort = 32767;
Console.WriteLine(myShort);

// This is a long variable.
// Bu bir long değişkenidir.
long myLong = 9223372036854775807;
Console.WriteLine(myLong);

// This is a int variable.
// Bu bir int değişkenidir.
int myInt = 2147483647;
Console.WriteLine(myInt);

// This is a float variable.
// Bu bir float değişkenidir.
float myFloat = 3.4028235E+38f;
Console.WriteLine(myFloat);

// This is a double variable.
// Bu bir double değişkenidir.
double myDouble = 1.7976931348623157E+308;
Console.WriteLine(myDouble);

// This is a decimal variable.
// Bu bir decimal değişkenidir.
decimal myDecimal = 79228162514264337593543950335m;
Console.WriteLine(myDecimal);

/*
 * These variables are implicitly declared variables. When hovering over the variables with the mouse, their types are displayed.
 * Bu değişkenler örtülü değişkenlerdir. Fare ile değişkenin üzerinde gelindiğinde değişken türü belirtilir.
 */

// Char
var myVarOne = 'V';
Console.WriteLine(myVarOne);

// String
var myVarTwo = "C Sharp Language";
Console.WriteLine(myVarTwo);

// Integer
var myVarThree = 2147483647;
Console.WriteLine(myVarThree);

// Float
var myVarFour = 3.4028235E+38f;
Console.WriteLine(myVarFour);

/*
 * Since the "f" suffix was not used, it was interpreted as a double type.
 * "f" soneki yazılmadığı için double türü olarak algılandı.
 */

var myVarFive = 3.4028235E+38;
Console.WriteLine(myVarFive);
#endregion

Console.ReadKey();
