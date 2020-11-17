﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_resource_handler_capi.h
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
	/// Callback for asynchronous continuation of cef_resource_handler_t::read().
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_resource_read_callback_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_resource_read_callback_t* self, int bytes_read)*
		/// </summary>
		public void* cont;

		/// <summary>
		/// Callback for asynchronous continuation of read(). If |bytes_read| == 0 the
		/// response will be considered complete. If |bytes_read| &gt; 0 then read() will
		/// be called again until the request is complete (based on either the result
		/// or the expected content length). If |bytes_read| 
		/// &lt;
		/// 0 then the request will
		/// fail and the |bytes_read| value will be treated as the error code.
		/// </summary>
		[NativeName("cont")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Continue(int bytes_read);
	}
}

