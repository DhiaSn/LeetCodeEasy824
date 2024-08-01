namespace LeetCodeEasy824
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result1 = Solution.ToGoatLatin("I speak Goat Latin");
            if (result1 != "Imaa peaksmaaa oatGmaaaa atinLmaaaaa")
            {
                Console.WriteLine($"result1 is: {result1} instead of \"Imaa peaksmaaa oatGmaaaa atinLmaaaaa\"");
                return;
            }
            string result2 = Solution.ToGoatLatin("The quick brown fox jumped over the lazy dog");
            if (result2 != "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa")
            {
                Console.WriteLine($"result2 is: {result2} instead of \"heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa\"");
                return;
            }
            
            Console.WriteLine($"it works perfectly!");
        }
    }
}
