using AoC.Running;
using Iced.Intel;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AoC.Challenges
{
    public class Day3 : BaseChallenge
    {
        private readonly string[] Input;

        public Day3()
        {
            Input = LoadInput(File.ReadAllLines, nameof(Day3));
        }

        public override string SolvePartOne()
        {
            string right;
            int sum = 0;
            foreach (string s in Input)
            {
                right = s[(s.Length / 2)..];
                for (int i = 0; i < s.Length / 2; i++)
                {
                    if (right.Contains(s[i]))
                    {
                        sum += s[i] - (s[i] >= 'a' ? 'a' - 1 : 'A' - 27);
                        break;
                    }
                }
            }
            return sum.ToString();
        }

        public override string SolvePartTwo()
        {
            int sum = 0;
            for (int i = 0; i < Input.Length - 2; i+=3)
            {
                for (int j = 0; j < Input[i].Length; j++)
                {
                    char c = Input[i][j];
                    if (Input[i + 1].Contains(c) && Input[i + 2].Contains(c))
                    {
                        sum += Input[i][j] - (Input[i][j] >= 'a' ? 'a' - 1 : 'A' - 27);
                        break;
                    }
                }
            }
            return sum.ToString();
        }
    }
}


