using System.ComponentModel.DataAnnotations;

namespace JLI.Framework.Data {
    public class AddressLocalityLengthAttribute : StringLengthAttribute {

        #region Constructor(s)

        public AddressLocalityLengthAttribute()
            : base(32) { }

        #endregion Constructor(s)
    
    }
}
