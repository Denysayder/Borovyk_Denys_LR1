using System.Collections.Generic;
using System.Text.Json;

Dictionary<string, int> dictionary1 = new Dictionary<string, int>()
{
    {"key1 :", 1},
    {"key2 :", 3},
    {"key3 :", 2}

};

Dictionary<string, int> dictionary2 = new Dictionary<string, int>()
{
    {"key1 :", 1},
    {"key2 :", 2},
};

foreach (var pair in dictionary1)
{
    if (dictionary2.ContainsKey(pair.Key))
    {
        if (dictionary2.ContainsValue(pair.Value))
            Console.WriteLine(pair.Key + pair.Value + " is present in both x and y");
    }
}
string json = JsonSerializer.Serialize(dictionary1);
Console.WriteLine(json);

















//using System.Collections.Generic;
//using System.Text.Json;

//Dictionary<string, int> dictionary1 = new Dictionary<string, int>()
//{
//    {"key1 :", 1},
//    {"key2 :", 3},
//    {"key3 :", 2}

//};

//Dictionary<string, int> dictionary2 = new Dictionary<string, int>()
//{
//    {"key1 :", 1},
//    {"key2 :", 2},
//};
//foreach (var pair in dictionary1)
//{
//    foreach (var pair2 in dictionary2)
//    {
//        int value, value2;
//        string key1, key2;
//        dictionary1.TryGetValue(pair.Key, out value);
//        key1 = pair.Key;
//        dictionary2.TryGetValue(pair2.Key, out value2);
//        key2 = pair2.Key;
//        if (value == value2 && key1 == key2)
//            Console.WriteLine(pair.Key + value + " is present in both x and y");
//    }
//}
//string json = JsonSerializer.Serialize(dictionary1);
//Console.WriteLine(json);







//string json = JsonConvert.SerializeObject(dictionary1, Formatting.Indented);
//Console.WriteLine(json);




//using System.Collections.Generic;

//Dictionary<string, int> dictionary1 = new Dictionary<string, int>()
//{
//    {"key1 :", 1},
//    {"key2 :", 3},
//    {"key3 :", 2}

//};

//Dictionary<string, int> dictionary2 = new Dictionary<string, int>()
//{
//    {"key1 :", 1},
//    {"key2 :", 2}
//};
//foreach (object pair in dictionary1)
//{
//    for (int i = 0; i < dictionary2.Count; i++)
//    {
//        if (pair == dictionary2.TryGetValue(pair.Key, out value)
//            Console.WriteLine($"{dictionary1(i).Key} {dictionary1(i).Values}");
//    }
//}






//using System.Collections.Generic;

//Dictionary<string, int> dictionary1 = new Dictionary<string, int>()
//{
//{ "key1 :", 1},
//    { "key2 :", 3},
//    { "key3 :", 2}

//};

//Dictionary<string, int> dictionary2 = new Dictionary<string, int>()
//{
//    {"key1 :", 1},
//    {"key2 :", 2}
//};




//bool equal = true;
//foreach (var pair in dictionary1)
//{
//    int value;
//    if (dictionary2.TryGetValue(pair.Key, out value))
//    {
//        // Require value be equal.
//        if (value != pair.Value)
//        {
//            equal = false;
//            break;
//            Console.WriteLine("5");
//        }
//    }
//    else
//    {
//        // Require key be present.
//        equal = false;
//        break;
//        Console.WriteLine("5");
//    }
//}


//using System;
//using System.Collections.Generic;


//        // Create a dictionary and add several elements to it.
//        var dict = new Dictionary<string, int>();
//        dict.Add("key1: ", 1);
//        dict.Add("key2: ", 3);
//        dict.Add("key3: ", 2);

//        // Create another dictionary.
//        var dict2 = new Dictionary<string, int>();
//dict2.Add("key1: ", 1);
//dict2.Add("key2: ", 2);
//dict2.Add("key3: ", 2);

//// Test for equality.
//bool equal = false;
////if (dict.Count == dict2.Count) // Require equal count.
////{
//    equal = true;
//    foreach (var pair in dict)
//    {
//        int value;
//        if (dict2.TryGetValue(pair.Key, out value))
//        {
//            // Require value be equal.
//            if (value != pair.Value)
//            {
//                equal = false;
//                break;
//            }
//        }
//        else
//        {
//            // Require key be present.
//            equal = false;
//            break;
//        }
//    }
////}
//        Console.WriteLine(equal);