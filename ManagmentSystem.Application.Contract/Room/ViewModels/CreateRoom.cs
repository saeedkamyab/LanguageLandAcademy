using System.ComponentModel.DataAnnotations;
using ZeroFramework.Application.Common;
namespace ManagmentSystem.Application.Contract.Room.ViewModels
{
    public class CreateRoom
    {

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string RoomName { get;  set; }

        public string Descriptions { get;  set; }
    }
}