using Prism.Interactivity.InteractionRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.InteractivityExtension.InteractionRequest
{
    public interface IPick : INotification
    {
        bool IsMultiSelect { get; set; }
        object PickedItem { get; }
    }
}
