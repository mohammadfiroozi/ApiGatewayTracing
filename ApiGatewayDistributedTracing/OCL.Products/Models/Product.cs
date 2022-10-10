namespace OCL.Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }

        public  static List<Product> GetProducts()
        {
            return new List<Product>()
            {
               new()
               {
                   Id=0,
                   Title="Samsung A73",
                   Qty=3,
                   Price=15000000
               },
                new()
               {
                   Id=1,
                   Title="Samsung Galaxy Watch  5",
                   Qty=6,
                   Price=5000000
               },
                 new()
               {
                   Id=2,
                   Title="IPhone 14 Pro Max",
                   Qty=12,
                   Price=65000000
               },
                  new()
               {
                   Id=3,
                   Title="Samsung A70",
                   Qty=32,
                   Price=1000000
               }
            };
        }
    }
}
