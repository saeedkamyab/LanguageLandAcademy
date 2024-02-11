using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagmentSystem.Application.Contract.Tuition.ViewModels;
using ZeroFramework.Application.Common;

namespace ManagmentSystem.Application.Contract.Tuition.Interface
{
    public interface ITuitionApplication
    {


        List<AllTuitions> GetAllTuitions();
      
        OperationResult CreateTuition(CreateRoom createTuition);
        
        OperationResult EditTuition(EditRoom editTuition);

        OperationResult PayTuition(long Id);

        OperationResult RemoveTuition(long Id);
        OperationResult RestoreTuition(long Id);
       
     

    }
}
