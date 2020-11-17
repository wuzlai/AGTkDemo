﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_stream_capi.h
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
	/// Structure used to read data from a stream. The functions of this structure
	/// may be called on any thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_stream_reader_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// size_t (*)(_cef_stream_reader_t* self, void* ptr, size_t size, size_t n)*
		/// </summary>
		public void* read;

		/// <summary>
		/// Read raw binary data.
		/// </summary>
		[NativeName("read")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern UIntPtr Read(void* ptr, UIntPtr size, UIntPtr n);

		/// <summary>
		/// int (*)(_cef_stream_reader_t* self, int64 offset, int whence)*
		/// </summary>
		public void* seek;

		/// <summary>
		/// Seek to the specified offset position. |whence| may be any one of SEEK_CUR,
		/// SEEK_END or SEEK_SET. Returns zero on success and non-zero on failure.
		/// </summary>
		[NativeName("seek")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int Seek(long offset, int whence);

		/// <summary>
		/// int64 (*)(_cef_stream_reader_t* self)*
		/// </summary>
		public void* tell;

		/// <summary>
		/// Return the current offset position.
		/// </summary>
		[NativeName("tell")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern long Tell();

		/// <summary>
		/// int (*)(_cef_stream_reader_t* self)*
		/// </summary>
		public void* eof;

		/// <summary>
		/// Return non-zero if at end of file.
		/// </summary>
		[NativeName("eof")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int Eof();

		/// <summary>
		/// int (*)(_cef_stream_reader_t* self)*
		/// </summary>
		public void* may_block;

		/// <summary>
		/// Returns true (1) if this reader performs work like accessing the file
		/// system which may block. Used as a hint for determining the thread to access
		/// the reader from.
		/// </summary>
		[NativeName("may_block")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int MayBlock();
	}
}

