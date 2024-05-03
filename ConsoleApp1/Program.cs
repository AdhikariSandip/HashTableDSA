using System;
using System.Collections.Generic;
using System.Drawing;

public class MyHashSet
{
    static int size = 1000;
    List<int>[] bucket = new List<int>[size];

    public MyHashSet()
    {
        for (int i = 0; i < size; i++)
        {
            bucket[i] = new List<int>();
        }

    }
    public int gethash(int key)
    {
        int a = key % size;
        return a;
    }

    public void Add(int key)
    {
      int  index = gethash(key);
        if (!bucket[index].Contains(key)) 
        { 
            bucket[index].Add(key); 
        }
    }

    public void Remove(int key)
    {
        int index1 = gethash(key);
        bucket[index1].Remove(key);
    }

    public bool Contains(int key)
    {
        int index1 = gethash(key);
        return bucket[index1].Contains(key);
        

    }
}
public class MyHashMap
{

    public MyHashMap()
    {

    }

    public void Put(int key, int value)
    {

    }

    public int Get(int key)
    {

    }

    public void Remove(int key)
    {

    }
}