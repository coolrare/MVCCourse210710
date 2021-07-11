using System;
using System.ComponentModel.DataAnnotations;

namespace MVCCourse210710.ValidationAttributes
{
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