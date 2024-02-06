using System;
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
    }
}
