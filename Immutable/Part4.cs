using System.Collections.Immutable;

namespace Immutable
{
    public class Part4
    {
        public string Poem { get; set; }
        public string AddPart(ImmutableList<string> immutableList)
        {
            var list = immutableList.Add("Вот кот," +
                "\r\nКоторый пугает и ловит синицу," +
                "\r\nКоторая часто ворует пшеницу," +
                "\r\nКоторая в темном чулане хранится" +
                "\r\nВ доме," +
                "\r\nКоторый построил Джек.");
            Poem = list[list.Count - 1];
            return Poem;
        }
    }
}
