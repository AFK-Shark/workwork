namespace ConsoleApp4
{
    using System;
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }
        public override string ToString()
        {
            return $"{Name} by {Author}";
        }
    }
    public class GenericValue<T>
    {
        public T Value { get; set; }
        public GenericValue(T value)
        {
            Value = value;
        }
        public void Reset()
        {
            Value = default(T);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericValue<int> intValue = new GenericValue<int>(42);
            Console.WriteLine($"Value intValue: {intValue.Value}");
            GenericValue<Book> bookValue = new GenericValue<Book>(new Book("1984", "George Orwell"));
            Console.WriteLine($"Value bookValue: {bookValue.Value}");
            intValue.Reset();
            Console.WriteLine($"After using Reset, value intValue: {intValue.Value}");
            bookValue.Reset();
            Console.WriteLine($"After using Reset, value bookValue: {bookValue.Value}");
        }
    }
}
