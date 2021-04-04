using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RevenueService.Api.Model;
using System.ServiceModel;
using System.Threading.Tasks;

namespace RevenueService.Api.Controllers
{
    /// <summary>
    /// Reference: http://www.rd.go.th/publish/42533.0.html
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TINServiceController : BaseApiController
    {
        /// <summary>
        /// ให้บริการตรวจสอบความถูกต้องของเลขประจำตัว ผู้เสียภาษีอากร และเลขประจำตัวประชาชน ว่าเป็นเลขที่มีอยู่จริง และเป็นเลขที่ถูกต้อง
        /// </summary>
        /// <remarks>ให้บริการตรวจสอบความถูกต้องของเลขประจำตัว ผู้เสียภาษีอากร และเลขประจำตัวประชาชน ว่าเป็นเลขที่มีอยู่จริง และเป็นเลขที่ถูกต้อง หน่วยงาน ที่ต้องการตรวจสอบ ความมีอยู่จริง ของเลขประจำตัว ผู้เสียภาษีอากร และเลขประจำตัวประชาชน เพื่อป้องกัน การปลอมเลขประจำตัว ผู้เสียภาษีอากร และเลขประจำตัวประชาชน ในการประกอบธุรกรรมต่างๆ ที่ก่อให้เกิดความเสียหาย แก่หน่วยงานหรือผู้ประกอบการต่างๆ</remarks>
        /// <param name="tIN">เลขประจำตัวผู้เสียภาษีอากร</param>
        /// <returns></returns>
        [HttpGet("Get/{tIN}")]
        public async Task<ActionResult<TINResult>> GetById(string tIN)
        {
            if (!string.IsNullOrEmpty(tIN))
            {
                TINSoapService.checktinpinserviceSoapClient service = new TINSoapService.checktinpinserviceSoapClient();
                ChannelFactory<TINSoapService.checktinpinserviceSoap> channelFactory = service.ChannelFactory;
                TINSoapService.checktinpinserviceSoap channel = channelFactory.CreateChannel();

                TINSoapService.ServiceTINRequest serviceRequest = new TINSoapService.ServiceTINRequest
                {
                    Body = new TINSoapService.ServiceTINRequestBody
                    {
                        username = soapUsername,
                        password = soapPassword,
                        TIN = tIN,
                    }
                };

                TINSoapService.ServiceTINResponse responseMessage = await channel.ServiceTINAsync(serviceRequest);
                object soapResult = responseMessage?.Body?.ServiceTINResult;
                JObject jObject = JObject.Parse(soapResult?.ToString());

                TINResult tINResult = new TINResult
                {
                    ID = ((JValue)((JContainer)jObject[nameof(TINResult.ID)]).First)?.Value?.ToString(),
                    MessageErr = ((JValue)((JContainer)jObject[nameof(TINResult.MessageErr)]).First)?.Value?.ToString(),
                    DigitOk = ((JValue)((JContainer)jObject[nameof(TINResult.DigitOk)]).First)?.Value?.ToString(),
                    IsExist = ((JValue)((JContainer)jObject[nameof(TINResult.IsExist)]).First)?.Value?.ToString(),
                    vID = ((JValue)((JContainer)jObject[nameof(TINResult.vID)]).First)?.Value?.ToString(),
                    vMessageErr = ((JValue)((JContainer)jObject[nameof(TINResult.vMessageErr)]).First)?.Value?.ToString(),
                    vDigitOk = ((JValue)((JContainer)jObject[nameof(TINResult.vDigitOk)]).First)?.Value?.ToString(),
                    vIsExist = ((JValue)((JContainer)jObject[nameof(TINResult.vIsExist)]).First)?.Value?.ToString()
                };

                return tINResult;
            }
            else
            {
                return BadRequest("Invalid tIN");
            }
        }
    }
}