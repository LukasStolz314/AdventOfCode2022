using System;
namespace AdventOfCode22
{
	public abstract class Challenge
	{
		public abstract String SolveFirst(List<String> input);
        public abstract String SolveSecond(List<String> input);

        public List<String> ParseFile(String path)
		{
			List<String> input = File.ReadAllLines(path).ToList();
			return input;
		}
	}
}

