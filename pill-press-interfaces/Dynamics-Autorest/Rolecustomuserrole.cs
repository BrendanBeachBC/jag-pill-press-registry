// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.PillPressRegistry.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Rolecustomuserrole operations.
    /// </summary>
    public partial class Rolecustomuserrole : IServiceOperations<DynamicsClient>, IRolecustomuserrole
    {
        /// <summary>
        /// Initializes a new instance of the Rolecustomuserrole class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public Rolecustomuserrole(DynamicsClient client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the DynamicsClient
        /// </summary>
        public DynamicsClient Client { get; private set; }

        /// <summary>
        /// Get bcgov_role_customuser_Role from bcgov_roles
        /// </summary>
        /// <param name='bcgovRoleid'>
        /// key: bcgov_roleid of bcgov_role
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
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<MicrosoftDynamicsCRMbcgovCustomuserCollection>> GetWithHttpMessagesAsync(string bcgovRoleid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (bcgovRoleid == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "bcgovRoleid");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("bcgovRoleid", bcgovRoleid);
                tracingParameters.Add("top", top);
                tracingParameters.Add("skip", skip);
                tracingParameters.Add("search", search);
                tracingParameters.Add("filter", filter);
                tracingParameters.Add("count", count);
                tracingParameters.Add("orderby", orderby);
                tracingParameters.Add("select", select);
                tracingParameters.Add("expand", expand);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "Get", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "bcgov_roles({bcgov_roleid})/bcgov_role_customuser_Role").ToString();
            _url = _url.Replace("{bcgov_roleid}", System.Uri.EscapeDataString(bcgovRoleid));
            List<string> _queryParameters = new List<string>();
            if (top != null)
            {
                _queryParameters.Add(string.Format("$top={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(top, Client.SerializationSettings).Trim('"'))));
            }
            if (skip != null)
            {
                _queryParameters.Add(string.Format("$skip={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(skip, Client.SerializationSettings).Trim('"'))));
            }
            if (search != null)
            {
                _queryParameters.Add(string.Format("$search={0}", System.Uri.EscapeDataString(search)));
            }
            if (filter != null)
            {
                _queryParameters.Add(string.Format("$filter={0}", System.Uri.EscapeDataString(filter)));
            }
            if (count != null)
            {
                _queryParameters.Add(string.Format("$count={0}", System.Uri.EscapeDataString(Microsoft.Rest.Serialization.SafeJsonConvert.SerializeObject(count, Client.SerializationSettings).Trim('"'))));
            }
            if (orderby != null)
            {
                _queryParameters.Add(string.Format("$orderby={0}", System.Uri.EscapeDataString(string.Join(",", orderby))));
            }
            if (select != null)
            {
                _queryParameters.Add(string.Format("$select={0}", System.Uri.EscapeDataString(string.Join(",", select))));
            }
            if (expand != null)
            {
                _queryParameters.Add(string.Format("$expand={0}", System.Uri.EscapeDataString(string.Join(",", expand))));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null) {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else {
                    _responseContent = string.Empty;
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<MicrosoftDynamicsCRMbcgovCustomuserCollection>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<MicrosoftDynamicsCRMbcgovCustomuserCollection>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

        /// <summary>
        /// Get bcgov_role_customuser_Role from bcgov_roles
        /// </summary>
        /// <param name='bcgovRoleid'>
        /// key: bcgov_roleid of bcgov_role
        /// </param>
        /// <param name='bcgovCustomuserid'>
        /// key: bcgov_customuserid of bcgov_customuser
        /// </param>
        /// <param name='select'>
        /// Select properties to be returned
        /// </param>
        /// <param name='expand'>
        /// Expand related entities
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<MicrosoftDynamicsCRMbcgovCustomuser>> RoleByKeyWithHttpMessagesAsync(string bcgovRoleid, string bcgovCustomuserid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (bcgovRoleid == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "bcgovRoleid");
            }
            if (bcgovCustomuserid == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "bcgovCustomuserid");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("bcgovRoleid", bcgovRoleid);
                tracingParameters.Add("bcgovCustomuserid", bcgovCustomuserid);
                tracingParameters.Add("select", select);
                tracingParameters.Add("expand", expand);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "RoleByKey", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "bcgov_roles({bcgov_roleid})/bcgov_role_customuser_Role({bcgov_customuserid})").ToString();
            _url = _url.Replace("{bcgov_roleid}", System.Uri.EscapeDataString(bcgovRoleid));
            _url = _url.Replace("{bcgov_customuserid}", System.Uri.EscapeDataString(bcgovCustomuserid));
            List<string> _queryParameters = new List<string>();
            if (select != null)
            {
                _queryParameters.Add(string.Format("$select={0}", System.Uri.EscapeDataString(string.Join(",", select))));
            }
            if (expand != null)
            {
                _queryParameters.Add(string.Format("$expand={0}", System.Uri.EscapeDataString(string.Join(",", expand))));
            }
            if (_queryParameters.Count > 0)
            {
                _url += "?" + string.Join("&", _queryParameters);
            }
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("GET");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null) {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else {
                    _responseContent = string.Empty;
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<MicrosoftDynamicsCRMbcgovCustomuser>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Microsoft.Rest.Serialization.SafeJsonConvert.DeserializeObject<MicrosoftDynamicsCRMbcgovCustomuser>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
