#region Licence

// WifiCat - Wifi Cat Version Selector - Program.cs
// Created 14.06.2017 19:08
// 
// 
// Wifi Configuration Assist Tool
// Copyright (C) 2017 Bennet Becker <bennet@becker-dd.de>
// 
// This program is free software: you can redistribute it and/or modify 
// it under the terms of the GNU Affero General Public License as published by 
// the Free Software Foundation, either version 3 of the License, or 
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, 
// but WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the 
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License 
// along with this program. If not, see <http://www.gnu.org/licenses/>.

#endregion

#region Using

using System;
using System.Windows.Forms;

#endregion

namespace Wifi_Cat_Version_Selector
{
    static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}