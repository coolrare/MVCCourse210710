using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCourse210710.ValidationAttributes
{
    public class BudgetRangeAttribute : DataTypeAttribute
    {
        public decimal MinValue { get; set; }
        public decimal MaxValue { get; set; }

        public BudgetRangeAttribute() : base(DataType.Text)
        {
            MinValue = 0;
            MaxValue = 100;

            ErrorMessage = $"請輸入合理的預算範圍 ({MinValue} ~ {MaxValue})";
        }

        public BudgetRangeAttribute(decimal minValue = 0, decimal maxValue = 100) : base(DataType.Text)
        {
            MinValue = minValue;
            MaxValue = maxValue;

            ErrorMessage = $"請輸入合理的預算範圍 ({MinValue} ~ {MaxValue})";
        }

        public BudgetRangeAttribute(int minValue = 0, int maxValue = 100) : base(DataType.Text)
        {
            MinValue = minValue;
            MaxValue = maxValue;

            ErrorMessage = $"請輸入合理的預算範圍 ({MinValue} ~ {MaxValue})";
        }

        public override bool IsValid(object value)
        {
            var obj = (decimal)value;
            return (obj >= MinValue && obj <= MaxValue);
        }
    }
}