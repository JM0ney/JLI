using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JLI.Framework.Data.Models.Common {
    public static class Countries {

        static Countries() {
            UnitedStates = new Country {
                Name = "United States",
                CountryCode = "1"
            };

            List = new ReadOnlyCollection<Country>(new[] { 
                UnitedStates
            });
        }

        public static readonly Country UnitedStates = null!;

        public static readonly IReadOnlyList<Country> List = null!;

    }

    public class Country {

        public String Name { get; init; } = null!;

        public String CountryCode { get; init; } = null!;
    }
}
