using System;
using System.Collections.Generic;


public class KeyValueStore<TKey, TValue>
{
    private Dictionary<TKey, TValue> _store = new Dictionary<TKey, TValue>();

    public void Add(TKey key, TValue value)
    {
        _store[key] = value;
    }

    public TValue GetValueByKey(TKey key)
    {
        return _store[key];
    }
}

class Program
{
    static void Main(string[] args)
    {

        var userNames = new KeyValueStore<int, string>();
        userNames.Add(1, "Анна");
        userNames.Add(2, "Богдан");
        Console.WriteLine($"Ім'я користувача з ID 1: {userNames.GetValueByKey(1)}");


        var productPrices = new KeyValueStore<string, double>();
        productPrices.Add("Молоко", 35.50);
        productPrices.Add("Хліб", 22.00);
        Console.WriteLine($"Ціна на молоко: {productPrices.GetValueByKey("Молоко")}");
    }
}
