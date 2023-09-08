using System.ComponentModel.DataAnnotations;

namespace JLI.Framework.Data {

    [Obsolete($"To be replaced with {nameof(AddressLocalityLengthAttribute)}")]
    public class AddressCityLengthAttribute : StringLengthAttribute {

        #region Constructor(s)

        public AddressCityLengthAttribute()
            : base(32) { }

        #endregion Constructor(s)

    }

}
