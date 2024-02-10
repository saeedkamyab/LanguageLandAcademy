using System.ComponentModel.DataAnnotations;
using ZeroFramework.Application.Common;
namespace ManagmentSystem.Application.Contract.TemporaryRegister.ViewModels
{
    public class CreateTemporaryRegister
    {

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string FullName { get;  set; }
      
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string PhoneNumbers { get;  set; }

        public string Description { get;  set; }

    }
}