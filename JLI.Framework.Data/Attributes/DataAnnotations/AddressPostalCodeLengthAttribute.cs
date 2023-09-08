using System.ComponentModel.DataAnnotations;

namespace JLI.Framework.Data {
    
    public class AddressPostalCodeLengthAttribute : StringLengthAttribute {

        #region Constructor(s)

        public AddressPostalCodeLengthAttribute()
            : base(16) { }

        #endregion Constructor(s)

    }

}
