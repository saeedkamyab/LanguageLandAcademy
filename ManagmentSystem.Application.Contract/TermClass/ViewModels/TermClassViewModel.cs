using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentSystem.Application.Contract.Tuition.ViewModels
{
    public class TermClassViewModel
    {
        #region Properties

        public long Id { get;  set; }

        public string CreateDate { get;  set; }

        public string LastUpdate { get; set; }

        public bool IsRemoved { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string Day { get; set; }

        public string Description { get; set; }

        public List<long> PeopleLists { get; set; }

        public int LevelId { get; private set; }

        public int RoomId { get; private set; }

        #endregion
    }
}
