public class Solution {
    public bool IsValid(string s) {
        //Brute Force 
        // while (true)
        // {
        //     string previous = s;

        //     s = s.Replace("[]", "");
        //     s = s.Replace("()", "");
        //     s = s.Replace("{}", "");

        //     if (s.Length == 0)
        //         return true;

        //     if (previous == s)
        //         return false;
               
        // }

        //Stack-based approach
        // Stack<char> stack = new();
        // for(int i = 0; i < s.Length; i++)
        // {
        //     if(s[i] == '(' || s[i] == '{' || s[i] == '[')
        //         stack.Push(s[i]);

        //     if(s[i] == ')' || s[i] == '}' || s[i] == ']')
        //     {
        //         if(stack.Count == 0) 
        //             return false;

        //         char top = stack.Pop();
        //         if ((s[i] == ')' && top != '(') || 
        //             (s[i] == '}' && top != '{') || 
        //             (s[i] == ']' && top != '['))
        //             return false;
        //     }
        // }

        // if(stack.Count == 0)
        //     return true;
        // else
        //     return false;

        //Dictionary lookup with stack
        Stack<char> stack = new();
        Dictionary<char, char> map = new() 
        {
            { ')', '('},
            { ']', '['},
            { '}', '{'}
        };

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[')
                stack.Push(s[i]);

            if(s[i] == ')' || s[i] == '}' || s[i] == ']')
            {
                if(stack.Count == 0) 
                    return false;

                char top = stack.Pop();
                if (top != map[s[i]])
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
