using ConsoleApp5.Services;

namespace ConsoleApp5
{
    internal class ConsoleUI
    {
        private readonly ProductService _productService;

        public ConsoleUI(ProductService productService)
        {
            _productService = productService;
        }

        // PRODUCTS
        public void CreateProduct_UI()
        {
            Console.Clear();
            Console.WriteLine("---- CREATE PRODUCT ----");

            Console.Write("Product Title: ");
            var title = Console.ReadLine()!;

            Console.Write("Product Price: ");
            var price = decimal.Parse(Console.ReadLine()!);

            Console.Write("Product Brand: ");
            var brandName = Console.ReadLine()!;

            var result = _productService.CreateProduct(title, price, brandName);
            if (result != null)
            {
                Console.Clear();
                Console.WriteLine("Product was created.");
                Console.ReadKey();
            }
        }
        public void GetProducts_UI()
        {
            Console.Clear();

            var products = _productService.GetProducts();
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Brand} ({product.Price} SEK)");
            }

            Console.ReadKey();
        }
        public void UpdateProduct_UI()
        {
            Console.Clear();
            Console.Write("Enter Product Id: ");
            var id = int.Parse(Console.ReadLine()!);

            var product = _productService.GetProductById(id);
            if (product != null)
            {
                Console.WriteLine($"{product.Name} - {product.Brand} ({product.Price} SEK)");
                Console.WriteLine();

                Console.Write("New Product Title: ");
                product.Name = Console.ReadLine()!;

                var newProduct = _productService.UpdateProduct(product);
                Console.WriteLine($"{product.Name} - {product.Brand} ({product.Price} SEK)");
            }
            else
            {
                Console.WriteLine("No product found.");
            }

            Console.ReadKey();
        }
        public void DeleteProduct_UI()
        {
            Console.Clear();
            Console.Write("Enter Product Id: ");
            var id = int.Parse(Console.ReadLine()!);

            var product = _productService.GetProductById(id);
            if (product != null)
            {
                _productService.DeleteProduct(id);
                Console.WriteLine("Product was deleted");
            }
            else
            {
                Console.WriteLine("No product found.");
            }

            Console.ReadKey();
        }
    }
}