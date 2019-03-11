using Prism.Interactivity.InteractionRequest;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.Interactivity.MahAppsPack_Samples.ViewModels
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
            this.RaiseNormalNotification.Subscribe(() => this.NormalNotification.Raise(new Notification()
            {
                Title = "NormalNotification",
                Content = "NormalNotification",
            }, n => Console.WriteLine("NormalNotification")));
            this.RaiseNormalConfirmation.Subscribe(() => this.NormalConfirmation.Raise(new Confirmation()
            {
                Title = "NormalConfirmation",
                Content = "NormalConfirmation?",
            }, n => Console.WriteLine($"NormalConfirmation:{n.Confirmed}")));
            this.RaiseSubWindowNotification.Subscribe(() => this.SubWindowNotification.Raise(new Notification()
            {
                Title = "SubWindowNotification",
                Content = "SubWindowNotification",
            }, n => Console.WriteLine("SubWindowNotification")));

            this.RaiseMetroNotification.Subscribe(() => this.MetroNotification.Raise(new Notification()
            {
                Title = "MetroNotification",
                Content = "MetroNotification",
            }, n => Console.WriteLine("MetroNotification")));
            this.RaiseMetroConfirmation.Subscribe(() => this.MetroConfirmation.Raise(new Confirmation()
            {
                Title = "MetroConfirmation",
                Content = "MetroConfirmation?",
            }, n => Console.WriteLine($"Metro:{n.Confirmed}")));
            this.RaiseMetroWindowNotification.Subscribe(() => this.MetroWindowNotification.Raise(new Notification()
            {
                Title = "MetroWindowNotification",
                Content = "",
            }, n => Console.WriteLine("MetroWindowNotification")));
        }
    }
}
