﻿namespace WebSisPar.Dtos.ProductDtos
{
    public class CreateProductDtos
    {
       
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string CategoryId { get; set; }
        public string CoverImage { get; set; }
        public string Description { get; set; }
    }
}
