using System;

namespace AdventOfCode22.Challenges
{
	public class Challenge5 : Challenge
	{
		public Challenge5()
		{
		}

        public override string SolveFirst(List<string> input)
        {
            String result = String.Empty;
            List<List<Char>> map = new();

            for (int j = 0; j < input[0].Length; j += 4) map.Add(new());
            foreach(var line in input)
            {
                if (Int32.TryParse(line[1].ToString(), out _))
                    break;

                for (int i = 0; i < line.Length - 1; i+=4)
                {
                    if (line[i].Equals('['))
                    {
                        map[i / 4].Insert(0, line[i + 1]);
                    }                    
                }
            }

            List<Tuple<Int32, Int32, Int32>> commands = new();
            foreach(var line in input.Skip(10))
            {
                var cleared = line.Replace("move", "").Replace("from", "")
                    .Replace("to", "").Trim();

                var arr = cleared.Split(" ").Where(c => c != String.Empty)
                    .Select(x => Convert.ToInt32(x)).ToArray();

                commands.Add(new(arr[0], arr[1], arr[2]));
            }

            foreach(var command in commands)
            {
                for(Int32 i = 0; i < command.Item1; i++)
                {
                    var value = map[command.Item2 - 1].Last();
                    map[command.Item2 - 1].RemoveAt(map[command.Item2 - 1].Count-1);
                    map[command.Item3 - 1].Add(value);
                }
            }

            foreach (var stack in map)
                result += stack.Last();

            return result;
        }

        public override string SolveSecond(List<string> input)
        {
            String result = String.Empty;
            List<List<Char>> map = new();

            for (int j = 0; j < input[0].Length; j += 4) map.Add(new());
            foreach (var line in input)
            {
                if (Int32.TryParse(line[1].ToString(), out _))
                    break;

                for (int i = 0; i < line.Length - 1; i += 4)
                {
                    if (line[i].Equals('['))
                    {
                        map[i / 4].Insert(0, line[i + 1]);
                    }
                }
            }

            List<Tuple<Int32, Int32, Int32>> commands = new();
            foreach (var line in input.Skip(10))
            {
                var cleared = line.Replace("move", "").Replace("from", "")
                    .Replace("to", "").Trim();

                var arr = cleared.Split(" ").Where(c => c != String.Empty)
                    .Select(x => Convert.ToInt32(x)).ToArray();

                commands.Add(new(arr[0], arr[1], arr[2]));
            }

            foreach(var command in commands)
            {
                var values = map[command.Item2 - 1].Skip(
                    map[command.Item2 - 1].Count - command.Item1).ToList();

                map[command.Item2 - 1].RemoveRange(map[command.Item2 - 1].Count
                    - command.Item1, command.Item1);

                map[command.Item3 - 1].AddRange(values);
            }

            foreach (var stack in map)
                result += stack.Last();

            return result;
        }
    }
}

