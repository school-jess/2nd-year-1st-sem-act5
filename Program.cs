using OopClass;

namespace _2nd_sem_5th_act;

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