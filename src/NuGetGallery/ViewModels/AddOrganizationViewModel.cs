﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;

namespace NuGetGallery
{
    public class AddOrganizationViewModel
    {
        [Required]
        [StringLength(64)]
        [Display(Name = "Organization Name")]
        public string OrganizationName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Organization Email Address")]
        public string OrganizationEmailAddress { get; set; }
    }
}