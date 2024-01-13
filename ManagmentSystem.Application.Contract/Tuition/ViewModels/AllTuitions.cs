using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ManagmentSystem.Application.Contract.Tuition.ViewModels
{
    public class AllTuitions
    {
        public string CreateDate { get;  set; }
        
        public double FinanceAmount { get;  set; }

        public bool FinanceStatus { get;  set; }

        public string FinancePayDate { get;  set; }

        public string FinanceDescription { get;  set; }

        public string LastUpdate { get; set; }
    }
}