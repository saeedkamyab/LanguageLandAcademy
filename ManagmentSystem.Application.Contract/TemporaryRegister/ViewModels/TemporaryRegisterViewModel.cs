﻿namespace ManagmentSystem.Application.Contract.TemporaryRegister.ViewModels
{
    public class TemporaryRegisterViewModel
    {
        #region Properties

        public long Id { get; set; }

        public string CreateDate { get; set; }

        public string FullName { get;  set; }

        public string PhoneNumbers { get;  set; }

        public string Description { get;  set; }

        public string LastUpdate { get; set; }

        public bool IsRemoved { get; set; }

        #endregion
    }
}
