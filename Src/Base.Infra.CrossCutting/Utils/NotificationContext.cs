using Base.Infra.CrossCutting.Utils.Interfaces;
using FluentValidation.Results;
using System.Collections.Generic;

namespace Base.Infra.CrossCutting.Utils
{
    public class NotificationContext : INotificationContext
    {
        public IReadOnlyCollection<Notification> Notifications => throw new System.NotImplementedException();

        public bool HasNotifications => throw new System.NotImplementedException();

        public void AddNotification(string message)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotification(string key, string message)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotification(Notification notification)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotifications(IReadOnlyCollection<Notification> notifications)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotifications(IList<Notification> notifications)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotifications(ICollection<Notification> notifications)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotifications(ICollection<string> notifications)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotifications(IEnumerable<string> notifications)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotifications(IEnumerable<Validatable> validatables)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotifications(Validatable validatable)
        {
            throw new System.NotImplementedException();
        }

        public void AddNotifications(ValidationResult validationResult)
        {
            throw new System.NotImplementedException();
        }

        public void ClearNotifications()
        {
            throw new System.NotImplementedException();
        }
    }
}
