﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_request_context_capi.h
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
	/// Callback structure for cef_request_context_t::ResolveHost.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_resolve_callback_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_resolve_callback_t* self, cef_errorcode_t result, cef_string_list_t resolved_ips)*
		/// </summary>
		public void* on_resolve_completed;

		/// <summary>
		/// Called on the UI thread after the ResolveHost request has completed.
		/// |result| will be the result code. |resolved_ips| will be the list of
		/// resolved IP addresses or NULL if the resolution failed.
		/// </summary>
		[NativeName("on_resolve_completed")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnResolveCompleted(CefErrorCode result, cef_string_list_t resolved_ips);
	}
}
