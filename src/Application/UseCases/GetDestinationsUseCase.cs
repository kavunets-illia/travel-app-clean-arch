using System.Collections.Generic;
using TravelApp.Domain.Entities;
using TravelApp.Domain.Interfaces;

namespace TravelApp.Application.UseCases
{
    public class GetDestinationsUseCase
    {
        private readonly ITravelRepository _travelRepository;

        public GetDestinationsUseCase(ITravelRepository travelRepository)
        {
            _travelRepository = travelRepository;
        }

        public IEnumerable<TravelDestination> Execute()
        {
            return _travelRepository.GetAllDestinations();
        }
    }
}
