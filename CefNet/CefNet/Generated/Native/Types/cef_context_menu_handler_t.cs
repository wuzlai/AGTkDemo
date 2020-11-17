﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_context_menu_handler_capi.h
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
	/// Implement this structure to handle context menu events. The functions of this
	/// structure will be called on the UI thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_context_menu_handler_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_context_menu_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_context_menu_params_t* params, _cef_menu_model_t* model)*
		/// </summary>
		public void* on_before_context_menu;

		/// <summary>
		/// Called before a context menu is displayed. |params| provides information
		/// about the context menu state. |model| initially contains the default
		/// context menu. The |model| can be cleared to show no context menu or
		/// modified to show a custom menu. Do not keep references to |params| or
		/// |model| outside of this callback.
		/// </summary>
		[NativeName("on_before_context_menu")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnBeforeContextMenu(cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* @params, cef_menu_model_t* model);

		/// <summary>
		/// int (*)(_cef_context_menu_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_context_menu_params_t* params, _cef_menu_model_t* model, _cef_run_context_menu_callback_t* callback)*
		/// </summary>
		public void* run_context_menu;

		/// <summary>
		/// Called to allow custom display of the context menu. |params| provides
		/// information about the context menu state. |model| contains the context menu
		/// model resulting from OnBeforeContextMenu. For custom display return true
		/// (1) and execute |callback| either synchronously or asynchronously with the
		/// selected command ID. For default display return false (0). Do not keep
		/// references to |params| or |model| outside of this callback.
		/// </summary>
		[NativeName("run_context_menu")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int RunContextMenu(cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* @params, cef_menu_model_t* model, cef_run_context_menu_callback_t* callback);

		/// <summary>
		/// int (*)(_cef_context_menu_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_context_menu_params_t* params, int command_id, cef_event_flags_t event_flags)*
		/// </summary>
		public void* on_context_menu_command;

		/// <summary>
		/// Called to execute a command selected from the context menu. Return true (1)
		/// if the command was handled or false (0) for the default implementation. See
		/// cef_menu_id_t for the command ids that have default implementations. All
		/// user-defined command ids should be between MENU_ID_USER_FIRST and
		/// MENU_ID_USER_LAST. |params| will have the same values as what was passed to
		/// on_before_context_menu(). Do not keep a reference to |params| outside of
		/// this callback.
		/// </summary>
		[NativeName("on_context_menu_command")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int OnContextMenuCommand(cef_browser_t* browser, cef_frame_t* frame, cef_context_menu_params_t* @params, int command_id, CefEventFlags event_flags);

		/// <summary>
		/// void (*)(_cef_context_menu_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame)*
		/// </summary>
		public void* on_context_menu_dismissed;

		/// <summary>
		/// Called when the context menu is dismissed irregardless of whether the menu
		/// was NULL or a command was selected.
		/// </summary>
		[NativeName("on_context_menu_dismissed")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnContextMenuDismissed(cef_browser_t* browser, cef_frame_t* frame);
	}
}

