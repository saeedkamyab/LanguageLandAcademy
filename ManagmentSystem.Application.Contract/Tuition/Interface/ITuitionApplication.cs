﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagmentSystem.Application.Contract.Tuition.ViewModel;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.Contract.Tuition.Interface
{
    public interface ITuitionApplication
    {


        List<GetAllTuitions> GetAllTuitions(int CategoryId, bool IsRemove);
      
        OperationResult CreateTuition(CreateTuition createTuition);
        
        OperationResult EditTuition(EditTuition editTuition);
       
     

    }
}
