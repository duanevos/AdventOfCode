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
    public class Day4 : BaseChallenge
    {
        private readonly string[] Input;

        public Day4()
        {
            Input = LoadInput(File.ReadAllLines, nameof(Day4));
        }

        public override string SolvePartOne()
        {
            int count = 0;
            for (int i = 0; i < Input.Length; i++)
            {
                string[] s = Input[i].Split(new char[] { ',', '-' });
                int l1 = int.Parse(s[0]), l2 = int.Parse(s[1]), r1 = int.Parse(s[2]), r2 = int.Parse(s[3]);
                if (l1 <= r1 && l2 >= r2 || l1 >= r1 && l2 <= r2) count++;
            }
            return count.ToString();
        }
        
        public override string SolvePartTwo()
        {
            int count = 0;
            for (int i = 0; i < Input.Length; i++)
            {
                string[] s = Input[i].Split(new char[] { ',', '-' });
                int l1 = int.Parse(s[0]), l2 = int.Parse(s[1]), r1 = int.Parse(s[2]), r2 = int.Parse(s[3]);
                if(l1 <= r2 && l2>= r1) count++;
            }
            return count.ToString();
        }
    }
}


