﻿/*

CapSavvy, a program to track bandwidth usage for customers of TekSavvy and their resellers
Copyright (C) 2014 Adam Zey, Darryl Tam

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

*/

using System;
using System.Text.RegularExpressions;
using CapSavvy.Data;

namespace CapSavvy.Modules
{
    public class mod_ebox_bus_dsl : mod_ebox_res_dsl
    {
        public mod_ebox_bus_dsl(UsageData usageData) : base(usageData) { } // Call base constructor

        public override string moduleName
        {
            get { return "Electronicbox Business DSL"; }
        }

        public override string validUsernameRegex
        {
            get { return @"^[a-z0-9_\-\.]{3,}@ebox-business\.com$"; }
        }

        public override bool supportsOffPeak
        {
            get { return true; }
        }
    }
}
