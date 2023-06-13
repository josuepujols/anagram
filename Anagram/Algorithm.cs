namespace Anagram
{
    internal class Algorithm
    {
        public static IEnumerable<string[]> FindAnagrams(IEnumerable<string> candidates)
        {
            if (null == candidates)
                throw new ArgumentNullException(nameof(candidates));

            return candidates
              .GroupBy(word => string.Concat(word.OrderBy(c => c)))
              .Where(group => group.Count() > 1)
              .Select(group => group.OrderBy(word => word).ToArray());
        }
    }
}
