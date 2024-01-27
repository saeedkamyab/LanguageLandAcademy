using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFramework.Domain;

namespace ManagmentSystem.Domain.TuitionAgg
{
    public class Tuition : EntityBase<long>
    {
        #region Properties

        public double TuitionAmount { get; private set; }

        public bool TuitionStatus { get; private set; }

        public DateTime TuitionPayDate { get; private set; }

        public string TuitionDescription { get; private set; }

        #endregion

        #region Constructor
        public Tuition(double tuitionAmount,
                       string tuitionDescription)
        {
            TuitionAmount = tuitionAmount;
            TuitionStatus = false;
            TuitionDescription = tuitionDescription;
        }
        #endregion

        #region Edit
        public void Edit(double tuitionAmount, bool tuitionStatus,
                         string tuitionDescription)
        {
            TuitionAmount = tuitionAmount;
            TuitionStatus = tuitionStatus;
            TuitionDescription = tuitionDescription;
            LastUpdate = DateTime.Now;
        }
        #endregion

        #region Remove & Restore
        public void Remove()
        {
            IsRemoved = true;
        }

        public void Restore()
        {
            IsRemoved = false;
        }
        #endregion

        #region Pay
        public void Pay()
        {
            TuitionStatus = true;
            TuitionPayDate = DateTime.Now;
        }
        #endregion
    }
}




//[Key]
//[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//public int FinanceId { get; private set; }

//[DisplayName("تاریخ ایجاد")]
//[Required(ErrorMessage = "وارد کردن تاریخ ایجاد الزامیست")]
//public DateTime FinanceDate { get; private set; }

//[DisplayName("بابت")]
//[Required(ErrorMessage = "وارد کردن این فیلد الزامیست")]
//public bool FinanceFor { get; private set; }

//[DisplayName("بدهکار یا بستانکار")]
//[Required(ErrorMessage = "وارد کردن این فیلد الزامیست")]
//public bool FinanceDebtorOrCreditor { get; private set; }