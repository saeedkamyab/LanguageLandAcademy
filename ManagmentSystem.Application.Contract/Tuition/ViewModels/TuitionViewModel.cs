using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Application.Contract.Tuition.ViewModels
{
    public class TuitionViewModel
    {
        #region Properties

        public long Id { get;  set; }

        public string CreateDate { get;  set; }

        public string LastUpdate { get; set; }

        public bool IsRemoved { get; set; }

        public double FinanceAmount { get;  set; }


        public bool FinanceStatus { get;  set; }


        public string FinancePayDate { get;  set; }


        public string FinanceDescription { get;  set; }

        #endregion
    }
}
