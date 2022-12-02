using System;

namespace AdventOfCode22.Challenges
{
    public class Challenge2 : Challenge
    {
        private Int32 GetIndex(String input) => input switch
        {
            "A" => 0,
            "B" => 1,
            "C" => 2,
            "X" => 0,
            "Y" => 1,
            "Z" => 2,
        };

        public override string SolveFirst(List<string> input)
        {
            Int32 result = 0;
            foreach(var line in input)
            {
                Int32 roundResult = 0;
                var arr = line.Split(' ');

                if (GetIndex(arr[0]) == GetIndex(arr[1]))
                    roundResult += 3;
                else if (((GetIndex(arr[0]) + 1) % 3) == GetIndex(arr[1]))
                    roundResult += 6;
                else
                    roundResult += 0;

                Int32 valueResult = GetIndex(arr[1]) + 1;

                result += roundResult + valueResult;
            }

            return result.ToString();
        }

        public override string SolveSecond(List<string> input)
        {
            Int32 result = 0;
            foreach (var line in input)
            {
                var arr = line.Split(' ');

                Int32 bigW = GetIndex(arr[1]) * 3;

                Int32 valueResult = 0;
                if (GetIndex(arr[1]) == 0)
                    valueResult = mod(GetIndex(arr[0]) - 1, 3) + 1;
                else if (GetIndex(arr[1]) == 1)
                    valueResult = GetIndex(arr[0]) + 1;
                else
                    valueResult = mod(GetIndex(arr[0]) + 1, 3) + 1;

                result += bigW + valueResult;
            }

            return result.ToString();
        }

        private int mod(int x, int m)
        {
            return (x % m + m) % m;
        }
    }
}

