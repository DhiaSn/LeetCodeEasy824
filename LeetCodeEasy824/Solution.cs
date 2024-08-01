namespace LeetCodeEasy824
{
    public static class Solution
    {
        public static string ToGoatLatin(string sentence)
        {
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                char firstChar = words[i].ToLower()[0];

                if (firstChar == 'a' || firstChar == 'e' || firstChar == 'i' || firstChar == 'o' || firstChar == 'u')
                    words[i] = $"{words[i]}ma";
                else
                {
                    char temp = words[i][0]; 
                    words[i] = words[i].Remove(0, 1);
                    words[i] = $"{words[i]}{temp}ma";
                }

                for (int j = 0; j < i +1; j++)
                    words[i] += "a";
            }
            return string.Join(' ', words);
        }
    }
}
