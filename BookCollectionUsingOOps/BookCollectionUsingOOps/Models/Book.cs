namespace BookCollectionUsingOOps.Models
{
    public class Book
    {
        private int _id;
        private string _title;
        private string _author;
        private int _year;

        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
    }
}
