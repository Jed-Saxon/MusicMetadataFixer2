Print("Hello, World!");
DirectoryInfo start = GetDirectoryFromUser("Enter unsorted directory: ");
DirectoryInfo end = GetDirectoryFromUser("Enter output directory: ");
Print("--- Starting sort ---");

OnError += Error;
Fix(start, end);
OnError -= Error;

Print("Finished!", colour: ConsoleColor.Green);

void Error(string msg)
{
    Print($"ERROR: {msg}", colour: ConsoleColor.Red);
}