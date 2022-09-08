using System.Collections.Immutable;

namespace Immutable
{
    public class Part7
    {
        public string Poem { get; set; }
        public string AddPart(ImmutableList<string> immutableList)
        {
            var list = immutableList.Add("А это старушка, седая и строгая," +
                "\r\nКоторая доит корову безрогую," +
                "\r\nЛягнувшую старого пса без хвоста," +
                "\r\nКоторый за шиворот треплет кота," +
                "\r\nКоторый пугает и ловит синицу," +
                "\r\nКоторая часто ворует пшеницу," +
                "\r\nКоторая в темном чулане хранится" +
                "\r\nВ доме," +
                "\r\nКоторый построил Джек");
            Poem = list[list.Count - 1];
            return Poem;
        }
    }
}
