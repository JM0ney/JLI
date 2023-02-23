﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data.Models {
    
    public abstract  class SoftDeleteOrderedModel : SoftDeleteModel, IOrderedModel {

        public int Order { get; set; }

    }
}