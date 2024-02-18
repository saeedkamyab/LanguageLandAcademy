﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Configuration.Permissions
{
    public static class ManagmentSystemPermissons
    {
        #region Tuitions Permissions

        public const int TuitionsList = 1;
        public const int SearchTuitionsList = 2;
        public const int CreateTuition = 3;
        public const int EditTuition = 4;
        public const int DeleteTuition = 5;

        #endregion

        #region Level Permissions

        public const int LevelList = 6;
        public const int CreateLevel = 7;
        public const int EditLevel = 8;
        public const int DeleteLevel = 9;


        #endregion

        #region TermClass Permissions

        public const int TermClassList = 10;
        public const int SearchTermClassList = 11;
        public const int CreateTermClass = 12;
        public const int EditTermClass = 13;
        public const int DeleteTermClass = 14;

        #endregion

        #region TermClass Permissions

        public const int RegisterList = 15;
        public const int CreateRegister = 16;
        public const int EditRegister = 17;
        public const int DeleteRegister = 18;

        #endregion
    }
}
