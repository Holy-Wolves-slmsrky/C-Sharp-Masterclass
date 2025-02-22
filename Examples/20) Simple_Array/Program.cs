
/*
 * Arrays are collections of variables arranged in a specific order.
 * The purpose of arrays is to store, access, organize, and process data in an orderly manner.
 * Arrays are used to store elements of the same type (e.g., numbers, characters, objects) in a sequential way.
 * This allows data to be processed easily.

 * Arrays are fundamentally declared in two ways:

 * 1) By specifying the size.
 * data_type[] array_name = new data_type[array_size];

 * 2) By specifying the values.
 * data_type[] array_name = [value 1, value 2, value 3, ..., value n];
 * or
 * data_type[] array_name = {value 1, value 2, value 3, ..., value n};
 * When declaring an array by specifying values, each value should be separated by a comma (,).

 * In C#, array indices start from 0.
 * That means the elements are counted starting from 0, not 1.

 * Diziler, belirli bir düzen içinde sıralanan değişken topluluğudur.
 * Dizilerin amacı; verileri düzenli bir şekilde depolamak, erişmek, düzenlemek ve işlemektir.
 * Diziler, aynı türdeki elemanları (örneğin, sayılar, karakterler, nesneler) sıralı bir şekilde tutmak için kullanılır.
 * Bu sayede verilerin kolayca işlenmesi sağlanır.

 * Diziler temelde iki şekilde bildirilir:

 * 1) Boyut belirtilerek.
 * veri_tipi[] dizi_adı = new veri_tipi[dizi_boyutu]

 * 2) Değerler belirtilerek.
 * veri_tipi[] dizi_adı = [veri 1, veri 2, veri 3 , ... , veri n];
 * veya
 * veri_tipi[] dizi_adı = {veri 1, veri 2, veri 3 , ... , veri n};
 * Değer belirtilerek dizi bildirilirken, her veriyi virgül (,) ile ayırmak gerekir.

 * C# dilinde dizi indeksleri 0'dan başlar.
 * Yani, elemanlar 1'den değil, 0'dan başlayarak sayılır.
 */

/*
 * Without using an array, 5 'integer' type variables need to be created to store 5 scores.
 * This leads to unnecessary code repetition and reduces the readability of the program.

 * Dizi kullanmadan, 5 skor tutmak için 5 adet 'integer' tipinde değişken oluşturmak gerekir.
 * Bu durum, gereksiz kod tekrarlarına yol açar ve programın okunabilirliğini azaltır.
 */
int scoreOne = 3;
int scoreTwo = 5;
int scoreThree = 7;
int scoreFour = 9;
int scoreFive = 11;

/*
 * To store 5 scores using an array, 1 'integer' type array needs to be created.
 * This does not lead to unnecessary code repetition and increases the readability of the program.

 * Dizi kullanarak 5 skor tutmak için 1 adet 'integer' tipinde dizi oluşturmak gerekir.
 * Bu durum, gereksiz kod tekrarlarına yol açmaz ve programın okunabilirliğini arttırır.
 */
int[] myScores = [3, 5, 7, 9, 11];

/*
 * Indexes - İndeksler: [ 0] [ 1] [ 2] [ 3] [ 4]
 *  Values -  Değerler: [ 3] [ 5] [ 7] [ 9] [11]
 */
int[] myNumbers = new int[5];
myNumbers[0] = 3;
myNumbers[1] = 5;
myNumbers[2] = 7;
myNumbers[3] = 9;
myNumbers[4] = 11;

/*
 * This code will give an error because the 5th index corresponds to the 6th element.
 * The declared array, however, is a 5-element array.
 * In arrays, indices start from 0, and the last index should be one less than the size of the array.

 * Bu kod hata verir çünkü 5. indeks 6. elamana denk gelir.
 * Tanımlanan dizi ise 5 elamanlı bir dizidir.
 * Dizilerde indeksler 0'dan başlayıp, son indeks dizinin boyutunun bir eksiği kadar olmalıdır.
 */
//myNumbers[5] = 13;

/*
 * This code will give an error because the array's data type is integer.
 * An array defined with the integer data type cannot accept a value that is not of the integer type.
 * Type safety is ensured.

 * Bu kod hata verir çünkü dizinin veri tipi integer'dır.
 * Integer veri tipinde tanımlanan bir diziye, integer veri tipinin dışında bir değer atanamaz.
 * Tip güvenliği sağlanır.
 */
//myNumbers[6] = "number";

Console.WriteLine(myNumbers[0]);
Console.WriteLine(myNumbers[1]);
Console.WriteLine(myNumbers[2]);
Console.WriteLine(myNumbers[3]);
Console.WriteLine(myNumbers[4]);

/*
 * This code will give an error because the array has 5 elements, and the last index of the array is 4.
 * The 5th index is out of the array's bounds, so an error occurs.

 * Bu kod hata verir çünkü dizi 5 elemanlıdır ve dizinin son indeksi 4'tür.
 * 5. indeks dizinin dışında kalır, dolayısıyla bir hata oluşur.
 */
//Console.WriteLine(myNumbers[5]);

Console.ReadKey();
