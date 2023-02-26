﻿using System.ComponentModel.DataAnnotations;

namespace JLI.Framework.Data {
    public class HexColorLength : StringLengthAttribute {

        #region Constructor(s)

        public HexColorLength()
            : base(6) { }

        #endregion Constructor(s)

    }
}
