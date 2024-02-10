using ZeroFramework.Domain;

namespace ManagmentSystem.Domain.TemporaryRegisterAgg
{
    public class TemporaryRegister: EntityBase<int>
    {
    
        public string FullName { get; private set; }

        public string PhoneNumbers { get; private set; }

        public string Description { get; private set; }

        //========================================================
        public TemporaryRegister(string fullName, string phoneNumbers, string description)
        {
            FullName = fullName;
            PhoneNumbers = phoneNumbers;
            Description = description;
        }

        public void Edit(string fullName, string phoneNumbers, string description)
        {
            FullName = fullName;
            PhoneNumbers = phoneNumbers;
            Description = description;
        }

    
        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
      
    }
}
