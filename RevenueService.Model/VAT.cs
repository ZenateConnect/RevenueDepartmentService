using System;
using System.Collections.Generic;
using System.Text;

namespace RevenueService.Model
{
    public class VAT
    {
        public VAT()
        {

        }

        public VAT(VATSoapService.vat soapVat)
        {

        }

        public string vNID { get; set; }
        public string vtin { get; set; }
        public string vtitleName { get; set; }
        public string vName { get; set; }
        public string vSurname { get; set; }
        public string vBranchTitleName { get; set; }
        public string vBranchName { get; set; }
        public string vBranchNumber { get; set; }
        public string vBuildingName { get; set; }
        public string vFloorNumber { get; set; }
        public string vVillageName { get; set; }
        public string vRoomNumber { get; set; }
        public string vHouseNumber { get; set; }
        public string vMooNumber { get; set; }
        public string vSoiName { get; set; }
        public string vStreetName { get; set; }
        public string vThambol { get; set; }
        public string vAmphur { get; set; }
        public string vProvince { get; set; }
        public string vPostCode { get; set; }
        public string vBusinessFirstDate { get; set; }
        public string vmsgerr { get; set; }
    }
}
