using System;
using System.Collections.Immutable;

namespace Immutable
{
    public class Program
    {
        static void Main(string[] args)
        {
            var immutableList = ImmutableList<string>.Empty;

            var myPart1 = new Part1();
            var myPart2 = new Part2();
            var myPart3 = new Part3();
            var myPart4 = new Part4();
            var myPart5 = new Part5();
            var myPart6 = new Part6();
            var myPart7 = new Part7();
            var myPart8 = new Part8();
            var myPart9 = new Part9();

            //var poem = myPart9.AddPart(
            //    myPart8.AddPart(
            //    myPart7.AddPart(
            //    myPart6.AddPart(
            //    myPart5.AddPart(
            //    myPart4.AddPart(
            //    myPart3.AddPart(
            //    myPart2.AddPart(
            //    myPart1.AddPart(immutableList)))))))));

            //var myPart1 = new Part1();
            //myPart1.AddPart(immutableList);

            //var myPart2 = new Part2();
            //myPart2.AddPart(immutableList);

            //var myPart3 = new Part3();
            //myPart3.AddPart(immutableList);

            //var myPart4 = new Part4();
            //myPart4.AddPart(immutableList);

            //var myPart5 = new Part5();
            //myPart5.AddPart(immutableList);

            //var myPart6 = new Part6();
            //myPart6.AddPart(immutableList);

            //var myPart7 = new Part7();
            //myPart7.AddPart(immutableList);

            //var myPart8 = new Part8();
            //myPart8.AddPart(immutableList);

            //var myPart9 = new Part9();
            //myPart9.AddPart(immutableList);

            //Console.WriteLine(myPart1.Poem + "\r\n"
            //    + myPart2.Poem + "\r\n"
            //    + myPart3.Poem + "\r\n"
            //    + myPart4.Poem + "\r\n"
            //    + myPart5.Poem + "\r\n"
            //    + myPart6.Poem + "\r\n"
            //    + myPart7.Poem + "\r\n"
            //    + myPart8.Poem + "\r\n"
            //    + myPart9.Poem + "\r\n");

            Console.WriteLine(poem);
        }
    }
}
