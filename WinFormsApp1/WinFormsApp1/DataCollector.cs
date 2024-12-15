namespace WinFormsDataCollector
{
    public partial class DataCollector : Form
    {
        MaterialInformation Material = new MaterialInformation();
        public DataCollector()
        {

            InitializeComponent();
            SetDefaultText(Material);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void shipToText_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            ButtonCLick();

            lblHelloWorld.Text = "Data written successfully!";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        void ButtonCLick()
        {
           
            DBConnection DBPrint = new DBConnection();
            UpdateMaterialInformation();
            DBPrint.WriteToDB(Material);
            Material.PrintAll();
            
        }

        private void UpdateMaterialInformation()
        {
            Material.VShipFrom = txtShipFrom.Text;
            Material.VShipTo = txtShipTo.Text;
            Material.VDescription = txtDescription.Text;
            Material.VPartNumber = txtPartNumber.Text;
            Material.VLotNo = txtLotNo.Text;
            Material.VLicensePlate = txtLicensePlate.Text;
            Material.VHeat = txtHeat.Text;
            Material.VSuplier = txtSuplier.Text;
            Material.VRev = txtRev.Text;
            Material.VPoNo = txtPoNo.Text;
            Material.VPlant = txtPlant.Text;
            Material.VQuantity = txtQuantity.Text;
            Material.VSerialNumber = txtSerialNumber.Text;
            Material.VSuplierCode = txtSuplierCode.Text;
            Material.VMfgDate = txtMfgDate.Text;
        }
        private void SetDefaultText(MaterialInformation Label1)
        {


            txtShipFrom.Text = Label1.VShipFrom;
            txtShipTo.Text = Label1.VShipTo;
            txtDescription.Text = Label1.VDescription;
            txtPartNumber.Text = Label1.VPartNumber;
            txtLotNo.Text = Label1.VLotNo;
            txtLicensePlate.Text = Label1.VLicensePlate;
            txtHeat.Text = Label1.VHeat;
            txtSuplier.Text = Label1.VSuplier;
            txtRev.Text = Label1.VRev;
            txtPoNo.Text = Label1.VPoNo;
            txtPlant.Text = Label1.VPlant;
            txtQuantity.Text = Label1.VQuantity;
            txtSerialNumber.Text = Label1.VSerialNumber;
            txtSuplierCode.Text = Label1.VSuplierCode;

            txtMfgDate.Text = Label1.VMfgDate;

        }


    }
}
