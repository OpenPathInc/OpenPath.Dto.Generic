using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OpenPath.Dto.Generic.Enumerator {

    /// <summary>
    /// A list of posiable search conditions.
    /// </summary>
    public enum SearchConditionEnumerator {

        /// <summary>
        /// A condition stating the search field must be equal to the value passed.
        /// </summary>
        [EnumMember(Value = "equals")] Equals = 100,

        /// <summary>
        /// A condition stating the search field must NOT equal to the value passed.
        /// </summary>
        [EnumMember(Value = "does_not_equals")] DoesNotEqual = 101,

        /// <summary>
        /// A condition stating the search field must contain the value passed.
        /// </summary>
        [EnumMember(Value = "contains")] Contains = 102,


        /// <summary>
        /// A condition stating the search field must be greater than the value passed.
        /// </summary>
        [EnumMember(Value = "is_greater_than")] IsGreaterThan = 200,

        /// <summary>
        /// A condition stating the search field must be greater than or equal to the value passed.
        /// </summary>
        [EnumMember(Value = "is_greater_than_or_equal_to")] IsGreaterThanOrEqualTo = 201,

        /// <summary>
        /// A condition stating the search field must be less than the value passed.
        /// </summary>
        [EnumMember(Value = "is_less_than")] IsLessThan = 202,

        /// <summary>
        /// A condition stating the search field must be less than or equal to the value passed.
        /// </summary>
        [EnumMember(Value = "is_less_than_or_equal_to")] IsLessThanOrEqualTo = 203,

        /// <summary>
        /// A condition stating the search field must match the regular expression value passed.
        /// </summary>
        [EnumMember(Value = "regex_match")] RegexMatch = 300,

        /// <summary>
        /// A condition stating the search field must NOT match the regular expression value passed.
        /// </summary>
        [EnumMember(Value = "regex_mismatch")] RegexMismatch = 301,


        /// <summary>
        /// A condition stating the search field should use the datebases freetext engine to
        /// evaluate the value passed.
        /// </summary>
        [EnumMember(Value = "freetext")] Freetext = 400

    }

}
