﻿using System;
using System.Text;

namespace Cacti.Web.Core.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveSpecialCharacters(this string evaluatedString)
        {
            var stringBuilder = new StringBuilder();

            evaluatedString = evaluatedString.Replace(" ", "-");

            foreach (var value in evaluatedString)
            {
                if ((value >= '0' && value <= '9') || (value >= 'A' && value <= 'Z') || (value >= 'a' && value <= 'z') || value == '-' || value == '_')
                {
                    stringBuilder.Append(value);
                }
            }
            return stringBuilder.ToString();
        }

        public static string ToFormattedString(this DateTime dateTime)
        {
            return dateTime.ToString("MMMM d, yyyy");
        }
    }
}
