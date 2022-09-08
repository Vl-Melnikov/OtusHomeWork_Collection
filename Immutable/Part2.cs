using System.Collections.Immutable;

namespace Immutable
{
    public class Part2
    {
        public string Poem { get; set; }
        public string AddPart(ImmutableList<string> immutableList)
        {
            var list = immutableList.Add("А это пшеница," +
                "\r\nКоторая в темном чулане хранится" +
                "\r\nВ доме," +
                "\r\nКоторый построил Джек.");
            Poem = list[list.Count - 1];
            return Poem;
        }
    }
}
