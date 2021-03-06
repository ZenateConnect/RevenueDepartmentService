﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RevenueService.Api.Helper;
using RevenueService.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Threading.Tasks;

namespace RevenueService.Api.Controllers
{
    /// <summary>
    /// Reference: http://www.rd.go.th/publish/42535.0.html
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class VATServiceController : BaseApiController
    {
        /// <summary>
        /// ให้บริการข้อมูลการตรวจสอบสถานะ และรายละเอียดผู้ประกอบการ ที่ได้ดำเนินการจดทะเบียนกับกรมสรรพากรอย่างถูกต้อง
        /// </summary>
        /// <remarks>
        /// ให้บริการข้อมูลการตรวจสอบสถานะ และรายละเอียดผู้ประกอบการ ที่ได้ดำเนินการจดทะเบียนกับกรมสรรพากรอย่างถูกต้อง อีกทั้งมีสิทธิ ในการออก ใบกำกับภาษีมูลค่าเพิ่ม ตามกฎหมาย ผู้ประกอบการ ทั้งในและต่างประเทศ ที่ต้องการตรวจสอบ บริษัทคู่ค้าว่าเป็นผู้ที่สามารถ ออกใบกำกับภาษีได้ถูกต้อง ตามกฎหมายไทย หรือไม่ เนื่องจากสถานะนี้สามารถเปลี่ยนแปลง ซึ่งป้องกันการแอบอ้าง การออกใบกำกับภาษีอย่างผิดกฎหมาย ซึ่งจะเกิดความเสียหาย แก่บริษัทผู้ใช้บริการ หรือรับใบกำกับภาษีดังกล่าว อีกทั้งเป็นการตรวจสอบ การมีตัวตนจริงของคู่ค้าดังกล่าว
        /// </remarks>
        /// <param name="tIN">เลขประจำตัวผู้เสียภาษี</param>
        /// <returns></returns>
        [HttpGet("Get/{tIN}")]
        public async Task<ActionResult<HttpResultModel>> GetById(string tIN)
        {
            HttpResultModel httpResult = new HttpResultModel();
            try
            {
                if (!string.IsNullOrWhiteSpace(tIN))
                {
                    VATSoapService.vatserviceRD3SoapClient service = new VATSoapService.vatserviceRD3SoapClient();
                    ChannelFactory<VATSoapService.vatserviceRD3Soap> channelFactory = service.ChannelFactory;
                    // Must set certificates before CreateChannel()
                    //string certificatepath1 = @"C:\Users\Me\source\repos\RevenueService\RevenueService.Api\Resources\adhq1.cer";
                    //string certificatepath2 = @"C:\Users\Me\source\repos\RevenueService\RevenueService.Api\Resources\ADHQ5.cer";
                    //X509Certificate2 certificate1 = new X509Certificate2(System.IO.File.ReadAllBytes(certificatepath1));
                    //X509Certificate2 certificate2 = new X509Certificate2(System.IO.File.ReadAllBytes(certificatepath2));
                    //channelFactory.Credentials.ClientCertificate.Certificate = certificate1;
                    //channelFactory.Credentials.ServiceCertificate.DefaultCertificate = certificate2;

                    VATSoapService.vatserviceRD3Soap channel = channelFactory.CreateChannel();
                    VATSoapService.ServiceRequest serviceRequest = new VATSoapService.ServiceRequest
                    {
                        Body = new VATSoapService.ServiceRequestBody
                        {
                            username = soapUsername,
                            password = soapPassword,
                            TIN = tIN,
                            Name = "",
                            ProvinceCode = 0,
                            BranchNumber = 0,
                            AmphurCode = 0,
                        }
                    };

                    VATSoapService.ServiceResponse responseMessage = await channel.ServiceAsync(serviceRequest);
                    VATSoapService.vat soapResult = responseMessage?.Body.ServiceResult;
                    Model.VAT vat = new Model.VAT(soapResult);
                    httpResult.SetPropertyHttpResult(httpResult, true, "", "", StatusCodes.Status200OK, vat);
                }
                else
                {
                    httpResult.SetPropertyHttpResult(httpResult, true, "", "", StatusCodes.Status400BadRequest);
                }
            }
            catch (Exception ex)
            {
                httpResult.SetPropertyHttpResult(httpResult, false, "", ex.Message, StatusCodes.Status500InternalServerError);
            }

            return httpResult;
        }

        /// <summary>
        /// ให้บริการข้อมูลการตรวจสอบสถานะ และรายละเอียดผู้ประกอบการ ที่ได้ดำเนินการจดทะเบียนกับกรมสรรพากรอย่างถูกต้อง
        /// </summary>
        /// <remarks>
        /// ให้บริการข้อมูลการตรวจสอบสถานะ และรายละเอียดผู้ประกอบการ ที่ได้ดำเนินการจดทะเบียนกับกรมสรรพากรอย่างถูกต้อง อีกทั้งมีสิทธิ ในการออก ใบกำกับภาษีมูลค่าเพิ่ม ตามกฎหมาย ผู้ประกอบการ ทั้งในและต่างประเทศ ที่ต้องการตรวจสอบ บริษัทคู่ค้าว่าเป็นผู้ที่สามารถ ออกใบกำกับภาษีได้ถูกต้อง ตามกฎหมายไทย หรือไม่ เนื่องจากสถานะนี้สามารถเปลี่ยนแปลง ซึ่งป้องกันการแอบอ้าง การออกใบกำกับภาษีอย่างผิดกฎหมาย ซึ่งจะเกิดความเสียหาย แก่บริษัทผู้ใช้บริการ หรือรับใบกำกับภาษีดังกล่าว อีกทั้งเป็นการตรวจสอบ การมีตัวตนจริงของคู่ค้าดังกล่าว
        /// </remarks>
        /// <param name="model">VAT Model: โยนค่า TIN, Name, ProvinceCode, BranchNumber, AmphurCode
        /// เลขประจำตัวผู้เสียภาษี(TIN)	เลขประจำตัวผู้เสียภาษีอากรที่ต้องการค้นหาข้อมูล 13 หลัก ถ้าไม่ทราบให้ว่างไว้
        /// ชื่อของผู้ประกอบการ (Name)	ชื่อร้านค้าที่ต้องการค้นหา ถ้าไม่ทราบให้ว่างไว้
        /// รหัสจังหวัด(ProvinceCode)	ถ้าไม่ทราบรหัส สามารถค้นหารหัสได้ใน CommonService ถ้าไม่ทราบให้ใส่ "0"
        /// เลขที่สาขา(BranchNumbe)	เลขที่สาขาที่ต้องการทราบข้อมูล ถ้าไม่ทราบให้ใส่ "0"
        /// รหัสอำเภอ(AmphurCode)	ถ้าไม่ทราบรหัส สามารถค้นหารหัสได้ใน CommonService ถ้าไม่ทราบให้ใส่ "0"</param>
        /// <returns></returns>
        [HttpGet("Get")]
        public async Task<ActionResult<HttpResultModel>> Get([FromBody]Model.VAT model)
        {
            HttpResultModel httpResult = new HttpResultModel();
            try
            {
                VATSoapService.vatserviceRD3SoapClient service = new VATSoapService.vatserviceRD3SoapClient();
                ChannelFactory<VATSoapService.vatserviceRD3Soap> channelFactory = service.ChannelFactory;
                VATSoapService.vatserviceRD3Soap channel = channelFactory.CreateChannel();
                VATSoapService.ServiceRequest serviceRequest = new VATSoapService.ServiceRequest
                {
                    Body = new VATSoapService.ServiceRequestBody
                    {
                        username = soapUsername,
                        password = soapPassword,
                        TIN = model.vtin,
                        Name = model.vName,
                        ProvinceCode = Convert.ToInt32(model.vProvince),
                        BranchNumber = Convert.ToInt32(model.vBranchNumber),
                        AmphurCode = Convert.ToInt32(model.vAmphur),
                    }
                };

                VATSoapService.ServiceResponse responseMessage = await channel.ServiceAsync(serviceRequest);
                VATSoapService.vat soapResult = responseMessage?.Body.ServiceResult;
                Model.VAT vatModel = new Model.VAT(soapResult);

                httpResult.SetPropertyHttpResult(httpResult, true, "", "", StatusCodes.Status200OK, vatModel);
            }
            catch (Exception ex)
            {
                httpResult.SetPropertyHttpResult(httpResult, false, "API Error", ex.Message, StatusCodes.Status500InternalServerError);
            }
           
            return Ok(httpResult);
        }

    }
}