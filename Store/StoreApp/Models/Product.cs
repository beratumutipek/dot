namespace StoreApp.Models

{
    public class Product
    {
        public int ProductID { get; set; }
        
        public string ProductName { get; set;} = String.Empty;

        public decimal Price { get; set; }
    }    
}