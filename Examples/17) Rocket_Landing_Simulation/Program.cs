
string rocket =
@"
            _
           / \
          /   \
         /     \
        /       \
       /         \
      /           \
     /-------------\
      \           /
       |---|-|---|
       |   | |   |
       |   | |   |
       |   | |   |
       |   | |   |
       |---|-|---|
        \  | |  /
         | | | |
         | | | |
         | | | |
         | | | |
         | | | |
        /  | |  \
       /   | |   \
      /    | |    \
     /_____|_|_____\
     \     | |     /
      \    | |    /
       \___|_|___/
           | |
           | |
          _|_|_
         (_____)
       ) \     / (
        ) \   / (
         ) \ / (
          ) - (
";

string floor = "-------------------------";

int topValue = 10;

for (int counter = 0; counter < topValue; counter++)
{
    floor = floor.Insert(0,"\r\n");
}

for (int counter = 0; counter < topValue; counter++)
{
    rocket = "\r\n" + rocket;
    Console.WriteLine(rocket);

    floor = floor.Substring(2);
    Console.Write(floor);

    /*
     * This line pauses the console application for the specified milliseconds (1000 ms = 1 second).
     * In other words, it temporarily pauses the program's execution.

     * Bu satır, konsol uygulamasını belirtilen milisaniye (1000 ms = 1 saniye) kadar bekletir.
     * Yani, programın çalışmasını geçici olarak durdurur.
     */
    Thread.Sleep(1000);

    /*
     * This line clears the console screen.
     * Bu satır, konsol ekranını temizler.
     */
    if (counter != topValue - 1)
        Console.Clear();
}

Console.WriteLine("The rocket has landed. Woohoo! Another successful landing!");

Console.ReadKey();
