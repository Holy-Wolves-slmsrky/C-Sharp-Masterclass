
/*
 * This is a classic project template in the C# language.
 * If you select the "Do not use top-level statements" option when creating a project in Visual Studio, Visual Studio will automatically generate this template for you.
 * You can also write this template from scratch.
 * Before the .Net 6.0 update, C# projects were generally started with this template.
 * The main difference in this template is the project name written after the "namespace" keyword.
 * All other code is almost identical in every program.

 * Bu, C# dilindeki klasik bir proje şablonudur.
 * Visual Studio'da bir proje oluştururken "Üst Düzey Deyimleri Kullanmayın" seçeneğini işaretlerseniz, Visual Studio otomatik olarak bu şablonu oluşturur.
 * Ayrıca, bu şablonu sıfırdan da yazabilirsiniz.
 * .Net 6.0 güncellemesinden önce, C# projeleri genellikle bu şablonla başlatılırdı.
 * Bu şablondaki temel fark, "namespace" anahtar kelimesinin ardından yazılan proje ismidir.
 * Diğer tüm kodlar, neredeyse her programda aynıdır.
 */

/*
 * 1) The namespace keyword:
 * In C#, the namespace keyword allows you to organize your code by grouping related classes, structs, interfaces, and other types in a logical and structured way.
 * A namespace brings together types that serve similar purposes.
 * This helps make the program more readable and manageable.
 * Additionally, it allows you to avoid name conflicts by using the same class names in different namespaces.
 * For example, classes with the same name in two different namespaces can be used independently of each other because each is defined in a different namespace.

 * 1) namespace anahtar kelimesi:
 * C# dilinde namespace anahtar kelimesi, kodunuzu mantıklı ve düzenli bir şekilde gruplayarak organize etmenizi sağlar.
 * Bir namespace, aynı işlevi gören sınıflar, yapılar, arayüzler ve diğer türleri bir araya toplar.
 * Bu, programın daha okunabilir ve yönetilebilir olmasına yardımcı olur.
 * Ayrıca, farklı namespace içinde aynı isimde sınıflar kullanarak isim çakışmalarını önlemenize olanak tanır.
 * Örneğin, iki farklı namespace içinde aynı isimdeki sınıflar, birbirinden bağımsız olarak kullanılabilir çünkü her biri farklı bir isim alanında tanımlıdır.
 */
namespace Old_CSharp_Template
{
    /*
     * 2) The class keyword:
     * In C#, the class keyword is used to define a class.
     * A class is a blueprint that combines the properties (variables) and behaviors (methods) of an object.
     * A class is one of the fundamental building blocks of object-oriented programming and serves as a "template" to create objects.
     * A class represents entities or concepts from the real world in software.
     * For example, a "Car" class may contain information about the car's properties (such as color, model, speed) and behaviors (such as acceleration, braking).
     * Within a class, variables (fields) and methods (functions) are defined.
     * An instance (object) of a class can be created, and the object's properties and methods can be accessed through it.
     * You can open the Solution Explorer with the "Control + Alt + L" keyboard shortcut.
     * In the Solution Explorer, there is a file named Program.cs.
     * This file contains the main class where we write our code.
     * In C# projects, the main class is typically named Program.

     * 2) class anahtar kelimesi:
     * C# dilinde class anahtar kelimesi, bir sınıf tanımlamak için kullanılır.
     * Sınıf, bir nesnenin özelliklerini (değişkenler) ve davranışlarını (metodlar) bir araya getiren bir şablondur.
     * Bir sınıf, nesne tabanlı programlamanın temel yapı taşlarından biridir ve nesnelerin oluşturulabilmesi için bir "şablon" işlevi görür.
     * Sınıf, gerçek dünyadaki varlıkların veya kavramların yazılımda temsilidir.
     * Örneğin, bir "Araba" sınıfı, arabanın özellikleri (renk, model, hız gibi) ve davranışları (hızlanma, fren yapma gibi) hakkında bilgileri içerebilir.
     * Sınıf içinde değişkenler (alanlar) ve metodlar (işlevler) tanımlanır.
     * Bir sınıfın örneği (nesnesi) oluşturulabilir ve o nesne üzerinden sınıfın özelliklerine ve metodlarına erişilebilir.
     * "Control + Alt + L" tuş kombinasyonu ile Çözüm Gezginini açabilirsiniz.
     * Çözüm Gezgininde, Program.cs adında bir dosya bulunur.
     * Bu dosya, kodlarımızı yazdığımız ana sınıfı içerir.
     * C# projelerinde genellikle ana sınıfın adı Program olarak belirlenir.
     */
    internal class Program
    {
        /*
         * A variable defined inside a class is called a "field".
         * A variable defined inside a method is called a "local variable".
         * Fields can be used anywhere within the class.

         * Bir sınıfın içerisinde tanımlanan değişken, "alan" olarak adlandırılır.
         * Bir metodun içerisinde tanımlanan değişken, "yerel değişken" olarak adlandırılır.
         * Alanlar sınıfın her yerinde kullanılabilir.
         */
        static int result;

        /*
         * This expression defines the first method where C# programs start.
         * The Main method is the entry point of a C# application.
         * When the program starts, the Main method is automatically executed.

         * 1) static
         * The static keyword indicates that this method is not tied to an instance of the class.
         * This means the Main method can be called directly by the class name without creating an instance of the class.
         * When C# applications start, static methods are executed first because they can be called before any object is created.

         * 2) string[] args
         * This parameter holds arguments that come from the command line or another source.
         * If the user provides extra information on the command line when starting the program, this information is passed to the args array.
         * args is an array, and each element in it is a string value.

         * Bu ifade, C# programlarının başladığı ilk metodu tanımlar.
         * Main metodu, bir C# uygulamasının başlangıç noktasıdır.
         * Program başladığında, Main metodu otomatik olarak çalıştırılır.

         * 1) static
         * static anahtar kelimesi, bu metodun sınıfın bir örneğine bağlı olmadığını belirtir.
         * Yani, Main metodu, sınıfın herhangi bir örneği oluşturulmadan doğrudan sınıf adıyla çağrılabilir.
         * C# uygulamaları başlatıldığında, ilk olarak static metodlar çalıştırılır, çünkü herhangi bir nesne yaratılmadan önce bu metod çağrılabilir.

         * 2) string[] args
         * Bu parametre, komut satırından veya başka bir kaynaktan gelen argümanları tutar.
         * Kullanıcı, programı başlatırken komut satırına ekstra bilgileri girerse, bu bilgiler args adlı diziye aktarılır.
         * args, bir dizi olup, her elemanı bir string değeridir.
         */
        static void Main(string[] args)
        {
            /*
             * In previous projects, we used top-level statements.
             * This means we were running our programs without writing this code.
             * The code we wrote would automatically be placed inside the Main method.

             * Bundan önceki projeleri, üst deyimleri kullanarak yazıyorduk.
             * Yani, bu kodları yazmadan programlarımızı çalıştırıyorduk.
             * Bizim yazdığımız kodlar otomatik olarak Main metodunun içerisine yazılıyordu.
             */
            Console.WriteLine("Hello, World!");

            Console.WriteLine($"Result = {sum(10,15)}");

            /*
             * We defined a method without using the static keyword.
             * Therefore, we need to create an instance of the class and access the method through that instance.

             * static anahtar kelimesini kullanmadan bir metot tanımladık.
             * Bu nedenle, sınıfın bir nesnesini oluşturmalı ve bu nesne üzerinden ilgili metoda erişmeliyiz.
             */
            Program myProgram = new Program();
            Console.WriteLine(myProgram.add(10,15));

            Console.ReadKey();
        }

        /*
         * Previously, we used to write our methods inside the Main method.
         * Now, we will write our methods outside the Main method.

         * The reasons for doing this are as follows:

         * 1) Readability:
         * If we write all the code inside the Main method, the program may become confusing and harder to understand over time.
         * By defining methods separately, we ensure that each function has its place and responsibility.
         * This makes both reading and understanding the code easier.

         * 2) Reusability:
         * If we write a method inside the Main method, we can only use it within the Main method.
         * However, if we define a method outside the Main method, we can reuse the same method elsewhere.
         * This prevents code repetition.

         * 3) Ease of Maintenance:
         * As the code grows and becomes more complex, defining methods outside makes it easier to locate and fix errors.
         * If there is a functional error, finding where the function is defined and fixing just that part becomes much simpler.

         * 4) Modularity:
         * Making programs more modular means breaking the code into different parts.
         * This allows for independent work on each part and provides more flexibility in projects.

         * Daha önce metotlarımızı Main metodumuzun içerisinde yazıyorduk.
         * Şimdi ise metotlarımızı Main metodunun dışında yazacağız.

         * Bunu yapmamızın sebepleri şunlardır:

         * 1) Okunabilirlik:
         * Eğer tüm kodları Main metodunun içinde yazarsak, program zamanla karışabilir ve zor anlaşılır hale gelebilir.
         * Metodları ayrı ayrı tanımlayarak, her bir işlevin kendi yerinde ve kendi sorumluluğunda olmasını sağlarız.
         * Bu, hem kodun okunmasını hem de anlaşılmasını kolaylaştırır.

         * 2) Yeniden Kullanılabilirlik
         * Eğer bir metodu Main metodunun içinde yazarsak, o metodu sadece Main metodunun içinde kullanabiliriz.
         * Oysa, bir metodu Main dışında tanımlarsak, başka yerlerde de aynı metodu tekrar kullanabiliriz.
         * Bu, kod tekrarını önler.

         * 3) Bakım Kolaylığı:
         * Kod büyüdükçe ve daha karmaşık hale geldikçe, metodların dışarıda tanımlanması, hataları bulmayı ve düzeltmeyi daha kolay hale getirir.
         * Eğer bir işlevsel hata varsa, o fonksiyonun tanımlı olduğu yeri bulmak ve sadece o kısmı düzeltmek çok daha basit olacaktır.

         * 4) Modülerlik:
         * Programları daha modüler hale getirmek, kodu farklı parçalara bölmek anlamına gelir.
         * Bu, her bir parça üzerinde bağımsız çalışılmasını sağlar ve projelerde daha fazla esneklik yaratır.
         */

        static int sum(int numberOne, int numberTwo)
        {
            result = numberOne + numberTwo;
            return result;
        }

        int add(int numberOne, int numberTwo)
        {
            result = numberOne + numberTwo;
            return result;
        }
    }
}
