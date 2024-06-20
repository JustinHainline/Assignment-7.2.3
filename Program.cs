namespace Assignment_7._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = IsAnagram("anagram", "anagram");
            Console.WriteLine($"Is 'anagram' an anagram of 'anagram'? {result}");
        }

        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            int[] charCount = new int[26]; // Assuming lowercase English letters

            // Count characters in s
            foreach (char c in s)
                charCount[c - 'a']++;

            // Subtract characters in t
            foreach (char c in t)
            {
                charCount[c - 'a']--;
                if (charCount[c - 'a'] < 0)
                    return false;
            }

            return true;
        }

    }
}
