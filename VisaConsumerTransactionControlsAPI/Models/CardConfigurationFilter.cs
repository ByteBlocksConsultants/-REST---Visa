using System.Collections.Generic;

namespace VisaConsumerTransactionControlsAPI.Models
{
    public class CardConfigurationFilter
    {
        public IList<Control> GlobalControlConfigs { get; set; }

        public IList<TransactionControl> TransactionConfigs { get; set; }

        public RequestingEntity RequestingEntity { get; set; }
    }
}