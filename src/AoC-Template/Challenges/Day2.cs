using AoC.Running;
using Iced.Intel;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AoC.Challenges
{
    public class Day2 : BaseChallenge
    {
        private readonly string[] Input;

        public Day2()
        {
            Input = LoadInput(File.ReadAllLines, nameof(Day2));
        }

        public override string SolvePartOne()
        {
            Dictionary<string, int> result = new()
            {
                {"C X", 7},
                {"C Y", 2},
                {"C Z", 6},

                {"B X", 1},
                {"B Y", 5},
                {"B Z", 9},

                {"A X", 4},
                {"A Y", 8},
                {"A Z", 3},
            };

            int score = 0;
            for (int i = 0; i < Input.Length; i++)
            {
                score += result[Input[i]];
            }

            return score.ToString();
        }

        public override string SolvePartTwo()
        {
            Dictionary<string, int> result = new()
            {
                {"C X", 2},
                {"C Y", 6},
                {"C Z", 7},

                {"B X", 1},
                {"B Y", 5},
                {"B Z", 9},

                {"A X", 3},
                {"A Y", 4},
                {"A Z", 8},
            };

            int score = 0;
            for (int i = 0; i < Input.Length; i++)
            {
                score += result[Input[i]];
            }

            return score.ToString();
        }
    }
}

