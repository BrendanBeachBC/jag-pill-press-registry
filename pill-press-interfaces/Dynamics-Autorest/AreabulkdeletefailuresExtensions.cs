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
    /// Extension methods for Areabulkdeletefailures.
    /// </summary>
    public static partial class AreabulkdeletefailuresExtensions
    {
            /// <summary>
            /// Get bcgov_area_BulkDeleteFailures from bcgov_areas
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovAreaid'>
            /// key: bcgov_areaid of bcgov_area
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
            public static MicrosoftDynamicsCRMbulkdeletefailureCollection Get(this IAreabulkdeletefailures operations, string bcgovAreaid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(bcgovAreaid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bcgov_area_BulkDeleteFailures from bcgov_areas
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovAreaid'>
            /// key: bcgov_areaid of bcgov_area
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
            public static async Task<MicrosoftDynamicsCRMbulkdeletefailureCollection> GetAsync(this IAreabulkdeletefailures operations, string bcgovAreaid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(bcgovAreaid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get bcgov_area_BulkDeleteFailures from bcgov_areas
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovAreaid'>
            /// key: bcgov_areaid of bcgov_area
            /// </param>
            /// <param name='bulkdeletefailureid'>
            /// key: bulkdeletefailureid of bulkdeletefailure
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMbulkdeletefailure BulkDeleteFailuresByKey(this IAreabulkdeletefailures operations, string bcgovAreaid, string bulkdeletefailureid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.BulkDeleteFailuresByKeyAsync(bcgovAreaid, bulkdeletefailureid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get bcgov_area_BulkDeleteFailures from bcgov_areas
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bcgovAreaid'>
            /// key: bcgov_areaid of bcgov_area
            /// </param>
            /// <param name='bulkdeletefailureid'>
            /// key: bulkdeletefailureid of bulkdeletefailure
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
            public static async Task<MicrosoftDynamicsCRMbulkdeletefailure> BulkDeleteFailuresByKeyAsync(this IAreabulkdeletefailures operations, string bcgovAreaid, string bulkdeletefailureid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BulkDeleteFailuresByKeyWithHttpMessagesAsync(bcgovAreaid, bulkdeletefailureid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
