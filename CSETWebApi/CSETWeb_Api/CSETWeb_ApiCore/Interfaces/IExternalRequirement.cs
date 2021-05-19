﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CSETWebCore.Api.Models;


namespace CSETWebCore.Api.Interfaces
{
    public interface IExternalRequirement
    {
        string Category { get; set; }

        [Required]
        string Identifier { get; set; }

        IEnumerable<ExternalResource> References { get; set; }

        [Required]
        List<string> SecurityAssuranceLevels { get; set; }

        ExternalResource Source { get; set; }

        [Required]
        string Heading { get; set; }

        [Required]
        string Subheading { get; set; }

        string Supplemental { get; set; }

        [Required]
        string Text { get; set; }

        [Required]
        int? Weight { get; set; }

        ExternalRequirement.QuestionList Questions { get; set; }
    }
}