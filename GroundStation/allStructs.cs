namespace GroundStation
{
    struct GlobalStatus
    {
        public bool RmCtrl;      //是否向下位机发送控制命令
        public bool inCtrl;      //下位机控制中
        public bool CtrlRcving;  //正在接收外部控制信号
    }
    struct FuncByte
    {
        public const byte stat = 0x01;
        public const byte atti = 0x02;
        public const byte sensor = 0x04;
        public const byte rc = 0x08;
        public const byte motor = 0x10;
        public const byte quaternion = 0x20;
        public const byte rolCtrl = 0xA1;
        public const byte pitCtrl = 0xA2;
        public const byte yawCtrl = 0xA3;
        public const byte ctrlOut = 0xAA;
        public const byte chart1 = 0xB1;
        public const byte chart2 = 0xB2;
        public const byte highspeed = 0x40;
    }
}