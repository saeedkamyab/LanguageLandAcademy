using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ManagmentSystem.Application.Contract.Tuition.ViewModels
{
    public class AllTuitions
    {
        public long Id { get; set; }

        public string CreateDate { get; set; }

        public double TuitionAmount { get; set; }

        public bool TuitionStatus { get; set; }

        public string TuitionPayDate { get; set; }

        public string TuitionDescription { get; set; }

        public string LastUpdate { get; set; }

        public bool IsRemoved { get; set; }

        public long OwnerId { get; set; }
    }
}