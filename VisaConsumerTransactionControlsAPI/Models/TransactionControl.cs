using VisaConsumerTransactionControlsAPI.Contracts;

namespace VisaConsumerTransactionControlsAPI.Models
{
    public class TransactionControl : IControl, ITransactionControl
    {
        public bool IsEnabled { get; set; }
        public DeclineOptions DeclineOptions { get; set; }
        public AlertOptions AlertOptions { get; set; }
        public string ControlTypeCode { get; set; }
    }
}