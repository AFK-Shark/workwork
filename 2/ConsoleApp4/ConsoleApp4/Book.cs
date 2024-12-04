using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Book<T>
    {
        string name;
        int pagesCount;
        string author;
        T id;
        public Book(string names, int pagesCounts, string authors, T ids)
        {
            name = names;
            pagesCount = pagesCounts;
            author = authors;
            id = ids;
        }

        public override string ToString()
        {
            return $"{name},{pagesCount},{author},{id}";
        }
    }
}
