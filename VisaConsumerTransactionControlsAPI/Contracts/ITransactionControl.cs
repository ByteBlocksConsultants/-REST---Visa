namespace VisaConsumerTransactionControlsAPI.Contracts
{
    public interface ITransactionControl
    {
        /// <summary>
        /// Type of code that makes sens to the
        /// provider (ex: provider here is Vasa
        /// "TCT_ATM_WITHDRAW", "TCT_CROSS_BORDER")
        /// </summary>
         string ControlTypeCode { get; set; }
    }
}