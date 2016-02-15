using System.Collections.Generic;
using OpenStack.Serialization;

namespace OpenStack
{
    /// <summary>
    /// Paging options when listing a resource that supports paging.
    /// </summary>
    public class PageOptions : IQueryStringBuilder
    {
        /// <summary>
        /// The number of resources to return per page.
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// The identifier of the first resource to return on the page.
        /// </summary>
        public Identifier StartingAt { get; set; }

        /// <summary />
        protected virtual IDictionary<string, object> BuildQueryString()
        {
            return new Dictionary<string, object>
            {
                {"marker", StartingAt},
                {"limit", PageSize}
            };
        }

        IDictionary<string , object> IQueryStringBuilder.Build()
        {
            return BuildQueryString();
        }
    }
}
