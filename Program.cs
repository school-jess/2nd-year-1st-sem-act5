// See https://aka.ms/new-console-template for more information

var nums = new List<int> { 1, 3, 5, 7, 9 };

int BiggestNum(List<int> arr)
{
    int biggest = 0;
    foreach (var elem in arr)
    {
        if (elem > biggest) biggest = elem;
    }

    return biggest;
}

Console.WriteLine(BiggestNum(nums));

int FindElem(List<int> arr, int target)
{
    int i = 0;
    foreach (var elem in arr)
    {
        if (elem == target) return i;
        i++;
    }

    return -1;
}

Console.WriteLine(FindElem(nums, 9));

List<T> RevArr<T>(List<T> arr)
{
    int right = arr.Count - 1;
    for (int i = 0; i < arr.Count / 2; i++, right--)
    {
        var tmp = arr[right];
        arr[right] = arr[i];
        arr[i] = tmp;
    }

    return arr;
}

foreach (var num in RevArr(nums.ToList()))
{
    Console.Write($"{num} ");
}

Console.WriteLine();

foreach (var num in nums.ToList())
{
    Console.Write($"{num} ");
}

Console.WriteLine();

while (true)
{
    string? input = Console.ReadLine();
    if (input == null)
    {
        continue;
    }

    Console.WriteLine(new string(RevArr(input.ToList()).ToArray()));
    Console.WriteLine(input);
    break;
}

int WordCount(string input)
{
    int wordCnt = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ' || i == input.Length - 1)
        {
            wordCnt++;
        }
    }

    return wordCnt;
}

while (true)
{
    string? input = Console.ReadLine();
    if (input == null)
    {
        continue;
    }

    Console.WriteLine(WordCount(input));
    break;
}