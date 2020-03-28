/**************文件说明**********************
与下位机的数据交换
********************************************/
namespace GroundStation
{
    partial class Form1
    {
        byte[] RxTemp = new byte[12];  //来自下位机的有效数据
        /***********************
        对从串口收到的数据进行预处理并将有效数据保存至RxTemp
        **********************/
        private void Protocol_Text_Receive()
        {
            byte RxData, RxState = 0, sum = 0, i = 0, FcnWord = 0, LenWord = 0;
            do
            {
                RxData = (byte)serialPort1.ReadByte();
                switch (RxState)
                {
                    case 0:
                        if (RxData == '>')
                        {
                            sum = RxData;
                            RxState = 1;
                        }
                        break;
                    case 1:
                        sum += RxData;
                        FcnWord = RxData;
                        RxState = 2;
                        break;
                    case 2:
                        if (RxState <= 12)
                        {
                            sum += RxData;
                            LenWord = RxData;
                            RxState = 3;
                        }
                        else
                        {
                            sum = 0;
                            RxState = 0;
                        }
                        break;
                    case 3:  //临时保存待用数据
                        sum += RxData;
                        RxTemp[i++] = RxData;
                        if (i >= LenWord)
                            RxState = 4;
                        break;
                    case 4:  //匹配校验和
                        RxState = 0;
                        i = 0;
                        if (sum == RxData)  //收到了正确的数据帧
                            Data_Receive_Precess(FcnWord);
                        else
                            lblCtrl.Text = "失控";
                        break;
                    default: break;
                }
                RxCount++;
            } while (serialPort1.BytesToRead > 0);
            labelRxCnt.Text = $"Rx:{RxCount}";
        }
        /***********************
        发送解锁帧
        **********************/
        private void XDAA_Send_Cmd(byte password)
        {
            byte sum = 0x3F;
            byte state;
            if ((GlobalStat & 0x40) == 0x40)  //解锁状态下发送锁定命令
                state = 0;
            else
                state = 0x01;
            CtrlByte[0] = 0x3C;
            CtrlByte[1] = 0x01;
            CtrlByte[2] = 0x02;
            CtrlByte[3] = state;
            CtrlByte[4] = password;
            sum += state;
            sum += password;
            CtrlByte[5] = sum;
            TxCount += 6;
        }
        private void XDAA_Send_RCdata()
        {
            byte sum = 0;
            int[] CtrlChannel = new int[4];
            CtrlChannel[0] = 100 - hScrollRol.Value;
            CtrlChannel[1] = 100 - vScrollPit.Value;
            CtrlChannel[2] = 100 - vScrollThr.Value;
            CtrlChannel[3] = 100 - hScrollYaw.Value;
            CtrlChannel[0] *= 10;
            CtrlChannel[1] *= 10;
            CtrlChannel[2] *= 10;
            CtrlChannel[3] *= 10;
            CtrlByte[0] = 0x3C;
            CtrlByte[1] = 0x08;
            CtrlByte[2] = 0x08;
            CtrlByte[3] = (byte)(CtrlChannel[0] / 256);
            CtrlByte[4] = (byte)(CtrlChannel[0] % 256);
            CtrlByte[5] = (byte)(CtrlChannel[1] / 256);
            CtrlByte[6] = (byte)(CtrlChannel[1] % 256);
            CtrlByte[7] = (byte)(CtrlChannel[2] / 256);
            CtrlByte[8] = (byte)(CtrlChannel[2] % 256);
            CtrlByte[9] = (byte)(CtrlChannel[3] / 256);
            CtrlByte[10] = (byte)(CtrlChannel[3] % 256);
            for (int i = 0; i < 11; i++)
                sum += CtrlByte[i];
            CtrlByte[11] = sum;
            TxCount += 12;
        }
        private void XDAA_Send_Param(int[] param,byte fcn)
        {
            byte sum = 0;
            CtrlByte[0] = 0x3C;
            CtrlByte[1] = fcn;
            CtrlByte[2] = 0x06;
            CtrlByte[3] = (byte)(param[0] / 256);
            CtrlByte[4] = (byte)(param[0] % 256);
            CtrlByte[5] = (byte)(param[1] / 256);
            CtrlByte[6] = (byte)(param[1] % 256);
            CtrlByte[7] = (byte)(param[2] / 256);
            CtrlByte[8] = (byte)(param[2] % 256);
            for (int i = 0; i < 9; i++)
                sum += CtrlByte[i];
            CtrlByte[9] = sum;
            TxCount += 10;
        }
        private void XDAA_Send_Req()
        {
            byte sum = 0xDD;
            CtrlByte[0] = 0x3C;
            CtrlByte[1] = 0xA0;
            CtrlByte[2] = 0x01;
            CtrlByte[3] = req;
            sum += req;
            CtrlByte[4] = sum;
            TxCount += 5;
        }
    }
}
