using WebSisParApi.Dto.CategoryDto;

namespace WebSisParApi.Dto.CategoryDtos
{
    public class GetByIdCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
