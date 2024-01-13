using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroFramework.Domain
{
    public class EntityBase<Tkey>
    {
        public Tkey Id { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdate { get; set; }
        public bool IsRemoved { get; set; }
     
        #region Constructor
        public EntityBase()
        {
            CreateDate = DateTime.Now;
            IsRemoved = false;
        }
        #endregion
    }
}
