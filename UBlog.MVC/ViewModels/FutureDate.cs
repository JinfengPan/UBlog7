﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace UBlog.MVC.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParse(Convert.ToString(value), out dateTime);

            return (isValid && dateTime > DateTime.Now);
            
        }
    }
}