using OpenPath.Dto.Generic.Query;
using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;

namespace OpenPath.Dto.Generic.Extension {

    /// <summary>
    /// An extension for the search lists to easily find the criteria for a search field.
    /// </summary>
    public static class SearchExtension {

        /// <summary>
        /// Find the search criteria by the field, this extension is not case senstive.
        /// </summary>
        /// <param name="filter">The filter we are looking for the search feild on.</param>
        /// <param name="field">The field we are trying to find in the filer.</param>
        /// <returns></returns>
        public static SearchDto FindSearchByFeild(this FilterDto filter, string field) {

            // validate
            if(filter == null) throw new ArgumentNullException("Filter cannot be null that you are trying to find a search filed on.");
            if(string.IsNullOrWhiteSpace(field)) throw new ArgumentNullException("The field you are searching for cannot be empty or null.");

            // define the return value
            var result = filter.Searches.FirstOrDefault(_ => _.Field.ToLower() == field.ToLower());

            return result;

        }

    }

}
