using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Beam.Client.ViewModels
{
    public class NewFrequency
    {
        [Required]
        [MaxLength(20)]
        [Display(Name="Frequency Name")]
        public string Name { get; set; } = "";
    }
}
