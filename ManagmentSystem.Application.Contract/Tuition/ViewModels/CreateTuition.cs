using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.Contract.Tuition.ViewModels
{
    public class CreateTuition
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public double FinanceAmount { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public bool FinanceStatus { get; set; }


        public string FinanceDescription { get; set; }


    }
}