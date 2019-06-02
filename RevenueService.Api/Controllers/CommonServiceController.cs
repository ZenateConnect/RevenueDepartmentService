using Microsoft.AspNetCore.Http;
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
    /// Reference: http://www.rd.go.th/publish/42539.0.html
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CommonServiceController : BaseApiController
    {
        private const string VATCommonService = "VATCommonService";
        private const string VRTCommonService = "VRTCommonService";

        /// <summary>
        /// ให้บริการข้อมูลพื้นฐานของร้านค้าที่ได้รับสิทธิ์คืนภาษีมูลค่าเพิ่มให้นักท่องเที่ยวเป็นข้อมูล และ ข้อมูลพื้นฐานของผู้ประกอบการจดทะเบียนภาษีมูลค่าเพิ่มเป็นข้อมูล
        /// </summary>
        /// <remarks>
        /// ให้บริการข้อมูลพื้นฐานของร้านค้าที่ได้รับสิทธิ์คืนภาษีมูลค่าเพิ่มให้นักท่องเที่ยวเป็นข้อมูล รหัสจังหวัด ชื่อจังหวัด รหัสประเภทธุรกิจ ชื่อประเภทธุรกิจ รหัสถนน และชื่อถนน
        /// ให้บริการข้อมูลพื้นฐานของผู้ประกอบการจดทะเบียนภาษีมูลค่าเพิ่มเป็นข้อมูล รหัสอำเภอ รหัสจังหวัด คำอธิบายรหัส(คำอธิบายจะแสดงเป็นชื่ออำเภอหรือชื่อจังหวัดเช่น กรณีที่รหัสอำเภอลงท้ายด้วย '00' จะแสดงชื่อจังหวัด ถ้าลงท้ายด้วยเลขอื่นจะแสดงชื่ออำเภอในจังหวัดนั้นๆ)
        /// </remarks>
        /// <param name="typeOfService"></param>
        /// <returns></returns>
        [HttpGet("Get/{typeOfService}")]
        public async Task<ActionResult<HttpResultModel>> Get(string typeOfService)
        {
            HttpResultModel httpResult = new HttpResultModel();
            try
            {
                CommonSoapService.commonserviceRD3SoapClient service = new CommonSoapService.commonserviceRD3SoapClient();
                ChannelFactory<CommonSoapService.commonserviceRD3Soap> channelFactory = service.ChannelFactory;
                CommonSoapService.commonserviceRD3Soap channel = channelFactory.CreateChannel();
                CommonSoapService.ServiceRequest serviceRequest = new CommonSoapService.ServiceRequest
                {
                    Body = new CommonSoapService.ServiceRequestBody
                    {
                        username = soapUsername,
                        password = soapPassword,
                        typeofservice = typeOfService
                    }
                };

                CommonSoapService.ServiceResponse responseMessage = await channel.ServiceAsync(serviceRequest);
                CommonSoapService.common soapResult = responseMessage?.Body.ServiceResult;

                List<Common> listCommon = new List<Common>();
                Model.Common commonModel = new Model.Common(soapResult);

                if (soapResult != null)
                {
                    int countRecord = 0;

                    if (typeOfService == VRTCommonService)
                        countRecord = soapResult.vBusinessTypeCode.Count();
                    else if (typeOfService == VATCommonService)
                        countRecord = soapResult.vAmphurCode.Count();

                    for (int index = 0; index < countRecord; index++)
                    {
                        Common common = new Common();
                        if (typeOfService == VRTCommonService)
                        {
                            common = new Common
                            {
                                typeofservice = typeOfService,
                                // VRTCommon
                                vBusinessTypeCode = soapResult.vBusinessTypeCode[index]?.ToString(),
                                vBusinessTypeName = soapResult.vBusinessTypeName[index]?.ToString(),
                                vStreetCode = soapResult.vStreetCode[index]?.ToString(),
                                vStreetName = soapResult.vStreetName[index]?.ToString(),
                                vVRTProvinceCode = soapResult.vVRTProvinceCode[index]?.ToString(),
                                vVRTProvinceName = soapResult.vVRTProvinceName[index]?.ToString(),

                                vMessErr = soapResult.vMessErr.Count() > 0 ? soapResult.vMessErr[index]?.ToString() : null,
                            };
                            listCommon.Add(common);
                        }
                        else if (typeOfService == VATCommonService)
                        {
                            common = new Common
                            {
                                typeofservice = typeOfService,
                                // VATCommon
                                vAmphurCode = soapResult.vAmphurCode[index]?.ToString(),
                                vProvinceCode = soapResult.vProvinceCode[index]?.ToString(),
                                vDescription = soapResult.vDescription[index]?.ToString(),

                                vMessErr = soapResult.vMessErr.Count() > 0 ? soapResult.vMessErr[index]?.ToString() : null,
                            };
                            listCommon.Add(common);
                        }
                    }
                }

                httpResult.SetPropertyHttpResult(httpResult, true, "", "", StatusCodes.Status200OK, listCommon);
            }
            catch (Exception ex)
            {
                httpResult.SetPropertyHttpResult(httpResult, false, "API Error", ex.Message, StatusCodes.Status500InternalServerError);
            }

            return Ok(httpResult);
        }

        /// <summary>
        /// ให้บริการข้อมูลพื้นฐานของร้านค้าที่ได้รับสิทธิ์คืนภาษีมูลค่าเพิ่มให้นักท่องเที่ยวเป็นข้อมูล และ ข้อมูลพื้นฐานของผู้ประกอบการจดทะเบียนภาษีมูลค่าเพิ่มเป็นข้อมูล
        /// </summary>
        /// <remarks>
        /// ให้บริการข้อมูลพื้นฐานของร้านค้าที่ได้รับสิทธิ์คืนภาษีมูลค่าเพิ่มให้นักท่องเที่ยวเป็นข้อมูล รหัสจังหวัด ชื่อจังหวัด รหัสประเภทธุรกิจ ชื่อประเภทธุรกิจ รหัสถนน และชื่อถนน
        /// ให้บริการข้อมูลพื้นฐานของผู้ประกอบการจดทะเบียนภาษีมูลค่าเพิ่มเป็นข้อมูล รหัสอำเภอ รหัสจังหวัด คำอธิบายรหัส(คำอธิบายจะแสดงเป็นชื่ออำเภอหรือชื่อจังหวัดเช่น กรณีที่รหัสอำเภอลงท้ายด้วย '00' จะแสดงชื่อจังหวัด ถ้าลงท้ายด้วยเลขอื่นจะแสดงชื่ออำเภอในจังหวัดนั้นๆ)
        /// </remarks>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpGet("Get")]
        public async Task<ActionResult<HttpResultModel>> Get([FromBody]Model.Common model)
        {
            HttpResultModel httpResult = new HttpResultModel();
            try
            {
                CommonSoapService.commonserviceRD3SoapClient service = new CommonSoapService.commonserviceRD3SoapClient();
                ChannelFactory<CommonSoapService.commonserviceRD3Soap> channelFactory = service.ChannelFactory;
                CommonSoapService.commonserviceRD3Soap channel = channelFactory.CreateChannel();
                CommonSoapService.ServiceRequest serviceRequest = new CommonSoapService.ServiceRequest
                {
                    Body = new CommonSoapService.ServiceRequestBody
                    {
                        username = soapUsername,
                        password = soapPassword,
                        typeofservice = model.typeofservice
                    }
                };

                CommonSoapService.ServiceResponse responseMessage = await channel.ServiceAsync(serviceRequest);
                CommonSoapService.common soapResult = responseMessage?.Body.ServiceResult;

                List<Common> listCommon = new List<Common>();
                Model.Common commonModel = new Model.Common(soapResult);

                if (soapResult != null)
                {
                    int countRecord = 0;

                    if (model.typeofservice == VRTCommonService)
                        countRecord = soapResult.vBusinessTypeCode.Count();
                    else if (model.typeofservice == VATCommonService)
                        countRecord = soapResult.vAmphurCode.Count();

                    for (int index = 0; index < countRecord; index++)
                    {
                        Common common = new Common();
                        if (model.typeofservice == VRTCommonService)
                        {
                            common = new Common
                            {
                                typeofservice = model.typeofservice,
                                // VRTCommon
                                vBusinessTypeCode = soapResult.vBusinessTypeCode[index]?.ToString(),
                                vBusinessTypeName = soapResult.vBusinessTypeName[index]?.ToString(),
                                vStreetCode = soapResult.vStreetCode[index]?.ToString(),
                                vStreetName = soapResult.vStreetName[index]?.ToString(),
                                vVRTProvinceCode = soapResult.vVRTProvinceCode[index]?.ToString(),
                                vVRTProvinceName = soapResult.vVRTProvinceName[index]?.ToString(),

                                vMessErr = soapResult.vMessErr.Count() > 0 ? soapResult.vMessErr[index]?.ToString() : null,
                            };
                            listCommon.Add(common);
                        }
                        else if (model.typeofservice == VATCommonService)
                        {
                            common = new Common
                            {
                                typeofservice = model.typeofservice,
                                // VATCommon
                                vAmphurCode = soapResult.vAmphurCode[index]?.ToString(),
                                vProvinceCode = soapResult.vProvinceCode[index]?.ToString(),
                                vDescription = soapResult.vDescription[index]?.ToString(),

                                vMessErr = soapResult.vMessErr.Count() > 0 ? soapResult.vMessErr[index]?.ToString() : null,
                            };
                            listCommon.Add(common);
                        }
                    }
                }

                httpResult.SetPropertyHttpResult(httpResult, true, "", "", StatusCodes.Status200OK, listCommon);
            }
            catch (Exception ex)
            {
                httpResult.SetPropertyHttpResult(httpResult, false, "API Error", ex.Message, StatusCodes.Status500InternalServerError);
            }

            return Ok(httpResult);
        }
    }
}