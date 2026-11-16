using System;
using TravelApp.Application.UseCases;
using TravelApp.Domain.Interfaces;
using TravelApp.Infrastructure.Repositories;

namespace TravelApp.Presentation.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            ITravelRepository repository = new JsonTravelRepository("destinations.json");
            var getDestinationsUseCase = new GetDestinationsUseCase(repository);

            Console.WriteLine("=== ДОСТУПНІ ТУРИСТИЧНІ НАПРЯМКИ ===");
            var destinations = getDestinationsUseCase.Execute();

            foreach (var dest in destinations)
            {
                Console.WriteLine($"Локація: {dest.Name} ({dest.Country}) — Ціна: {dest.Price} USD");
            }
        }
    }
}
