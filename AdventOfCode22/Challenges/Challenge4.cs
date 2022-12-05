using System;

namespace AdventOfCode22.Challenges
{
	public class Challenge4 : Challenge
	{
		public Challenge4()
		{
		}

        public override string SolveFirst(List<string> input)
        {
            Int32 result = 0;

            foreach(var line in input)
            {
                var pair = line.Split(',');
                var first = pair[0].Split('-').Select(x => Convert.ToInt32(x)).ToArray();
                var second = pair[1].Split('-').Select(x => Convert.ToInt32(x)).ToArray();

                List<Int32> p1 = new();
                List<Int32> p2 = new();
                
                for (int i = first[0]; i <= first[1]; i++) p1.Add(i);
                for (int i = second[0]; i <= second[1]; i++) p2.Add(i);

                Boolean r = p1.Except(p2).ToList().Count == 0 ||
                    p2.Except(p1).ToList().Count == 0;

                result += r ? 1 : 0;
            }

            return result.ToString();
        }

        public override string SolveSecond(List<string> input)
        {
            Int32 result = 0;

            foreach (var line in input)
            {
                var pair = line.Split(',');
                var first = pair[0].Split('-').Select(x => Convert.ToInt32(x)).ToArray();
                var second = pair[1].Split('-').Select(x => Convert.ToInt32(x)).ToArray();

                List<Int32> p1 = new();
                List<Int32> p2 = new();

                for (int i = first[0]; i <= first[1]; i++) p1.Add(i);
                for (int i = second[0]; i <= second[1]; i++) p2.Add(i);

                Boolean r = p1.Any(x => p2.Contains(x)) ||
                    p2.Any(x => p1.Contains(x));

                result += r ? 1 : 0;
            }

            return result.ToString();
        }
    }
}

