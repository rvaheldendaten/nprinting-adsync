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
using RestSharp;

namespace Qlik.NPrinting.Rest.Client.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IRestResponse response);
}
