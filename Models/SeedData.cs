using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tankdaten.Data;
using System;
using System.Linq;
using Tankdaten.Models;

namespace Tankdaten.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new TankdatenContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<TankdatenContext>>()))
        {
            // Look for any movies.
            if (context.TankdatenViewModel.Any())
            {
                return;   // DB has been seeded
            }
            context.TankdatenViewModel.AddRange(
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IT-256",
                    GetanktAm = DateTime.Parse("2025-02-28"),
                    Kosten = 76.24M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IT-256",
                    GetanktAm = DateTime.Parse("2025-02-16"),
                    Kosten = 69.84M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IT-256",
                    GetanktAm = DateTime.Parse("2025-02-01"),
                    Kosten = 72.35M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IT-256",
                    GetanktAm = DateTime.Parse("2025-01-06"),
                    Kosten = 45.50M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IT-256",
                    GetanktAm = DateTime.Parse("2024 -12-12"),
                    Kosten = 78.22M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IT-512",
                    GetanktAm = DateTime.Parse("2025-02-26"),
                    Kosten = 69.85M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IT-512",
                    GetanktAm = DateTime.Parse("2025-02-18"),
                    Kosten = 65.94M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IT-512",
                    GetanktAm = DateTime.Parse("2025-01-27"),
                    Kosten = 50.84M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IT-512",
                    GetanktAm = DateTime.Parse("2025-01-16"),
                    Kosten = 59.65M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IT-512",
                    GetanktAm = DateTime.Parse("2024-12-27"),
                    Kosten = 63.78M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IT-512",
                    GetanktAm = DateTime.Parse("2024-12-08"),
                    Kosten = 63.71M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-OB-80",
                    GetanktAm = DateTime.Parse("2025-02-04"),
                    Kosten = 40.19M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-OB-80",
                    GetanktAm = DateTime.Parse("2024-12-23"),
                    Kosten = 60.23M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-OB-80",
                    GetanktAm = DateTime.Parse("2024-11-24"),
                    Kosten = 51.78M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IO-420",
                    GetanktAm = DateTime.Parse("2025-03-01"),
                    Kosten = 73.81M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IO-420",
                    GetanktAm = DateTime.Parse("2025-02-07"),
                    Kosten = 57.92M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IO-420",
                    GetanktAm = DateTime.Parse("2025-01-12"),
                    Kosten = 56.23M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IO-420",
                    GetanktAm = DateTime.Parse("2024-12-22"),
                    Kosten = 71.01M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IO-420",
                    GetanktAm = DateTime.Parse("2024-12-02"),
                    Kosten = 66.89M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IO-420",
                    GetanktAm = DateTime.Parse("2024-11-28"),
                    Kosten = 88.18M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IT-128",
                    GetanktAm = DateTime.Parse("2025-02-23"),
                    Kosten = 23.70M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IT-128",
                    GetanktAm = DateTime.Parse("2025-01-28"),
                    Kosten = 50.25M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IT-128",
                    GetanktAm = DateTime.Parse("2025-01-06"),
                    Kosten = 55.70M
                },
                new TankdatenViewModel
                {
                    Fahrzeug = "B-IT-128",
                    GetanktAm = DateTime.Parse("2024-12-15"),
                    Kosten = 62.35M
                }
            );
            context.SaveChanges();
        }
    }
}

