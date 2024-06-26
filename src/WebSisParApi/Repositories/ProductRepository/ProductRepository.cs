﻿using Dapper;
using WebApi.Models.DapperContext;
using WebSisParApi.Dtos.CategoryDtos;
using WebSisParApi.Dtos.ProductDtos;
using WebSisParApi.Dtos.ProductDtos;

namespace WebSisParApi.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * from dbo.Product ";

            using (var connection = _context.CreateConnecon())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "Select Product.Id,Product.Title,Product.Price,City,Product.District,Product.CoverImage,Product.Description,"+
                "Category.Name from dbo.Product inner join dbo.Category on " +
                " Product.CategoryId =Category.Id  ";

            using (var connection = _context.CreateConnecon())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}
