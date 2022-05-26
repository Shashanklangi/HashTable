
namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1:Find the frequency of word in sentence
            Console.WriteLine("Hello Word");
            LinkedHashMap<string, int> linkedHashMap = new LinkedHashMap<string, int>(5);
            string sentence = "paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = sentence.ToLower().Split(" ");
            foreach(string word in words)
            {
                int value = linkedHashMap.Get(word);
                if (value == default)
                {
                    value = 1;
                }
                else value += 1;
                linkedHashMap.Add(word, value);
            }
            int frequency = linkedHashMap.Get("paranoid");
            Console.WriteLine(frequency);
        }
    }
}