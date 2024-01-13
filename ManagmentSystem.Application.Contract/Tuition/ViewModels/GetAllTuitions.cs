using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ManagmentSystem.Application.Contract.Tuition.ViewModels
{
    public class GetAllTuitions
    {
        public string CreateDate { get; private set; }
        
        public double FinanceAmount { get; private set; }

        public bool FinanceStatus { get; private set; }

        public string FinancePayDate { get; private set; }

        public string FinanceDescription { get; private set; }

        public string LastUpdate { get; set; }
    }
}