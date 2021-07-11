using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCCourse210710.ValidationAttributes
{
    public class ModelClientValidationBudgetRangeRule : ModelClientValidationRule
    {
        public ModelClientValidationBudgetRangeRule(string errorMessage, object minValue, object maxValue)
        {
            ErrorMessage = errorMessage;
            ValidationType = "range"; // 這是 jQuery Unobtrusive validation 內建支援的類型
            ValidationParameters["min"] = minValue;
            ValidationParameters["max"] = maxValue;
        }
    }

    public class BudgetRangeAttributeAdapter : DataAnnotationsModelValidator<RangeAttribute>
    {
        public BudgetRangeAttributeAdapter(ModelMetadata metadata, ControllerContext context, BudgetRangeAttribute attribute)
            : base(metadata, context, attribute)
        {
        }

        public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
        {
            string errorMessage = ErrorMessage;
            return new[] { new ModelClientValidationBudgetRangeRule(errorMessage, Attribute.Minimum, Attribute.Maximum) };
        }
    }

    public class BudgetRangeAttribute : RangeAttribute
    {
        public BudgetRangeAttribute() : base(0, 100)
        {
        }

        public BudgetRangeAttribute(int minimum, int maximum) : base(minimum, maximum)
        {
        }

        public BudgetRangeAttribute(double minimum, double maximum) : base(minimum, maximum)
        {
        }

        public BudgetRangeAttribute(Type type, string minimum, string maximum) : base(type, minimum, maximum)
        {
        }

        public override string FormatErrorMessage(string name)
        {
            ErrorMessage = "請輸入合理的預算範圍 ({1} ~ {2})";
            return base.FormatErrorMessage(name);
        }
    }
}