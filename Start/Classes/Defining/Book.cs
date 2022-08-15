using System;

namespace Defining
{
    // classes have a name, unique within the namespace
    public class Book
    {
        // TODO: classes have member variables, or "fields" to hold data
        protected string _name;
        public string _author;
        protected int _pagecount;

        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        public string getDescription()
        {
            return $"{_name} by {_author}";
        }


        // TODO: classes have one or more constructors


        // TODO: methods are used to operate on the class and data

    }
}
