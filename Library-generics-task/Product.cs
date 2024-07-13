namespace Library_generics_task
{
    public abstract class Product
    {
        private static int _id = 0;
        public int Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalIncome { get; protected set; }

        public Product()
        {
            Id = ++_id;
        }

        public abstract void Sell();
        public abstract void ShowInfo();
    }
}
