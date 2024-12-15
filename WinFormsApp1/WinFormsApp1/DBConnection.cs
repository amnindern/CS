using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WinFormsDataCollector
{
    internal class DBConnection
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=.\\ExcelFile.xls;" +
                "Extended Properties='Excel 8.0;HDR=YES;'";

        //OleDbConnection conn = new OleDbConnection();
        public DBConnection()
        {





        }

        public void WriteToDB(MaterialInformation material)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                //Step to Retrieve max ID

                int maxId = 0;
                string selectMaxIdQuery = "SELECT MAX(ID) FROM [Sheet1$]";

                using (OleDbCommand selectCommand = new OleDbCommand(selectMaxIdQuery, connection))
                {
                    var result = selectCommand.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        maxId = Convert.ToInt32(result);
                    }
                }

                int newId = maxId + 1;
                // Define the SQL command to insert data
                string insertCommand = $"INSERT INTO [Sheet1$] (ID, ShipFrom, ShipTo, Description, PartNumber, LicensePlate, Heat, LotNo, SuplierCode, Rev, PoNo, Plant, Quantity, SerialNumber, Suplier, MfgDate)" +
                    $" VALUES ({newId}, \"{material.VShipFrom}\", \"{material.VShipTo}\", \"{material.VDescription}\", \"{material.VPartNumber}\", \"{material.VLicensePlate}\", \"{material.VHeat}\",\"{material.VLotNo}\",\"{material.VSuplierCode}\", \"{material.VRev}\", \"{material.VPoNo}\", \"{material.VPlant}\", \"{material.VQuantity}\", \"{material.VSerialNumber}\",\"{material.VSuplier}\",\"{material.VMfgDate}\")";
                // Execute the command
                using (OleDbCommand command = new OleDbCommand(insertCommand, connection))
                {
                    command.ExecuteNonQuery();
                    System.Diagnostics.Debug.WriteLine("Data written successfully!");
                }

            }
        }
    }
}
