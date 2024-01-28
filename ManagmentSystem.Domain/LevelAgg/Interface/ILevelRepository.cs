﻿using ManagmentSystem.Application.Contract.Level;
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
        List<GetAllLevelItems> getAllLevels();

    }
}