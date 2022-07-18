namespace ex1
{
    class Program
    {
        static string[] wordsSplit(string text, char[] separators)
        {
            string[] splitedText = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return splitedText;
        }
        static void Print(string[] splitedText)
        {
            for (int i = 0; i < splitedText.Length; i++)
            {
                Console.WriteLine($"{splitedText[i]}");
            }
        }
        static void Main(string[] args)
        {
            char[] separators = new char[] { ' ', '.', ',' };
            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();

            wordsSplit(text, separators);
            Print(wordsSplit(text, separators)); //можно сделать так? или есть другой способ?

            Console.ReadKey();
        }
    }
}