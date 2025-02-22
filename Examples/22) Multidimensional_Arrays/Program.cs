
/*
 * Multidimensional arrays are defined similarly to simple arrays but include additional distinctions based on the number of dimensions.
 * Each dimension requires an index to be specified.
 * When defining multidimensional arrays, a comma (,) is used to separate dimensions.
 * For example, when defining a two-dimensional array, two variables representing the size of each dimension are used.

 * As an example, a declaration of a two-dimensional array can be written as:
 * int[,] myArray = new int[2, 3];

 * In this example, a two-dimensional array named 'myArray' is created with 2 rows and 3 columns.
 * The first dimension (row count) is 2, and the second dimension (column count) is 3.
 * In multidimensional arrays, each dimension is defined separately, and each element in the array can be accessed through these dimensions.

 * Curly braces '{}' are used to group the elements of the array. Each inner brace represents a row of the array.
 * In the assignment process, each row is defined within its own curly braces, and the elements within each row are separated by commas ','.

 * Çok boyutlu diziler, tıpkı basit diziler gibi tanımlanır, ancak farklı bir yapıya sahip olmak için boyut sayısına göre ek ayrımlar içerir.
 * Bu dizilerde her boyut için bir indeks belirtmeniz gerekir.
 * Birçok boyutlu dizinin tanımlanmasında, boyutlar arasına virgül (,) eklenir.
 * Örneğin, iki boyutlu bir dizi tanımlarken her bir boyutun büyüklüğünü belirten iki değişken kullanılır.

 * Örnek olarak, bir iki boyutlu dizi tanımlamak için şu şekilde bir bildirim yapılabilir:
 * int[,] myArray = new int[2, 3];

 * Bu örnekte myArray adında 2 satır ve 3 sütun içeren bir iki boyutlu dizi oluşturulmuştur.
 * İlk boyut (satır sayısı) 2, ikinci boyut (sütun sayısı) ise 3 olarak belirtilmiştir.
 * Çok boyutlu dizilerde, her bir boyut için ayrı ayrı boyutlar tanımlanır ve dizinin her elemanına bu boyutlar üzerinden erişilebilir.

 * Küme parantezleri '{}', dizinin öğelerini gruplamak için kullanılır. Her bir iç küme, dizinin bir satırını temsil eder.
 * Atama işleminde, her satır kendi küme parantezleri içinde tanımlanır ve her satırdaki öğeler virgül ile ',' ayrılır.
 */

int[,] simpleExample = { { 1, 2 } , { 3 , 4} , { 5, 6} };
/*
 * [row index - satır numarası] [value - değer] [value - değer]
 * [0] [1] [2]
 * [1] [3] [4]
 * [2] [5] [6]
 */

for (int firstCounter = 0; firstCounter < 3; firstCounter++)
{
    for (int secondCounter = 0; secondCounter < 2; secondCounter++)
    {
        Console.WriteLine($"simpleExample[{firstCounter}, {secondCounter}] = {simpleExample[firstCounter, secondCounter]}");
    }
}

Console.WriteLine();

/*
 * Assigning an initial value to the array is not mandatory.
 * Values can be assigned later, as shown in the example below.

 * Diziye başlangıç değeri atamak zorunlu değildir.
 * Sonradan atanacak değerler aşağıdaki örnekte olduğu gibi atanır.
 */
simpleExample[0, 0] = 7;

Console.WriteLine($"simpleExample[0, 0] = {simpleExample[0, 0]}");

Console.WriteLine();

char[,] ticTacToe =
{
    { 'X', 'O', 'X'},
    { 'O', 'X', 'O'},
    { 'O', 'O', 'X'}
};
/*
 * [row index - satır numarası] [value - değer] [value - değer]
 * [0] [X] [O] [X]
 * [1] [O] [X] [O]
 * [2] [O] [O] [X]
 */

for (int firstCounter = 0; firstCounter < 3; firstCounter++)
{
    for (int secondCounter = 0; secondCounter < 3; secondCounter++)
    {
        Console.Write($"{ticTacToe[firstCounter, secondCounter]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

/*
 * In this array, values are assigned based on the index values.
 * The coordinate (0,0) gives the first element of the array. (That is, the value "0,0")
 * The coordinate (2,2) gives the last element of the array. (That is, the value "2,2")

 * Bu dizide değerler, indeks değerlerine göre atanmıştır.
 * 0,0 koordinatı dizinin ilk elemanını verir. (Yani "0,0" değerini)
 * 2,2 koordinatı dizinin son elemanını verir. (Yani "2,2" değerini)
 */
string[,] indexExample =
{
    { "0,0", "0,1", "0,2" },
    { "1,0", "1,1", "1,2" },
    { "2,0", "2,1", "2,2" },
};

for (int firstCounter = 0; firstCounter < 3; firstCounter++)
{
    for (int secondCounter = 0; secondCounter < 3; secondCounter++)
    {
        Console.WriteLine($"indexExample[{firstCounter}, {secondCounter}] = {indexExample[firstCounter, secondCounter]}");
    }
    Console.WriteLine();
}

Console.WriteLine();

string[,,] simple3DArray =
// 1. Boyut
{
    // 2. Boyut
    {
        // 3. Boyut
        { "0,0,0", "0,0,1", "0,0,2"},
        { "0,1,0", "0,1,1", "0,1,2"}
    },

    {
        { "1,0,0", "1,0,1", "1,0,2"},
        { "1,1,0", "1,1,1", "1,1,2"}
    },

    {
        { "2,0,0", "2,0,1", "2,0,2"},
        { "2,1,0", "2,1,1", "2,1,2"}
    }
};

for (int firstCounter = 0; firstCounter < 3; firstCounter++)
{
    for (int secondCounter = 0; secondCounter < 2; secondCounter++)
    {
        for (int thirdCounter = 0; thirdCounter < 3; thirdCounter++)
        {
            Console.WriteLine($"simple3DArray[{firstCounter},{secondCounter},{thirdCounter}] = {simple3DArray[firstCounter, secondCounter, thirdCounter]}");
        }
    }
    Console.WriteLine();
}

Console.ReadKey();
