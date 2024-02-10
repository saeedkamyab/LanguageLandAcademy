using ZeroFramework.Infrastructure;

namespace ManagmentSystem.Application.Contract.Tuition.ViewModels
{
    public class EditTermClass : CreateTermClass
    {
        public long Id { get; set; }
        public List<PeaopleDto> MappedPeople { get; set; }

        public EditTermClass()
        {
            PeopleLists = new List<long>();
        }
    }
}