namespace Supermarket
{

    public abstract class Product : IPay
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public abstract decimal ValueToPay();               
        
        public override string ToString()
        {
            return$"{Id} - {Description}, " +
                $"\n\tPrice........:    {Price:N2}" +
                $"\n\tTax..........:    {Tax*100:N2}%";
        }
        
    }
    
}
