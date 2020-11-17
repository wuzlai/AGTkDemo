﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_v8handler_t.cs
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
	/// Structure that should be implemented to handle V8 function calls. The
	/// functions of this structure will be called on the thread associated with the
	/// V8 function.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefV8Handler : CefBaseRefCounted<cef_v8handler_t>, ICefV8HandlerPrivate
	{
		private static readonly ExecuteDelegate fnExecute = ExecuteImpl;

		internal static unsafe CefV8Handler Create(IntPtr instance)
		{
			return new CefV8Handler((cef_v8handler_t*)instance);
		}

		public CefV8Handler()
		{
			cef_v8handler_t* self = this.NativeInstance;
			self->execute = (void*)Marshal.GetFunctionPointerForDelegate(fnExecute);
		}

		public CefV8Handler(cef_v8handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefV8HandlerPrivate.AvoidExecute();

		/// <summary>
		/// Handle execution of the function identified by |name|. |object| is the
		/// receiver (&apos;this&apos; object) of the function. |arguments| is the list of
		/// arguments passed to the function. If execution succeeds set |retval| to the
		/// function return value. If execution fails set |exception| to the exception
		/// that will be thrown. Return true (1) if execution was handled.
		/// </summary>
		protected internal unsafe virtual bool Execute(string name, CefV8Value @object, CefV8Value[] arguments, ref CefV8Value retval, ref string exception)
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int ExecuteDelegate(cef_v8handler_t* self, cef_string_t* name, cef_v8value_t* @object, UIntPtr argumentsCount, cef_v8value_t** arguments, cef_v8value_t** retval, cef_string_t* exception);

		// int (*)(_cef_v8handler_t* self, const cef_string_t* name, _cef_v8value_t* object, size_t argumentsCount, const _cef_v8value_t** arguments, _cef_v8value_t** retval, cef_string_t* exception)*
		private static unsafe int ExecuteImpl(cef_v8handler_t* self, cef_string_t* name, cef_v8value_t* @object, UIntPtr argumentsCount, cef_v8value_t** arguments, cef_v8value_t** retval, cef_string_t* exception)
		{
			var instance = GetInstance((IntPtr)self) as CefV8Handler;
			if (instance == null || ((ICefV8HandlerPrivate)instance).AvoidExecute())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)@object);
				return default;
			}
			CefV8Value[] obj_arguments = new CefV8Value[(int)argumentsCount];
			for (int i = 0; i < obj_arguments.Length; i++)
			{
				var item = *(arguments + i);
				item->@base.AddRef();
				obj_arguments[i] = CefV8Value.Wrap(CefV8Value.Create, item);
			}
			CefV8Value obj_retval = CefV8Value.Wrap(CefV8Value.Create, *retval);
			string s_exception = CefString.Read(exception);
			string s_orig_exception = s_exception;
			int rv = instance.Execute(CefString.Read(name), CefV8Value.Wrap(CefV8Value.Create, @object), obj_arguments, ref obj_retval, ref s_exception) ? 1 : 0;
			*retval = (obj_retval != null) ? obj_retval.GetNativeInstance() : null;
			if (s_exception != s_orig_exception)
				CefString.Replace(exception, s_exception);
			return rv;
		}
	}
}
