using System;

namespace Zovi_Fashion.Models
{
    public class ErrorViewModel
    {               //Request ID
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
