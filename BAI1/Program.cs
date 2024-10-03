using System;
using System.Collections.Generic;



public class BAI_Afteken1 {
    public static void Main(string[] args) {
        // var list = new List<int>() { 1, 3, 5, 7, 3, 8, 9, 5 };
        // Opdr1FilterList(list);
        //
        // Opdr2bStackFromQueue(Opdr2aQueue50());
        //
        // Opdr3RandomNumbers(10, 15, 6);
        
        var sul = new Solution();
        Console.WriteLine(sul.RomanToInt("XIV"));
    }

    public static void Opdr1FilterList(List<int> lijst) { // O(n) 
        var dict = new Dictionary<int, int>();
        foreach (int i in lijst) {
            if (dict.ContainsKey(i)) {
                dict[i]++;
            } else {
                dict.Add(i, 1);
            }
        }

        var filter = new List<int>();
        foreach (int i in lijst) {
            if (dict[i] >= 2) {
                filter.Add(i);
            }
        }
        
        lijst.Clear();
        lijst.AddRange(filter);
    }

    public static Queue<int> Opdr2aQueue50() { // O(n)
        var queue = new Queue<int>();
        for (int i = 1; i <= 50; i++) {
            queue.Enqueue(i);
        }
        return queue;
    }

    public static Stack<int> Opdr2bStackFromQueue(Queue<int> queue) { // O(n)
        var stack = new Stack<int>();
        for (int i = queue.Count - 1; i >= 0; i--) {
            var x = queue.Dequeue();
            if (x % 4 == 0) {
                stack.Push(x);
            }
        }
        return stack;
    }
    
    public static Stack<int> Opdr3RandomNumbers(int lower, int upper, int count) { // O(n)
        var random = new Random();
        var uniqueNumbersDict = new Dictionary<int, bool>();
        while (uniqueNumbersDict.Count < count) {
            var num = random.Next(lower, upper + 1);
            if (!uniqueNumbersDict.ContainsKey(num)) {
                uniqueNumbersDict[num] = true; 
            }
        }
        var stack = new Stack<int>(uniqueNumbersDict.Keys);
        return stack;
    }
    public class Solution {
        public int RomanToInt(string s) {
            var romanValues = new Dictionary<char, int> {
                { 'I', 1 }, { 'V', 5 }, { 'X', 10 },
                { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
            };
            int total = 0;
            int prevValue = 0;
            for (int i = s.Length - 1; i >= 0; i--) {
                int currentValue = romanValues[s[i]];
                if (currentValue < prevValue) {
                    total -= currentValue;
                } else {
                    total += currentValue;
                }
                prevValue = currentValue;
            }
            return total;
        }
    }

}


