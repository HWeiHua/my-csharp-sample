﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


using A5300_UDP_P2P.Message;


namespace A5300_UDP_P2P.MessageCoding
{

    /// <summary>
    /// 登出应答消息编码.
    /// 
    /// 因为是空消息体， 所以简单定义类即可.
    /// </summary>
    public class LogoutRespondCoding : AbstractMessageCoding<LogoutRespond>
    {

    }

}
