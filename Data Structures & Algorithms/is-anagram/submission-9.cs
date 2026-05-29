public class Solution {
    public bool IsAnagram(string s, string t) {
        // if(s.Length != t.Length)
        // return false;
    
        // Dictionary<char, int> sOcc = new();
        // Dictionary<char, int> tOcc = new();

        // foreach(var character in s)
        // {
        //     if(!sOcc.ContainsKey(character))
        //         sOcc[character] = 0;
            
        //     sOcc[character]++;
        // }

        // foreach(var character in t)
        // {
        //     if(!tOcc.ContainsKey(character))
        //         tOcc[character] = 0;
            
        //     tOcc[character]++;
        // }

        // foreach(var kv in sOcc)
        // {
        //     if(!tOcc.ContainsKey(kv.Key) || tOcc[kv.Key] != kv.Value)
        //     return false;
        // }

        // return true;

        if(s.Length != t.Length)
        return false;

        Dictionary<char, int> sOcc = new();

        foreach(var character in s)
        {
            if(!sOcc.ContainsKey(character))
                sOcc[character] = 0;
            
            sOcc[character]++;
        }

        foreach(var character in t)
        {
            if(!sOcc.ContainsKey(character))
                return false;

            sOcc[character]--;

            if(sOcc[character] < 0)
                return false;
        }

        return true;
    }
}
