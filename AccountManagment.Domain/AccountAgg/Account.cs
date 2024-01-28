using AccountManagment.Domain.RoleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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

        public int RoleId { get; private set; }
        public Role Role { get; private set; }
        #endregion

        #region Constructor

        public Account(string fullName, string fName,
          string nationalCode,
          bool gender, string address,
          string profilePhoto, int roleId, string userName, string password)
        {
            UserName = userName;
            Password = password;
            FullName = fullName;
            FName = fName;
            NationalCode = nationalCode;
            Gender = gender;
            Address = address;
            ProfilePhoto = profilePhoto;
            RoleId = roleId;
            if (roleId == 0)
                RoleId = 2;

        }
        #endregion

        #region Edit
        public void Edit(string fullname, string username, string fName,
            string nationalCode, bool gender, string address,
          int roleId, string profilePhoto)
        {
            FullName = fullname;
            UserName = username;
            FName= fName;
            NationalCode= nationalCode;
            Gender= gender;
            Address= address;
            RoleId = roleId;

            if (!string.IsNullOrWhiteSpace(profilePhoto))
                ProfilePhoto = profilePhoto;
        }
        #endregion

        #region ChangePass
        public void ChangePassword(string password)
        {
            Password = password;
        }
        #endregion

    }
}
