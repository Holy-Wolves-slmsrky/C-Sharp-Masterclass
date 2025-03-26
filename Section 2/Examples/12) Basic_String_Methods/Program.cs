
/*
 * The Clone() method creates a copy of a string.
 * Clone() metodu, bir string ifadenin bir kopyasını oluşturur.
 */
string string_1 = "Hello, World!";
string string_2 = (string)string_1.Clone();
Console.WriteLine($"{string_2}\n");

/*
 * The Compare() method compares two string values based on alphabetical order.
 * If the first string comes before the second string, it returns -1.
 * If the first string comes after the second string, it returns 1.
 * If both strings are equal, it returns 0.

 * Compare() metodu, iki string ifadeyi alfabetik sıraya göre karşılaştırır.
 * Eğer ilk ifade, ikinci ifadeden önce geliyorsa -1 döndürür.
 * Eğer ilk ifade, ikinci ifadeden sonra geliyorsa 1 döndürür.
 * Eğer iki ifade eşitse 0 döndürür.
 */
Console.WriteLine($"{string.Compare("apple", "banana")}");
Console.WriteLine($" {string.Compare("date", "cherry")}");
Console.WriteLine($" {string.Compare("elderberry", "elderberry")}\n");

/*
 * It performs a case-sensitive comparison.
 * Büyük - Küçük harf duyarlı karşılaştırır.
 */
Console.WriteLine($" {string.Compare("A", "a")}\n");

/*
 * It performs a case-insensitive comparison.
 * Büyük - Küçük harf duyarlı olmadan karşılaştırır.
 */
Console.WriteLine($" {string.Compare("A", "a", true)}\n");

/*
 * The CompareOrdinal() method compares two string values based on their Unicode values.
 * CompareOrdinal() metodu, iki string ifadeyi Unicode değerine göre karşılaştırır.
 */
Console.WriteLine($"{string.CompareOrdinal("abc", "abd")}");
Console.WriteLine($" {string.CompareOrdinal("abd", "abc")}");
Console.WriteLine($" {string.CompareOrdinal("abc", "abc")}\n");

/*
 * This code returns -32 because the characters 'A' and 'a' have different Unicode values.
 * Bu kod -32 değerini döndürür. Çünkü 'A' ve 'a' karakterleri farklı Unicode değerlerine sahiptir.

 * A = 65
 * a = 97
 * 65 - 97 = -32
 */
Console.WriteLine($"{string.CompareOrdinal("A", "a")}\n");

/*
 * The Contains() method checks whether a string contains a specific substring.
 * Contains() metodu, bir string ifadenin belirli bir alt string ifadeyi içerip içermediğini kontrol eder.
 */
string string_3 = "C# is a powerful language.";
Console.WriteLine($"{string_3.Contains("powerful")}");

/*
 * The Contains method is case-sensitive.
 * The StringComparison.OrdinalIgnoreCase option performs a case-insensitive comparison.
 * It can be used with many methods.
 * StartsWith, EndsWith, Equals etc.

 * Contains metodu büyük - küçük harf duyarlıdır.
 * StringComparison.OrdinalIgnoreCase kodu büyük - küçük harf duyarlı olmadan kontrol eder.
 * Birçok metot ile kullanılabilir.
 * StartsWith, EndsWith, Equals vb.
 */
Console.WriteLine($"{string_3.Contains("PoWeRfUl", StringComparison.OrdinalIgnoreCase)}\n");

/*
 * The StartsWith() method checks whether a string starts with a specific substring.
 * StartsWith() metodu, bir string ifadenin belirli bir alt string ile başlayıp başlamadığını kontrol eder.
 */
string string_4 = "Program.cs";
Console.WriteLine($"{string_4.StartsWith("Program")}\n");

/*
 * The EndsWith() method checks whether a string ends with a specific substring.
 * EndsWith() metodu, bir string ifadenin belirli bir alt string ile bitip bitmediğini kontrol eder.
 */
string string_5 = "Program.cs";
Console.WriteLine($"{string_5.EndsWith(".cs")}\n");

/*
 * The Equals() method checks whether two string values are equal.
 * Equals() metodu, iki string ifadenin eşit olup olmadığını kontrol eder.
 */
string string_6 = "CSharp";
string string_7 = "CSharp";
Console.WriteLine($"{string_6.Equals(string_7)}\n");

/*
 * The GetHashCode() method returns the hash code of a string.
 * GetHashCode() metodu, bir string ifadenin hash kodunu döndürür.
 */
string string_8 = "CSharpLanguage";
Console.WriteLine($"{string_8.GetHashCode()}\n");

/*
 * The IndexOf() method returns the position of the first occurrence of a character or substring.
 * IndexOf() metodu, bir karakterin veya alt string ifadenin ilk bulunduğu konumu döndürür.
 */
string string_9 = "Hello World!";
Console.WriteLine($"{string_9.IndexOf('l')}");
Console.WriteLine($"{string_9.IndexOf("World")}");

/*
 * It can be set to search after a specific position.
 * This code will search for the character 'o' after the 5th character.

 * Belirli bir konumdan sonra araması için ayarlanabilir.
 * Bu kod 'o' karakterini 5. karakterden sonra arayacaktır.
 */
Console.WriteLine($"{string_9.IndexOf('o', 5)}\n");

/*
 * The LastIndexOf() method returns the position of the last occurrence of a character or substring.
 * LastIndexOf() metodu, bir karakterin veya alt string ifadenin son bulunduğu konumu döndürür.
 */
Console.WriteLine($"{string_9.LastIndexOf('l')}");
Console.WriteLine($"{string_9.LastIndexOf("World")}\n");

/*
 * The Insert() method inserts a new string at the specified index.
 * Insert() metodu, belirtilen index'e yeni bir string ekler.
 */
string string_10 = " Hello ";
Console.WriteLine($"{string_10.Insert(7, "World!")}\n");

/*
 * The PadLeft() method adds a specified number of spaces or a specified character to the left side of a string.
 * PadLeft() metodu, bir string ifadenin sol tarafına belirli sayıda boşluk veya belirli bir karakter ekler.
 */
Console.WriteLine($"{string_10.PadLeft(10)}");
Console.WriteLine($"{string_10.PadLeft(10, '-')}\n");

/*
 * The PadRight() method adds a specified number of spaces or a specified character to the right side of a string.
 * PadRight() metodu, bir string ifadenin sağ tarafına belirli sayıda boşluk veya belirli bir karakter ekler.
 */
Console.WriteLine($"{string_10.PadRight(10)}");
Console.WriteLine($"{string_10.PadRight(10, '-')}\n");

/*
 * The Remove() method deletes the characters of a string starting from a specified index or removes characters within a specified range.
 * Remove() metodu, bir string ifadenin belirli bir index'ten sonrasını siler veya belirli bir aralıktaki karakterleri kaldırır.
 */
string string_11 = "Remove() method";
Console.WriteLine($"{string_11.Remove(8)}");
Console.WriteLine($"{string_11.Remove(0,8)}\n");

/*
 * The Replace() method replaces a specific character or word in a string with another value.
 * Replace() metodu, bir string ifadenin içinde belirli bir karakteri veya kelimeyi başka bir şeyle değiştirir.
 */
string string_12 = "Hello, World!";
Console.WriteLine($"{string_12.Replace('o','0')}");
Console.WriteLine($"{string_12.Replace("World", "Universe")}");
Console.WriteLine($"{string_12.Replace("hello", "Hi", StringComparison.OrdinalIgnoreCase)}\n");

/*
 * The Substring() method is used to get a specific portion of a string.
 * Substring() metodu, bir string ifadenin belirli bir kısmını almak için kullanılır.
 */
Console.WriteLine($"{string_12.Substring(7)}");
Console.WriteLine($"{string_12.Substring(7, 5)}\n");

/*
 * The ToLower() method converts all characters of a string to lowercase.
 * ToLower() metodu, bir string ifadenin her karakterini küçük harfe çevirir.
 */
string string_13 = "HELLO";
Console.WriteLine($"{string_13.ToLower()}");

/*
 * This code converts the string in a culture-sensitive manner.
 * Bu kod, kültüre duyarlı bir şekilde çevirir.
 */
string Turkish = "İSTANBUL";
Console.WriteLine($"{Turkish.ToLower(new System.Globalization.CultureInfo("tr-TR"))}\n");

/*
 * The ToLowerInvariant() method converts a string to lowercase in a culture-invariant manner.
 * ToLowerInvariant metodu, kültüre duyarlı bir şekilde çevirir.
 */
Console.WriteLine($"{string_13.ToLowerInvariant()}\n");

/*
 * The ToUpper() method converts all characters of a string to uppercase.
 * ToUpper() metodu, bir string ifadenin her karakterini büyük harfe çevirir.
 */
string string_14 = "hello";
Console.WriteLine($"{string_14.ToUpper()}");

/*
 * This code converts the string in a culture-sensitive manner.
 * Bu kod, kültüre duyarlı bir şekilde çevirir.
 */
string English = "istanbul";
Console.WriteLine($"{English.ToUpper(new System.Globalization.CultureInfo("en-EN"))}\n");

/*
 * The ToUpperInvariant() method converts a string to lowercase in a culture-invariant manner.
 * ToUpperInvariant metodu, kültüre duyarlı bir şekilde çevirir.
 */
Console.WriteLine($"{string_14.ToUpperInvariant()}\n");

/*
 * The Trim() method removes the leading and trailing whitespace characters from a string.
 * Trim() metodu, bir string ifadenin başındaki ve sonundaki boşlukları kaldırır.
 */
string string_15 = "   Hello, World!   ";
Console.WriteLine($"{string_15.Trim()}");

/*
 * It is also used to remove specific characters.
 * Belirli karakteri kaldırmada da kullanılır.
 */
string string_16 = "***Hello***";
Console.WriteLine($"{string_16.Trim('*')}\n");

/*
 * The TrimStart() method removes the leading whitespace characters from a string.
 * TrimStart() metodu, bir string ifadenin başındaki boşlukları kaldırır.
 */
string string_17 = "   Hello, World!";
Console.WriteLine($"{string_17.TrimStart()}\n");

/*
 * The TrimEnd() method removes the trailing whitespace characters from a string.
 * TrimEnd() metodu, bir string ifadenin sonundaki boşlukları kaldırır.
 */
string string_18 = "Hello, World!   ";
Console.WriteLine($"{string_18.TrimEnd()}\n");

/*
 * The IsNullOrEmpty() method checks whether a string is null or empty.
 * IsNullOrEmpty() metodu, bir string ifadenin boş olup olmadığını kontrol eder.
 */
string string_19 = "";
Console.WriteLine($"{string.IsNullOrEmpty(string_19)}");

/*
 * The IsNullOrWhiteSpace() method checks whether a string is null, empty, or consists only of whitespace characters.
 * IsNullOrWhiteSpace() metodu, bir string ifadenin tamamen boş veya sadece boşluklardan mı oluştuğunu kontrol eder.
 */
string string_20 = "    ";
Console.WriteLine($"{string.IsNullOrWhiteSpace(string_20)}");

/*
 * The Length property returns the number of characters in a string.
 * Length metodu, bir string ifadenin karakter sayısını döndürür.
 */
string string_21 = "C# is a programming language.";
Console.WriteLine($"{string_21.Length}");

Console.ReadKey();
