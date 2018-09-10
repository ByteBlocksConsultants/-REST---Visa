using System.Collections.Generic;
using System.Threading.Tasks;
using VisaConsumerTransactionControlsAPI.Contracts;
using VisaConsumerTransactionControlsAPI.Models;
using VisaConsumerTransactionControlsAPI.Models.Request;
using VisaConsumerTransactionControlsAPI.Models.Response;

namespace VisaConsumerTransactionControlsAPI.Repositories
{
    class VisaRepository : ICardManagementRepository
    {
        public Task<ActivationResponse> ActivateCard(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<ActivationResponse> ActivateCard(ActivationRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<object> BlockCard(CardConfigurationFilter request)
        {
            throw new System.NotImplementedException();
        }

        public Task<CardConfigurationResponse> GetCardConfigurations(string accountNumber)
        {
            var item = new CardConfigurationResponse
            {
                GlobalControlConfigs =  new List<Control>(),
                TransactionConfigs = new List<TransactionControl>()
            };

            return Task.FromResult<CardConfigurationResponse>(item);
        }

        public Task CreateCardConfiguration(CardConfigurationFilter cardConfigurationFilter)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateCardConfiguration(CardConfigurationFilter cardConfigurationFilter)
        {
            throw new System.NotImplementedException();
        }

        public   Task<DeleteResponse> DeleteCardConfiguration(ControlDeleteRequest cardConfigurationFilter)
        {
            var item = new DeleteResponse
            {
                IsSuccess = true 
            };

            return Task.FromResult<DeleteResponse>(item);
        }
    }
}