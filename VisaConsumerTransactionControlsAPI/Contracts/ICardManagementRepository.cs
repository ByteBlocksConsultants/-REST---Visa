using System.Threading.Tasks;
using VisaConsumerTransactionControlsAPI.Controllers;
using VisaConsumerTransactionControlsAPI.Models;
using VisaConsumerTransactionControlsAPI.Models.Request;
using VisaConsumerTransactionControlsAPI.Models.Response;
using VisaConsumerTransactionControlsAPI.Repositories;

namespace VisaConsumerTransactionControlsAPI.Contracts
{
    public interface ICardManagementRepository
    {
        /// <summary>
        /// Register card for remote management
        /// </summary>
        /// <param name="cardNumber">Visa Card Pan number</param>
        /// <returns></returns>
        Task<ActivationResponse> ActivateCard(string cardNumber);
        Task<ActivationResponse> ActivateCard(ActivationRequest request);

        /// <summary>
        /// Global Block - Turn on/off credit/debit card at any time so that a
        /// fraudulent transaction(s) are prevented. 
        /// </summary>
        /// <returns></returns>
        Task<object> BlockCard(CardConfigurationFilter request);
         
        Task<CardConfigurationResponse> GetCardConfigurations(string accountNumber);
          
        Task CreateCardConfiguration(CardConfigurationFilter cardConfigurationFilter);
        Task UpdateCardConfiguration(CardConfigurationFilter cardConfigurationFilter);
        Task<DeleteResponse> DeleteCardConfiguration(ControlDeleteRequest cardConfigurationFilter);
    }
}