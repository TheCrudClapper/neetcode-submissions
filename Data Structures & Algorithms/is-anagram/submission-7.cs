public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] charsS = s.ToCharArray();
        char[] charsT = t.ToCharArray();

        Array.Sort(charsS);
        Array.Sort(charsT);

        if((new string(charsS)).Equals(new string(charsT)))
            return true;
        
        return false;
    }
}
