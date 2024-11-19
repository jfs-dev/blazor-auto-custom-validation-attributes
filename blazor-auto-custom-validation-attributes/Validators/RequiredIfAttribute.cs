using System.ComponentModel.DataAnnotations;

namespace blazor_auto_custom_validation_attributes.Validators;

public class RequiredIfAttribute(string dependentProperty, object targetValue) : ValidationAttribute
{
    private readonly string _dependentProperty = dependentProperty;
    private readonly object _targetValue = targetValue;

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var dependentProperty = validationContext.ObjectType.GetProperty(_dependentProperty);

        if (dependentProperty is null)
            return new ValidationResult($"A propriedade { _dependentProperty } não foi encontrada.", [validationContext.MemberName!]);

        var dependentValue = dependentProperty.GetValue(validationContext.ObjectInstance);

        if (dependentValue is not null && dependentValue.Equals(_targetValue))
            if (value is null || string.IsNullOrWhiteSpace(value.ToString()))
                return new ValidationResult(ErrorMessage ?? $"{ validationContext.DisplayName } é obrigatório.", [validationContext.MemberName!]);

        return ValidationResult.Success;
    }
}
