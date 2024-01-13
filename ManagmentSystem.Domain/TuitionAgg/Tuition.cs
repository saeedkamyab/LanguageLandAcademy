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

        [DisplayName("مبلغ")]
        [Required(ErrorMessage = "وارد کردن مبلغ الزامیست")]
        public double FinanceAmount { get; private set; }

        [DisplayName("وضعیت")]
        public bool? FinanceStatus { get; private set; }

        [DisplayName("تاریخ پرداخت")]
        public DateTime? FinancePayDate { get; private set; }


        [DisplayName("توضیحات")]
        [MaxLength(250)]
        public string? FinanceDescription { get; private set; }

        #endregion

        #region Constructor
        public Tuition(double financeAmount, bool? financeStatus, 
            DateTime? financePayDate, string? financeDescription)
        {
            FinanceAmount = financeAmount;
            FinanceStatus = financeStatus;
            FinancePayDate = financePayDate;
            FinanceDescription = financeDescription;
        }
        #endregion

        #region Edit
        public void Edit(double financeAmount, bool? financeStatus,
                         string? financeDescription)
        {
            FinanceAmount = financeAmount;
            FinanceStatus = financeStatus;
            FinanceDescription = financeDescription;
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