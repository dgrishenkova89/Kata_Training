namespace Training_Tasks;

public class FibonacciLastDigit
{
    public static int GetLastDigit(int index)
    {
        if (index <= 1)
        {
            return index;
        }

        var firstDigit = 0;
        var lastDigit = 1;

        for (int i = 1; i < index; i++)
        {
            var temp = (firstDigit + lastDigit) % 10;
            firstDigit = lastDigit;
            lastDigit = temp;
        }

        return lastDigit;
    }
}
