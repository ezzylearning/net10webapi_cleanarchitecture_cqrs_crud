namespace MyShop.Domain.Products
{
    public class Product
    {
        public int ProductId { get; private set; }
        public string ProductName { get; private set; }
        public int? SupplierId { get; private set; }
        public int? CategoryId { get; private set; }
        public string QuantityPerUnit { get; private set; }
        public decimal UnitPrice { get; private set; }
        public short UnitsInStock { get; private set; }
        public short UnitsOnOrder { get; private set; }
        public short ReorderLevel { get; private set; }
        public bool Discontinued { get; private set; }

        private Product() { }

        private Product(
            string productName, 
            decimal unitPrice, 
            short unitsInStock)
        {            
            ProductName = productName;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
            Discontinued = false;
        }

        public static Product Create(
            string productName,
            decimal unitPrice,
            short unitsInStock)
        {
            return new Product(productName, unitPrice, unitsInStock);
        }

        public void Update(
            string productName,
            decimal unitPrice,
            short unitsInStock)
        {
            ProductName = productName;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
        }
    }
}
