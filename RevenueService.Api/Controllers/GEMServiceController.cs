using System;
using System.ServiceModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RevenueService.Api.Model;

namespace RevenueService.Api.Controllers
{
    /// <summary>
    /// Reference: http://www.rd.go.th/publish/42532.0.html
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class GEMServiceController : BaseApiController
    {
        /// <summary>
        /// ให้บริการข้อมูลที่ผู้ประกอบการนำเข้า หรือขายอัญมณี ทองคำขาว เงิน และพาราเดียม ผู้จดทะเบียนที่สำนัก บริหารภาษีธุรกิจขนาดใหญ่ หรือ สำนักงานสรรพากรพื้นที่ ที่ผู้ประกอบการอยู่ภายใต้การบริหาร เพื่อขอสิทธิ์ยกเว้นภาษีมูลค่าเพิ่ม โดยให้บริการสำหรับผู้ประกอบการทั้งในและต่างประเทศที่ต้องการ
        /// </summary>
        /// <remarks>
        /// ให้บริการข้อมูลที่ผู้ประกอบการนำเข้า หรือขายอัญมณี ทองคำขาว เงิน และพาราเดียม ผู้จดทะเบียนที่สำนัก บริหารภาษีธุรกิจขนาดใหญ่ หรือ สำนักงานสรรพากรพื้นที่ ที่ผู้ประกอบการอยู่ภายใต้การบริหาร เพื่อขอสิทธิ์ยกเว้นภาษีมูลค่าเพิ่ม โดยให้บริการสำหรับผู้ประกอบการทั้งในและต่างประเทศที่ต้องการ ตรวจสอบความมีตัวตนจริงของคู่ค้า และสามารถตรวจสอบการได้รับสิทธิยกเว้นภาษีมูลค่าเพิ่มจากกรมสรรพากร อย่างถูกต้อง ตามกฎหมาย ทั้งนี้ กรมศุลกากร นำไปใช้เพื่อตรวจสอบผู้ประกอบการนำเข้าอัญมณีว่ารายใดได้รับสิทธิ์ยกเว้นภาษีมูลค่าเพิ่มจากกรมสรรพากร เพื่อประโยชน์ในการจัดเก็บภาษีมูลค่าเพิ่มได้อย่างถูกต้องครบถ้วน โดยพิจารณาจากวันที่ได้รับสิทธิ์ยกเว้นภาษีมูลค่าเพิ่ม
        /// </remarks>
        /// <param name="model">GEM Model: โยนค่า 
        /// </param>
        /// <returns></returns>
        [HttpGet("Get")]
        public async Task<ActionResult<GEM>> Get([FromBody]GEM model)
        {
            GEMSoapService.gemserviceRD3SoapClient service = new GEMSoapService.gemserviceRD3SoapClient();
            ChannelFactory<GEMSoapService.gemserviceRD3Soap> channelFactory = service.ChannelFactory;
            GEMSoapService.gemserviceRD3Soap channel = channelFactory.CreateChannel();
            GEMSoapService.ServiceRequest serviceRequest = new GEMSoapService.ServiceRequest
            {
                Body = new GEMSoapService.ServiceRequestBody
                {
                    username = soapUsername,
                    password = soapPassword,
                    TIN = model.vTaxPayerID,
                    ProvinceCode = Convert.ToInt32(model.vProvinceCode),
                    GuildName = model.vGuildName,
                    VATTaxPayerName = model.vVATTaxPayerName
                }
            };

            GEMSoapService.ServiceResponse responseMessage = await channel.ServiceAsync(serviceRequest);
            GEMSoapService.gems soapResult = responseMessage?.Body.ServiceResult;
            GEM gemModel = new GEM(soapResult);
            // TODO: ตรงนี้ไม่มีตัวอย่างข้อมูลสำหรับทดสอบ หากต้องการใช้งานจะต้องพัฒนาต่อเอง

            return gemModel;
        }
    }
}