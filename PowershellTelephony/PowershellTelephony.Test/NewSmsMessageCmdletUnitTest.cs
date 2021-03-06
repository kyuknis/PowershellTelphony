﻿/* 
 * Powershell Telephony Library
 * Copyright(C) 2017  Yuknis Corp
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.If not, see<http://www.gnu.org/licenses/>.
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PowershellTelephony;

namespace PowershellTelephony.Test
{
    [TestClass]
    public class NewSmsMessageCmdletUnitTest
    {
        [TestMethod]
        public void SendSmsMessage()
        {
            string TestTwilioAccountSid = @"";
            string TestTwilioAuthToken = @"";
            string Recepient = @"";
            string Sender = @"";
            string Body = String.Format("Test on {0}", DateTime.Now);

            NewSmsMessageCmdlet Cmdlet = new NewSmsMessageCmdlet();
            Cmdlet.CreateTwilioClient(TestTwilioAccountSid, TestTwilioAuthToken);
            Cmdlet.SendSmsMessage(Recepient, Sender, Body);
        }
    }
}
