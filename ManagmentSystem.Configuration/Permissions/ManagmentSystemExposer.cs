using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Infrastructure;

namespace ManagmentSystem.Configuration.Permissions
{
    public class ManagmentSystemExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                      "Tuitions",new List<PermissionDto>
                      {
                         new PermissionDto(1,"TuitionsList"),
                         new PermissionDto(2,"SearchTuitionsList"),
                         new PermissionDto(3,"CreateTuition"),
                         new PermissionDto(4,"EditTuition"),
                         new PermissionDto(5,"DeleteTuition"),
                      }
                },
                {
                      "Level" , new List<PermissionDto>
                      { 
                         new PermissionDto(6,"LevelList"),
                         new PermissionDto(7,"CreateLevel"),
                         new PermissionDto(8,"EditLevel"),
                         new PermissionDto(9,"DeleteLevel"),
                      }
                }

            };
        }
    }
}
