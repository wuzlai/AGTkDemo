﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/internal/cef_types.h
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;

namespace CefNet
{
	/// <summary>
	/// Error codes for CDM registration. See cef_web_plugin.h for details.
	/// </summary>
	public enum CefCDMRegistrationError
	{
		/// <summary>
		/// No error. Registration completed successfully.
		/// </summary>
		None = 0,

		/// <summary>
		/// Required files or manifest contents are missing.
		/// </summary>
		IncorrectContents = 1,

		/// <summary>
		/// The CDM is incompatible with the current Chromium version.
		/// </summary>
		Incompatible = 2,

		/// <summary>
		/// CDM registration is not supported at this time.
		/// </summary>
		NotSupported = 3,
	}
}
