using System.Text;

namespace SampleStringBuilderVsString;

public class SampleExample
{
    // Entrega menor tempo de resposta com array
    public static string ParseNumberString(int[] numbers)
    {
        var resultParse = "";

        for (int i = 0; i < numbers.Length; i++)
        {
            resultParse += numbers[i].ToString();
        }

        return resultParse;
    }

    // Entrega maior tempos de resposta com IEnumerable
    public static string ParseNumberString(IEnumerable<int> numbers)
    {
        var resultParse = "";

        foreach (var item in numbers)
        {
            resultParse += item.ToString();
        }

        return resultParse;
    }
}

public class SampleExampleOtimization
{
    public static string ParseNumberString(int[] numbers)
    {
        var resultParse = new StringBuilder();

        for (int i = 0; i < numbers.Length; i++)
        {
            resultParse.Append(numbers[i]);
        }

        return resultParse.ToString();
    }

    public static string ParseNumberString(IEnumerable<int> numbers)
    {
        var resultParse = new StringBuilder();

        foreach (var item in numbers)
        {
            resultParse.Append(item);
        }

        return resultParse.ToString();
    }
}
