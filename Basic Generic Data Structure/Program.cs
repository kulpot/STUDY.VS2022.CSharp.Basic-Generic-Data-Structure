using System;

//ref link:https://www.youtube.com/watch?v=OJ5GuyxoY20&list=PLRwVmtr-pp05ETzLYQ8kv1cI5v9ddT8er&index=5
// Array limit + grow solution

/*class ListInt
{
    int[] ints = new int[3];
    int currentIndex;

    public void Add(int i)
    {
        if (currentIndex == ints.Length)
            Grow();
        ints[currentIndex++] = i;
    }

    public int Get(int index)
    {
        return ints[index];
    }
    void Grow()
    {
        int[] temp = new int[ints.Length * 2];
        Array.Copy(ints, temp, ints.Length);
        ints = temp;
    }

    public int Length { get { return ints.Length; } }

}

class ListString
{
    string[] ints = new string[3];
    int currentIndex;

    public void Add(string i)
    {
        if (currentIndex == ints.Length)
            Grow();
        ints[currentIndex++] = i;
    }

    public string Get(int index)
    {
        return ints[index];
    }
    void Grow()
    {
        string[] temp = new string[ints.Length * 2];
        Array.Copy(ints, temp, ints.Length);
        ints = temp;
    }

    public int Length { get { return ints.Length; } }

}*/

class List<T> // List structure that can take any generic type
{
    T[] ints = new T[3];
    int currentIndex;

    public void Add(T i)
    {
        if (currentIndex == ints.Length)
            Grow();
        ints[currentIndex++] = i;
    }

    public T Get(int index)
    {
        return ints[index];
    }
    void Grow()
    {
        T[] temp = new T[ints.Length * 2];
        Array.Copy(ints, temp, ints.Length);
        ints = temp;
    }

    public int Length { get { return ints.Length; } }

}

class MainClass
{
    static void Main()
    {
        //ListInt myInts = new ListInt();
        List<int> myInts = new List<int>();
        myInts.Add(12); myInts.Add(25); myInts.Add(92);
        myInts.Add(5);
        for (int i = 0; i < myInts.Length; i++)
            Console.WriteLine(myInts.Get(i));
        List<string> myStrings = new List<string>();
        myStrings.Add("Bob");
        myStrings.Add("Suzy");
        myStrings.Add("Fred");
        for (int i = 0; i < myStrings.Length; i++)
            Console.WriteLine(myStrings.Get(i));
    }
}