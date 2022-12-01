using System.Reflection;
using AdventOfCode22;

var challengeIndex = Console.ReadLine();

Assembly assembly = Assembly.GetAssembly(typeof(Program))!;
Type challengeType = assembly.GetTypes()
    .FirstOrDefault(t => t.Name == $"Challenge{challengeIndex}")!;

Challenge challenge = (Challenge)Activator.CreateInstance(challengeType)!;

String result = challenge.Solve();

Console.WriteLine(result);
Console.ReadLine();

