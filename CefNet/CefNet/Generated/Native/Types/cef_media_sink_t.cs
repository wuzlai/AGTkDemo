﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_media_router_capi.h
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
	/// Represents a sink to which media can be routed. Instances of this object are
	/// retrieved via cef_media_observer_t::OnSinks. The functions of this structure
	/// may be called on any browser process thread unless otherwise indicated.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_media_sink_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_media_sink_t* self)*
		/// </summary>
		public void* get_id;

		/// <summary>
		/// Returns the ID for this sink.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_id")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetId();

		/// <summary>
		/// int (*)(_cef_media_sink_t* self)*
		/// </summary>
		public void* is_valid;

		/// <summary>
		/// Returns true (1) if this sink is valid.
		/// </summary>
		[NativeName("is_valid")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsValid();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_media_sink_t* self)*
		/// </summary>
		public void* get_name;

		/// <summary>
		/// Returns the name of this sink.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_name")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetName();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_media_sink_t* self)*
		/// </summary>
		public void* get_description;

		/// <summary>
		/// Returns the description of this sink.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_description")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetDescription();

		/// <summary>
		/// cef_media_sink_icon_type_t (*)(_cef_media_sink_t* self)*
		/// </summary>
		public void* get_icon_type;

		/// <summary>
		/// Returns the icon type for this sink.
		/// </summary>
		[NativeName("get_icon_type")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern CefMediaSinkIconType GetIconType();

		/// <summary>
		/// void (*)(_cef_media_sink_t* self, _cef_media_sink_device_info_callback_t* callback)*
		/// </summary>
		public void* get_device_info;

		/// <summary>
		/// Asynchronously retrieves device info.
		/// </summary>
		[NativeName("get_device_info")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void GetDeviceInfo(cef_media_sink_device_info_callback_t* callback);

		/// <summary>
		/// int (*)(_cef_media_sink_t* self)*
		/// </summary>
		public void* is_cast_sink;

		/// <summary>
		/// Returns true (1) if this sink accepts content via Cast.
		/// </summary>
		[NativeName("is_cast_sink")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsCastSink();

		/// <summary>
		/// int (*)(_cef_media_sink_t* self)*
		/// </summary>
		public void* is_dial_sink;

		/// <summary>
		/// Returns true (1) if this sink accepts content via DIAL.
		/// </summary>
		[NativeName("is_dial_sink")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsDialSink();

		/// <summary>
		/// int (*)(_cef_media_sink_t* self, _cef_media_source_t* source)*
		/// </summary>
		public void* is_compatible_with;

		/// <summary>
		/// Returns true (1) if this sink is compatible with |source|.
		/// </summary>
		[NativeName("is_compatible_with")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsCompatibleWith(cef_media_source_t* source);
	}
}
