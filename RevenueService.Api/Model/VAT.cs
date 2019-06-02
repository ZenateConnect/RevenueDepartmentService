using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevenueService.Api.Model
{
    /// <summary>
    /// Model รายละเอียดผู้ประกอบการ ที่ได้ดำเนินการจดทะเบียนกับกรมสรรพากรอย่างถูกต้อง
    /// </summary>
    public class VAT
    {
        public VAT()
        {
            vProvince = "0";
            vBranchNumber = "0";
            vAmphur = "0";
        }

        public VAT(VATSoapService.vat soapObject)
        {
            if(soapObject != null)
            {
                vAmphur = soapObject.vAmphur?.FirstOrDefault()?.ToString();
                vBranchName = soapObject.vBranchName?.FirstOrDefault()?.ToString();
                vBranchNumber = soapObject.vBranchNumber?.FirstOrDefault()?.ToString();
                vBranchTitleName = soapObject.vBranchTitleName?.FirstOrDefault()?.ToString();
                vBuildingName = soapObject.vBuildingName?.FirstOrDefault()?.ToString();
                vBusinessFirstDate = soapObject.vBusinessFirstDate?.FirstOrDefault()?.ToString();
                vFloorNumber = soapObject.vFloorNumber?.FirstOrDefault()?.ToString();
                vHouseNumber = soapObject.vHouseNumber?.FirstOrDefault()?.ToString();
                vMooNumber = soapObject.vMooNumber?.FirstOrDefault()?.ToString();
                vName = soapObject.vName?.FirstOrDefault()?.ToString();
                vNID = soapObject.vNID?.FirstOrDefault()?.ToString();
                vPostCode = soapObject.vPostCode?.FirstOrDefault()?.ToString();
                vProvince = soapObject.vProvince?.FirstOrDefault()?.ToString();
                vRoomNumber = soapObject.vRoomNumber?.FirstOrDefault()?.ToString();
                vSoiName = soapObject.vSoiName?.FirstOrDefault()?.ToString();
                vStreetName = soapObject.vStreetName?.FirstOrDefault()?.ToString();
                vSurname = soapObject.vSurname?.FirstOrDefault()?.ToString();
                vThambol = soapObject.vThambol?.FirstOrDefault()?.ToString();
                vtin = soapObject.vtin?.FirstOrDefault()?.ToString();
                vtitleName = soapObject.vtitleName?.FirstOrDefault()?.ToString();
                vVillageName = soapObject.vVillageName?.FirstOrDefault()?.ToString();
                vmsgerr = soapObject.vmsgerr?.FirstOrDefault()?.ToString();
            }
        }

        /// <summary>
        /// เลขประจำตัวผู้เสียภาษี 13 หลัก (NID)
        /// </summary>
        public string vNID { get; set; }

        /// <summary>
        /// เลขประจำตัวผู้เสียภาษี
        /// </summary>
        public string vtin { get; set; }

        /// <summary>
        /// คำนำหน้าชื่อของผู้ประกอบการ (Name)
        /// </summary>
        public string vtitleName { get; set; }

        /// <summary>
        /// ชื่อของผู้ประกอบการ (Name)
        /// </summary>
        public string vName { get; set; }

        /// <summary>
        ///  นามสกุลของผู้ประกอบการ (SurName)
        /// </summary>
        public string vSurname { get; set; }

        /// <summary>
        /// เลขทีสาขา (BranchNumber)
        /// </summary>
        public string vBranchNumber { get; set; }

        /// <summary>
        /// คำนำหน้าชื่อ (BranchTitle)
        /// </summary>
        public string vBranchTitleName { get; set; }

        /// <summary>
        /// ชื่อสถานประกอบการ (BranchName)
        /// </summary>
        public string vBranchName { get; set; }

        /// <summary>
        /// ชื่ออาคาร (BuildingName)
        /// </summary>
        public string vBuildingName { get; set; }

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
        public string vThambol { get; set; }

        /// <summary>
        /// อำเภอ (AmphurName)
        /// </summary>
        public string vAmphur { get; set; }

        /// <summary>
        /// จังหวัด (ProvinceName)
        /// </summary>
        public string vProvince { get; set; }

        /// <summary>
        /// รหัสไปรษณีย์ (PostCode)
        /// </summary>
        public string vPostCode { get; set; }

        /// <summary>
        /// วันที่กรมสรรพากรอนุมัติให้เป็นผู้ประกอบการจดทะเบียนภาษีมูลค่าเพิ่ม ซึ่งมีสิทธิ์ออกใบกำกับภาษีซื้อ (BusinessFirstDate)
        /// </summary>
        public string vBusinessFirstDate { get; set; }

        /// <summary>
        /// Error Message
        /// </summary>
        public string vmsgerr { get; set; }
    }
}
