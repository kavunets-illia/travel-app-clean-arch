using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using TravelApp.Domain.Entities;
using TravelApp.Domain.Interfaces;

namespace TravelApp.Infrastructure.Repositories
{
    public class JsonTravelRepository : ITravelRepository
    {
        private readonly string _filePath;

        public JsonTravelRepository(string filePath)
        {
            _filePath = filePath;
        }

        public IEnumerable<TravelDestination> GetAllDestinations()
        {
            if (!File.Exists(_filePath))
            {
                return new List<TravelDestination>
                {
                    new TravelDestination("1", "Київ", "Україна", 150.0m),
                    new TravelDestination("2", "Париж", "Франція", 1200.0m),
                    new TravelDestination("3", "Рим", "Італія", 950.0m)
                };
            }
            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<TravelDestination>>(json) ?? new List<TravelDestination>();
        }

        public void SaveDestination(TravelDestination destination)
        {
            var list = new List<TravelDestination>(GetAllDestinations());
            list.Add(destination);
            var json = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}
