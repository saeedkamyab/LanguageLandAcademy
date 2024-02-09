using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroFramework.Infrastructure
{
    public static class LevelType
    {
        public const int GroupNormal = 1;
        public const int GroupCompact = 2;
        public const int PrivateNormal = 3;
        public const int PrivateCompact = 4;

        public static string GetTypeBy(long id)
        {
            switch (id)
            {
                case 1:
                    return "گروهی / عادی";
                case 2:
                    return "گروهی / فشرده";
                case 3:
                    return "خصوصی / عادی";
                case 4:
                    return "خصوصی / فشرده";
                default:
                    return "";
            }
        }
    }
}
