namespace VisaConsumerTransactionControlsAPI.Models
{
    public class DeclineOptions
    {
        public bool DeclineAll { get; set; }

        public decimal DeclineThresholdAmount { get; set; }
    }
}