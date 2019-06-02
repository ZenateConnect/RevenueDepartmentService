using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevenueService.Api.Model
{
    /// <summary>
    /// Http Response
    /// </summary>
    public class HttpResultModel
    {
        public HttpResultModel()
        {
            Title = "";
            Message = "";
            StatusCode = "400";
            Value = null;
        }

        public string Title { get; set; }
        public string Message { get; set; }
        public string StatusCode { get; set; }
        public dynamic Value { get; set; }

        public HttpResultModel SetPropertyHttpResult(HttpResultModel httpResultModel, bool isSuccess = false, string title = "", string message = "", int statusCode = StatusCodes.Status200OK, dynamic objValue = null)
        {
            if(httpResultModel != null)
            {
                if (isSuccess)
                {
                    httpResultModel.Title = !string.IsNullOrEmpty(title) ? $"{title} - {ReasonPhrases.GetReasonPhrase(statusCode)}" : $"{ReasonPhrases.GetReasonPhrase(statusCode)}";
                    httpResultModel.StatusCode = statusCode.ToString();
                }
                else
                {
                    httpResultModel.Title = $"API Error! - {ReasonPhrases.GetReasonPhrase(statusCode)}";
                    httpResultModel.StatusCode = statusCode.ToString();
                }

                httpResultModel.Message = message;
                httpResultModel.Value = objValue;
            }
            else
            {
                httpResultModel = new HttpResultModel();
            }
            
            return httpResultModel;
        }
    }
}
