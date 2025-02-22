namespace SimpleWebApiFullCrud.Dtos
{
    public class PutProductServiceDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public decimal UnitPrice { get; set; }
        public string? Description { get; set; }

    }
}
