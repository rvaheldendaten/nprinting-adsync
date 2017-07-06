/* 
 * Qlik NPrinting API
 *
 * You can extend your reporting system by using the Qlik NPrinting API. This API provides endpoints to perform operations on apps, On-Demand requests and results, reports, filters, and so on.  For all requests, the data returned is filtered based on user permissions. That is, if a user is not authorized to access a certain object, that object is not returned in the reponse.  API Stability: Experimental.  Deprecation period: None. Can change at any point and should be used only to evaluate upcoming functionality.     
 *
 * OpenAPI spec version: 0.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;
using RestSharp;

namespace Qlik.NPrinting.Rest.Client.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAppsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Generates the list of Qlik NPrinting Apps.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the complete list of Qlik NPrinting apps that the current user has permission to see. The list is always filtered based on user permissions.  The response includes the title and other details about each app, and lists the apps in the order specified by the &#x60;sort&#x60; parameter. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">A comma separated list of fields to use for sorting the apps. Allowed field values are \&quot;name\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /apps?sort&#x3D;+name,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>InlineResponse2001</returns>
        AppListResponse AppsGet (string sort = null, int? offset = null, int? limit = null);

        /// <summary>
        /// Generates the list of Qlik NPrinting Apps.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the complete list of Qlik NPrinting apps that the current user has permission to see. The list is always filtered based on user permissions.  The response includes the title and other details about each app, and lists the apps in the order specified by the &#x60;sort&#x60; parameter. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">A comma separated list of fields to use for sorting the apps. Allowed field values are \&quot;name\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /apps?sort&#x3D;+name,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<AppListResponse> AppsGetWithHttpInfo (string sort = null, int? offset = null, int? limit = null);
        /// <summary>
        /// Returns details about a specific app.
        /// </summary>
        /// <remarks>
        /// This endpoint returns detailed information about the app specified by the &#x60;id&#x60; parameter. The calling user must be authorized to view the specified app. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the app.</param>
        /// <returns>InlineResponse2002</returns>
        AppResponse AppsIdGet (Guid id);

        /// <summary>
        /// Returns details about a specific app.
        /// </summary>
        /// <remarks>
        /// This endpoint returns detailed information about the app specified by the &#x60;id&#x60; parameter. The calling user must be authorized to view the specified app. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the app.</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<AppResponse> AppsIdGetWithHttpInfo (Guid id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Generates the list of Qlik NPrinting Apps.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the complete list of Qlik NPrinting apps that the current user has permission to see. The list is always filtered based on user permissions.  The response includes the title and other details about each app, and lists the apps in the order specified by the &#x60;sort&#x60; parameter. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">A comma separated list of fields to use for sorting the apps. Allowed field values are \&quot;name\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /apps?sort&#x3D;+name,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<AppListResponse> AppsGetAsync (string sort = null, int? offset = null, int? limit = null);

        /// <summary>
        /// Generates the list of Qlik NPrinting Apps.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the complete list of Qlik NPrinting apps that the current user has permission to see. The list is always filtered based on user permissions.  The response includes the title and other details about each app, and lists the apps in the order specified by the &#x60;sort&#x60; parameter. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">A comma separated list of fields to use for sorting the apps. Allowed field values are \&quot;name\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /apps?sort&#x3D;+name,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<AppListResponse>> AppsGetAsyncWithHttpInfo (string sort = null, int? offset = null, int? limit = null);
        /// <summary>
        /// Returns details about a specific app.
        /// </summary>
        /// <remarks>
        /// This endpoint returns detailed information about the app specified by the &#x60;id&#x60; parameter. The calling user must be authorized to view the specified app. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the app.</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<AppResponse> AppsIdGetAsync (Guid id);

        /// <summary>
        /// Returns details about a specific app.
        /// </summary>
        /// <remarks>
        /// This endpoint returns detailed information about the app specified by the &#x60;id&#x60; parameter. The calling user must be authorized to view the specified app. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the app.</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<AppResponse>> AppsIdGetAsyncWithHttpInfo (Guid id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AppsApi : IAppsApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        public AppsApi(ApiClient apiClient)
        {
            ApiClient = apiClient;

            ExceptionFactory = ApiClient.DefaultExceptionFactory;
        }


        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.ApiClient.RestClient.BaseUrl.ToString();
        }



        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Generates the list of Qlik NPrinting Apps. This endpoint returns the complete list of Qlik NPrinting apps that the current user has permission to see. The list is always filtered based on user permissions.  The response includes the title and other details about each app, and lists the apps in the order specified by the &#x60;sort&#x60; parameter. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">A comma separated list of fields to use for sorting the apps. Allowed field values are \&quot;name\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /apps?sort&#x3D;+name,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>InlineResponse2001</returns>
        public AppListResponse AppsGet (string sort = null, int? offset = null, int? limit = null)
        {
             ApiResponse<AppListResponse> localVarResponse = AppsGetWithHttpInfo(sort, offset, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generates the list of Qlik NPrinting Apps. This endpoint returns the complete list of Qlik NPrinting apps that the current user has permission to see. The list is always filtered based on user permissions.  The response includes the title and other details about each app, and lists the apps in the order specified by the &#x60;sort&#x60; parameter. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">A comma separated list of fields to use for sorting the apps. Allowed field values are \&quot;name\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /apps?sort&#x3D;+name,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< AppListResponse > AppsGetWithHttpInfo (string sort = null, int? offset = null, int? limit = null)
        {

            var localVarPath = ApiClient.ApiPathPrefix + "/apps";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(this.ApiClient.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sort != null) localVarQueryParams.Add("sort", this.ApiClient.ParameterToString(sort)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", this.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", this.ApiClient.ParameterToString(limit)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AppsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AppListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AppListResponse) this.ApiClient.Deserialize(localVarResponse, typeof(AppListResponse)));
            
        }

        /// <summary>
        /// Generates the list of Qlik NPrinting Apps. This endpoint returns the complete list of Qlik NPrinting apps that the current user has permission to see. The list is always filtered based on user permissions.  The response includes the title and other details about each app, and lists the apps in the order specified by the &#x60;sort&#x60; parameter. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">A comma separated list of fields to use for sorting the apps. Allowed field values are \&quot;name\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /apps?sort&#x3D;+name,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<AppListResponse> AppsGetAsync (string sort = null, int? offset = null, int? limit = null)
        {
             ApiResponse<AppListResponse> localVarResponse = await AppsGetAsyncWithHttpInfo(sort, offset, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generates the list of Qlik NPrinting Apps. This endpoint returns the complete list of Qlik NPrinting apps that the current user has permission to see. The list is always filtered based on user permissions.  The response includes the title and other details about each app, and lists the apps in the order specified by the &#x60;sort&#x60; parameter. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">A comma separated list of fields to use for sorting the apps. Allowed field values are \&quot;name\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /apps?sort&#x3D;+name,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AppListResponse>> AppsGetAsyncWithHttpInfo (string sort = null, int? offset = null, int? limit = null)
        {

            var localVarPath = ApiClient.ApiPathPrefix + "/apps";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(this.ApiClient.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (sort != null) localVarQueryParams.Add("sort", this.ApiClient.ParameterToString(sort)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", this.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", this.ApiClient.ParameterToString(limit)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AppsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AppListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AppListResponse) this.ApiClient.Deserialize(localVarResponse, typeof(AppListResponse)));
            
        }

        /// <summary>
        /// Returns details about a specific app. This endpoint returns detailed information about the app specified by the &#x60;id&#x60; parameter. The calling user must be authorized to view the specified app. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the app.</param>
        /// <returns>InlineResponse2002</returns>
        public AppResponse AppsIdGet (Guid id)
        {
             ApiResponse<AppResponse> localVarResponse = AppsIdGetWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns details about a specific app. This endpoint returns detailed information about the app specified by the &#x60;id&#x60; parameter. The calling user must be authorized to view the specified app. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the app.</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse<AppResponse> AppsIdGetWithHttpInfo (Guid id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AppsApi->AppsIdGet");

            var localVarPath = ApiClient.ApiPathPrefix + "/apps/{id}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(this.ApiClient.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", this.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AppsIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AppResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AppResponse) this.ApiClient.Deserialize(localVarResponse, typeof(AppResponse)));
            
        }

        /// <summary>
        /// Returns details about a specific app. This endpoint returns detailed information about the app specified by the &#x60;id&#x60; parameter. The calling user must be authorized to view the specified app. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the app.</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<AppResponse> AppsIdGetAsync (Guid id)
        {
             ApiResponse<AppResponse> localVarResponse = await AppsIdGetAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns details about a specific app. This endpoint returns detailed information about the app specified by the &#x60;id&#x60; parameter. The calling user must be authorized to view the specified app. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the app.</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AppResponse>> AppsIdGetAsyncWithHttpInfo (Guid id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling AppsApi->AppsIdGet");

            var localVarPath = ApiClient.ApiPathPrefix + "/apps/{id}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(this.ApiClient.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", this.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AppsIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AppResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AppResponse) this.ApiClient.Deserialize(localVarResponse, typeof(AppResponse)));
            
        }

    }
}