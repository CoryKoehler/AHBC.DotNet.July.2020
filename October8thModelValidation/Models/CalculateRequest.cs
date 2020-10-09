using System;
using System.ComponentModel.DataAnnotations;

namespace October8thModelValidation.Models
{
    public class CalculateRequest
    {
        [Required]
        [Range(0, 100)]
        public int FirstNumber { get; set; }

        [Required]
        [Range(0, 100)]
        public int SecondNumber { get; set; }

        public CalculateType Type { get; set; }
    }
}
