using AccountManagment.Domain.RoleAgg;
using ZeroFramework.Domain;

namespace AccountManagment.Domain.AccountAgg
{
    public class Account : EntityBase<long>
    {
        #region Properties
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string FullName { get; private set; }
        public string FName { get; private set; }
        public string NationalCode { get; private set; }
        public bool Gender { get; private set; }
        public string Address { get; private set; }
        public string ProfilePhoto { get; private set; }
        public string Description { get; set; }

        //Relation
        public int RoleId { get; private set; }
        public Role Role { get; private set; }
        #endregion

        #region Constructor

        public Account(string fullName, string fName,
          string nationalCode,
          bool gender, string address,
          int roleId, string userName, string password, string profilePhoto, string description)
        {
            UserName = userName;
            Password = password;
            FullName = fullName;
            FName = fName;
            NationalCode = nationalCode;
            Gender = gender;
            Address = address;
            if (profilePhoto != null)
            {
                ProfilePhoto = profilePhoto;
            }
            else
            {
                ProfilePhoto = "unImage.png";
            }
            Description = description;

            RoleId = roleId;
            if (roleId == 0)
                RoleId = 2;

        }
        #endregion

        #region Edit
        public void Edit(string fullname, string username, string pass, string fName,
            string nationalCode, bool gender, string address,
          int roleId, string profilePhoto, string description)
        {
            FullName = fullname;
            UserName = username;
            FName = fName;
            NationalCode = nationalCode;
            Gender = gender;
            Address = address;
            RoleId = roleId;
            Description = description;
            if (!string.IsNullOrWhiteSpace(profilePhoto))
                ProfilePhoto = profilePhoto;
            if (!string.IsNullOrWhiteSpace(pass))
                Password = pass;
        }
        #endregion

    }
}
