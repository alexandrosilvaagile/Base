using FluentValidation;
using FluentValidation.Results;
using System.Linq;
using System.Text.Json.Serialization;

namespace Base.Infra.CrossCutting.Utils
{
    public abstract class Validatable
    {
        [JsonIgnore]
        public ValidationResult ValidationResult { get; private set; }
        [JsonIgnore]
        public bool IsValid => Validate();
        [JsonIgnore]
        public bool IsInvalid => !IsValid;

        protected Validatable()
        {
            ValidationResult = new ValidationResult();
        }

        public virtual bool Validate()
        {
            return ValidationResult.IsValid;
        }
        protected bool UseValidator<TModel>(TModel model, AbstractValidator<TModel> validator)
        {
            var result = validator.Validate(model);
            if (!result.IsValid)
            {
                AddNotifications(result);
            }
            return ValidationResult.IsValid;
        }
        public void AddNotification(string errorMessage) => AddNotification(propertyName: string.Empty, errorMessage);
        public void AddNotification(string propertyName, string errorMessage) => AddNotification(new ValidationFailure(propertyName, errorMessage));
        protected void AddNotifications(ValidationResult validationResult)
        {
            foreach (var failure in validationResult.Errors)
            {
                AddNotification(failure);
            }
        }
        private void AddNotification(ValidationFailure failure)
        {
            if (string.IsNullOrEmpty(failure.ErrorMessage))
            {
                return;
            }
            if (ValidationResult.Errors.Any(f =>
                f.PropertyName == failure.PropertyName &&
                f.ErrorMessage == failure.ErrorMessage))
            {
                return;
            }
            ValidationResult.Errors.Add(failure);
        }
    }
}
