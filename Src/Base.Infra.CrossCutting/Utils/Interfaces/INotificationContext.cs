using System.Collections.Generic;
using FluentValidation.Results;

namespace Base.Infra.CrossCutting.Utils.Interfaces
{
    public interface INotificationContext
    {
        IReadOnlyCollection<Notification> Notifications { get; }
        bool HasNotifications { get; }
        void AddNotification(string message);
        void AddNotification(string key, string message);
        void AddNotification(Notification notification);
        void AddNotifications(IReadOnlyCollection<Notification> notifications);
        void AddNotifications(IList<Notification> notifications);
        void AddNotifications(ICollection<Notification> notifications);
        void AddNotifications(IEnumerable<Notification> notifications);
        void AddNotifications(ICollection<string> notifications);
        void AddNotifications(IEnumerable<string> notifications);
        void AddNotifications(IEnumerable<Validatable> validatables);
        void AddNotifications(Validatable validatable);
        void AddNotifications(ValidationResult validationResult);

        void ClearNotifications();
    }
}
