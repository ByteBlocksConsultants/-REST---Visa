using VisaConsumerTransactionControlsAPI.Models;

namespace VisaConsumerTransactionControlsAPI.Contracts
{
    public interface IControl
    {
        /// <summary>
        /// Function enabled or disabled
        /// </summary>
        bool IsEnabled { get; set; }

        /// <summary>
        /// Decline options
        /// </summary>
        DeclineOptions DeclineOptions { get; set; }

        /// <summary>
        /// Alert options
        /// </summary>
        AlertOptions AlertOptions { get; set; }
    }
}