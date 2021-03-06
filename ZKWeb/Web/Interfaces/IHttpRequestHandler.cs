﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZKWeb.Web.Interfaces {
	/// <summary>
	/// 网站http请求的处理器接口
	/// 在IHttpRequestPreHandler调用后调用，后注册的先调用
	/// </summary>
	public interface IHttpRequestHandler {
		/// <summary>
		/// 网站接收到http请求时的处理
		/// </summary>
		void OnRequest();
	}
}
