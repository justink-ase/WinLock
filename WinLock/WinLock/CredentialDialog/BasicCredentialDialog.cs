﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WinLock.CredentialDialog
{
	class BasicCredentialDialog : ICredentialDialog
	{
		public NetworkCredential GetNetworkCredentials(string server, string dialogTitle, string dialogText)
		{
			throw new NotImplementedException();
		}
	}
}