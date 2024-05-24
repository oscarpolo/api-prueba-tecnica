namespace ApiPruebaTecnica.Entities
{
    public class NewOrderDto
    {
        public int CustomerID { get; set; }
        public string? CustomerAddress { get; set; }
        public List<ProducsOrderDto>? ProductsOrder { get; set; }
    }
}
