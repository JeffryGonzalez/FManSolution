
public class Program
{
    public static void Main(string[] args)
    {
       
        var enteredCommands = args[0];
        Console.WriteLine("Command Help");

        Console.WriteLine($"You entered '{enteredCommands}'");
        var commandRef = new CommandReference
        {
            Name = "kubectl",
            Description = "kubectl is for working with kubernetes",
            Examples = new List<CommandExample>
    {
        new CommandExample
        {
            Command = @"kubectl apply -f .\deployment.yaml",
            Description = "Apply this to the kubernetes api",

        },
        new CommandExample
        {
            Command = @"kubectl get namespaces",
            Description = "List all the namespaces in the current cluster"
        }
    }

        };
        Console.WriteLine(commandRef.Name);
        Console.WriteLine(commandRef.Description);

        Console.WriteLine(); // blank line.

        foreach (var example in commandRef.Examples)
        {
            Console.WriteLine(example.Command);
            Console.WriteLine(example.Description);
        }
    }
}

// Step 1 - create the data structures.
class CommandReference
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