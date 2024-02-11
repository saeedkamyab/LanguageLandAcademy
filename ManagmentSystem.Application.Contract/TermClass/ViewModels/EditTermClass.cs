using ZeroFramework.Infrastructure;

namespace ManagmentSystem.Application.Contract.TermClass.ViewModels
{
    public class EditTermClass : CreateTermClass
    {
        public long Id { get; set; }
        public List<PeopleDto> MappedPeople { get; set; }

        public EditTermClass()
        {
            PeopleLists = new List<long>();
        }
    }
}