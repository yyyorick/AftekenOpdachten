using System.Globalization;

public class Program {
    public static void Main(){
        // OpdrachtEenWeekDrie("3 6 7 + * =");
        
        
        
        OpdrachtTweeWeekDrie("([\n])");          // GELDIG
        OpdrachtTweeWeekDrie("([\n)]");          // ONGELDIG
        OpdrachtTweeWeekDrie("(\n}");            // ONGELDIG
        OpdrachtTweeWeekDrie("( (( )) ([ ]) )"); // GELDIG
        OpdrachtTweeWeekDrie("( (( )) ([ )] )"); // ONGELDIG
        
    }

    public static void OpdrachtEenWeekDrie(string input){
        var stack = new Stack<int>();
        foreach (char c in input){
            if (int.TryParse(c.ToString(), out int i)){
                stack.Push(i);
                continue;
            }
            switch (c){
                case '+':
                    stack.Push(stack.Pop() + stack.Pop());
                    break;
                case '*':
                    stack.Push(stack.Pop() * stack.Pop());
                    break;
                case '=':
                    Console.WriteLine(stack.Pop());
                    break;
            }
        }
    }

    public static void OpdrachtTweeWeekDrie(string input) {
        Stack<char> stack = new();
        foreach (char c in input) {
            switch (c) {
                case '(':
                    stack.Push(')');
                    break;
                case '[':
                    stack.Push(']');
                    break;
                case '{':
                    stack.Push('}');
                    break;
                case ')':
                case ']':
                case '}':
                    if (stack.Count == 0 || stack.Pop() != c) {
                        Console.WriteLine("ONGELDIG");
                        return;
                    }
                    break;
            }
        }
        if (stack.Count == 0) {
            Console.WriteLine("GELDIG");
        } else {
            Console.WriteLine("ONGELDIG");
        }
    }

}