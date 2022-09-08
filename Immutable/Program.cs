using System;
using System.Collections.Immutable;

namespace Immutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var immutableList = ImmutableList<string>.Empty;
            var myPart1 = new Part1().AddPart(immutableList);
            var myPart2 = new Part2().AddPart(immutableList);
            var myPart3 = new Part3().AddPart(immutableList);
            var myPart4 = new Part4().AddPart(immutableList);
            var myPart5 = new Part5().AddPart(immutableList);
            var myPart6 = new Part6().AddPart(immutableList);
            var myPart7 = new Part7().AddPart(immutableList);
            var myPart8 = new Part8().AddPart(immutableList);
            var myPart9 = new Part9().AddPart(immutableList);

            //Console.WriteLine(immutableList.);
        }
    }
}
