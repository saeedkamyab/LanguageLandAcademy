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

        public double TuitionAmount { get;  set; }


        public bool TuitionStatus { get;  set; }


        public string TuitionPayDate { get;  set; }


        public string TuitionDescription { get;  set; }

        #endregion
    }
}
