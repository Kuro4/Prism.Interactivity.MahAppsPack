using Prism.Interactivity.InteractionRequest;
using Prism.InteractivityExtension;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.InteractivityExtension_Samples
{
    public class MainWindowViewModel
    {
        #region Normal
        public InteractionRequest<Notification> NormalNotification { get; private set; } = new InteractionRequest<Notification>();
        public InteractionRequest<Confirmation> NormalConfirmation{ get; private set; } = new InteractionRequest<Confirmation>();
        public InteractionRequest<Notification> SubWindowNotification { get; private set; } = new InteractionRequest<Notification>();

        public ReactiveCommand RaiseNormalNotification { get; private set; } = new ReactiveCommand();
        public ReactiveCommand RaiseNormalConfirmation{ get; private set; } = new ReactiveCommand();
        public ReactiveCommand RaiseSubWindowNotification { get; private set; } = new ReactiveCommand();
        #endregion
        #region Metro
        public InteractionRequest<Notification> MetroNotification { get; private set; } = new InteractionRequest<Notification>();
        public InteractionRequest<Confirmation> MetroConfirmation { get; private set; } = new InteractionRequest<Confirmation>();
        public InteractionRequest<Notification> MetroWindowNotification { get; private set; } = new InteractionRequest<Notification>();

        public ReactiveCommand RaiseMetroNotification { get; private set; } = new ReactiveCommand();
        public ReactiveCommand RaiseMetroConfirmation{ get; private set; } = new ReactiveCommand();
        public ReactiveCommand RaiseMetroWindowNotification{ get; private set; } = new ReactiveCommand();
        #endregion

        public MainWindowViewModel()
        {
            this.RaiseNormalNotification.Subscribe(() => this.NormalNotification.RaiseEx("NormalNotification", "NormalNotification", n => Console.WriteLine("NormalNotification")));
            this.RaiseNormalConfirmation.Subscribe(() => this.NormalConfirmation.RaiseEx("NormalConfirmation", "NormalConfirmation?", n => Console.WriteLine($"NormalConfirmation:{n.Confirmed}")));
            this.RaiseSubWindowNotification.Subscribe(() => this.SubWindowNotification.RaiseEx("SubWindowNotification", "SubWindowNotification", n => Console.WriteLine("SubWindowNotification")));

            this.RaiseMetroNotification.Subscribe(() => this.MetroNotification.RaiseEx("MetroNotification", "MetroNotification", n => Console.WriteLine("MetroNotification")));
            this.RaiseMetroConfirmation.Subscribe(() => this.MetroConfirmation.RaiseEx("MetroConfirmation", "MetroConfirmation?", n => Console.WriteLine($"Metro:{n.Confirmed}")));
            this.RaiseMetroWindowNotification.Subscribe(() => this.MetroWindowNotification.RaiseEx("MetroWindowNotification", "", n => Console.WriteLine("MetroWindowNotification")));
            
        }
    }
}
