//
//  GdbClient.cs
//
//  Author:
//       Benito Palacios <benito356@gmail.com>
//
//  Copyright (c) 2014 Benito Palacios
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;

namespace NitroDebugger.RSP
{
	/// <summary>
	/// GDB Client. Direct connection to emulator.
	/// Application layer, only packets supported by DeSmuME implemented.
	/// </summary>
	public class GdbClient
	{
		private Presentation presentation;

		public GdbClient(string hostname, int port)
		{
			this.presentation = new Presentation(hostname, port);
		}

		public void Close()
		{
			this.presentation.Close();
		}

		public StopSignal GetHaltedReason()
		{
			throw new NotImplementedException();
		}

		public StopSignal Stop()
		{
			throw new NotImplementedException();
		}

		public void Continue()
		{
			throw new NotImplementedException();
		}

		public string Test()
		{
			throw new NotImplementedException();
		}

		public StopSignal NextStep()
		{
			throw new NotImplementedException();
		}

		private StopSignal ParseStopResponse(string response)
		{
			if (response.Length == 3 && response[0] == 'S') {
				int signal = Convert.ToInt32(response.Substring(1, 2));
				return ((TargetSignals)signal).ToStopSignal();
			} else {
				throw new FormatException("Unexpected response");
			}
		}
	}
}

