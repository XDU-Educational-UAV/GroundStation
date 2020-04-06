using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroundStation
{
    struct GlobalStatus
    {
        public bool LockCmdOn;  //是否发送请求解锁或锁定命令
        public bool SendModeChange;  //是否发送请求更改飞行模式命令
        public bool isUnlock;  //下位机是否解锁
        public bool TextSave;  //控制器参数是否保存至文本框,否则保存至只读标签
        public bool CtrlLink;  //是否向下位机发送控制命令
        public bool inCtrl;  //控制中
        public bool SendEn;  //允许发送状态数据
    }
    struct FunctionByte
    {
        public const byte stat=0x01;
        public const byte atti=0x02;
        public const byte sensor=0x04;
        public const byte rc=0x08;
        public const byte motor=0x10;
        public const byte rolCtrl=0xA1;
        public const byte rolStat=0xA2;
        public const byte pitCtrl=0xA3;
        public const byte pitStat=0xA4;
    }
}