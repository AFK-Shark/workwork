namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            Book<int> book_01 = new("Остров сокровищ", 350, "Роберт Стивенсон", 1);
            Book<int> book_02 = new("Остров сокровищ 2 - На береку папугая", 200, "Роберт Стивенсон младший", 5);
            Book<int> book_03 = new("5 гномов и один гриб", 999, "Игорь Телепузников", 6);
            Book<int> book_04 = new("Что-то", 5, "Вселенная",  999);
            Console.WriteLine(book_01.ToString());
            Console.WriteLine(book_02.ToString());
            Console.WriteLine(book_03.ToString());
            Console.WriteLine(book_04.ToString());
        }
    }
}
