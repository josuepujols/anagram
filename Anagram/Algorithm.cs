namespace Anagram
{
    internal class Algorithm
    {
        public static bool IsAnagram(string firstWord, string secondWord)
        {
            if (IsValid(firstWord, secondWord))
                return false;
            char[] s1Array = firstWord.ToLower().ToCharArray();
            char[] s2Array = secondWord.ToLower().ToCharArray();

            Array.Sort(s1Array);
            Array.Sort(s2Array);

            firstWord = new string(s1Array);
            secondWord = new string(s2Array);

            return firstWord == secondWord;
        }

        public static bool IsAnagram2(string firstWord, string secondWord)
        {
            if (IsValid(firstWord, secondWord))
                return false;
            string firstWordSorted = string.Concat(firstWord.OrderBy(c => c));
            string secondWordSorted = string.Concat(secondWord.OrderBy(c => c));
            return firstWordSorted == secondWordSorted;
        }

        public static bool IsValid(string firstWord, string secondWord)
        {
            if (firstWord.Length != secondWord.Length)
                return false;
            if (firstWord == secondWord)
                return false;
            return true;
        }
    }
}
