using Avalonia.Media;
using CefNet;
using CefNet.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AGTkDemo
{
	internal sealed class CustomWebViewGlue : AvaloniaWebViewGlue
	{
		private const int SHOW_DEV_TOOLS = (int)CefMenuId.UserFirst + 0;
		private const int INSPECT_ELEMENT = (int)CefMenuId.UserFirst + 1;

		public CustomWebViewGlue(CustomWebView view)
			: base(view)
		{

		}

		private new CustomWebView WebView
		{
			get { return (CustomWebView)base.WebView; }
		}

		protected override bool OnSetFocus(CefBrowser browser, CefFocusSource source)
		{
			if (source == CefFocusSource.Navigation)
				return true;
			return false;
		}

		protected override void OnBeforeContextMenu(CefBrowser browser, CefFrame frame, CefContextMenuParams menuParams, CefMenuModel model)
		{
			//处理 鼠标右键的快捷键
			model.Clear();
			model.AddItem((int)CefMenuId.Copy, "复制");
			//model.AddItem((int)CefMenuId.ViewSource, AppResource.查看源);
			


			
		}

		protected override bool OnContextMenuCommand(CefBrowser browser, CefFrame frame, CefContextMenuParams menuParams, int commandId, CefEventFlags eventFlags)
		{
			if (commandId >= (int)CefMenuId.UserFirst && commandId <= (int)CefMenuId.UserLast)
			{
				switch (commandId)
				{
					case SHOW_DEV_TOOLS:
						((CustomWebView)WebView).ShowDevTools();
						break;
					case INSPECT_ELEMENT:
						((CustomWebView)WebView).ShowDevTools(new CefPoint(menuParams.XCoord, menuParams.YCoord));
						break;
				}
				return true;
			}
			return false; ;
		}

		protected override void OnFullscreenModeChange(CefBrowser browser, bool fullscreen)
		{
			WebView.RaiseFullscreenModeChange(fullscreen);
		}

		protected override bool OnConsoleMessage(CefBrowser browser, CefLogSeverity level, string message, string source, int line)
		{
			Debug.Print("[{0}]: {1} ({2}, line: {3})", level, message, source, line);
			return false;
		}
	}
}
