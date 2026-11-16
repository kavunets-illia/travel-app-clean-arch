using System.Collections.Generic;
using TravelApp.Domain.Entities;

namespace TravelApp.Domain.Interfaces
{
    public interface ITravelRepository
    {
        IEnumerable<TravelDestination> GetAllDestinations();
        void SaveDestination(TravelDestination destination);
    }
}
