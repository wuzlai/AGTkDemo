﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_navigation_entry_visitor_t.cs
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;
using CefNet.CApi;
using CefNet.Internal;

namespace CefNet
{
	/// <summary>
	/// Callback structure for cef_browser_host_t::GetNavigationEntries. The
	/// functions of this structure will be called on the browser process UI thread.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefNavigationEntryVisitor : CefBaseRefCounted<cef_navigation_entry_visitor_t>, ICefNavigationEntryVisitorPrivate
	{
		private static readonly VisitDelegate fnVisit = VisitImpl;

		internal static unsafe CefNavigationEntryVisitor Create(IntPtr instance)
		{
			return new CefNavigationEntryVisitor((cef_navigation_entry_visitor_t*)instance);
		}

		public CefNavigationEntryVisitor()
		{
			cef_navigation_entry_visitor_t* self = this.NativeInstance;
			self->visit = (void*)Marshal.GetFunctionPointerForDelegate(fnVisit);
		}

		public CefNavigationEntryVisitor(cef_navigation_entry_visitor_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefNavigationEntryVisitorPrivate.AvoidVisit();

		/// <summary>
		/// Method that will be executed. Do not keep a reference to |entry| outside of
		/// this callback. Return true (1) to continue visiting entries or false (0) to
		/// stop. |current| is true (1) if this entry is the currently loaded
		/// navigation entry. |index| is the 0-based index of this entry and |total| is
		/// the total number of entries.
		/// </summary>
		protected internal unsafe virtual bool Visit(CefNavigationEntry entry, bool current, int index, int total)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int VisitDelegate(cef_navigation_entry_visitor_t* self, cef_navigation_entry_t* entry, int current, int index, int total);

		// int (*)(_cef_navigation_entry_visitor_t* self, _cef_navigation_entry_t* entry, int current, int index, int total)*
		private static unsafe int VisitImpl(cef_navigation_entry_visitor_t* self, cef_navigation_entry_t* entry, int current, int index, int total)
		{
			var instance = GetInstance((IntPtr)self) as CefNavigationEntryVisitor;
			if (instance == null || ((ICefNavigationEntryVisitorPrivate)instance).AvoidVisit())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)entry);
				return default;
			}
			return instance.Visit(CefNavigationEntry.Wrap(CefNavigationEntry.Create, entry), current != 0, index, total) ? 1 : 0;
		}
	}
}