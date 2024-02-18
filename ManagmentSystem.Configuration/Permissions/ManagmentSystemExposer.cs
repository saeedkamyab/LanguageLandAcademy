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
                         new PermissionDto(ManagmentSystemPermissons.TuitionsList,"TuitionsList"),
                         new PermissionDto(ManagmentSystemPermissons.SearchTuitionsList,"SearchTuitionsList"),
                         new PermissionDto(ManagmentSystemPermissons.CreateTuition,"CreateTuition"),
                         new PermissionDto(ManagmentSystemPermissons.EditTuition,"EditTuition"),
                         new PermissionDto(ManagmentSystemPermissons.DeleteTuition,"DeleteTuition"),
                      }
                },
                {
                      "Level" , new List<PermissionDto>
                      {
                         new PermissionDto(ManagmentSystemPermissons.LevelList,"LevelList"),
                         new PermissionDto(ManagmentSystemPermissons.CreateLevel,"CreateLevel"),
                         new PermissionDto(ManagmentSystemPermissons.EditLevel,"EditLevel"),
                         new PermissionDto(ManagmentSystemPermissons.DeleteLevel,"DeleteLevel"),
                      }
                }, 
                {
                      "TermClass" , new List<PermissionDto>
                      {
                         new PermissionDto(ManagmentSystemPermissons.TermClassList,"TermClassList"),
                         new PermissionDto(ManagmentSystemPermissons.CreateTermClass,"CreateTermClass"),
                         new PermissionDto(ManagmentSystemPermissons.EditTermClass,"EditTermClass"),
                         new PermissionDto(ManagmentSystemPermissons.DeleteTermClass,"DeleteTermClass"),
                         new PermissionDto(ManagmentSystemPermissons.SearchTermClassList,"SearchTermClass"),
                      }
                },
                  {
                      "Register" , new List<PermissionDto>
                      {
                         new PermissionDto(ManagmentSystemPermissons.RegisterList,"RegisterList"),
                         new PermissionDto(ManagmentSystemPermissons.CreateRegister,"CreateRegister"),
                         new PermissionDto(ManagmentSystemPermissons.EditRegister,"EditRegister"),
                         new PermissionDto(ManagmentSystemPermissons.DeleteRegister,"DeleteRegister"),
                      }
                }

            };
        }
    }
}
