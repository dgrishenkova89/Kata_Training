namespace Training_Tasks;

public class ReversedStrings
{
    public static string SimpleReverse(string sourceString) => string.Concat(sourceString.Reverse());

    public static string Reverse(string sourceString)
    {
        if (string.IsNullOrWhiteSpace(sourceString))
        {
            return sourceString;
        }

        var reverseString = string.Empty;
        for (int i = sourceString.Length - 1; i >= 0; i--)
        {
            reverseString += sourceString[i];
        }

        return reverseString;
    }
}