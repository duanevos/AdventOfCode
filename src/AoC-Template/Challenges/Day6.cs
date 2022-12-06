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
    public class Day6 : BaseChallenge
    {
        private readonly string Input;

        public Day6()
        {
            Input = LoadInput(File.ReadAllText, nameof(Day6));
        }

        public override string SolvePartOne()
        {
            for (int i = 0; i < Input.Length; i++)
            {
                if (new HashSet<char>(Input.Substring(i, 4)).Count == 4)
                {
                    return (i + 4).ToString();
                }
            }
            return "-1";
        }

        public override string SolvePartTwo()
        {
            for (int i = 0; i < Input.Length; i++)
            {
                if (new HashSet<char>(Input.Substring(i, 14)).Count == 14)
                {
                    return (i + 14).ToString();
                }
            }
            return "-1";
        }
    }
}


