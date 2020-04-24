namespace GroundStation
{
    struct GlobalStatus
    {
        public bool TextSave;  //控制器参数是否保存至文本框,否则保存至只读标签
        public bool CtrlLink;  //是否向下位机发送控制命令
        public bool inCtrl;  //下位机控制中
        public bool CtrlRcving;  //正在接收外部控制信号
        public bool ChartFirst;  //接收的是第一个数,初始化Y轴最大值和最小值
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
        public const byte rolStat = 0xA2;
        public const byte pitCtrl = 0xA3;
        public const byte pitStat = 0xA4;
        public const byte ctrlOut = 0xAA;
    }
}