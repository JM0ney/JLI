using System.ComponentModel.DataAnnotations;

namespace JLI.Framework.Data {
    [Obsolete($"To be replaced with {nameof(AddressJurisdictionLengthAttribute)}")]
    public class AddressStateLengthAttribute : StringLengthAttribute {

        #region Constructor(s)

        public AddressStateLengthAttribute()
            : base(2) { }

        #endregion Constructor(s)

    }
}
