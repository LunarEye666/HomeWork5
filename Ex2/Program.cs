namespace ex2
{
    class Program
    {
        static string wordsSplit(string startedText, char[] separators)
        {
            string[] splitedText = startedText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string newText = reverseText(splitedText);
            return newText;
        }
        static string reverseText(string[] text)
        {
            Array.Reverse(text);
            string reversed = string.Join(' ', text);
            return reversed;
        }
        static void Main(string[] args)
        {
            char[] separators = new char[] { ' ', '.', ',' };
            Console.WriteLine("Введите предложение: ");
            string text = Console.ReadLine();

            text = wordsSplit(text, separators);

            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}