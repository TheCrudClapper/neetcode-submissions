public class Solution {
    public bool IsValid(string s) {
        //Brute Force O(n^2)
        while (true)
        {
            string previous = s;

            s = s.Replace("[]", "");
            s = s.Replace("()", "");
            s = s.Replace("{}", "");

            if (previous == s)
                return false;

            if (s == string.Empty)
                return true;
            }
        }

    
}
