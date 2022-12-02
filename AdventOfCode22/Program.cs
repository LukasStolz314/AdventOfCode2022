using System.Reflection;
using AdventOfCode22;

var challengeInput = Console.ReadLine();
var challengeArr = (challengeInput ?? "1").Split('.');

Assembly assembly = Assembly.GetAssembly(typeof(Program))!;
Type challengeType = assembly.GetTypes()
    .FirstOrDefault(t => t.Name == $"Challenge{challengeArr.First()}")!;

Challenge challenge = (Challenge)Activator.CreateInstance(challengeType)!;

var input = challenge.ParseFile(Environment.CurrentDirectory
    + $"/Inputs/Input{challengeArr.First()}.txt");

String result;
if (challengeArr.Last().Equals("1"))
    result = challenge.SolveFirst(input);
else
    result = challenge.SolveSecond(input);

Console.WriteLine(result);
Console.ReadLine();

