﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_jsdialog_handler_t.cs
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

namespace CefNet.Internal
{
	sealed partial class CefJSDialogHandlerGlue: CefJSDialogHandler, ICefJSDialogHandlerPrivate
	{
		private WebViewGlue _implementation;

		public CefJSDialogHandlerGlue(WebViewGlue impl)
		{
			_implementation = impl;
		}

		bool ICefJSDialogHandlerPrivate.AvoidOnJSDialog()
		{
			return _implementation.AvoidOnJSDialog();
		}

		protected internal unsafe override bool OnJSDialog(CefBrowser browser, string originUrl, CefJSDialogType dialogType, string messageText, string defaultPromptText, CefJSDialogCallback callback, ref int suppressMessage)
		{
			return _implementation.OnJSDialog(browser, originUrl, dialogType, messageText, defaultPromptText, callback, ref suppressMessage);
		}

		bool ICefJSDialogHandlerPrivate.AvoidOnBeforeUnloadDialog()
		{
			return _implementation.AvoidOnBeforeUnloadDialog();
		}

		protected internal unsafe override bool OnBeforeUnloadDialog(CefBrowser browser, string messageText, bool isReload, CefJSDialogCallback callback)
		{
			return _implementation.OnBeforeUnloadDialog(browser, messageText, isReload, callback);
		}

		bool ICefJSDialogHandlerPrivate.AvoidOnResetDialogState()
		{
			return _implementation.AvoidOnResetDialogState();
		}

		protected internal unsafe override void OnResetDialogState(CefBrowser browser)
		{
			_implementation.OnResetDialogState(browser);
		}

		bool ICefJSDialogHandlerPrivate.AvoidOnDialogClosed()
		{
			return _implementation.AvoidOnDialogClosed();
		}

		protected internal unsafe override void OnDialogClosed(CefBrowser browser)
		{
			_implementation.OnDialogClosed(browser);
		}

	}
}