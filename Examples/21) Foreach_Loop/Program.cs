
/*
 * The foreach loop is a loop used to access each element of a collection (array, list, etc.) one by one.
 * This loop allows performing operations on the elements of the collection in order.
 * It is commonly used for processing arrays or collections.
 * It focuses on processing each element without worrying about the size of the collection.
 * There is no need to manually check the size of the collection in the loop, which helps reduce errors.
 * With the foreach loop, you can only access the elements of the collection. You cannot modify the values of the elements.

 * foreach (var item in collection)
 * {
 *      Code to be executed.
 *      Operations on each item.
 * }

 * You can use a specific data type (e.g., int, string, etc.) instead of var here.
 * To maintain type safety or when working with objects, it is recommended to use the appropriate data type instead of var.

 * Foreach döngüsü, bir koleksiyon (dizi, liste, vb.) içindeki her bir öğeye tek tek erişmek için kullanılan bir döngüdür.
 * Bu döngü, koleksiyondaki elemanların sırasıyla işlemler yapmayı sağlar.
 * Genellikle diziler veya koleksiyonlar üzerinde işlem yapmak için tercih edilir.
 * Koleksiyonun boyutuna odaklanmadan sadece her öğe üzerinde işlem yapmaya odaklanır.
 * Döngüde koleksiyonun boyutunu manuel olarak kontrol etmeniz gerekmez, bu da hataları azaltır.
 * Foreach döngüsü ile koleksiyondaki öğelere sadece erişebilirsiniz. Öğelerin değerini değiştiremezsiniz. 

 * foreach (var eleman in koleksiyon)
 * {
 *      Çalıştırılacak kodlar.
 *      Her bir eleman üzerinde yapılacak işlem.
 * }

 * Burada kullanılan var yerine belirli bir veri tipi de (int, string, vb.) kullanılabilir.
 * Tip güvenliğini korumak için veya nesneler ile çalışıldığında var tipi yerine ilgili veri tipi kullanılmalıdır.
 */

string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

/*
 * Example of printing an array containing days to the screen using a for loop and a foreach loop.
 * Günleri içeren bir diziyi for döngüsü ve foreach döngüsü ile ekrana yazdırma örneği.
 */

foreach (var item in days)
{
    Console.WriteLine(item);
}

Console.WriteLine();

foreach (string item in days)
{
    Console.WriteLine(item);
}

Console.WriteLine();

/*
 * array_name.Length -> Gives the number of elements in the array.
 *   dizi_adı.Length -> Dizinin eleman sayısını verir.
 */

for (int counterFor = 0; counterFor < days.Length; counterFor++)
{
    Console.WriteLine(days[counterFor]);
}

/*
 * This code will give an error because with a foreach loop, you can only access the elements.
 * Bu kod hata verir çünkü foreach dögüsü ile sadece öğelere erişilebilir.
 */
//foreach (var item in days)
//{
//    item = "C#";
//}

Console.ReadKey();
