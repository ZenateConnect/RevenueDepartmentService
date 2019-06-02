using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevenueService.Api.Model
{
    public class GEM
    {
        public GEM()
        {

        }

        public GEM(GEMSoapService.gems soapObject)
        {
            if(soapObject != null)
            {
                vVATTaxPayerName = soapObject.vVATTaxPayerName?.FirstOrDefault()?.ToString();
                vVATTaxPayerSurname = soapObject.vVATTaxPayerSurname?.FirstOrDefault()?.ToString();
                vGuildName = soapObject.vGuildName?.FirstOrDefault()?.ToString();
                vProvince = soapObject.vProvince?.FirstOrDefault()?.ToString();
                vProvinceCode = soapObject.vProvince?.FirstOrDefault()?.ToString();
                vProvinceName = soapObject.vProvinceName?.FirstOrDefault()?.ToString();
                vNID = soapObject.vNID?.FirstOrDefault()?.ToString();
                vTIN = soapObject.vTIN?.FirstOrDefault()?.ToString();
                vTitleName = soapObject.vTitleName?.FirstOrDefault()?.ToString();
                vBuildingNumber = soapObject.vBuildingNumber?.FirstOrDefault()?.ToString();
                vRoomNumber = soapObject.vRoomNumber?.FirstOrDefault()?.ToString();
                vFloorNumber = soapObject.vFloorNumber?.FirstOrDefault()?.ToString();
                vVillageName = soapObject.vVillageName?.FirstOrDefault()?.ToString();
                vHouseNumber = soapObject.vHouseNumber?.FirstOrDefault()?.ToString();
                vMooNumber = soapObject.vMooNumber?.FirstOrDefault()?.ToString();
                vSoiName = soapObject.vSoiName?.FirstOrDefault()?.ToString();
                vStreetName = soapObject.vStreetName?.FirstOrDefault()?.ToString();
                vAmphurName = soapObject.vAmphurName?.FirstOrDefault()?.ToString();
                vPostCode = soapObject.vPostCode?.FirstOrDefault()?.ToString();
                vPrivilegeDate = soapObject.vPrivilegeDate?.FirstOrDefault()?.ToString();
                vMessErr = soapObject.vMessErr?.FirstOrDefault()?.ToString();
            }
            
        }

        /// <summary>
        /// เลขประจำตัวผู้เสียภาษี (TaxPayerID)	เลขประจำตัวผู้เสียภาษีอากรที่ต้องการค้นหาข้อมูล 13 หลัก(Please insert the taxpayer number for searching)
        /// </summary>
        public string vTaxPayerID { get; set; }

        /// <summary>
        /// ชื่อของผู้ประกอบการ (VATTaxPayerName)	ชื่อร้านค้าที่ต้องการค้นหา (Please insert the name of the shops for searching)
        /// </summary>
        public string vVATTaxPayerName { get; set; }

        /// <summary>
        /// นามสกุลของผู้ประกอบการ
        /// </summary>
        public string vVATTaxPayerSurname { get; set; }

        /// <summary>
        /// ชื่อสมาคมที่เป็นสมาชิก (GuildName)	มีให้เลือกดังนี้ (Please choose from the following)
        /// - สมาคมผู้ค่าอัญมณีไทยและเครื่องประดับ / The Thai Gem and Jewelry Traders Association(TGJTA)
        /// - สมาคมการค้าเพชรและพลอยอินเดียน-ไทย / Indian-Thai Diamond and Colorstone Association(ITDCA)
        /// - สมาคมเครื่องถมและเครื่องเงินไทย / Thai Niello and Silver ware Association under Royal Patronage
        /// - สมาคมผู้ผลิตอัญมณีและเครื่องประดับไทย / Thai Gem and Jewelry Manufacturers Association
        /// - สมาคมเพชรพลอยเงินทอง / The Jeweller Association
        /// - สมาคมผู้ประกอบการเจียระไนเพชร / Thai Diamond Manufacturers Association
        /// - สมาคมผู้ค้าอัญมณีและเครื่องประดับจันทบุรี / Chanthaburi Gems and Jewelry Traders Association
        /// </summary>
        public string vGuildName { get; set; }

        /// <summary>
        /// รหัสจังหวัด (ProvinceCode)	ถ้าไม่ทราบรหัส สามารถค้นหารหัสได้ใน CommonService (If Province code is not known, please search in CommonService)
        /// </summary>
        public string vProvinceCode { get; set; }

        /// <summary>
        /// เลขประจำตัวผู้เสียภาษี 13 หลัก (NID)
        /// </summary>
        public string vNID { get; set; }

        /// <summary>
        /// คำนำหน้าชื่อ (TitleName)
        /// </summary>
        public string vTIN { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string vProvince { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string vTitleName { get; set; }

        /// <summary>
        /// ชื่ออาคาร (BuildingName)
        /// </summary>
        public string vBuildingNumber { get; set; }

        /// <summary>
        /// ห้องที่ (RoomNumber)
        /// </summary>
        public string vRoomNumber { get; set; }

        /// <summary>
        /// ชั้นที่ (FloorNumber)
        /// </summary>
        public string vFloorNumber { get; set; }

        /// <summary>
        /// หมู่บ้าน (VillageName)
        /// </summary>
        public string vVillageName { get; set; }

        /// <summary>
        /// เลขที่ตั้งของสถานประกอบการ (HouseNumber)
        /// </summary>
        public string vHouseNumber { get; set; }

        /// <summary>
        /// หมู่ที่ (MooNumber)
        /// </summary>
        public string vMooNumber { get; set; }

        /// <summary>
        /// ซอย (SoiName)
        /// </summary>
        public string vSoiName { get; set; }

        /// <summary>
        /// ถนน (StreetName)
        /// </summary>
        public string vStreetName { get; set; }

        /// <summary>
        /// ตำบล (ThumbolName)
        /// </summary>
        public string vThambolName { get; set; }

        /// <summary>
        /// อำเภอ (AmphurName)
        /// </summary>
        public string vAmphurName { get; set; }

        /// <summary>
        /// จังหวัด (ProvinceName)
        /// </summary>
        public string vProvinceName { get; set; }

        /// <summary>
        /// รหัสไปรษณีย์ (PostCode)
        /// </summary>
        public string vPostCode { get; set; }

        /// <summary>
        /// วันเดือนปีที่กรมสรรพากรอนุมัติให้ใช้สิทธิ์ได้(PrivilegeDate)
        /// </summary>
        public string vPrivilegeDate { get; set; }


        public string vMessErr { get; set; }
    }
}
