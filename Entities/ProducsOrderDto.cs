namespace ApiPruebaTecnica.Entities
{
    public class ProducsOrderDto
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int Total { get; set; }
    }
}
