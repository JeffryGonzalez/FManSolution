Console.WriteLine("Command Help");

Console.WriteLine("You entered 'kubectl'");
var commandRef = new CommandReference
{
    CommandName = "kubectl",
    CommandDescription = "kubectl is for working with kubernetes",
    Examples = new List<CommandReference>
    {
        new CommandReference { 
            CommandName = @"kubectl apply -f .\deployment.yaml",
            CommandDescription ="This will apply the deployment file to the kubernetes API)"
        }
    }
    
};
//Console.WriteLine("kubectl is for working with kubernetes");
//Console.WriteLine("Here are some examples of commands using kubectl");

//Console.WriteLine(); // blank line.

//var example1 = @"Command:
//kubectl apply -f .\deployment.yaml

//(this will apply the deployment file to the kubernetes API)";
//var example2 = @"Command:
//kubectl get namespaces

//(this will list all the namespaces in your current cluster)";

//Console.WriteLine(example1);
//Console.WriteLine(example2);

// Step 1 - create the data structures.
class CommandReference
{
    public string CommandName { get; set; } = "";
    public string CommandDescription { get; set; } = "";

    public List<CommandExample> Examples { get; set; } = new List<CommandExample>();
}

class CommandExample
{
    public string Command { get; set; } = "";
    public string Description { get; set; } = "";
}