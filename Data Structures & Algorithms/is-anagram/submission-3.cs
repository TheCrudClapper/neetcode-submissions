public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
            
        char[] chars1 = s.ToCharArray();
        char[] chars2 = t.ToCharArray();

        Array.Sort(chars1);
        Array.Sort(chars2);

        string a1 = new(chars1);
        string a2 = new(chars2);

        if(a1.Equals(a2))
            return true;

        return false;
    }
}
