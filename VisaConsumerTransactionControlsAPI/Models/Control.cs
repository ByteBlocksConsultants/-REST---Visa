using VisaConsumerTransactionControlsAPI.Contracts;

namespace VisaConsumerTransactionControlsAPI.Models
{
    public class Control : IControl
    { 
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Decline Options
        /// </summary>
        public DeclineOptions DeclineOptions { get; set; }

        /// <summary>
        /// Alert options
        /// </summary>
        public AlertOptions AlertOptions { get; set; }
    }
}