using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string [] args)
    {
        /*
        var s = new Stack<int>();
        s.Push(1);
        s.Push(2);
        s.Push(3);

        //Popは先頭の要素削除
        s.Pop();

        //Peekは先頭の要素を持ってくるメソッド
        Console.WriteLine("先頭の要素は{0}です",s.Peek());

        s.Clear();
        Console.WriteLine("TryPeekを実行します.結果は{0},取得した値は{1}です",s.TryPeek(out int val1),val1);
        s.Push(4);
        Console.WriteLine("唯一の要素{0}",s.Peek());

        Console.WriteLine("sに4が含まれているかどうか。結果は{0}です",s.Contains(4));
        Console.WriteLine("sに3が含まれているかどうか。結果は{0}です",s.Contains(3));



        Console.WriteLine("TryPeekを実行します.結果は{0},取得した値は{1}です",s.TryPeek(out int val2),val2);

        foreach(var i in s)
        {
            Console.WriteLine(i);
        }


        s.Clear();
        

        var s = new Stack<int>();

        s.Push(5);
        s.Push(6);
        s.Push(7);

        int[] s_array = s.ToArray();

        for(int i = 0; i < s_array.Length; i++)
        {
            Console.WriteLine(s_array[i]);
        }
        
        Console.WriteLine(s_array[2]);
        Console.WriteLine(s_array[0]);
        */



        var s = new Stack<int>();
        for(int i = 0; i < 5; i ++)
        {
            s.Push(i);
        }


        var array = new int[10];
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = 10;
        }

        //array配列中に配列化したStackが参入してくる形

        s.CopyTo(array, 3);
        //string.Joinってなんかしっくりこない
        //他にできる方法はないか次回までに考えてきてください
        Console.WriteLine("[{0}]",string.Join("",array));


    }
}