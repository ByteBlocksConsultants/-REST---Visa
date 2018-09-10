using System.Threading.Tasks;
using VisaConsumerTransactionControlsAPI.Models;
using VisaConsumerTransactionControlsAPI.Models.Request;
using VisaConsumerTransactionControlsAPI.Models.Response;
using VisaConsumerTransactionControlsAPI.Repositories;

namespace VisaConsumerTransactionControlsAPI.Contracts
{
    public interface ICardManager
    {
        Task<ActivationResponse> RegisterAndActivateCard(ActivationRequest activationRequest);
        Task<CardConfigurationResponse> GetCardConfigurations(string id);
        Task<CardConfigurationResponse> CreateCardConfiguration(CardConfigurationFilter cardConfigurationFilter);
        Task<CardConfigurationResponse> UpdateCardConfiguration(CardConfigurationFilter cardConfigurationFilter);
        Task<DeleteResponse> DeleteCardConfiguration(ControlDeleteRequest entity);
    }
}