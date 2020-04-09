using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
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
        public byte FcnWord = 0, LenWord = 0;
        private byte[] DataToSend = new byte[12];
        private byte RxState = 0, sum = 0, p = 0;
        /***********************
        对从串口收到的数据进行预处理并将有效数据保存至RxTemp
        **********************/
        public byte Byte_Receive(byte RxData)
        {
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
                    if (RxData <= 12)
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
                    DataReceived[p++] = RxData;
                    if (p >= LenWord)
                        RxState = 4;
                    else if (p >= 12)
                        RxState = 5;
                    break;
                case 4:  //匹配校验和
                    RxState = 0;
                    p = 0;
                    if (sum == RxData)  //收到了正确的数据帧
                        return 0;
                    else
                        return 2;
                default:
                    p = 0;
                    RxState = 0;
                    break;
            }
            return 1;
        }
        /***********************
        发送解锁帧
        **********************/
        public byte Send_Cmd(byte password, byte state, Action<byte[], int> SerialWrite)
        {
            byte sum = 0x3F;
            DataToSend[0] = 0x3C;
            DataToSend[1] = 0x01;
            DataToSend[2] = 0x02;
            DataToSend[3] = state;
            DataToSend[4] = password;
            sum += state;
            sum += password;
            DataToSend[5] = sum;
            SerialWrite(DataToSend, 6);
            return 6;
        }
        /***********************
        发送int16型数据
        **********************/
        public byte Send_S16_Data(int[] data, byte len, byte fcn, Action<byte[],  int> SerialWrite)
        {
            byte i, cnt = 0, checksum = 0;
            DataToSend[cnt++] = 0x3C;
            DataToSend[cnt++] = fcn;
            DataToSend[cnt++] = (byte)(len * 2);
            for (i = 0; i < len; i++)
            {
                DataToSend[cnt++] = (byte)(data[i] / 256);
                DataToSend[cnt++] = (byte)(data[i] % 256);
            }
            for (i = 0; i < cnt; i++)
                checksum += DataToSend[i];
            DataToSend[cnt++] = checksum;
            SerialWrite(DataToSend,  cnt);
            return cnt;
        }
        /***********************
        发送byte型数据
        **********************/
        public byte Send_U8_Data(byte[] data, byte len, byte fcn, Action<byte[],  int> SerialWrite)
        {
            byte i, cnt = 0, checksum = 0;
            DataToSend[cnt++] = 0x3C;
            DataToSend[cnt++] = fcn;
            DataToSend[cnt++] = len;
            for (i = 0; i < len; i++)
                DataToSend[cnt++] = data[i];
            for (i = 0; i < cnt; i++)
                checksum += DataToSend[i];
            DataToSend[cnt++] = checksum;
            SerialWrite(DataToSend,  cnt);
            return cnt;
        }
        /***********************
        发送req
        **********************/
        public byte Send_Req(byte req1,byte req2, Action<byte[], int> SerialWrite)
        {
            byte sum = 0xDE;  //3C+A0+02=DE
            DataToSend[0] = 0x3C;
            DataToSend[1] = 0xA0;
            DataToSend[2] = 0x02;
            DataToSend[3] = req1;
            DataToSend[4] = req2;
            sum += req1;
            sum += req2;
            DataToSend[5] = sum;
            SerialWrite(DataToSend,  6);
            return 6;
        }
    }
}
