
/*
 * Break Point
 * Break Point allows us to examine the state of the application step by step by stopping the program at a specific line of code.
 * The following line has a break point (red button).
 * You can continue the code step by step with the "F10" key.

 * Bekleme Noktası
 * Bekleme Noktası, programı belirli bir kod satırında durdurarak uygulamanın durumunu adım adım incelememizi sağlar.
 * Aşağıdaki satırda bir bekleme noktası (kırmızı düğme) vardır.
 * "F10" tuşu ile kodu adım adım devam ettirebilirsiniz.
 */

int number1 = 10;

/*
 * Compile Error
 * A Compilation Error is an error detected by the compiler during the code compilation process, such as syntax errors or type mismatches.
 * The following code has a compilation error.
 * The reason for this error is that the code is not terminated with ";".
 * This error is a syntax error.

 * Derleme Hatası
 * Derleme Hatası, kod derleme işlemi sırasında derleyici tarafından tespit edilen sözdizimi hataları veya tür uyuşmazlıkları gibi bir hatadır.
 * Aşağıdaki kodda bir derleme hatası vardır.
 * Bu hatanın nedeni kodun ";" ile sonlandırılmamış olmasıdır.
 * Bu hata bir sözdizimi hatasıdır.
 */

/*
 * There is error in this code.
 * Bu kodda bir hata var.
 */
// int number2 = 0

/*
 * There is no error in this code.
 * Bu kodda bir hata yok.
 */
int number2 = 0;

/*
 * Runtime Error
 * A Runtime Error is an error that occurs while the program is running.
 * The following code has a runtime error.
 * The reason for this error is a Mathematical operation.
 * The division of a number by 0 is undefined and this operation is not possible.

 * Çalışma Zamanı Hatası
 * Çalışma Zamanı Hatası, program çalışırken meydana gelen bir hatadır.
 * Aşağıdaki kodda bir çalışma zamanı hatası vardır.
 * Bu hatanın nedeni Matematiksel bir işlemdir.
 * Bir sayının 0 ile bölümü tanımsızdır ve bu işlem mümkün değildir.
 */

Console.WriteLine($"{number1} / {number2} = {number1 / number2}");

Console.ReadKey();
