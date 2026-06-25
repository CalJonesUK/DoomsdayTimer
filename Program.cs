Console.WriteLine("Welcome to dooms pin code entry, enter the wrong password and the world will end \n");
Thread.Sleep(3000); // 1000 milliseconds = 1 second
Console.WriteLine("Enter the pin code: ");

var pin = "1234"; // The correct pin code
var userInput = Console.ReadLine();

if (pin == userInput)
{
    Console.WriteLine("Pin code accepted, world is saved.");
}
else
{
    Console.WriteLine("Incorrect pin code. The world will end.");

    Console.WriteLine("5 \n");
    Thread.Sleep(1000); // 1000 milliseconds = 1 second

    Console.WriteLine("4 \n");
    Thread.Sleep(1000); // 1000 milliseconds = 1 second

    Console.WriteLine("3 \n");
    Thread.Sleep(1000); // 1000 milliseconds = 1 second

    Console.WriteLine("2 \n");
    Thread.Sleep(1000); // 1000 milliseconds = 1 second

    Console.WriteLine("1 \n");
}



Console.ReadKey(); //Prevents the console from closing immediately after running the program.gfg