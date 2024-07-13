using Library_generics_task.Exceptions;

namespace Library_generics_task
{
    public class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public Book(decimal price, string authorname, int pagecount)
        {
            Price = price;
            AuthorName = authorname;
            PageCount = pagecount;
        }
        public override void Sell()
        {
            if (Count > 0)
            {
                Count--;
                TotalIncome += Price;
            }
            else
            {
                throw new ProductCountIsZeroException("Product count is zero. Cannot sell.");
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Book Id: {Id} - Name: {Name} - Price: {Price}- Author: {AuthorName} -  Page Count: {PageCount}");
        }
    }









}

