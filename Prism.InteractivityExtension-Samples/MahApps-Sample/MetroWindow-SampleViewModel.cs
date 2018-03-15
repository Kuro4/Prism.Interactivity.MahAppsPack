using Prism.Interactivity.InteractionRequest;
using Prism.InteractivityExtension;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.InteractivityExtension_Samples.MahApps_Sample
{
    public class MetroWindow_SampleViewModel
    {
        public ReactiveProperty<Accents> Accent { get; private set; } = new ReactiveProperty<Accents>(Accents.Blue);
        public ReactiveProperty<Themes> Theme { get; private set; } = new ReactiveProperty<Themes>(Themes.BaseLight);

        public InteractionRequest<Notification> Notification { get; private set; } = new InteractionRequest<Notification>();
        public InteractionRequest<Confirmation> Confirmation { get; private set; } = new InteractionRequest<Confirmation>();

        public ReactiveCommand RaiseNotification { get; private set; } = new ReactiveCommand();
        public ReactiveCommand RaiseConfirmation { get; private set; } = new ReactiveCommand();

        public MetroWindow_SampleViewModel()
        {
            this.RaiseNotification.Subscribe(() => this.Notification.RaiseEx("Notification", "Notification!", n => Console.WriteLine("Notification")));
            this.RaiseConfirmation.Subscribe(() => this.Confirmation.RaiseEx("Confirmation", "Confirmation?", n => Console.WriteLine($"Confirmation:{n.Confirmed}")));
        }
    }
}
