using Prism.Interactivity.InteractionRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.InteractivityExtension.InteractionRequest
{
    public class FilePick : Notification, IPick
    {
        public bool IsMultiSelect { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object PickedItem => throw new NotImplementedException();
    }
}
