namespace RevenueService.Api.Model
{
    /// <summary>
    /// Model ข้อมูลผู้ประกอบการ
    /// </summary>
    public class VRT
    {
        public VRT()
        {
            vShopName = "";
            vBusinessTypeCode = "0";
            vStreetCode = "0";
            vProvinceCode = "0";
        }

        /// <summary>
        /// ชื่อสถานประกอบการ (BusinessName)
        /// </summary>
        public string vBusinessName { get; set; }

        /// <summary>
        /// รหัสประเภทธุรกิจ (BusinessTypeCode)
        /// </summary>
        public string vBusinessTypeCode { get; set; }

        /// <summary>
        /// ชื่อประเภทธุรกิจ (BusinessTypeName)
        /// </summary>
        public string vBusinessTypeName { get; set; }

        /// <summary>
        /// ชื่อร้าน (ShopName)
        /// </summary>
        public string vShopName { get; set; }

        /// <summary>
        /// เลขที่ตั้งของสถานประกอบการ (HouseNumber)
        /// </summary>
        public string vHouseNumber { get; set; }

        /// <summary>
        /// รหัสถนน(StreetCode)
        /// </summary>
        public string vStreetCode { get; set; }

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
        /// รหัสจังหวัด (ProvinceCode)
        /// </summary>
        public string vProvinceCode { get; set; }

        /// <summary>
        /// จังหวัด (ProvinceName)
        /// </summary>
        public string vProvinceName { get; set; }

        /// <summary>
        /// รหัสไปรษณีย์ (PostCode)
        /// </summary>
        public string vPostCode { get; set; }

        /// <summary>
        /// Error Message
        /// </summary>
        public string vmsgerr { get; set; }

    }
}
