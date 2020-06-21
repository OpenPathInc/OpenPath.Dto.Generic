using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OpenPath.Dto.Generic.Enumerator {

    /// <summary>
    /// Enumberators for sorting orders
    /// </summary>
    public enum OrderEnumerator {

        /// <summary>
        /// Sort in assending order.
        /// </summary>
        [EnumMember(Value = "assending")] Assending = 100,

        /// <summary>
        /// Sort in decending order.
        /// </summary>
        [EnumMember(Value = "decending")] Decending = 200,

        /// <summary>
        /// No sorting order.
        /// </summary>
        [EnumMember(Value = "none")] None = int.MaxValue

    }

}
