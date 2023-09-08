using System.ComponentModel.DataAnnotations;

namespace JLI.Framework.Data {
    public sealed class AddressJurisdictionLengthAttribute : StringLengthAttribute {

        #region Constructor(s)

        public AddressJurisdictionLengthAttribute()
            : base(32) { }

        #endregion Constructor(s)

    }

}
