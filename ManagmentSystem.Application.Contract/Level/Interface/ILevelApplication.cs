using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.Contract.Level.Interface
{
    public interface ILevelApplication
    {

        List<GetAllLevelItems> GetAllLevels();

        OperationResult CreateLevel(AddLevelItem entity);

        OperationResult UpdateLevel(EditLevelItem entity);

        OperationResult DeleteLevel(RemoveLevelItem entity);

        OperationResult RestoreLevel(RestoreLevelItem entity);

    }
}
