﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_cookie_visitor_t.cs
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
	/// Structure to implement for visiting cookie values. The functions of this
	/// structure will always be called on the UI thread.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefCookieVisitor : CefBaseRefCounted<cef_cookie_visitor_t>, ICefCookieVisitorPrivate
	{
		private static readonly VisitDelegate fnVisit = VisitImpl;

		internal static unsafe CefCookieVisitor Create(IntPtr instance)
		{
			return new CefCookieVisitor((cef_cookie_visitor_t*)instance);
		}

		public CefCookieVisitor()
		{
			cef_cookie_visitor_t* self = this.NativeInstance;
			self->visit = (void*)Marshal.GetFunctionPointerForDelegate(fnVisit);
		}

		public CefCookieVisitor(cef_cookie_visitor_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefCookieVisitorPrivate.AvoidVisit();

		/// <summary>
		/// Method that will be called once for each cookie. |count| is the 0-based
		/// index for the current cookie. |total| is the total number of cookies. Set
		/// |deleteCookie| to true (1) to delete the cookie currently being visited.
		/// Return false (0) to stop visiting cookies. This function may never be
		/// called if no cookies are found.
		/// </summary>
		protected internal unsafe virtual bool Visit(CefCookie cookie, int count, int total, ref int deleteCookie)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int VisitDelegate(cef_cookie_visitor_t* self, cef_cookie_t* cookie, int count, int total, int* deleteCookie);

		// int (*)(_cef_cookie_visitor_t* self, const const _cef_cookie_t* cookie, int count, int total, int* deleteCookie)*
		private static unsafe int VisitImpl(cef_cookie_visitor_t* self, cef_cookie_t* cookie, int count, int total, int* deleteCookie)
		{
			var instance = GetInstance((IntPtr)self) as CefCookieVisitor;
			if (instance == null || ((ICefCookieVisitorPrivate)instance).AvoidVisit())
			{
				return default;
			}
			return instance.Visit(*(CefCookie*)cookie, count, total, ref *deleteCookie) ? 1 : 0;
		}
	}
}
