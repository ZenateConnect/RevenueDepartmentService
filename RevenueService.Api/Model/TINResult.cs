using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevenueService.Api.Model
{
    /// <summary>
    /// Model ของ TINSoapService
    /// </summary>
    public class TINResult
    {
        public TINResult()
        {

        }

        /// <summary>
        /// เลขประจำตัวฯ ที่นำเข้าเพื่อตรวจสอบ
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// ผลการตรวจสอบ ถูกต้อง หรือ ไม่ถูกต้อง
        /// </summary>
        public string DigitOk { get; set; }

        /// <summary>
        /// มี หรือ ไม่มี อยู่ในฐานข้อมูลกรมสรรพากร
        /// </summary>
        public string IsExist { get; set; }
        public string MessageErr { get; set; }

        public string vID { get; set; }
        public string vDigitOk { get; set; }
        public string vIsExist { get; set; }
        public string vMessageErr { get; set; }
    }
}
