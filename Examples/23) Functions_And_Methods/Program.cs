
#region English - Click
/*
 * A method is a block of code written to perform a specific task.
 * A method is a function that performs a specific purpose and can be reused repeatedly when needed.
 * Methods help in making the program more organized, readable, and reusable.
 * The main goal of methods is to provide reusability, avoid code repetition, and make the program more organized.

 * 1) Code Organization:
 * Methods help in breaking down the code into logical parts.
 * By dividing a complex program into smaller, more manageable pieces, each part becomes a functional unit on its own.

 * 2) Reusability:
 * Methods allow you to use the same task multiple times.
 * By writing a task once, you can call it whenever needed, thus avoiding code repetition.

 * 3) Debugging and Maintenance:
 * Methods are parts of the program that perform a specific function, making it easier to debug and maintain.
 * Fixing an error in one method is enough, so you don’t need to fix the error in multiple places.

 * 4) Abstraction:
 * Methods hide complex operations and provide only the necessary information.
 * When users call a method, they do not need to know how it works; they only need to know what it does and what it returns.

 * <Access Specifier> <Type> <Method Name> (Parameter List)
 * {
 *      Code the method will execute.
 * }

 * The Access Specifier indicates who can access a method. It defines the method’s access permissions.
 * Commonly used access specifiers in C# are:
 * public: The method can be accessed from anywhere.
 * private: The method can only be accessed within the class. It cannot be accessed by other classes.
 * protected: The method can only be accessed within the class itself and by derived classes.
 * internal: The method can only be accessed by other classes within the same project. External access is not allowed.
 * protected internal: The method can be accessed by other classes within the same project and also by derived classes.

 * Return Type specifies what type of value the method will return after execution.
 * If the method does not need to return anything, the return type is void.

 * Method Name is the name assigned to the method. This name represents the method’s purpose and is case-sensitive.
 * Example names:
 * Add(): A method used to add two numbers.
 * add(): A method used to add three numbers.
 * Print(): A method used to print something to the screen.

 * Parameter List determines what kind of data will be passed to the method when it is called.
 * These parameters are used to pass necessary information into the method to perform its function.
 * For example, in the Add(int a, int b) method, a and b are the parameters needed for the addition operation.

 * The Method Body is the block of code that performs the method's function.
 * For example, the body of the Add method could be:
 * {
 *      return a + b;
 * }

 * The return keyword is used to return a value to the calling code.
 * If the method needs to return a value, it is sent back using the return keyword.
 */
#endregion

#region Türkçe - Tıkla
/*
 * Yöntem, belirli bir amacı yerine getiren ve belirli bir işlemi gerçekleştiren bir kod bloğudur.
 * Yöntem, belirli bir amacı yerine getiren ve gerektiğinde tekrar tekrar kullanılabilen bir metoddur.
 * Yöntemler, programın düzenli, okunabilir ve tekrar kullanılabilir olmasına yardımcı olur.
 * Yöntemlerin temel amacı, yeniden kullanılabilirlik sağlamak, kod tekrarını önlemek ve programı daha organize hale getirmektir.

 * 1) Kodun Düzenlenmesi:
 * Yöntemler, kodu mantıklı bir şekilde parçalara ayırmanıza yardımcı olur.
 * Karmaşık bir programı daha küçük ve yönetilebilir parçalara bölerek, her bir parçayı kendi başına işlevsel bir birim haline getirirsiniz.

 * 2) Tekrar Kullanılabilirlik:
 * Yöntemler, aynı işlemi birden fazla kez kullanmanıza olanak tanır.
 * Bir işlemi bir kez yazıp, her ihtiyaç duyduğunuzda çağırarak, kod tekrarını engellersiniz.

 * 3) Hata Ayıklama ve Bakım:
 * Yöntemler, belirli bir işlevi yerine getiren bölümler olduğu için hata ayıklamak ve bakım yapmak daha kolaydır.
 * Hatalı bir metodun tek bir yerde düzeltilmesi yeterlidir, böylece başka bir yerde hata düzeltmek zorunda kalmazsınız.

 * 4) Soyutlama:
 * Yöntemler, karmaşık işlemleri gizleyerek yalnızca gerekli olan bilgiyi sağlar.
 * Kullanıcılar bir yöntemi çağırdığında nasıl çalıştığını bilmek zorunda değildir, sadece ne işe yaradığını ve ne döndürdüğünü bilirler.

 * <Erişim Belirleyici> <Tipi> <Yöntem Adı> (Parametre Listesi)
 * {
 *      Yöntemin çalıştıracağı kodlar.
 * }

 * Erişim Belirleyici, bir metodun kimler tarafından erişilebileceğini belirtir. Yani metodun erişim iznini tanımlar.
 * C# dilinde yaygın olarak kullanılan erişim belirleyiciler şunlardır:
 * 1) public: Metoda her yerden erişilebilir.
 * 2) private: Metoda yalnızca sınıfın içinde erişilebilir. Diğer sınıflardan erişilemez.
 * 3) protected: Metoda yalnızca sınıfın kendisi ve o sınıftan türetilmiş sınıflar tarafından erişilebilir.
 * 4) internal: Metoda yalnızca aynı proje içindeki diğer sınıflardan erişilebilir. Dışarıdan erişim mümkün değildir.
 * 5) protected internal: Metoda, hem aynı proje içindeki diğer sınıflardan hem de o sınıftan türetilmiş sınıflardan erişilebilir.

 * Dönüş Tipi, metodun çalıştıktan sonra hangi tipte bir değer döndüreceğini belirtir.
 * Eğer metodun herhangi bir şey döndürmesine gerek yoksa, dönüş türü void olur.

 * Yöntem Adı, metodun tanımlandığı isimdir. Bu isim, metodun ne işe yaradığını ifade eder ve büyük-küçük harf duyarlılığına sahiptir.
 * Örnek adlandırmalar:
 * Add(): İki sayıyı toplamak için kullanılan bir metodun adı olabilir.
 * add(): Üç sayıyı toplamak için kullanılan bir metodun adı olabilir.
 * Print(): Bir şeyin ekrana yazdırılması için kullanılan bir metodun adı olabilir.

 * Parametre Listesi, metodu çağırırken hangi tür verilerin yönteme iletileceğini belirler.
 * Bu parametreler, metodu çalıştırmak için gerekli bilgileri metodun içine iletmek amacıyla kullanılır.
 * Örneğin, Add(int a, int b) metodunda a ve b, toplama işlemi için gerekli olan iki parametreyi temsil eder.

 * Yöntem gövdesi, metodun işlevini yerine getiren kod bloğudur.
 * Örneğin, Add metodunun gövdesi şöyle olabilir:
 * {
 *      return a + b;
 * }

 * return anahtar kelimesi, metodu çağıran koda bir değer döndürmek için kullanılır.
 * Yöntem bir değer döndürecekse, bu değeri return ile geri gönderir.
 */
#endregion

/*
 * Example of defining a void method without parameters.
 * Parametresiz void tipi metod tanımlama örneği.
 */
void Write()
{
    Console.WriteLine("There is a code inside the method.\n");
}
Console.WriteLine("This is a code outside the method.");

/*
 * Example of defining a integer method without parameters.
 * Parametresiz integer tipi metod tanımlama örneği.
 */
int Add()
{
    return 5 + 10;
}

/*
 * Example of defining a void method with parameters.
 * Parametreli void tipi metod tanımlama örneği.
 */
void write(string text)
{
    Console.WriteLine("There is a code inside the method.");
    Console.WriteLine($"Entered text: {text}\n");
}

/*
 * Example of defining a integer method with parameters.
 * Parametreli integer tipi metod tanımlama örneği.
 */
int add(int numberOne, int numberTwo)
{
    int result = numberOne + numberTwo;
    return result;
}

/*
 * Example of calling a method.
 * Metod çağırma örneği.
 */

Write();

Console.Write("Please enter the text: ");
write(Console.ReadLine());

Console.WriteLine($"Result = {Add()}\n");

int userNumberOne = 0, userNumberTwo = 0;

do
{
    Console.Write("Please enter the first whole number: ");
}
while (!int.TryParse(Console.ReadLine(), out userNumberOne));

do
{
    Console.Write("Please enter the second whole number: ");
}
while (!int.TryParse(Console.ReadLine(), out userNumberTwo));

Console.WriteLine($"Result = {add(userNumberOne, userNumberTwo)}\n");

/*
 * This code will give an error because, just like in loops, variables in methods are only accessible within the block where they are declared.
 * Bu kodlar hata verir, çünkü döngülerde olduğu gibi yöntemlerde de değişkenler, bildirildikleri kod bloğu içerisinden erişilebilir.
 */
//text = "Test";
//result = 10;

string text = "C#";

int number = 0;
Console.WriteLine($"number is {number}");

AddNumbers(10, 15);

number = 10;
Console.WriteLine($"number is {number}");

void AddNumbers(int numberOne, int numberTwo)
{
    number = 20;
    Console.WriteLine($"number is {number}");

    int result = numberOne + numberTwo;
    Console.WriteLine($"Result = {result}");

    Console.WriteLine("Hello " + text);
}

/*
 * There are 3 things to pay attention to in this example:

 * 1) The method is declared on line 205, but it is called on line 201.
 * The line where the method is declared does not matter.
 * What matters is its access modifier and where it is defined within the code block.

 * 2) Method parameters are only valid within the method block.
 * Earlier, we defined the variables numberOne and numberTwo in a method called add().
 * Now, we have defined them in the AddNumbers() method.
 * The compiler did not throw an error because there are two variables with the same name.

 * 3) When a variable is defined outside of a method block, we can access the related variable from within the method block.
 * A method must return data of the type it is defined to return.
 * If operations are to be done with two different types, we define the variables inside the program block and can use them within the method block.
 * The best solution to this problem is to use objects or structures.

 * Bu örnekte dikkat edilmesi gereken 3 şey var:

 * 1) Metod 205 numaralı satırda bildiriliyor ama 201 numaralı satırda çağrılıyor.
 * Metodun hangi satırda bildirildiği önemli değildir.
 * Metodun erişim belirleyicisi ve hangi kod bloğu içinde tanımlandığı önemlidir.

 * 2) Metod parametreleri sadece metod bloğunu kapsar.
 * Daha önce numberOne ve numberTwo değişkenlerini add() adlı metotta tanımlamıştık.
 * Şimdi de AddNumbers() adlı metotta tanımladık.
 * Derleyici bize aynı ada sahip iki değişken olduğu için hata vermedi.

 * 3) Bir metod bloğunun dışında bir değişken tanımlandığında, metot bloğu içinden ilgili değişkene erişebiliriz.
 * Bir metod, tanımlandığı tipe ait veri döndürmek zorundadır.
 * Eğer iki farklı tip ile işlem yapılacak ise, değişkenleri program bloğu içinde tanımlarız ve metod bloğu içinde değişkenleri kullanabiliriz.
 * Bu soruna en iyi çözüm nesneleri veya yapıları kullanmaktır.
 */

Console.ReadKey();
