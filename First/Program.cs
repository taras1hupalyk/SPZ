using First;

var commandHandler = new PSCommandHandler();
var output = commandHandler.GetAliases();
Console.WriteLine(output);