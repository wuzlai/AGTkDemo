﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_server_capi.h
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------


.namespace CefNet.CApi
{
	.class public cef_server_t
	{
		// _cef_task_runner_t* (*)(_cef_server_t* self)*
		.method public hidebysig valuetype CefNet.CApi.cef_task_runner_t* GetTaskRunner()
		{
			.maxstack 2
			ldarg.0
			ldarg.0
			ldfld void* CefNet.CApi.cef_server_t::get_task_runner
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				valuetype CefNet.CApi.cef_task_runner_t*(valuetype CefNet.CApi.cef_server_t*)
			ret
		}

		// void (*)(_cef_server_t* self)*
		.method public hidebysig void Shutdown()
		{
			.maxstack 2
			ldarg.0
			ldarg.0
			ldfld void* CefNet.CApi.cef_server_t::shutdown
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				void(valuetype CefNet.CApi.cef_server_t*)
			ret
		}

		// int (*)(_cef_server_t* self)*
		.method public hidebysig int32 IsRunning()
		{
			.maxstack 2
			ldarg.0
			ldarg.0
			ldfld void* CefNet.CApi.cef_server_t::is_running
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				int32(valuetype CefNet.CApi.cef_server_t*)
			ret
		}

		// cef_string_userfree_t (*)(_cef_server_t* self)*
		.method public hidebysig valuetype CefNet.CApi.cef_string_userfree_t GetAddress()
		{
			.maxstack 2
			ldarg.0
			ldarg.0
			ldfld void* CefNet.CApi.cef_server_t::get_address
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				valuetype CefNet.CApi.cef_string_userfree_t(valuetype CefNet.CApi.cef_server_t*)
			ret
		}

		// int (*)(_cef_server_t* self)*
		.method public hidebysig int32 HasConnection()
		{
			.maxstack 2
			ldarg.0
			ldarg.0
			ldfld void* CefNet.CApi.cef_server_t::has_connection
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				int32(valuetype CefNet.CApi.cef_server_t*)
			ret
		}

		// int (*)(_cef_server_t* self, int connection_id)*
		.method public hidebysig int32 IsValidConnection(int32 connection_id)
		{
			.maxstack 3
			ldarg.0
			ldarg.1
			ldarg.0
			ldfld void* CefNet.CApi.cef_server_t::is_valid_connection
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				int32(valuetype CefNet.CApi.cef_server_t*, int32)
			ret
		}

		// void (*)(_cef_server_t* self, int connection_id, const cef_string_t* content_type, const void* data, size_t data_size)*
		.method public hidebysig void SendHttp200response(int32 connection_id, valuetype CefNet.CApi.cef_string_t* content_type, void* data, native uint data_size)
		{
			.maxstack 6
			ldarg.0
			ldarg.1
			ldarg.2
			ldarg.3
			ldarg.s 4
			ldarg.0
			ldfld void* CefNet.CApi.cef_server_t::send_http200response
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				void(valuetype CefNet.CApi.cef_server_t*, int32, valuetype CefNet.CApi.cef_string_t*, void*, native uint)
			ret
		}

		// void (*)(_cef_server_t* self, int connection_id)*
		.method public hidebysig void SendHttp404response(int32 connection_id)
		{
			.maxstack 3
			ldarg.0
			ldarg.1
			ldarg.0
			ldfld void* CefNet.CApi.cef_server_t::send_http404response
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				void(valuetype CefNet.CApi.cef_server_t*, int32)
			ret
		}

		// void (*)(_cef_server_t* self, int connection_id, const cef_string_t* error_message)*
		.method public hidebysig void SendHttp500response(int32 connection_id, valuetype CefNet.CApi.cef_string_t* error_message)
		{
			.maxstack 4
			ldarg.0
			ldarg.1
			ldarg.2
			ldarg.0
			ldfld void* CefNet.CApi.cef_server_t::send_http500response
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				void(valuetype CefNet.CApi.cef_server_t*, int32, valuetype CefNet.CApi.cef_string_t*)
			ret
		}

		// void (*)(_cef_server_t* self, int connection_id, int response_code, const cef_string_t* content_type, int64 content_length, cef_string_multimap_t extra_headers)*
		.method public hidebysig void SendHttpResponse(int32 connection_id, int32 response_code, valuetype CefNet.CApi.cef_string_t* content_type, int64 content_length, valuetype CefNet.CApi.cef_string_multimap_t extra_headers)
		{
			.maxstack 7
			ldarg.0
			ldarg.1
			ldarg.2
			ldarg.3
			ldarg.s 4
			ldarg.s 5
			ldarg.0
			ldfld void* CefNet.CApi.cef_server_t::send_http_response
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				void(valuetype CefNet.CApi.cef_server_t*, int32, int32, valuetype CefNet.CApi.cef_string_t*, int64, valuetype CefNet.CApi.cef_string_multimap_t)
			ret
		}

		// void (*)(_cef_server_t* self, int connection_id, const void* data, size_t data_size)*
		.method public hidebysig void SendRawData(int32 connection_id, void* data, native uint data_size)
		{
			.maxstack 5
			ldarg.0
			ldarg.1
			ldarg.2
			ldarg.3
			ldarg.0
			ldfld void* CefNet.CApi.cef_server_t::send_raw_data
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				void(valuetype CefNet.CApi.cef_server_t*, int32, void*, native uint)
			ret
		}

		// void (*)(_cef_server_t* self, int connection_id)*
		.method public hidebysig void CloseConnection(int32 connection_id)
		{
			.maxstack 3
			ldarg.0
			ldarg.1
			ldarg.0
			ldfld void* CefNet.CApi.cef_server_t::close_connection
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				void(valuetype CefNet.CApi.cef_server_t*, int32)
			ret
		}

		// void (*)(_cef_server_t* self, int connection_id, const void* data, size_t data_size)*
		.method public hidebysig void SendWebSocketMessage(int32 connection_id, void* data, native uint data_size)
		{
			.maxstack 5
			ldarg.0
			ldarg.1
			ldarg.2
			ldarg.3
			ldarg.0
			ldfld void* CefNet.CApi.cef_server_t::send_web_socket_message
			calli explicit unmanaged
#ifdef WINDOWS
				stdcall
#else
				cdecl
#endif
				void(valuetype CefNet.CApi.cef_server_t*, int32, void*, native uint)
			ret
		}
	}
}

