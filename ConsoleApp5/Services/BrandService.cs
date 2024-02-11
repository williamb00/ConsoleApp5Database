using ConsoleApp5.Entities;
using ConsoleApp5.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Services
{
    internal class BrandService
    {
        private readonly BrandRepository _brandRepository;

        public BrandService(BrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public BrandEntity CreateBrand(string name)
        {
            // Skapa ett nytt varumärke med det angivna namnet
            var brandEntity = new BrandEntity
            {
                Name = name
            };

            // Lägg till det nya varumärket i databasen
            brandEntity = _brandRepository.Create(brandEntity);

            return brandEntity;
        }

        public BrandEntity GetBrandById(int id)
        {
            // Hämta varumärket med det angivna ID:et
            var brandEntity = _brandRepository.GetById(id);
            return brandEntity;
        }

        public IEnumerable<BrandEntity> GetAllBrands()
        {
            // Hämta alla varumärken från databasen
            var brands = _brandRepository.GetAll();
            return brands;
        }

        public BrandEntity UpdateBrand(BrandEntity brandEntity)
        {
            // Uppdatera varumärkets information i databasen
            var updatedBrandEntity = _brandRepository.Update(brandEntity);
            return updatedBrandEntity;
        }

        public void DeleteBrand(int id)
        {
            // Ta bort varumärket med det angivna ID:et från databasen
            _brandRepository.Delete(id);
        }
    }
}