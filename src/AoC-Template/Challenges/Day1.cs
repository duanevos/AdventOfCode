using AoC.Running;
using BenchmarkDotNet.Disassemblers;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsTCPIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC.Challenges
{
    public class Day1 : BaseChallenge
    {
        private readonly string[] Input;

        public Day1()
        {
            Input = LoadInput(File.ReadAllLines, nameof(Day1));
        }

        public override string SolvePartOne()
        {
            return SumCalories().Max().ToString();
        }

        public override string SolvePartTwo()
        {
            return SumCalories().OrderByDescending(x => x).Take(3).Sum().ToString();
        }

        private List<int> SumCalories()
        {
            int sum = 0;
            List<int> calories = new();
            for (int i = 0; i < Input.Length; i++){
                if (Input[i] == "")
                {
                    calories.Add(sum);
                    sum = 0;
                }
                else sum = int.Parse(Input[i]);
            }
            return calories;
        }
    }
}
