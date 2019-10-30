using System;
using System.Collections.Generic;
using System.Text;

namespace AllinOneForDummies.Core.Models.Base
{
    public class BaseModel
    {
        public bool? IsDeleted { get; set; }
        public DateTime? DeleteTime { get; set; }
    }
}
