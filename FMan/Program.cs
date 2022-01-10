
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

public class Program
{
    public static void Main(string[] args)
    {

        var homeFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        var fmanDirectory = Path.Combine(homeFolder, ".fman");

        var filePath = Path.Combine(fmanDirectory, "commands.yaml");

        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(new UnderscoredNamingConvention())
            .Build();

        var fileContent = File.ReadAllText(filePath);
        var commandList = deserializer.Deserialize<CommandsList>(fileContent);
       

        foreach(var command in commandList.Commands)
        {
            Console.WriteLine(command.Name);
            Console.WriteLine(command.Description);
            foreach(var example in command.Examples)
            {
                Console.WriteLine("\t" + example.Command);
                Console.WriteLine("\t" + example.Description);
            }
        }
        //var enteredCommands = args[0];
        //Console.WriteLine("Command Help");

        //Console.WriteLine($"You entered '{enteredCommands}'");


        //Console.WriteLine(commandRef.Name);
        //Console.WriteLine(commandRef.Description);

        //Console.WriteLine(); // blank line.

        //foreach (var example in commandRef.Examples)
        //{
        //    Console.WriteLine(example.Command);
        //    Console.WriteLine(example.Description);
        //}
    }
}

// Step 1 - create the data structures.
class Commands
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";

    public List<CommandExample> Examples { get; set; } = new List<CommandExample>();
}

class CommandExample
{
    public string Command { get; set; } = "";
    public string Description { get; set; } = "";
}
class CommandsList
{
    public float Version { get; set; }
    public List<Commands> Commands{get; set; } = new List<Commands>();
}