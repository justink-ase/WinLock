﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WinLock.CredentialDialog
{
	public interface ICredentialDialog
	{
		bool VerifyCredentials(String dialogTitle, String dialogText);
	}
}
