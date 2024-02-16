namespace ZeroFramework.Infrastructure
{
    public static class Roles
    {
        public const string Administrator = "2";
        public const string Clerck = "20";
        public const string Teacher = "3";
        public const string Student = "4";
        
        public static string GetRoleBy(long id)
        {
            switch (id)
            {
                case 2:
                    return "مدیر ارشد";
                case 20:
                    return "کارمند";
                case 3:
                    return "مدرس";
                case 4:
                    return "زبان آموز";
                default:
                    return "";
            }
        }
    }
}
