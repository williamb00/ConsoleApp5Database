using ConsoleApp5;
using ConsoleApp5.Contexts;
using ConsoleApp5.Repositories;
using ConsoleApp5.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{

    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\willi\OneDrive\Skrivbord\Datalagring\ConsoleApp5\ConsoleApp5\Data\database.mdf;Integrated Security=True;Connect Timeout=30"));

    services.AddScoped<AddressRepository>();
    services.AddScoped<BrandRepository>();
    services.AddScoped<CustomerRepository>();
    services.AddScoped<ProductRepository>();
    services.AddScoped<ProductReviewRepository>();
    services.AddScoped<AddressService>();
    services.AddScoped<BrandService>();
    services.AddScoped<CustomerService>();
    services.AddScoped<ProductService>();
    services.AddScoped<ProductReviewService>();

    services.AddSingleton<ConsoleUI>();

}).Build();

var consoleUI = builder.Services.GetRequiredService<ConsoleUI>();

consoleUI.CreateProduct_UI();
consoleUI.GetProducts_UI();
consoleUI.UpdateProduct_UI();
consoleUI.DeleteProduct_UI();