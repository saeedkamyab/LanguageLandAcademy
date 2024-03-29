﻿using System;
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
        public long Id { get;  set; }

        public string CreateDate { get;  set; }

        public string LastUpdate { get; set; }

        public bool IsRemoved { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string Day { get; set; }

        public string Description { get; set; }

        public int LevelId { get;  set; }

        public string Room { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public bool Status { get; set; }
    }
}
