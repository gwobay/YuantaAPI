﻿using System;
using System.Runtime.InteropServices;
using YuantaShareStructList;

namespace OdrFutOrder
{
    //母結構(Input)
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ParentStruct_Out
    {
        public TByte4 abyRtnCode;
        public TByte50 abyRtnMessage;
        public uint uintCount;
    }
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ChildStruct_Out
    {
        public int intIdentify;		//識別碼
        public short shtReplyCode;	//委託結果代碼
        public TByte5 abyOrderNO;	//委託書編號
        public TYuantaDate struTradeDate;	//交易日期
        public TByte abyErrKind;	//錯誤種類
        public TByte3 abyErrNO;		//錯誤代號
        public TByte74 abyAdvisory;	//錯誤訊息

    }
}
