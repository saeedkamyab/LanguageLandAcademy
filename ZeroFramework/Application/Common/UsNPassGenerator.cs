using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroFramework.Application.Common
{
    public static class UsNPassGenerator
    {
        public static string GenerateUserName() 
        {
            var username = "User_" + DateTime.Now.Second.ToString("00") + DateTime.Now.Minute.ToString("00") + DateTime.Now.Hour.ToString("00") + DateTime.Now.Month.ToString("00");
            return username;
        }
        public static string GeneratePass(string nCode)
        {
            var pass = "@UsPass_"+ nCode + DateTime.Now.Minute.ToString("00") + DateTime.Now.Second.ToString("00") +DateTime.Now.Hour.ToString("00");
            return pass;
        }
    }
}
