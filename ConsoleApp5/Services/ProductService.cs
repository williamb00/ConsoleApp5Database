using ConsoleApp5.Entities;
using ConsoleApp5.Repositories;
using ConsoleApp5.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Services
{
    internal class ProductService
    {
        private readonly ProductRepository _productRepository;
        private readonly BrandService _brandService; 

        public ProductService(ProductRepository productRepository, BrandService brandService)
        {
            _productRepository = productRepository;
            _brandService = brandService; 
        }


        public ProductEntity CreateProduct(string Name, decimal price, string brandName) 
        {

            var brandEntity = _brandService.CreateBrand(brandName); 

            var productEntity = new ProductEntity
            {
                Name = Name,
                Price = price,
                BrandId = brandEntity.Id, 
            };

            productEntity = _productRepository.Create(productEntity);
            return productEntity;
        }



        public ProductEntity GetProductById(int id)
        {
            var productEntity = _productRepository.Get(x => x.Id == id);
            return productEntity;
        }

        public IEnumerable<ProductEntity> GetProducts()
        {
            var products = _productRepository.GetAll();
            return products;
        }

        public ProductEntity UpdateProduct(ProductEntity productEntity)
        {
            var updatedProductEntity = _productRepository.Update(x => x.Id == productEntity.Id, productEntity);
            return updatedProductEntity;
        }


        public void DeleteProduct(int id)
        {
            _productRepository.Delete(x => x.Id == id);
        }
    }
}