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

        public long Id { get; private set; }

        public string CreateDate { get; private set; }

        public string LastUpdate { get; set; }

        public bool IsRemoved { get; set; }

        public double FinanceAmount { get; private set; }


        public bool? FinanceStatus { get; private set; }


        public string? FinancePayDate { get; private set; }


        public string? FinanceDescription { get; private set; }

        #endregion
    }
}
