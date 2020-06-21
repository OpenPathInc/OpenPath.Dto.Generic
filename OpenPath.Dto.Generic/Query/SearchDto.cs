using System;
using System.Collections.Generic;
using System.Text;

namespace OpenPath.Dto.Generic.Query {

    /// <summary>
    /// The search data object is used to define columns and fields we want to perform searches on.
    /// </summary>
    public class SearchDto {

        /// <summary>
        /// The field is the column or field we want to perform a search on.
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// The value is the value we are searching based on the condition if supplied.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// This is the search condition we want to search, such as does this match, not match or
        /// is greater than or less than.
        /// </summary>
        public Enumerator.SearchConditionEnumerator Condition { get; set; }

    }

}
