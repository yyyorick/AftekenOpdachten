


using System.Collections.Generic;
using System.Transactions;

public class Program {
    public static void Main(string[] args) {
        List<int> list = new List<int>() { 1, 3, 5, 7, 3, 8, 9, 5 };
        Opg1FilterList(list);

        Opdr2bStackFromQueue(Opdr2aQueue50());
        
        Opdr3RandomNumbers(10, 15, 6);
    }

    public static void Opg1FilterList(List<int> lijst) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int i in lijst) {
            if (dict.ContainsKey(i)) {
                dict[i]++;
            }
            else {
                dict.Add(i, 1);
            }
        }

        foreach (var key in dict.Keys) {
            if (dict[key] < 2) {
                lijst.Remove(key);
            }
        }

        foreach (int i in lijst) {
            Console.Write(i + " ");
        }
    }

    public static Queue<int> Opdr2aQueue50() {
        Queue<int> queue = new Queue<int>();
        for (int i = 1; i <= 50; i++) {
            queue.Enqueue(i);
        }
        return queue;
    }

    public static Stack<int> Opdr2bStackFromQueue(Queue<int> queue) {
        var stack = new Stack<int>();
        for (int i = queue.Count - 1; i >= 0; i--) {
            var x = queue.Dequeue();
            if (x % 4 == 0) {
                stack.Push(x);
            }
        }
        return stack;
    }
    
    public static Stack<int> Opdr3RandomNumbers(int lower, int upper, int count) {
        Random random = new Random();
        Stack<int> stack = new();
        while (stack.Count != count) {
            var num = random.Next(lower, upper + 1);
            if (!stack.Contains(num)) {
                stack.Push(num);
                Console.Write(num + " ");
            }
        }
        return stack;
    }


}


