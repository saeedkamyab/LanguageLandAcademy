using AccountManagment.Application.Contracts.AccountAppContract.ViewModels;
using ManagmentSystem.Application.Contract.Level.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Domain.BaseInterface;

namespace ManagmentSystem.Domain.LevelAgg.Interface
{
    public interface ILevelRepository:IBaseRepository<int,Level>
    {
        List<GetAllLevelItems> GetAllLevels();

        EditLevelItem GetLevelItemDetails(int id);

    }
}
