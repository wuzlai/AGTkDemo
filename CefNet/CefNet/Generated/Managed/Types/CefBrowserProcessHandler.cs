﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_browser_process_handler_t.cs
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
	/// Structure used to implement browser process callbacks. The functions of this
	/// structure will be called on the browser process main thread unless otherwise
	/// indicated.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefBrowserProcessHandler : CefBaseRefCounted<cef_browser_process_handler_t>, ICefBrowserProcessHandlerPrivate
	{
		private static readonly OnContextInitializedDelegate fnOnContextInitialized = OnContextInitializedImpl;

		private static readonly OnBeforeChildProcessLaunchDelegate fnOnBeforeChildProcessLaunch = OnBeforeChildProcessLaunchImpl;

		private static readonly OnRenderProcessThreadCreatedDelegate fnOnRenderProcessThreadCreated = OnRenderProcessThreadCreatedImpl;

		private static readonly GetPrintHandlerDelegate fnGetPrintHandler = GetPrintHandlerImpl;

		private static readonly OnScheduleMessagePumpWorkDelegate fnOnScheduleMessagePumpWork = OnScheduleMessagePumpWorkImpl;

		internal static unsafe CefBrowserProcessHandler Create(IntPtr instance)
		{
			return new CefBrowserProcessHandler((cef_browser_process_handler_t*)instance);
		}

		public CefBrowserProcessHandler()
		{
			cef_browser_process_handler_t* self = this.NativeInstance;
			self->on_context_initialized = (void*)Marshal.GetFunctionPointerForDelegate(fnOnContextInitialized);
			self->on_before_child_process_launch = (void*)Marshal.GetFunctionPointerForDelegate(fnOnBeforeChildProcessLaunch);
			self->on_render_process_thread_created = (void*)Marshal.GetFunctionPointerForDelegate(fnOnRenderProcessThreadCreated);
			self->get_print_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetPrintHandler);
			self->on_schedule_message_pump_work = (void*)Marshal.GetFunctionPointerForDelegate(fnOnScheduleMessagePumpWork);
		}

		public CefBrowserProcessHandler(cef_browser_process_handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Called on the browser process UI thread immediately after the CEF context
		/// has been initialized.
		/// </summary>
		protected internal unsafe virtual void OnContextInitialized()
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnContextInitializedDelegate(cef_browser_process_handler_t* self);

		// void (*)(_cef_browser_process_handler_t* self)*
		private static unsafe void OnContextInitializedImpl(cef_browser_process_handler_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefBrowserProcessHandler;
			if (instance == null)
			{
				return;
			}
			instance.OnContextInitialized();
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefBrowserProcessHandlerPrivate.AvoidOnBeforeChildProcessLaunch();

		/// <summary>
		/// Called before a child process is launched. Will be called on the browser
		/// process UI thread when launching a render process and on the browser
		/// process IO thread when launching a GPU or plugin process. Provides an
		/// opportunity to modify the child process command line. Do not keep a
		/// reference to |command_line| outside of this function.
		/// </summary>
		protected internal unsafe virtual void OnBeforeChildProcessLaunch(CefCommandLine commandLine)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnBeforeChildProcessLaunchDelegate(cef_browser_process_handler_t* self, cef_command_line_t* command_line);

		// void (*)(_cef_browser_process_handler_t* self, _cef_command_line_t* command_line)*
		private static unsafe void OnBeforeChildProcessLaunchImpl(cef_browser_process_handler_t* self, cef_command_line_t* command_line)
		{
			var instance = GetInstance((IntPtr)self) as CefBrowserProcessHandler;
			if (instance == null || ((ICefBrowserProcessHandlerPrivate)instance).AvoidOnBeforeChildProcessLaunch())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)command_line);
				return;
			}
			instance.OnBeforeChildProcessLaunch(CefCommandLine.Wrap(CefCommandLine.Create, command_line));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefBrowserProcessHandlerPrivate.AvoidOnRenderProcessThreadCreated();

		/// <summary>
		/// Called on the browser process IO thread after the main thread has been
		/// created for a new render process. Provides an opportunity to specify extra
		/// information that will be passed to
		/// cef_render_process_handler_t::on_render_thread_created() in the render
		/// process. Do not keep a reference to |extra_info| outside of this function.
		/// </summary>
		protected internal unsafe virtual void OnRenderProcessThreadCreated(CefListValue extraInfo)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnRenderProcessThreadCreatedDelegate(cef_browser_process_handler_t* self, cef_list_value_t* extra_info);

		// void (*)(_cef_browser_process_handler_t* self, _cef_list_value_t* extra_info)*
		private static unsafe void OnRenderProcessThreadCreatedImpl(cef_browser_process_handler_t* self, cef_list_value_t* extra_info)
		{
			var instance = GetInstance((IntPtr)self) as CefBrowserProcessHandler;
			if (instance == null || ((ICefBrowserProcessHandlerPrivate)instance).AvoidOnRenderProcessThreadCreated())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)extra_info);
				return;
			}
			instance.OnRenderProcessThreadCreated(CefListValue.Wrap(CefListValue.Create, extra_info));
		}

		/// <summary>
		/// Return the handler for printing on Linux. If a print handler is not
		/// provided then printing will not be supported on the Linux platform.
		/// </summary>
		protected internal unsafe virtual CefPrintHandler GetPrintHandler()
		{
			return default;
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_print_handler_t* GetPrintHandlerDelegate(cef_browser_process_handler_t* self);

		// _cef_print_handler_t* (*)(_cef_browser_process_handler_t* self)*
		private static unsafe cef_print_handler_t* GetPrintHandlerImpl(cef_browser_process_handler_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefBrowserProcessHandler;
			if (instance == null)
			{
				return default;
			}
			CefPrintHandler rv = instance.GetPrintHandler();
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefBrowserProcessHandlerPrivate.AvoidOnScheduleMessagePumpWork();

		/// <summary>
		/// Called from any thread when work has been scheduled for the browser process
		/// main (UI) thread. This callback is used in combination with CefSettings.
		/// external_message_pump and cef_do_message_loop_work() in cases where the CEF
		/// message loop must be integrated into an existing application message loop
		/// (see additional comments and warnings on CefDoMessageLoopWork). This
		/// callback should schedule a cef_do_message_loop_work() call to happen on the
		/// main (UI) thread. |delay_ms| is the requested delay in milliseconds. If
		/// |delay_ms| is
		/// &lt;
		/// = 0 then the call should happen reasonably soon. If
		/// |delay_ms| is &gt; 0 then the call should be scheduled to happen after the
		/// specified delay and any currently pending scheduled call should be
		/// cancelled.
		/// </summary>
		protected internal unsafe virtual void OnScheduleMessagePumpWork(long delayMs)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnScheduleMessagePumpWorkDelegate(cef_browser_process_handler_t* self, long delay_ms);

		// void (*)(_cef_browser_process_handler_t* self, int64 delay_ms)*
		private static unsafe void OnScheduleMessagePumpWorkImpl(cef_browser_process_handler_t* self, long delay_ms)
		{
			var instance = GetInstance((IntPtr)self) as CefBrowserProcessHandler;
			if (instance == null || ((ICefBrowserProcessHandlerPrivate)instance).AvoidOnScheduleMessagePumpWork())
			{
				return;
			}
			instance.OnScheduleMessagePumpWork(delay_ms);
		}
	}
}
