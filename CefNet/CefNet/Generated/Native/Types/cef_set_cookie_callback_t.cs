﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_cookie_capi.h
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;

namespace CefNet.CApi
{
	/// <summary>
	/// Structure to implement to be notified of asynchronous completion via
	/// cef_cookie_manager_t::set_cookie().
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_set_cookie_callback_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_set_cookie_callback_t* self, int success)*
		/// </summary>
		public void* on_complete;

		/// <summary>
		/// Method that will be called upon completion. |success| will be true (1) if
		/// the cookie was set successfully.
		/// </summary>
		[NativeName("on_complete")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnComplete(int success);
	}
}
