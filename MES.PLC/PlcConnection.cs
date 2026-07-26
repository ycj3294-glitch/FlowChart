using ACTETHERLib;

namespace MES.PLC
{
    public class PlcConnection
    {// plc 연결 클래스
        // plc 생성자
        private readonly PlcConfig _config;
        // 설비 객체(plc 라이브러리에 따라서 다름. 지금은 미쓰비시 mxcomponent)
        private readonly ACTETHERLib.ActAJ71E71TCP _plc = new ACTETHERLib.ActAJ71E71TCP();      

        public bool IsConnected { get; private set; }

        public PlcConnection(string plcName)
        {
            _config = PlcConfigs.Items
                .FirstOrDefault(x => x.Name == plcName)
                ?? throw new ArgumentException(
                    $"PLC 설정을 찾을 수 없습니다: {plcName}");
        }
       

        public bool Connect()
        {
            try
            {
                string ipAddress = _config.IpAddress;
                int port = _config.Port;

                

               
                // 실제 PLC 라이브러리 연결 코드
                //_plc = new PlcClient(ipAddress, port);
                //_plc.Connect();

                IsConnected = true;
                return true;
            }
            catch
            {
                IsConnected = false;
                return false;
            }
        }

        // Disconnect 메서드

        // plc 데이터 가져오기
    }
}
