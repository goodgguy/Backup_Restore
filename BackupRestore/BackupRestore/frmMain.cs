using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupRestore
{
    public partial class frmMain : Form
    {
        private String devicename="";
        private String database="";
        private String bansaoluu;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tempdbDataSet.backup_devices' table. You can move, or remove it, as needed.
            //this.backup_devicesTableAdapter.Fill(this.tempdbDataSet.backup_devices);
            // TODO: This line of code loads data into the 'tempdbDataSet.databases' table. You can move, or remove it, as needed.
            this.databasesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.databasesTableAdapter.Fill(this.tempdbDataSet.databases);
            this.backup_devicesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.backup_devicesTableAdapter.Fill(this.tempdbDataSet.backup_devices);

            this.sP_STT_BACKUPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_STT_BACKUPTableAdapter.Fill(this.tempdbDataSet.SP_STT_BACKUP, ((DataRowView)databasesBindingSource[databasesBindingSource.Position])["name"].ToString());

            barCreateDevice.Enabled = false;
            barBackUp.Enabled = false;
            groupBox2.Visible = false;
        }

        private void databasesGridControl_Click(object sender, EventArgs e)
        {
            //            DataTable dt = (DataTable)this.backup_devicesBindingSource.DataSource;
            //            for (int i = 0; i < dt.Rows.Count; i++)
            //            {
            //
            //            }
            String databasename = ((DataRowView)databasesBindingSource[databasesBindingSource.Position])["name"].ToString();
            String device = "DEVICE_";
            String sum = String.Concat(device,databasename);
            this.devicename = sum;
            this.database = databasename;
            for(int i=0;i<backup_devicesBindingSource.Count;i++)
            {
                if(sum.CompareTo(((DataRowView)backup_devicesBindingSource[i])["name"].ToString())==0)
                {
                    barCreateDevice.Enabled = false;
                    barBackUp.Enabled = true;
                    UpdateDataGridViewBackUp();
                    return;
                }
            }
            barCreateDevice.Enabled = true;
            barBackUp.Enabled = false;
            UpdateDataGridViewBackUp();
        }

        private void barExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.conn.Close();
            Close();
        }

        private void databasesGridControl_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void barCreateDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String strfullPathDivice = Program.strDefaultPath +"/"+Program.servername+ "/" + devicename + ".bak";
            Directory.CreateDirectory(Program.strDefaultPath + "/" + Program.servername);
            String query = "DECLARE @result int "+
                "EXEC @result= sp_addumpdevice 'disk',@p1,@p2 "+
                "SELECT 'result'=@result";
            SqlCommand sqlCommand = new SqlCommand(query, Program.conn);
            sqlCommand.Parameters.AddWithValue("@p1", this.devicename);
            sqlCommand.Parameters.AddWithValue("@p2", strfullPathDivice);
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi thực thi database!\n" + ex.Message, "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            if(result==1)
            {
                MessageBox.Show("Tạo Divice thất bại", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Tạo Divice thành công", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
            barCreateDevice.Enabled = false;
            barBackUp.Enabled = true;
            UpdateDataDeviceTable();
        }

        private void barBackUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String getquery = "";
            String backup = "BACKUP DATABASE @p1 TO @p2 ";
            String backup_INIT = "BACKUP DATABASE @p1 TO @p2 WITH INIT";
            if (cbXoasaoluu.Checked == true)
            {
                getquery = backup_INIT;
            }
            else
            {
                getquery = backup;
            }
            if (Program.conn == null && Program.conn.State != ConnectionState.Open) Program.conn.Open();
            SqlCommand sqlCommand = new SqlCommand(getquery, Program.conn);
            sqlCommand.Parameters.AddWithValue("@p1", this.database);
            sqlCommand.Parameters.AddWithValue("@p2",this.devicename);
            SqlDataReader dr = null;
            try
            {
                dr = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi database!\n" + ex.Message, "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dr.Close();
            cbXoasaoluu.Checked = false;
            UpdateDataGridViewBackUp();
        }
        private void UpdateDataGridViewBackUp()
        {
            this.sP_STT_BACKUPTableAdapter.Fill(this.tempdbDataSet.SP_STT_BACKUP, database);
        }
        private void UpdateDataDeviceTable()
        {
            this.backup_devicesTableAdapter.Fill(this.tempdbDataSet.backup_devices);
        }

        private void barRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(this.sP_STT_BACKUPBindingSource.Count == 0)
            {
                MessageBox.Show("Không có bản sao lưu nào", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Error);return;
            }
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            String strRestore ="ALTER DATABASE " + database + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +"\n"+
                "USE tempdb ";
            if(barCheckRestore.Checked==false)
            {
                strRestore += "RESTORE DATABASE " + database + " FROM " + devicename + " WITH FILE= " + bansaoluu + ", REPLACE  " +
                    "ALTER DATABASE " + database + " SET MULTI_USER ";
                int err=Program.ExecSqlNonQuery(strRestore, Program.connstr);
                if(err==1)
                {
                    MessageBox.Show("Restore thất bại", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Restore thành công", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else
            {                
                DateTime ThoiDiemStop = datePickerDay.Value.Date + datePickerTime.Value.TimeOfDay;
                String strThoiDiemStop = datePickerDay.Value.ToString("yyyy-MM-dd")+" "+datePickerTime.Value.ToString("HH:mm:ss");
                //MessageBox.Show(strThoiDiemStop, "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                String logPath = Program.strDefaultPath +"/"+Program.servername+ "/" + database + ".trn";
                String logDatabase = Program.strDefaultPath +"/"+Program.servername+ "/" + devicename + ".bak";
                strRestore += "\n" + "BACKUP LOG " + database + " TO DISK =" + "'" + logPath + "'" + " WITH INIT"
                    + "\n" + " RESTORE DATABASE " + database + " FROM DISK = '" + logDatabase + "' WITH NORECOVERY,REPLACE"
                    + "\n" + " RESTORE DATABASE " + database + " FROM DISK = '" + logPath + "' WITH STOPAT='"+strThoiDiemStop+"'"
                    + "\n" + " ALTER DATABASE " + database + " SET MULTI_USER";
                //MessageBox.Show(strRestore, "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 DateTime ngaygioBU = (DateTime)((DataRowView)sP_STT_BACKUPBindingSource[sP_STT_BACKUPBindingSource.Position])["backup_start_date"];
                 if ((ThoiDiemStop.Date < ngaygioBU.Date) ||
                      (ThoiDiemStop.Date == ngaygioBU.Date && ThoiDiemStop.Date.Ticks < ngaygioBU.TimeOfDay.Ticks))
                 {
                     MessageBox.Show("THỜI ĐIỂM PHỤC HỒI PHẢI SAU THỜI ĐIỂM BẢN SAO LƯU ĐÃ CHỌN", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return;
                 }
                 if (ThoiDiemStop > DateTime.Now)
                 {
                     MessageBox.Show("THỜI ĐIỂM PHỤC HỒI PHẢI TRƯỚC THỜI ĐIỂM HIÊN TẠI", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return;
                 }
                 int err = Program.ExecSqlNonQuery(strRestore, Program.connstr);
                 if (err == 1)
                 {
                     MessageBox.Show("Restore thất bại", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return;
                 }
                 else
                 {
                     MessageBox.Show("Restore thành công", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }








                /* DateTime ngaygioBU = (DateTime)((DataRowView)sP_STT_BACKUPBindingSource[sP_STT_BACKUPBindingSource.Position])["backup_start_date"];
                 string strThoiDiemStopAt = dateStop.DateTime.Day + "/" + dateStop.DateTime.Month + "/" + dateStop.DateTime.Year + " " +
                     timeStop.Time.Hour + ":" + timeStop.Time.Minute + ":" + timeStop.Time.Second;
                 MessageBox.Show(strThoiDiemStopAt, "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 DateTime ThoiDiemStopAt;
                 ThoiDiemStopAt = DateTime.ParseExact(strThoiDiemStopAt,"dd//MM/yyyy hh:mm:ssss",null);          
                 if ((dateStop.DateTime.Date<ngaygioBU.Date)||
                     (dateStop.DateTime.Date == ngaygioBU.Date && ThoiDiemStopAt.TimeOfDay.Ticks<ngaygioBU.TimeOfDay.Ticks))
                 {
                     MessageBox.Show("THỜI ĐIỂM PHỤC HỒI PHẢI SAU THỜI ĐIỂM BẢN SAO LƯU ĐÃ CHỌN", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return;
                 }
                 if(ThoiDiemStopAt>DateTime.Now)
                 {
                     MessageBox.Show("THỜI ĐIỂM PHỤC HỒI PHẢI TRƯỚC THỜI ĐIỂM HIÊN TẠI", "Nofication", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return;
                 }*/

            }
        }

        private void sP_STT_BACKUPGridControl_Click(object sender, EventArgs e)
        {
            if(this.sP_STT_BACKUPBindingSource.Count!=0)
            {
                bansaoluu=((DataRowView)sP_STT_BACKUPBindingSource[sP_STT_BACKUPBindingSource.Position])["position"].ToString();
            }
        }

        private void barCheckRestore_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(barCheckRestore.Checked==true)
            {
                groupBox2.Visible = true;
            }else
            {
                groupBox2.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbXoasaoluu_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
