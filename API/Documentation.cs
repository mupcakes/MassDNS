#region License
// Copyright (c) 2013 mupton@liquidweb.com
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using StormOnDemandAPI;

namespace APIMethods
{
	/// <summary>
	/// API Documentation built from automatically generated JSON output from API.
	/// </summary>
	public class Documentation
	{
		public static Dictionary<string, dynamic> docs = PullAPIDocs();

		/// <summary>
		/// Generates a Dictionary key,value set of the JSON documentation.
		/// </summary>
		private static Dictionary<string, dynamic> PullAPIDocs ()
		{
			WebClient cli = new WebClient ();

			string tmp = cli.DownloadString ("https://www.stormondemand.com/api/docs/v1/docs.json");

			//Regex removes \n characters that are outside of strings so it will store properly
			return docs = JsonConvert.DeserializeObject<Dictionary<string, dynamic>> (Regex.Replace (tmp, @"[\n]", " "));
		}

		/// <summary>
		/// Used to pull method info from documentation via category/method.
		/// </summary>
		public static JObject MethodInfo (string category, string method)
		{ 
			return docs == null ? PullAPIDocs() : docs[category]["__methods"][method]; 
		}

		/// <summary>
		/// Used to return specific parameters from the category/method such as __input, __output parameters.
		/// </summary>
		public static JValue MethodInfo (string category, string method, string parameters)
		{ 
			return docs == null ? PullAPIDocs () : docs[category]["__methods"][method][parameters]; 
		}
	}
}

