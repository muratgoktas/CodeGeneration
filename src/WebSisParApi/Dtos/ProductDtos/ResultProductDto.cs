namespace WebSisParApi.Dto.ProductDtos
{
    public class ResultProductDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int CategoryId { get; set; }
    }
}
