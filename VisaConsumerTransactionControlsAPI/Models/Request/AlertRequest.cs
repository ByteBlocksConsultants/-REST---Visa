namespace VisaConsumerTransactionControlsAPI.Models.Request
{
    public interface IAlertRequest
    {
        AlertType AlertType { get; set; }
    }

    public enum AlertType
    {
       
    }

    public class AlertRequest : IAlertRequest
    {
        public AlertRequest()
        {
        }

        public AlertType AlertType { get; set; }
    }
}