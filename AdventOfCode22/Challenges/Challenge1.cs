using System;
namespace AdventOfCode22.Challenges
{
    public class Challenge1 : Challenge
    {
        public override string SolveFirst(List<String> input)
        {
            List<Int64> result = new() { 0 };
            foreach(var line in input)
            {
                if(String.IsNullOrEmpty(line))
                {
                    result.Add(0);
                }
                else
                {
                    result[result.Count - 1] += Convert.ToInt64(line);
                }
            }

            return result.Max().ToString();
        }

        public override string SolveSecond(List<string> input)
        {
            List<Int32> result = new() { 0 };
            foreach (var line in input)
            {
                if (String.IsNullOrEmpty(line))
                {
                    result.Add(0);
                }
                else
                {
                    result[result.Count - 1] += Convert.ToInt32(line);
                }
            }

            result = result.OrderByDescending(x => x).ToList();

            return (result[0] + result[1] + result[2]).ToString();
        }
    }
}

