using ConsoleApp5.Entities;
using ConsoleApp5.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Services
{
    internal class ProductReviewService
    {
        private readonly ProductReviewRepository _productReviewRepository;

        public ProductReviewService(ProductReviewRepository productReviewRepository)
        {
            _productReviewRepository = productReviewRepository;
        }

        public ProductReviewEntity CreateProductReview(int productId, int customerId, string comment, int rating)
        {
            var productReviewEntity = new ProductReviewEntity
            {
                ProductId = productId,
                CustomerId = customerId,
                Comment = comment,
                Rating = rating
            };

            productReviewEntity = _productReviewRepository.Create(productReviewEntity);

            return productReviewEntity;
        }

        public ProductReviewEntity GetProductReviewById(int id)
        {
            var productReviewEntity = _productReviewRepository.GetById(id);
            return productReviewEntity;
        }

        public IEnumerable<ProductReviewEntity> GetAllProductReviews()
        {
            var productReviews = _productReviewRepository.GetAll();
            return productReviews;
        }

        public ProductReviewEntity UpdateProductReview(ProductReviewEntity productReviewEntity)
        {
            var updatedProductReviewEntity = _productReviewRepository.Update(productReviewEntity);
            return updatedProductReviewEntity;
        }

        public void DeleteProductReview(int id)
        {
            _productReviewRepository.Delete(id);
        }
    }
}