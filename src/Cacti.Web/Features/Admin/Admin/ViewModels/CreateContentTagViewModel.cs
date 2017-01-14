﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Cacti.Web.Features.Admin.Admin.ViewModels
{
    public class CreateContentTagViewModel
    {
        [Required]
        [Remote("ValidateContentTagName", "Admin")]
         public string Name { get; set; }
    }
}