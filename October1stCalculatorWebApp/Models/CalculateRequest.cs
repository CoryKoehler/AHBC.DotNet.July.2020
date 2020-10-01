using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace October1stCalculatorWebApp.Models
{
    public class CalculateRequest
    {
        [Required]
        [Range(0, 100)]
        [DisplayName("First Number")]
        public int FirstNumber { get; set; }

        [Required]
        [Range(0, 100)]
        [DisplayName("Second Number")]
        public int SecondNumber { get; set; }

        public CalculateType Type { get; set; }
    }
}
