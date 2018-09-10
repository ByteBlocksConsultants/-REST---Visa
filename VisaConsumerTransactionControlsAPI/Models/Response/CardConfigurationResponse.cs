using System.Collections.Generic;

namespace VisaConsumerTransactionControlsAPI.Models.Response
{
    public class CardConfigurationResponse : BaseResponse
    {
        public IList<Control> GlobalControlConfigs { get; set; }

        public IList<TransactionControl> TransactionConfigs { get; set; }
    }
}