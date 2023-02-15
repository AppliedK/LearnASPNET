using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace LearnASPNET
{
    public class LengthValidator : BaseValidator
    {
        public int MaxLength { get; set; }
        protected override bool EvaluateIsValid()
        {
           string value = this.GetControlValidationValue(this.ControlToValidate);
            if (value.Length > MaxLength)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}