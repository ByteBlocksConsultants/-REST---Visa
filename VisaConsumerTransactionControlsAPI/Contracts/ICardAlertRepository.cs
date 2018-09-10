using VisaConsumerTransactionControlsAPI.Models;
using VisaConsumerTransactionControlsAPI.Models.Request;

namespace VisaConsumerTransactionControlsAPI.Contracts
{
    public interface ICardAlertRepository
    { 
        object CreateAlert(AlertRequest alertRequest);
        object RemoveAlert(AlertRequest alertRequest);
        object CrossBorderAlert();
        object TransactionThresholdAlerts();  
        object EcommerceAlert();
    }
}