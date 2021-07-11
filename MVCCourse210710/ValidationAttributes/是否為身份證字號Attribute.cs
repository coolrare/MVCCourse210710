using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCCourse210710.ValidationAttributes
{
    public class 是否為身份證字號Attribute : RegularExpressionAttribute
    {
        public 是否為身份證字號Attribute() : base(@"[A-Z][123]\d{8}")
        {
            base.ErrorMessage = "請輸入合法的身份證字號";
        }
    }
}