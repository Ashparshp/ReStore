namespace API.Entities
{
    public class Product
    {
        internal int QuantityInStock;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }

        public string PictureUrl { get; set; }

        public String Type { get; set; }

        public String Brand { get; set; }

        public int Quantity { get; set; }
        
    }
}