namespace _2nd_sem_5th_act;

interface IArrManipulation
{
    void SearchArr(int target);
}

interface IStrManipulation
{
    void GetInput();
}

class IntArr : IArrManipulation
{
    private List<int> intArr;
    private int biggest;
    private int foundElem;

    public IntArr(List<int> arr)
    {
        intArr = arr;
        biggest = 0;
    }

    public void SearchArr(int target)
    {
        int i = 0;
        foreach (var elem in intArr)
        {
            if (elem > biggest) biggest = elem;

            if (elem == target) foundElem = i;
            i++;
        }
        RevArr();
    }

    public void GetBiggest()
    {
        Console.WriteLine($"Biggest: {biggest}");
        foreach (var elem in intArr)
        {
            Console.Write($"{elem}, ");
        }

        Console.WriteLine();
    }

    public void GetTargetIndex()
    {
        Console.WriteLine($"Element found at {foundElem}");
    }

    private void RevArr()
    {
        int right = intArr.Count - 1;
        for (int i = 0; i < intArr.Count / 2; i++, right--)
        {
            var tmp = intArr[right];
            intArr[right] = intArr[i];
            intArr[i] = tmp;
        }
    }
}

class Str : IStrManipulation
{
    private string input;

    public void GetInput()
    {
        input = "";
        while (input == "")
        {
            input = Console.ReadLine();
        }
    }

    public void GetReversed()
    {
        List<char> arr = new List<char>(input);
        int right = arr.Count - 1;
        for (int i = 0; i < arr.Count / 2; i++, right--)
        {
            var tmp = arr[right];
            arr[right] = arr[i];
            arr[i] = tmp;
        }

        foreach (var elem in arr)
        {
            Console.Write($"{elem}, ");
        }

        Console.WriteLine();
    }

    public void WordCount()
    {
        int wordCnt = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ' ' || i == input.Length - 1)
            {
                wordCnt++;
            }
        }

        Console.WriteLine($"Word Count: {wordCnt}");
    }
}

class Program
{
    static void Main()
    {
        IntArr intArr = new IntArr(new List<int>() { 1, 3, 5, 7, 9 });
        intArr.SearchArr(9);
        intArr.GetBiggest();
        intArr.GetTargetIndex();
        Str str = new Str();
        str.GetInput();
        str.GetReversed();
        str.WordCount();
    }
}