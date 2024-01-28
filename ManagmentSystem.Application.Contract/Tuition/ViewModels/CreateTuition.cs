using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.Contract.Tuition.ViewModels
{
    public class CreateTuition
    {

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public long TuitionOwner { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public double TuitionAmount { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public bool TuitionStatus { get; set; }


        public string TuitionDescription { get; set; }


    }
}