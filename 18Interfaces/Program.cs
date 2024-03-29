﻿using System;
using System.Globalization;
using Course18Interfaces.Entities;
using Course18Interfaces.Services;

namespace Course18Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter rental data
            Console.WriteLine("** Enter rental data **");   // Dados do aluguel de carro
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            // INVOICE
            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));     // instanciando o objeto
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);    // gera invoice associado ao aluguel

            Console.WriteLine("\nINVOICE");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
