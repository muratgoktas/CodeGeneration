namespace WebSisParApi.Dtos.ProductDtos;

public class ResultProductDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string City { get; set; }
    public string District { get; set; }
    public string CoverImage { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
}
