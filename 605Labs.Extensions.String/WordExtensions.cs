namespace _605Labs.Extensions.String;

public static class WordExtensions
{
    public static int WordCount(this string str)
    {
        if (str == null)
        {
            return 0;
        }

        return str.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}