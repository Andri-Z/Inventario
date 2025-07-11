using Inventario.Context;
using Inventario.Forms;
using Inventario.Interfaces;
using Inventario.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;

namespace Inventario
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            var frmServices = host.Services.GetRequiredService<FrmCategorias>();

            Application.Run(frmServices);
        }
        static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) =>
            {
                config.AddJsonFile("appsettings.json");
            }).ConfigureServices((context, services) =>
            {
                services.AddDbContext<InventarioContext>(options =>
                    options.UseSqlServer(context.Configuration.GetConnectionString("InventarioDB")));

                services.AddTransient<FrmCategorias>();
                services.AddTransient<ICategorias, CategoriasServices>();
            });
    }
}