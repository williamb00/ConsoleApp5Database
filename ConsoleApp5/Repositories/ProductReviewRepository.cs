﻿using ConsoleApp5.Contexts;
using ConsoleApp5.Entities;
using ConsoleApp5.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Repositories
{
    internal class ProductReviewRepository : Repo<ProductReviewEntity>
    {
        public ProductReviewRepository(DataContext context) : base(context)
        {
        }

        internal void Delete(int id)
        {
            throw new NotImplementedException();
        }

        internal ProductReviewEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        internal ProductReviewEntity Update(ProductReviewEntity productReviewEntity)
        {
            throw new NotImplementedException();
        }
    }
}