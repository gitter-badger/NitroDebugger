﻿//
//  Test.cs
//
//  Author:
//       Benito Palacios Sánchez <benito356@gmail.com>
//
//  Copyright (c) 2014 Benito Palacios Sánchez
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using NUnit.Framework;
using System;
using NitroDebugger.RSP;
using System.Net.Sockets;
using System.Net;

namespace UnitTests
{
	[TestFixture()]
	public class Test
	{
		private const int DefaultPort = 10101;

		[Test()]
		public void ConnectLocalhostDefaultPort()
		{
			TcpListener server = new TcpListener(IPAddress.Loopback, DefaultPort);
			server.Start();

			Assert.DoesNotThrow(() => new Session("localhost", DefaultPort));

			server.Stop();
		}
	}
}

