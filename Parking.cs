using ParkingApp.BLL;
using ParkingApp.EntityClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ParkingApp
{
    public partial class Parking : Form
    {
        List<Vehicle> vehList = new List<Vehicle>();
        BusinessLogic objBAL = new BusinessLogic();
        int typeId = 0;
        string tableName = "";
        public Parking()
        {
            InitializeComponent();
        }

        private void Parking_Load(object sender, EventArgs e)
        {
            bindVehicleType();
            lblCountPark.Visible = false;
        }

        void bindVehicleType()
        {
            try
            {
                DataTable dtVeh = new DataTable();
                dtVeh = objBAL.getVehicleType();
                ddlType.DataSource = dtVeh;
                ddlType.DisplayMember = "Name";
                ddlType.ValueMember = "Id";
            }
            catch
            {
                //MessageBox.Show("Exception : ");
            }
        }

        void checkParking(string s)
        {
            try
            {
                lblCountPark.Visible = false;
                DataTable dtPark = new DataTable();
                dtPark = objBAL.getPakingSlot(s);
                int count = dtPark.Rows.Count;
                if(count>0)
                    lblCountPark.Visible = true;
                lblCount.Text = count.ToString();
                if(count==0)
                {
                    if(typeId>4)
                    {
                        MessageBox.Show("Sorry, No parking available at this time.");
                        return;
                    }
                    MessageBox.Show("Selected type parking is not available, we are searching for you another available parking.");
                    typeId++;
                    ddlType.SelectedIndex = typeId;
                    //string str = GetProperParking(typeId);
                    //checkParking(str);
                }
                else
                {
                    ddlParking.DataSource = dtPark;
                    ddlParking.ValueMember = "Id";
                    ddlParking.DisplayMember = "SlotNo";
                }
            }
            catch
            {
                //MessageBox.Show("Exception : ");
            }
        }

        private void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = ddlType.Text.Trim();
            typeId = ddlType.SelectedIndex;

            if(type!="Select" && type != "System.Data.DataRowView")
            {
                string str = GetProperParking(typeId);
                checkParking(str);
            }
        }

        string GetProperParking(int type)
        {
            string ParkingType="";
            switch(type)
            {
                case 1:
                    ParkingType = "ParkingSmall";
                    break;

                case 2:
                    ParkingType = "ParkingMedium";
                    break;

                case 3:
                    ParkingType = "ParkingLarge";
                    break;
            }
            tableName = ParkingType;
            return ParkingType;
        }

        private void btnPark_Click(object sender, EventArgs e)
        {
            if(ddlType.SelectedIndex<1)
            {
                MessageBox.Show("Please select the vehicle type.");
                return;
            }
            if(txtVehicleNo.Text.Trim().Length<1)
            {
                MessageBox.Show("Please enter vehicle number.");
                return;
            }

            DateTime currTime = new DateTime();
            currTime = DateTime.Now;
            string updateQry = "Update " + tableName + " Set IsAvailable=0, VehicleNo='" + txtVehicleNo.Text.Trim() + "', EntryTime=GetDate() where SlotNo='" + ddlParking.Text.Trim() + "'";
            string parkQuery = "Insert into ParkingHistory(VehicleNo, ParkingSlot, EntryTime)Values('" + txtVehicleNo.Text.Trim() + "','" + ddlParking.Text.Trim() + "',GetDate());" + updateQry;
            bool status = objBAL.SaveDetail(parkQuery);
            if (status)
            {
                MessageBox.Show("Parked Successfully.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(ddlType.Text=="Select")
            {
                ParkingHistory parkingDetail = new ParkingHistory();
                if(txtVehicleNo.Text.Trim().Length>0)
                {
                    parkingDetail = objBAL.GetVehicleDetail(txtVehicleNo.Text.Trim());
                    if (parkingDetail.ParkingSlot != null)
                    {
                        string type = parkingDetail.ParkingSlot.Substring(0, 1);
                        if (type == "S")
                            typeId = 1;
                        if (type == "M")
                            typeId = 2;
                        if (type == "L")
                            typeId = 3;

                        GetProperParking(typeId);
                        string updateQry = "Update ParkingHistory Set ExitTime=GETDATE()  where VehicleNo='"+ parkingDetail.VehicleNo+ "' and Id='"+ parkingDetail.Id+ "'";
                        string exitParkQuery = "Update " + tableName + " Set ExitTime=GETDATE(), IsAvailable=1 where VehicleNo='" + parkingDetail.VehicleNo + "' and SlotNo='"+ parkingDetail.ParkingSlot+ "';" + updateQry;
                        bool status = objBAL.SaveDetail(exitParkQuery);
                        if (status)
                        {
                            MessageBox.Show("Thank you for visiting.");
                            txtVehicleNo.Clear();
                        }
                    }
                    else
                        MessageBox.Show("This vehicle does not exist, Please provide the valid vehicle number.");
                }
                else
                    MessageBox.Show("Please provide the vehicle number.");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
