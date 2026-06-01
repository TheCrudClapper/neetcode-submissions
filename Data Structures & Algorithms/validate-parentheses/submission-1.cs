public class Solution {
    public bool IsValid(string s) {
        //Brute Force O(n^2)
        while (true)
        {
            string previous = s;

            s = s.Replace("[]", "");
            s = s.Replace("()", "");
            s = s.Replace("{}", "");

            if (s.Length == 0)
                return true;

            if (previous == s)
                return false;
               
        }

    }
}
