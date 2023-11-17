namespace Lab11.Models
{
    public class Detail
    {

        public int DetailId { get; set; }
        public int Price { get; set; }
        public int Amount {  get; set; }
        public string Subtotal { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
