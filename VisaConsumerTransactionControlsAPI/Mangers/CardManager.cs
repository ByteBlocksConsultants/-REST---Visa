using System.Threading.Tasks;
using VisaConsumerTransactionControlsAPI.Contracts;
using VisaConsumerTransactionControlsAPI.Models.Request;
using VisaConsumerTransactionControlsAPI.Models.Response;

namespace VisaConsumerTransactionControlsAPI.Models
{
    public class CardManager : ICardManager
    {
        private readonly ICardManagementRepository _cardManagementRepository;
        private readonly IDataRepository _dataRepository;

        public CardManager(ICardManagementRepository cardManagementRepository)
        {
            _cardManagementRepository = cardManagementRepository;
        }

        public Task<ActivationResponse> RegisterAndActivateCard(ActivationRequest request)
        {
            return _cardManagementRepository.ActivateCard(request);
        }

        public Task<CardConfigurationResponse> GetCardConfigurations(string id)
        {
            var pan = _dataRepository.GetPlasticInfo(id);

            return _cardManagementRepository.GetCardConfigurations(pan);
        }

        public Task<CardConfigurationResponse> CreateCardConfiguration(CardConfigurationFilter cardConfigurationFilter)
        {
            throw new System.NotImplementedException();
        }

        public async Task<CardConfigurationResponse> UpdateCardConfiguration(CardConfigurationFilter cardConfigurationFilter)
        {
            var id = string.Empty; //TODO: change

            var pan = _dataRepository.GetPlasticInfo(id);

            var config = await _cardManagementRepository.GetCardConfigurations(pan);

            if (config != null)
            {
                //TODO:
                //var cardUpdate = await _cardManagementRepository.UpdateCardConfiguration(cardConfigurationFilter);

                return new CardConfigurationResponse
                {
                    IsSuccess = true
                };
            }

            return new CardConfigurationResponse
            {
                IsSuccess = false
            };
        }
    }
}