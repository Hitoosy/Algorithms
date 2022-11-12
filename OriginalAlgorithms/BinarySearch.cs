using System;
using System.Linq;

public static class Program
{
    static void Main()
    {
        var target = int.Parse(Console.ReadLine());

        int[] array = Enumerable.Range(1,10) .Select(t => 2 * t - 1).ToArray();

        //二分探索
        var index = BinarySearch<int>(array, target, 0, array.Length - 1);

        if(index != -1) Console.WriteLine($"array[{index}] : {array[index]}");
        else Console.WriteLine("Not Found");
    }

    //今後このコード使える IComparableは比較を可能にするメソッドを提供するインターフェースである(CompareTo メソッドを所持する)
    //インターフェースとは
    public static  int  BinarySearch<T>(T[] array, T target, int min, int max) where T : IComparable<T>
    {
       if(max < min) return -1;

       int mid = min + (max - min)/2;  

       //ここの内容が重要
       if(array[mid].CompareTo(target) > 0)
       {
          return BinarySearch(array, target, min, mid - 1);
       }

       else if(array[mid].CompareTo(target) < 0)
       {
          return BinarySearch(array, target, mid + 1, max);
       }

       return mid;

    }
}


//array : ソートされた配列
//target : 探す数字
//min :　探索範囲の最初のインデックス
//max :  探索範囲の最後のインデックス


//間違ったemailを設定していた
