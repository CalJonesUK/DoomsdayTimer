Console.WriteLine("PA system: 10 minutes of oxygen remaining. \n"); //As the player is coming to, they hear a PA system announcement warning them of the limited oxygen supply.
Thread.Sleep(5000);
Console.Clear();
Console.WriteLine("You wake up, Trapped inside a capsule. Upon coming to your senses, you realize you are floating in space.\n\nYou look around and see a small LCD control panel in front of you. ");
Thread.Sleep(10000);
Console.Clear();
//--------------------------------------------------------------------------------------------------------------------------------

Console.WriteLine("Do you investigate the panel? \n ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Y / N: ");

string investigate = Console.ReadLine().ToUpper();
Console.ResetColor();
Console.Clear();

if (investigate == "Y" || investigate == "YES")
{
    Console.WriteLine("You investigate panel, here is what you find:\n\nThe dusk settles softly, and starlight begins its jo1urney.\r\nOld tales drift on the wind, carrying se2crets long forgotten.\r\nShadows move with quiet grace, weaving my3steries in the dark.\r\nAnd those who listen closely may uncov4er what others miss.\r\n");
    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine("Press Enter when ready...");
    Console.ReadKey();
    Console.ResetColor();
    Console.Clear();
}
else if (investigate == "N" || investigate == "NO") //This response would trigger a death screen. Ending the program.
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("██╗   ██╗ ██████╗ ██╗   ██╗    ██████╗ ██╗██████╗ \r\n██║   ██║██╔═══██╗██║   ██║    ██╔══██╗██║██╔══██╗\r\n██║   ██║██║   ██║██║   ██║    ██████╔╝██║██║  ██║\r\n╚██╗ ██╔╝██║   ██║██║   ██║    ██╔══██╗██║██║  ██║\r\n ╚████╔╝ ╚██████╔╝╚██████╔╝    ██████╔╝██║██████╔╝\r\n  ╚═══╝   ╚═════╝  ╚═════╝     ╚═════╝ ╚═╝╚═════╝ "); 
    Thread.Sleep(2000);
    Environment.Exit(0); //Used to terminate the program immediately after the player dies.
}
//--------------------------------------------------------------------------------------------------------------------------------


Console.WriteLine("Doomsday Timer: Pin authentication required \n");
Thread.Sleep(1000); // 1000 milliseconds = 1 second
Console.Write("Authentication code: "); //Console.Write() is used to keep the cursor on the same line after printing the text.

string pin = "1234"; // The correct pin code
string userInput = Console.ReadLine();

if (userInput == pin)
{
    Console.WriteLine("Authentication accepted: Failsafe deactivated.");
    Thread.Sleep(5000);
    Console.Clear();
    Console.WriteLine("'PA System: Failsafe deactivated. Oxygen supply restored, capsule power restored'\n");
    Thread.Sleep(5000);
    Console.Clear();
    Console.WriteLine("TBC");
    Thread.Sleep(5000);
    Environment.Exit(0); //Remove "Environment.Exit(0)" if you carry on the story, this is just a placeholder for now.
}
else
{
    Console.WriteLine("Authentication failed: Failsafe initiated. \n");

    for (int countdown = 5; countdown > 0; countdown--)
    {
        Console.WriteLine("Countdown:" + countdown);
        Thread.Sleep(1000); // 1000 milliseconds = 1 second
        Console.Clear();
    }

    Console.WriteLine("Failsafe triggered: Earth destruction completed. You have 2 minutes of oxygen remaining.");
    Thread.Sleep(5000);
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("██╗   ██╗ ██████╗ ██╗   ██╗    ██████╗ ██╗██████╗ \r\n██║   ██║██╔═══██╗██║   ██║    ██╔══██╗██║██╔══██╗\r\n██║   ██║██║   ██║██║   ██║    ██████╔╝██║██║  ██║\r\n╚██╗ ██╔╝██║   ██║██║   ██║    ██╔══██╗██║██║  ██║\r\n ╚████╔╝ ╚██████╔╝╚██████╔╝    ██████╔╝██║██████╔╝\r\n  ╚═══╝   ╚═════╝  ╚═════╝     ╚═════╝ ╚═╝╚═════╝ ");
    Thread.Sleep(2000);
    Environment.Exit(0);
}