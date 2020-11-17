﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_request_context_t.cs
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
	/// A request context provides request handling for a set of related browser or
	/// URL request objects. A request context can be specified when creating a new
	/// browser via the cef_browser_host_t static factory functions or when creating
	/// a new URL request via the cef_urlrequest_t static factory functions. Browser
	/// objects with different request contexts will never be hosted in the same
	/// render process. Browser objects with the same request context may or may not
	/// be hosted in the same render process depending on the process model. Browser
	/// objects created indirectly via the JavaScript window.open function or
	/// targeted links will share the same render process and the same request
	/// context as the source browser. When running in single-process mode there is
	/// only a single render process (the main process) and so all browsers created
	/// in single-process mode will share the same request context. This will be the
	/// first request context passed into a cef_browser_host_t static factory
	/// function and all other request context objects will be ignored.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefRequestContext : CefBaseRefCounted<cef_request_context_t>
	{
		internal static unsafe CefRequestContext Create(IntPtr instance)
		{
			return new CefRequestContext((cef_request_context_t*)instance);
		}

		public CefRequestContext(cef_request_context_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Gets a value indicating whether this object is the global context. The global context
		/// is used by default when creating a browser or URL request with a NULL
		/// context argument.
		/// </summary>
		public unsafe virtual bool IsGlobal
		{
			get
			{
				return SafeCall(NativeInstance->IsGlobal() != 0);
			}
		}

		/// <summary>
		/// Gets the handler for this context if any.
		/// </summary>
		public unsafe virtual CefRequestContextHandler Handler
		{
			get
			{
				return SafeCall(CefRequestContextHandler.Wrap(CefRequestContextHandler.Create, NativeInstance->GetHandler()));
			}
		}

		/// <summary>
		/// Gets the cache path for this object. If NULL an &quot;incognito mode&quot; in-
		/// memory cache is being used.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string CachePath
		{
			get
			{
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetCachePath()));
			}
		}

		/// <summary>
		/// Gets the MediaRouter object associated with this context.
		/// </summary>
		public unsafe virtual CefMediaRouter MediaRouter
		{
			get
			{
				return SafeCall(CefMediaRouter.Wrap(CefMediaRouter.Create, NativeInstance->GetMediaRouter()));
			}
		}

		/// <summary>
		/// Returns true (1) if this object is pointing to the same context as |that|
		/// object.
		/// </summary>
		public unsafe virtual bool IsSame(CefRequestContext other)
		{
			return SafeCall(NativeInstance->IsSame((other != null) ? other.GetNativeInstance() : null) != 0);
		}

		/// <summary>
		/// Returns true (1) if this object is sharing the same storage as |that|
		/// object.
		/// </summary>
		public unsafe virtual bool IsSharingWith(CefRequestContext other)
		{
			return SafeCall(NativeInstance->IsSharingWith((other != null) ? other.GetNativeInstance() : null) != 0);
		}

		/// <summary>
		/// Returns the cookie manager for this object. If |callback| is non-NULL it
		/// will be executed asnychronously on the IO thread after the manager&apos;s
		/// storage has been initialized.
		/// </summary>
		public unsafe virtual CefCookieManager GetCookieManager(CefCompletionCallback callback)
		{
			return SafeCall(CefCookieManager.Wrap(CefCookieManager.Create, NativeInstance->GetCookieManager((callback != null) ? callback.GetNativeInstance() : null)));
		}

		/// <summary>
		/// Register a scheme handler factory for the specified |scheme_name| and
		/// optional |domain_name|. An NULL |domain_name| value for a standard scheme
		/// will cause the factory to match all domain names. The |domain_name| value
		/// will be ignored for non-standard schemes. If |scheme_name| is a built-in
		/// scheme and no handler is returned by |factory| then the built-in scheme
		/// handler factory will be called. If |scheme_name| is a custom scheme then
		/// you must also implement the cef_app_t::on_register_custom_schemes()
		/// function in all processes. This function may be called multiple times to
		/// change or remove the factory that matches the specified |scheme_name| and
		/// optional |domain_name|. Returns false (0) if an error occurs. This function
		/// may be called on any thread in the browser process.
		/// </summary>
		public unsafe virtual bool RegisterSchemeHandlerFactory(string schemeName, string domainName, CefSchemeHandlerFactory factory)
		{
			fixed (char* s0 = schemeName)
			fixed (char* s1 = domainName)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = schemeName != null ? schemeName.Length : 0 };
				var cstr1 = new cef_string_t { Str = s1, Length = domainName != null ? domainName.Length : 0 };
				return SafeCall(NativeInstance->RegisterSchemeHandlerFactory(&cstr0, &cstr1, (factory != null) ? factory.GetNativeInstance() : null) != 0);
			}
		}

		/// <summary>
		/// Clear all registered scheme handler factories. Returns false (0) on error.
		/// This function may be called on any thread in the browser process.
		/// </summary>
		public unsafe virtual bool ClearSchemeHandlerFactories()
		{
			return SafeCall(NativeInstance->ClearSchemeHandlerFactories() != 0);
		}

		/// <summary>
		/// Tells all renderer processes associated with this context to throw away
		/// their plugin list cache. If |reload_pages| is true (1) they will also
		/// reload all pages with plugins.
		/// cef_request_context_handler_t::OnBeforePluginLoad may be called to rebuild
		/// the plugin list cache.
		/// </summary>
		public unsafe virtual void PurgePluginListCache(bool reloadPages)
		{
			NativeInstance->PurgePluginListCache(reloadPages ? 1 : 0);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Returns true (1) if a preference with the specified |name| exists. This
		/// function must be called on the browser process UI thread.
		/// </summary>
		public unsafe virtual bool HasPreference(string name)
		{
			fixed (char* s0 = name)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = name != null ? name.Length : 0 };
				return SafeCall(NativeInstance->HasPreference(&cstr0) != 0);
			}
		}

		/// <summary>
		/// Returns the value for the preference with the specified |name|. Returns
		/// NULL if the preference does not exist. The returned object contains a copy
		/// of the underlying preference value and modifications to the returned object
		/// will not modify the underlying preference value. This function must be
		/// called on the browser process UI thread.
		/// </summary>
		public unsafe virtual CefValue GetPreference(string name)
		{
			fixed (char* s0 = name)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = name != null ? name.Length : 0 };
				return SafeCall(CefValue.Wrap(CefValue.Create, NativeInstance->GetPreference(&cstr0)));
			}
		}

		/// <summary>
		/// Returns all preferences as a dictionary. If |include_defaults| is true (1)
		/// then preferences currently at their default value will be included. The
		/// returned object contains a copy of the underlying preference values and
		/// modifications to the returned object will not modify the underlying
		/// preference values. This function must be called on the browser process UI
		/// thread.
		/// </summary>
		public unsafe virtual CefDictionaryValue GetAllPreferences(bool includeDefaults)
		{
			return SafeCall(CefDictionaryValue.Wrap(CefDictionaryValue.Create, NativeInstance->GetAllPreferences(includeDefaults ? 1 : 0)));
		}

		/// <summary>
		/// Returns true (1) if the preference with the specified |name| can be
		/// modified using SetPreference. As one example preferences set via the
		/// command-line usually cannot be modified. This function must be called on
		/// the browser process UI thread.
		/// </summary>
		public unsafe virtual bool CanSetPreference(string name)
		{
			fixed (char* s0 = name)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = name != null ? name.Length : 0 };
				return SafeCall(NativeInstance->CanSetPreference(&cstr0) != 0);
			}
		}

		/// <summary>
		/// Set the |value| associated with preference |name|. Returns true (1) if the
		/// value is set successfully and false (0) otherwise. If |value| is NULL the
		/// preference will be restored to its default value. If setting the preference
		/// fails then |error| will be populated with a detailed description of the
		/// problem. This function must be called on the browser process UI thread.
		/// </summary>
		public unsafe virtual bool SetPreference(string name, CefValue value, ref string error)
		{
			fixed (char* s0 = name)
			fixed (char* s2 = error)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = name != null ? name.Length : 0 };
				var cstr2 = new cef_string_t { Str = s2, Length = error != null ? error.Length : 0 };
				var rv = NativeInstance->SetPreference(&cstr0, (value != null) ? value.GetNativeInstance() : null, &cstr2) != 0;
				error = CefString.ReadAndFree(&cstr2);
				GC.KeepAlive(this);
				return rv;
			}
		}

		/// <summary>
		/// Clears all certificate exceptions that were added as part of handling
		/// cef_request_handler_t::on_certificate_error(). If you call this it is
		/// recommended that you also call close_all_connections() or you risk not
		/// being prompted again for server certificates if you reconnect quickly. If
		/// |callback| is non-NULL it will be executed on the UI thread after
		/// completion.
		/// </summary>
		public unsafe virtual void ClearCertificateExceptions(CefCompletionCallback callback)
		{
			NativeInstance->ClearCertificateExceptions((callback != null) ? callback.GetNativeInstance() : null);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Clears all HTTP authentication credentials that were added as part of
		/// handling GetAuthCredentials. If |callback| is non-NULL it will be executed
		/// on the UI thread after completion.
		/// </summary>
		public unsafe virtual void ClearHttpAuthCredentials(CefCompletionCallback callback)
		{
			NativeInstance->ClearHttpAuthCredentials((callback != null) ? callback.GetNativeInstance() : null);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Clears all active and idle connections that Chromium currently has. This is
		/// only recommended if you have released all other CEF objects but don&apos;t yet
		/// want to call cef_shutdown(). If |callback| is non-NULL it will be executed
		/// on the UI thread after completion.
		/// </summary>
		public unsafe virtual void CloseAllConnections(CefCompletionCallback callback)
		{
			NativeInstance->CloseAllConnections((callback != null) ? callback.GetNativeInstance() : null);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Attempts to resolve |origin| to a list of associated IP addresses.
		/// |callback| will be executed on the UI thread after completion.
		/// </summary>
		public unsafe virtual void ResolveHost(string origin, CefResolveCallback callback)
		{
			fixed (char* s0 = origin)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = origin != null ? origin.Length : 0 };
				NativeInstance->ResolveHost(&cstr0, (callback != null) ? callback.GetNativeInstance() : null);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Load an extension.
		/// If extension resources will be read from disk using the default load
		/// implementation then |root_directory| should be the absolute path to the
		/// extension resources directory and |manifest| should be NULL. If extension
		/// resources will be provided by the client (e.g. via cef_request_handler_t
		/// and/or cef_extension_handler_t) then |root_directory| should be a path
		/// component unique to the extension (if not absolute this will be internally
		/// prefixed with the PK_DIR_RESOURCES path) and |manifest| should contain the
		/// contents that would otherwise be read from the &quot;manifest.json&quot; file on
		/// disk.
		/// The loaded extension will be accessible in all contexts sharing the same
		/// storage (HasExtension returns true (1)). However, only the context on which
		/// this function was called is considered the loader (DidLoadExtension returns
		/// true (1)) and only the loader will receive cef_request_context_handler_t
		/// callbacks for the extension.
		/// cef_extension_handler_t::OnExtensionLoaded will be called on load success
		/// or cef_extension_handler_t::OnExtensionLoadFailed will be called on load
		/// failure.
		/// If the extension specifies a background script via the &quot;background&quot;
		/// manifest key then cef_extension_handler_t::OnBeforeBackgroundBrowser will
		/// be called to create the background browser. See that function for
		/// additional information about background scripts.
		/// For visible extension views the client application should evaluate the
		/// manifest to determine the correct extension URL to load and then pass that
		/// URL to the cef_browser_host_t::CreateBrowser* function after the extension
		/// has loaded. For example, the client can look for the &quot;browser_action&quot;
		/// manifest key as documented at
		/// https://developer.chrome.com/extensions/browserAction. Extension URLs take
		/// the form &quot;chrome-extension://
		/// &lt;extension
		/// _id&gt;/
		/// &lt;path
		/// &gt;&quot;.
		/// Browsers that host extensions differ from normal browsers as follows:
		/// - Can access chrome.* JavaScript APIs if allowed by the manifest. Visit
		/// chrome://extensions-support for the list of extension APIs currently
		/// supported by CEF.
		/// - Main frame navigation to non-extension content is blocked.
		/// - Pinch-zooming is disabled.
		/// - CefBrowserHost::GetExtension returns the hosted extension.
		/// - CefBrowserHost::IsBackgroundHost returns true for background hosts.
		/// See https://developer.chrome.com/extensions for extension implementation
		/// and usage documentation.
		/// </summary>
		public unsafe virtual void LoadExtension(string rootDirectory, CefDictionaryValue manifest, CefExtensionHandler handler)
		{
			fixed (char* s0 = rootDirectory)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = rootDirectory != null ? rootDirectory.Length : 0 };
				NativeInstance->LoadExtension(&cstr0, (manifest != null) ? manifest.GetNativeInstance() : null, (handler != null) ? handler.GetNativeInstance() : null);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Returns true (1) if this context was used to load the extension identified
		/// by |extension_id|. Other contexts sharing the same storage will also have
		/// access to the extension (see HasExtension). This function must be called on
		/// the browser process UI thread.
		/// </summary>
		public unsafe virtual bool DidLoadExtension(string extensionId)
		{
			fixed (char* s0 = extensionId)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = extensionId != null ? extensionId.Length : 0 };
				return SafeCall(NativeInstance->DidLoadExtension(&cstr0) != 0);
			}
		}

		/// <summary>
		/// Returns true (1) if this context has access to the extension identified by
		/// |extension_id|. This may not be the context that was used to load the
		/// extension (see DidLoadExtension). This function must be called on the
		/// browser process UI thread.
		/// </summary>
		public unsafe virtual bool HasExtension(string extensionId)
		{
			fixed (char* s0 = extensionId)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = extensionId != null ? extensionId.Length : 0 };
				return SafeCall(NativeInstance->HasExtension(&cstr0) != 0);
			}
		}

		/// <summary>
		/// Retrieve the list of all extensions that this context has access to (see
		/// HasExtension). |extension_ids| will be populated with the list of extension
		/// ID values. Returns true (1) on success. This function must be called on the
		/// browser process UI thread.
		/// </summary>
		public unsafe virtual bool GetExtensions(CefStringList extensionIds)
		{
			return SafeCall(NativeInstance->GetExtensions(extensionIds.GetNativeInstance()) != 0);
		}

		/// <summary>
		/// Returns the extension matching |extension_id| or NULL if no matching
		/// extension is accessible in this context (see HasExtension). This function
		/// must be called on the browser process UI thread.
		/// </summary>
		public unsafe virtual CefExtension GetExtension(string extensionId)
		{
			fixed (char* s0 = extensionId)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = extensionId != null ? extensionId.Length : 0 };
				return SafeCall(CefExtension.Wrap(CefExtension.Create, NativeInstance->GetExtension(&cstr0)));
			}
		}
	}
}