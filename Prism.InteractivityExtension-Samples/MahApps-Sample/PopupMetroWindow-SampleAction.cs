using Prism.Interactivity.InteractionRequest;
using Prism.InteractivityExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prism.InteractivityExtension_Samples.MahApps_Sample
{
    public class PopupMetroWindow_SampleAction : PopupWindowActionBase
    {
        protected override Window CreateWindow(INotification notification)
        {
            return new MetroWindow_Sample() { Title = notification.Title };
        }

        protected override void ApplyNotificationToWindow(Window window, INotification notification)
        {
        }
    }
}