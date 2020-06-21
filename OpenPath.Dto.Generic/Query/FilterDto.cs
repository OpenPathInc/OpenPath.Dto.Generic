using OpenPath.Dto.Generic.Enumerator;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace OpenPath.Dto.Generic.Query {

    /// <summary>
    /// A generic data object to set the standard filters for a data query
    /// </summary>
    public class FilterDto {

        /// <summary>
        /// The date this filter should start at.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The date this filter should end at.
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The amount of results that should be returned per page.
        /// </summary>
        public int? Return { get; set; }

        /// <summary>
        /// The page of data to return based on the Return value.
        /// </summary>
        public int? Page { get; set; }

        /// <summary>
        /// The order to sort the results by.
        /// </summary>
        public OrderEnumerator? SortBy { get; set; }

        /// <summary>
        /// The item (column) we should sort by.
        /// </summary>
        public string SortItem { get; set; }

        /// <summary>
        /// Used for when returning the results of a filter, the available field returns the total
        /// number of available results.
        /// </summary>
        public int? Available { get; set; }

        /// <summary>
        /// A list of search filters by field.
        /// </summary>
        public List<SearchDto> Searches { get; set; }

    }

}
