using Microsoft.AspNetCore.Mvc;
using RevenueService.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace RevenueService.Api.Controllers
{
    /// <summary>
    /// Reference: http://www.rd.go.th/publish/42534.0.html
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class VRTServiceController : BaseApiController
    {
        /// <summary>
        /// ให้บริการข้อมูลผู้ประกอบการ ที่ได้รับสิทธิเมื่อนักท่องเที่ยวต่างประเทศ ซื้อสินค้าแล้ว สามารถเรียกคืนภาษีมูลค่าเพิ่มได้ในภายหลัง
        /// </summary>
        /// <remarks>
        /// ให้บริการข้อมูลผู้ประกอบการ ที่ได้รับสิทธิเมื่อนักท่องเที่ยวต่างประเทศ ซื้อสินค้าแล้ว สามารถเรียกคืนภาษีมูลค่าเพิ่มได้ในภายหลัง โดยให้บริการ สำหรับหน่วยงาน ที่ต้องการนำข้อมูลดังกล่าวไปให้ บริการนักท่องเที่ยว เพื่อตรวจสอบร้านค้า ที่นักท่องเที่ยวสามารถ เรียกคืนภาษีมูลค่าเพิ่ม ได้ถูกต้อง ตามกฎหมาย ซึ่งป้องกัน การแอบอ้าง จากร้านค้า ซึ่งจะเป็นปัญหาต่อ นักท่องเที่ยวในภายหลัง และให้นักท่องเที่ยว มีความมั่นใจในการซื้อสินค้าจากร้านดังกล่าว
        /// </remarks>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<VRT>>> GetAll()
        {
            List<VRT> listVRT = new List<VRT>();
            VRTSoapService.vrtserviceRD3SoapClient service = new VRTSoapService.vrtserviceRD3SoapClient();
            ChannelFactory<VRTSoapService.vrtserviceRD3Soap> channelFactory = service.ChannelFactory;
            VRTSoapService.vrtserviceRD3Soap channel = channelFactory.CreateChannel();

            VRTSoapService.ServiceRequest serviceRequest = new VRTSoapService.ServiceRequest
            {
                Body = new VRTSoapService.ServiceRequestBody
                {
                    username = soapUsername,
                    password = soapPassword,
                    ShopName = "",
                    BusinessTypeCode = "",
                    ProvinceCode = 0,
                    StreetCode = 0
                }
            };

            VRTSoapService.ServiceResponse responseMessage = await channel.ServiceAsync(serviceRequest);
            VRTSoapService.vrt soapResult = responseMessage?.Body?.ServiceResult;


            if (soapResult != null)
            {
                int countRecord = soapResult.vShopName.Count();

                for (int index = 0; index < countRecord; index++)
                {
                    VRT vrtModel = new VRT
                    {
                        vShopName = soapResult.vShopName[index]?.ToString(),
                        vBusinessTypeName = soapResult.vBusinessTypeName[index]?.ToString(),
                        vBusinessName = soapResult.vBusinessName[index]?.ToString(),
                        vHouseNumber = soapResult.vHouseNumber[index]?.ToString(),
                        vStreetName = soapResult.vStreetName[index]?.ToString(),
                        vThambolName = soapResult.vThambolName[index]?.ToString(),
                        vAmphurName = soapResult.vAmphurName[index]?.ToString(),
                        vProvinceName = soapResult.vProvinceName[index]?.ToString(),
                        vPostCode = soapResult.vPostCode[index]?.ToString(),
                        vmsgerr = soapResult.vmsgerr.Count() > 0 ? soapResult.vmsgerr[index]?.ToString() : null,
                    };
                    listVRT.Add(vrtModel);
                }
            }

            return listVRT;
        }

        /// <summary>
        /// ให้บริการข้อมูลผู้ประกอบการ ที่ได้รับสิทธิเมื่อนักท่องเที่ยวต่างประเทศ ซื้อสินค้าแล้ว สามารถเรียกคืนภาษีมูลค่าเพิ่มได้ในภายหลัง
        /// </summary>
        /// <remarks>
        /// ให้บริการข้อมูลผู้ประกอบการ ที่ได้รับสิทธิเมื่อนักท่องเที่ยวต่างประเทศ ซื้อสินค้าแล้ว สามารถเรียกคืนภาษีมูลค่าเพิ่มได้ในภายหลัง โดยให้บริการ สำหรับหน่วยงาน ที่ต้องการนำข้อมูลดังกล่าวไปให้ บริการนักท่องเที่ยว เพื่อตรวจสอบร้านค้า ที่นักท่องเที่ยวสามารถ เรียกคืนภาษีมูลค่าเพิ่ม ได้ถูกต้อง ตามกฎหมาย ซึ่งป้องกัน การแอบอ้าง จากร้านค้า ซึ่งจะเป็นปัญหาต่อ นักท่องเที่ยวในภายหลัง และให้นักท่องเที่ยว มีความมั่นใจในการซื้อสินค้าจากร้านดังกล่าว
        /// </remarks>
        /// <param name="model">
        /// ชื่อร้านค้า (ShopName)	ชื่อร้านค้าที่ต้องการค้นหา
        /// รหัสประเภทธุรกิจ(BusinessTypeCode) ถ้าไม่ทราบรหัส สามารถค้นหารหัสได้ใน CommonService
        /// รหัสจังหวัด(ProvinceCode)  ถ้าไม่ทราบรหัส สามารถค้นหารหัสได้ใน CommonService
        /// รหัสถนน(StreetCode) ถ้าไม่ทราบรหัส สามารถค้นหารหัสได้ใน CommonService
        /// </param>
        /// <returns></returns>
        [HttpGet("Get")]
        public async Task<ActionResult<IEnumerable<VRT>>> Get(VRT model)
        {
            List<VRT> listVRT = new List<VRT>();
            VRTSoapService.vrtserviceRD3SoapClient service = new VRTSoapService.vrtserviceRD3SoapClient();
            ChannelFactory<VRTSoapService.vrtserviceRD3Soap> channelFactory = service.ChannelFactory;
            VRTSoapService.vrtserviceRD3Soap channel = channelFactory.CreateChannel();

            VRTSoapService.ServiceRequest serviceRequest = new VRTSoapService.ServiceRequest
            {
                Body = new VRTSoapService.ServiceRequestBody
                {
                    username = soapUsername,
                    password = soapPassword,
                    ShopName = model?.vShopName,
                    BusinessTypeCode = model?.vBusinessTypeCode,
                    ProvinceCode = Convert.ToInt32(model?.vProvinceCode),
                    StreetCode = Convert.ToInt32(model?.vStreetCode)
                }
            };

            VRTSoapService.ServiceResponse responseMessage = await channel.ServiceAsync(serviceRequest);
            VRTSoapService.vrt soapResult = responseMessage?.Body?.ServiceResult;

            if (soapResult != null)
            {
                int countRecord = soapResult.vShopName.Count();

                for (int index = 0; index < countRecord; index++)
                {
                    VRT vrtModel = new VRT
                    {
                        vShopName = soapResult.vShopName[index]?.ToString(),
                        vBusinessTypeCode = model?.vBusinessTypeCode,
                        vBusinessTypeName = soapResult.vBusinessTypeName[index]?.ToString(),
                        vBusinessName = soapResult.vBusinessName[index]?.ToString(),
                        vHouseNumber = soapResult.vHouseNumber[index]?.ToString(),
                        vStreetCode = model?.vStreetCode,
                        vStreetName = soapResult.vStreetName[index]?.ToString(),
                        vThambolName = soapResult.vThambolName[index]?.ToString(),
                        vAmphurName = soapResult.vAmphurName[index]?.ToString(),
                        vProvinceCode = model?.vProvinceCode,
                        vProvinceName = soapResult.vProvinceName[index]?.ToString(),
                        vPostCode = soapResult.vPostCode[index]?.ToString(),
                        vmsgerr = soapResult.vmsgerr.Count() > 0 ? soapResult.vmsgerr[index]?.ToString() : null,
                    };
                    listVRT.Add(vrtModel);
                }
            }

            return listVRT;
        }
    }
}