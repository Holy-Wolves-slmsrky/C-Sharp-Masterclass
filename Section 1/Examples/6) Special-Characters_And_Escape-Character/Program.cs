
#region English - Click
/*
 * ~ Reserved Characters in C# ~
 * In C#, certain characters are reserved for specific uses. These characters play a critical role in the structure and functioning of C# code.
 * 1) Brackets "{ }" are used to identify a scope or block of code, such as methods, loops, conditional statements and class definitions.
 * 2) Parentheses "( )" used for method calls and declarations, controlling order of operations in expressions, and surrounding conditions in control structures like if, for, while, etc.
 * 3) Square Brackets "[ ]" used for array type declarations and accessing array elements. Also used in attributes.
 * 4) Semicolon ";" used to terminate statements.
 * 5) The Colon ":" is used in conditional (ternary) operator expressions, in swich expressions (when specifying the case block), when implementing interfaces, and when specifying from which a class derives.
 * 6) Commas "," are used to separate items in lists, to separate parameters or variables in methods.
 * 7) The Period "." is used to access members of a class or namespace, such as methods or properties.
 * 8) Question Mark "?" used in nullable type declarations and the null-conditional operators. Also part of the conditional (ternary) operator.
 * 9) Plus "+" used as an arithmetic operator and to concatenate strings. Also used to denote unary plus or to define overloaded operators.
 * 10) Minus "-" used as an arithmetic operator, to indicate a negative number, or to define overloaded operators.
 * 11) Asterisk "*" used as an arithmetic operator for multiplication, to denote pointer types, or to define overloaded operators.
 * 12) Slash "/" used as an arithmetic operator for division. Also starts comment lines.
 * 13) Percentage "%" used as the modulus operator.
 * 14) Ampersand "&" used for the 'address-of' operator in unsafe code, logical AND, and bitwise AND. Also used in method signatures to indicate a reference parameter.
 * 15) Pipe "|" used for logical OR and bitwise OR.
 * 16) Caret "^" used for bitwise XOR.
 * 17) Exclamation Mark "!" used to denote logical negation.
 * 18) Tilde "~" used for bitwise NOT and to define destructor methods in classes.
 * 19) Angle Brackets "<, >" used in generic type definitions and methods, as well as for less than and greater than comparisons.
 * 20) Equals "=" used for assignment (==) and to test equality when paired with another equals sign (=>, <=). Also used in lambda expressions.
 * 21) At Sign "@" used as a prefix to indicate a verbatim string literal, where escape sequences are ignored, or to use keywords as identifiers.
 * 22) Dollar Sign "$" used to denote string interpolation, allowing variables to be embedded directly within string literals.
 * 23) Backslash "\" used as an escape character in string literals. For example, for a new line (\n) or for a tab (\t).
 * 24) Hash "#" used in preprocessor directives, such as #define, #if, #else, #endif, #region and #endregion.

 * These characters are integral to the structure and syntax of C# code, and they are reserved for these purposes. Using them outside of their designated roles typically requires escaping or special syntax to avoid compiler errors. Understanding the specific roles of these characters helps in writing effective and error-free C# code.
 */
#endregion

#region Türkçe - Tıkla
/*
 * ~ C#'ta Ayrılmış Karakterler ~
 * C#'ta belirli karakterler özel kullanımlar için ayrılmıştır. Bu karakterler C# kodunun yapısı ve işleyişinde kritik bir rol oynar.
 * 1) Süslü Parantezler "{ }", yöntemler, döngüler, koşullu ifadeler ve sınıf tanımları gibi bir kod kapsamını veya bloğunu tanımlamak için kullanılır.
 * 2) Parantezler "( )", yöntem çağrıları ve bildirimleri için, ifadelerdeki işlem sırasını kontrol etmek için ve if, for, while gibi kontrol yapılarındaki koşulları çevrelemek için kullanılır.
 * 3) Köşeli Parantezler "[ ]", dizi tipi bildirimleri ve dizi elemanlarına erişim için kullanılır. Özniteliklerde de kullanılır.
 * 4) Noktalı Virgül ";", ifadeleri sonlandırmak için kullanılır.
 * 5) İki Nokta Üst Üste ":", koşullu (üçlü) operatör ifadelerinde, swich ifadelerinde (case bloğunu belirtirken), arayüzleri uygularken ve bir sınıfın hangi sınıftan türediğini belirtirken kullanılır.
 * 6) Virgül "," listelerdeki öğeleri ayırmak, yöntemlerdeki parametreleri veya değişkenleri ayırmak için kullanılır.
 * 7) Nokta ".", yöntemler veya özellikler gibi bir sınıfın veya ad alanının üyelerine erişmek için kullanılır.
 * 8) Soru İşareti "?", nullable tip bildirimlerinde ve null koşullu operatörlerde kullanılır. Ayrıca koşullu (üçlü) operatörün bir parçasıdır.
 * 9) Artı "+", aritmetik operatör olarak ve dizeleri birleştirmek için kullanılır. Ayrıca tekli artıyı belirtmek veya aşırı yüklenmiş operatörleri tanımlamak için de kullanılır.
 * 10) Eksi "-", aritmetik operatör olarak, negatif bir sayıyı belirtmek için veya aşırı yüklenmiş operatörleri tanımlamak için kullanılır.
 * 11) Yıldız "*", çarpma işlemi için aritmetik operatör olarak, işaretçi tiplerini belirtmek için veya aşırı yüklenmiş operatörleri tanımlamak için kullanılır.
 * 12) Eğik Çizgi "/", bölme işlemi için aritmetik operatör olarak kullanılır. Ayrıca yorum satırlarını başlatır.
 * 13) Yüzde "%", modül operatörü olarak kullanılır.
 * 14) Ampersand "&" güvenli olmayan kodda 'address-of' operatörü, mantıksal AND ve bitsel AND için kullanılır. Ayrıca yöntem imzalarında bir referans parametresini belirtmek için kullanılır.
 * 15) Düz Çizgi "|", mantıksal VEYA ve bitsel VEYA için kullanılır.
 * 16) Şapka "^", bitsel XOR için kullanılır.
 * 17) Ünlem İşareti "!", mantıksal olumsuzlamayı belirtmek için kullanılır.
 * 18) Tilde "~", bitsel NOT için ve sınıflardaki yıkıcı yöntemleri tanımlamak için kullanılır.
 * 19) Büyük, Küçük İşareti "<, >", genel tip tanımları ve metotlarının yanı sıra küçüktür ve büyüktür karşılaştırmaları için kullanılır.
 * 20) Eşittir "=", atama (==) için ve başka bir eşittir işaretiyle (=>, <=) eşleştirildiğinde eşitliği test etmek için kullanılır. Lambda ifadelerinde de kullanılır.
 * 21) Ât İşareti "@", kaçış dizilerinin göz ardı edildiği harfi harfine bir dize değişmezini belirtmek veya anahtar sözcükleri tanımlayıcı olarak kullanmak için bir önek olarak kullanılır.
 * 22) Dolar İşareti "$", dize enterpolasyonunu belirtmek için kullanılır ve değişkenlerin doğrudan dize değişmezlerinin içine gömülmesine olanak tanır.
 * 23) Ters Eğik Çizgi "\" dize değişmezlerinde kaçış karakteri olarak kullanılır. Örneğin, yeni bir satır (\n) veya bir sekme (\t) için.
 * 24) Hash "#" #define, #if, #else, #endif, #region ve #endregion gibi önişlemci direktiflerinde kullanılır.

 * Bu karakterler C# kodunun yapısı ve sözdiziminin ayrılmaz parçalarıdır ve bu amaçlar için ayrılmışlardır. Belirlenen rolleri dışında kullanılmaları, derleyici hatalarını önlemek için genellikle kaçış veya özel sözdizimi gerektirir. Bu karakterlerin belirli rollerini anlamak, etkili ve hatasız C# kodu yazmaya yardımcı olur.
 */
#endregion

// Use Of Escape Characters - Kaçış Karakterleri Kullanımı

Console.WriteLine("This is a \"string\" with a backslash \\.");

/*
 * This code gives an error (compile error). Because (" and \) signs are special characters.
 * Bu kod bir hata (derleme hatası) verir. Çünkü (" ve \) işaretleri özel karakterdir.
 */
//Console.WriteLine("This is a "string" with a backslash \.");

// New Line - Yeni Satır
Console.WriteLine("This is a \n new line.");

// Tab Line - Satır Başı
Console.WriteLine("\t This is a tab line.");

Console.ReadKey();
