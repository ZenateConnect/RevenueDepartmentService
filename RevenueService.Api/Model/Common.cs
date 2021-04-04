using System.Linq;

namespace RevenueService.Api.Model
{
    public class Common
    {
        public Common()
        {

        }

        public Common(CommonSoapService.common soapObject)
        {
            if (soapObject != null)
            {
                vBusinessTypeCode = soapObject.vBusinessTypeCode?.FirstOrDefault()?.ToString();
                vBusinessTypeName = soapObject.vBusinessTypeName?.FirstOrDefault()?.ToString();
                vStreetCode = soapObject.vStreetCode?.FirstOrDefault()?.ToString();
                vStreetName = soapObject.vStreetName?.FirstOrDefault()?.ToString();
                vVRTProvinceCode = soapObject.vVRTProvinceCode?.FirstOrDefault()?.ToString();
                vVRTProvinceName = soapObject.vVRTProvinceName?.FirstOrDefault()?.ToString();

                vAmphurCode = soapObject.vAmphurCode?.FirstOrDefault()?.ToString();
                vProvinceCode = soapObject.vProvinceCode?.FirstOrDefault()?.ToString();
                vDescription = soapObject.vDescription?.FirstOrDefault()?.ToString();
                vMessErr = soapObject.vMessErr?.FirstOrDefault()?.ToString();
            }
        }

        /// <summary>
        /// ถ้าต้องการเชื่อมต่อกับ VRTService ให้ส่ง "VRTCommonService"
        /// ถ้าต้องการเชื่อมต่อกับ VATService ให้ส่ง "VATCommonService"
        /// </summary>
        public string typeofservice { get; set; }

        #region VRTCommonService
        /// <summary>
        /// รหัสประเภทธุรกิจ (BusinessTypeCode)
        /// </summary>
        public string vBusinessTypeCode;

        /// <summary>
        /// ชื่อประเภทธุรกิจ (BusinessTypeName)
        /// </summary>
        public string vBusinessTypeName;
        
        /// <summary>
        /// รหัสถนน (StreetCode)
        /// </summary>
        public string vStreetCode;

        /// <summary>
        /// ชื่อถนน (StreetName)
        /// </summary>
        public string vStreetName;

        /// <summary>
        /// รหัสจังหวัด (ProvinceCode)
        /// </summary>
        public string vVRTProvinceCode;

        /// <summary>
        /// ชื่อจังหวัด (ProvinceName)
        /// </summary>
        public string vVRTProvinceName;

        #endregion

        #region VATCommonService
        /// <summary>
        /// รหัสอำเภอ (AmphurCode)
        /// </summary>
        public string vAmphurCode;

        /// <summary>
        /// รหัสจังหวัด (ProvinceCode)
        /// </summary>
        public string vProvinceCode;

        /// <summary>
        /// ชื่ออำเภอ / จังหวัด (Description)
        /// </summary>
        public string vDescription;
        #endregion
        /// <summary>
        /// Error Message
        /// </summary>
        public string vMessErr;

    }
}
