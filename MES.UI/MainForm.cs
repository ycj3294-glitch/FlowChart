using DevExpress.Pdf;
using DevExpress.XtraBars;
using MES.DATA.Oracle;
using MES.PLC;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MES.UI
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();           

            var manager = new OracleConnectionManager();
            

            //using (var conn = manager.CreateConnection())
            //{
            //    //MessageBox.Show(OracleConfig.ConnectionString);
            //    conn.Open();
            //    MessageBox.Show("Oracle 연결 성공");
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateDbStatus();

            UpdatePlcStatus("Dosing", DosingPlcStatus);
            UpdatePlcStatus("Mixing", MixingPlcStatus);
            
        }
        

        // DB 연결 상태 업데이트
        private void UpdateDbStatus()
        {
            try
            {
                var manager = new OracleConnectionManager();
                
                using (var conn = manager.CreateConnection())
                {
                    conn.Open();
                    DbStatus.Caption = "DB : 연결됨";
                    DbStatus.Appearance.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                DbStatus.Caption = "DB : 연결 안됨";
                DbStatus.Appearance.ForeColor = Color.Red;
                MessageBox.Show(ex.Message);
            }
        }

        // PLC 연결 상태 업데이트
        private void UpdatePlcStatus(string plcName, BarStaticItem status)
        {
            var plcConnection = new PlcConnection(plcName);

            if (plcConnection.Connect())
            {
                status.Caption = $"{plcName} PLC : 연결됨";
                status.Appearance.ForeColor = Color.Green;
            }
            else
            {
                status.Caption = $"{plcName} PLC : 연결 안됨";
                status.Appearance.ForeColor = Color.Red;
            }
        }
    }
    // 중복창 검사
    // 자식창 표시

}
