// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Lkbcgovregioncreatedonbehalfby.
    /// </summary>
    public static partial class LkbcgovregioncreatedonbehalfbyExtensions
    {
            /// <summary>
            /// Get lk_bcgov_region_createdonbehalfby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMbcgovRegionCollection Get(this ILkbcgovregioncreatedonbehalfby operations, string ownerid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(ownerid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get lk_bcgov_region_createdonbehalfby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMbcgovRegionCollection> GetAsync(this ILkbcgovregioncreatedonbehalfby operations, string ownerid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(ownerid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get lk_bcgov_region_createdonbehalfby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
            /// </param>
            /// <param name='bcgovRegionid'>
            /// key: bcgov_regionid of bcgov_region
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMbcgovRegion CreatedonbehalfbyByKey(this ILkbcgovregioncreatedonbehalfby operations, string ownerid, string bcgovRegionid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.CreatedonbehalfbyByKeyAsync(ownerid, bcgovRegionid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get lk_bcgov_region_createdonbehalfby from systemusers
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ownerid'>
            /// key: ownerid of systemuser
            /// </param>
            /// <param name='bcgovRegionid'>
            /// key: bcgov_regionid of bcgov_region
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMbcgovRegion> CreatedonbehalfbyByKeyAsync(this ILkbcgovregioncreatedonbehalfby operations, string ownerid, string bcgovRegionid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreatedonbehalfbyByKeyWithHttpMessagesAsync(ownerid, bcgovRegionid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
