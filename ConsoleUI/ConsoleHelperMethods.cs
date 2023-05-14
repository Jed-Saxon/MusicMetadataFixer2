namespace MusicMetadataFixer2;

public class ConsoleHelperMethods
{
    public static void Print(string msg, bool writeLine = true, ConsoleColor colour = ConsoleColor.White)
    {
        Console.ForegroundColor = colour;
        if (writeLine) Console.WriteLine(msg);
        else Console.Write(msg);
        Console.ResetColor();
    }

    public static DirectoryInfo GetDirectoryFromUser(string msg)
    {
        while (true)
        {
            Print(msg, false);
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Print("Please enter a valid directory");
                continue;
            }

            DirectoryInfo directory = new(input);

            if (directory.Exists)
            {
                Print("This is a valid directory", colour: ConsoleColor.Green);
                return directory;
            }

            Print("Please enter a valid directory", colour: ConsoleColor.Red);
        }

        throw new NotImplementedException();
    }
}