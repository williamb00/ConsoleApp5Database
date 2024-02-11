using ConsoleApp5.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Entities
{
    internal class ProductReviewEntity
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int CustomerId { get; set; }

        public string Comment { get; set; } = null!;

        public int Rating { get; set; }

        public ProductEntity Product { get; set; } = null!;

        public CustomerEntity Customer { get; set; } = null!;
    }
}