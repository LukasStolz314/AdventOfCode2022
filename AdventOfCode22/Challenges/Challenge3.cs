using System;

namespace AdventOfCode22.Challenges
{
	public class Challenge3 : Challenge
	{		
        public override string SolveFirst(List<string> input)
        {
            Int32 result = 0;
            foreach(var line in input)
            {
                Char similarItem = '0';
                List<Char> subset = line.Skip(line.Length / 2).ToList();

                foreach(var c in line.Take(line.Length / 2))
                {
                    if(subset.Contains(c)) similarItem = c;                    
                }

                result += GetResultValues(similarItem);
            }

            return result.ToString();
        }

        public override string SolveSecond(List<string> input)
        {
            Int32 result = 0;
            for (int i = 0; i < input.Count - 1; i += 3)
            {
                var similarItem = input[i]
                    .Intersect(input[i + 1])
                    .Intersect(input[i+2])
                    .FirstOrDefault();

                result += GetResultValues(similarItem);
            }

            return result.ToString();
        }

        private Int32 GetResultValues(Char item)
        {
            var result = Char.IsUpper(item) ? 26 : 0;
            result += (Int32)Char.ToLower(item) - 96;

            return result;
        }
    }
}

