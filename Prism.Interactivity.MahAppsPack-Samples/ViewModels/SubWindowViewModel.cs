using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Interactivity.MahAppsPack;
using Prism.Mvvm;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Prism.Interactivity.MahAppsPack_Samples.ViewModels
{
    public class SubWindowViewModel : BindableBase, IInteractionRequestAware
    {
        INotification IInteractionRequestAware.Notification { get; set; }
        public Action FinishInteraction { get; set; }

        public ReactiveProperty<Accents> Accent { get; private set; } = new ReactiveProperty<Accents>(Accents.Blue);
        public ReactiveProperty<Themes> Theme { get; private set; } = new ReactiveProperty<Themes>(Themes.BaseLight);

        public InteractionRequest<Notification> Notification { get; private set; } = new InteractionRequest<Notification>();
        public InteractionRequest<Confirmation> Confirmation { get; private set; } = new InteractionRequest<Confirmation>();

        public ReactiveCommand RaiseNotification { get; private set; } = new ReactiveCommand();
        public ReactiveCommand RaiseConfirmation { get; private set; } = new ReactiveCommand();

        public SubWindowViewModel()
        {
            this.RaiseNotification.Subscribe(() => this.Notification.Raise(new Notification()
            {
                Title = "Notification",
                Content = "Notification!",
            }, n => Console.WriteLine("Notification")));
            this.RaiseConfirmation.Subscribe(() => this.Confirmation.Raise(new Confirmation()
            {
                Title = "Confirmation",
                Content = "Confirmation?",
            }, n => Console.WriteLine($"Confirmation:{n.Confirmed}")));
        }
    }
}
