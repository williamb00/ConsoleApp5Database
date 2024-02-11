using ConsoleApp5.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{

    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\willi\OneDrive\Skrivbord\Datalagring\ConsoleApp5\ConsoleApp5\Data\database.mdf;Integrated Security=True;Connect Timeout=30"));

}).Build();