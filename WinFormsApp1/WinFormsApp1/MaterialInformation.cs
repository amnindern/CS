using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDataCollector
{

    internal class MaterialInformation
    {
        public string VShipFrom { get; set; } = $@"MTech Ltd 
100 Howden Rd.
Toronto, ON M1R 3E4";

        public string VShipTo { get; set; } = $@"M.S.M
280 Aviva Park Drive
Woodbridge, ON L4L 9C7";

        

        public string VDescription { get; set; } = "SPROCKET";
        public string VPartNumber { get; set; } = "S708.03";
        public string VLicensePlate { get; set; } = "IJ2482627480000306";
        public string VHeat { get; set; } = "79007429";
        public string VLotNo { get; set; } = "6884";
        public string VSuplierCode { get; set; } = "208662";
        public string VRev { get; set; } = "08";
        public string VPoNo { get; set; } = "5400006062";
        public string VPlant { get; set; } = "C302";
        public string VQuantity { get; set; } = "0";
        public string VSerialNumber { get; set; } = "";
        public string VSuplier { get; set; } = "400-1475";
        public string VMfgDate { get; set; } = DateTime.Today.ToString("d");
        
        public void AddMaterialDB()
        {

        }
        public void PrintAll()
        {
            System.Diagnostics.Debug.WriteLine(this.VShipFrom);
            System.Diagnostics.Debug.WriteLine(this.VShipTo);
            System.Diagnostics.Debug.WriteLine(this.VDescription);
            System.Diagnostics.Debug.WriteLine(this.VPartNumber);
            System.Diagnostics.Debug.WriteLine(this.VLicensePlate);
            System.Diagnostics.Debug.WriteLine(this.VHeat);
            System.Diagnostics.Debug.WriteLine(this.VLotNo);
            System.Diagnostics.Debug.WriteLine(this.VSuplierCode);
            System.Diagnostics.Debug.WriteLine(this.VRev);
            System.Diagnostics.Debug.WriteLine(this.VPoNo);
            System.Diagnostics.Debug.WriteLine(this.VQuantity);
            System.Diagnostics.Debug.WriteLine(this.VPlant);
            System.Diagnostics.Debug.WriteLine(this.VSerialNumber);
            System.Diagnostics.Debug.WriteLine(this.VSuplier);
            System.Diagnostics.Debug.WriteLine(this.VMfgDate);
           
        }
    }
}
