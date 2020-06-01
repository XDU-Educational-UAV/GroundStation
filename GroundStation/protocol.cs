using System;
/**************文件说明**********************
与下位机的数据交换
Byte_Receive
Send_Cmd
Send_S16_Data
Send_U8_Data
Send_Req
********************************************/

namespace GroundStation
{
    class Protocol
    {
        public byte[] DataReceived = new byte[12];  //来自下位机的有效数据
        public byte FcnByte = 0;
        private byte LenByte = 0;
        private readonly byte[] DataToSend = new byte[12];
        private byte RxState = 0, CheckSum = 0, cnt = 0;
        /*对从串口收到的数据进行预处理并将有效数据保存至RxTemp*/
        /*返回值:0,收到完整的数据帧;1,数据帧未接收完成;2,接收数据帧出错*/
        public byte Byte_Receive(byte RxData)
        {
            switch (RxState)
            {
                case 0:  //帧头校验
                    if (RxData == '>')
                    {
                        CheckSum = RxData;
                        RxState = 1;
                    }
                    else if (RxData == '@')
                    {
                        FcnByte = CheckSum = RxData;
                        RxState = 0x11;
                    }
                    else
                        return 2;  //数据帧出错
                    break;
                case 1:  //功能字校验与保存
                    CheckSum += RxData;
                    FcnByte = RxData;
                    RxState = 2;
                    break;
                case 2:  //数据长度校验与保存
                    if (RxData <= 12)
                    {
                        CheckSum += RxData;
                        LenByte = RxData;
                        RxState = 3;
                    }
                    else
                    {
                        CheckSum = 0;
                        RxState = 0;
                        return 2;  //数据帧出错
                    }
                    break;
                case 3:  //临时保存待用数据
                    CheckSum += RxData;
                    DataReceived[cnt++] = RxData;
                    if (cnt >= LenByte)
                        RxState = 0x0A;
                    break;
                case 0x11:  //临时保存待用数据
                    CheckSum += RxData;
                    DataReceived[cnt++] = RxData;
                    if (cnt >= 4)
                        RxState = 0x0A;
                    break;
                case 0x0A:
                    RxState = 0;
                    cnt = 0;
                    if (CheckSum == RxData)
                        return 0;  //收到了正确的数据帧
                    else
                        return 2;  //数据帧出错
                default:
                    cnt = 0;
                    RxState = 0;
                    return 2;  //数据帧出错
            }
            return 1;  //数据帧尚未接收完成
        }
        /***********************
        发送解锁帧
        **********************/
        public byte Send_Cmd(byte state, Action<byte[], int> SerialWrite)
        {
            byte sum = 0x3E;
            DataToSend[0] = 0x3C;
            DataToSend[1] = 0x01;
            DataToSend[2] = 0x01;
            DataToSend[3] = state;
            sum += state;
            DataToSend[4] = sum;
            SerialWrite(DataToSend, 5);
            return 5;
        }
        /***********************
        发送int16型数据
        **********************/
        public byte Send_S16_Data(int[] data, byte len, byte fcn, Action<byte[], int> SerialWrite)
        {
            byte i, cnt = 0, sum = 0;
            DataToSend[cnt++] = 0x3C;
            DataToSend[cnt++] = fcn;
            DataToSend[cnt++] = (byte)(len * 2);
            for (i = 0; i < len; i++)
            {
                DataToSend[cnt++] = (byte)(data[i] / 256);
                DataToSend[cnt++] = (byte)(data[i] % 256);
            }
            for (i = 0; i < cnt; i++)
                sum += DataToSend[i];
            DataToSend[cnt++] = sum;
            SerialWrite(DataToSend, cnt);
            return cnt;
        }
        /***********************
        发送byte型数据
        **********************/
        public byte Send_U8_Data(byte[] data, byte len, byte fcn, Action<byte[], int> SerialWrite)
        {
            byte i, cnt = 0, sum = 0;
            DataToSend[cnt++] = 0x3C;
            DataToSend[cnt++] = fcn;
            DataToSend[cnt++] = len;
            for (i = 0; i < len; i++)
                DataToSend[cnt++] = data[i];
            for (i = 0; i < cnt; i++)
                sum += DataToSend[i];
            DataToSend[cnt++] = sum;
            SerialWrite(DataToSend, cnt);
            return cnt;
        }
        /***********************
        发送req
        **********************/
        public byte Send_Req(byte fcn, byte req, Action<byte[], int> SerialWrite)
        {
            byte sum = 0x3D;  //3C+01
            DataToSend[0] = 0x3C;
            DataToSend[1] = fcn;
            DataToSend[2] = 0x01;
            DataToSend[3] = req;
            sum += fcn;
            sum += req;
            DataToSend[4] = sum;
            SerialWrite(DataToSend, 5);
            return 5;
        }
    }
}
