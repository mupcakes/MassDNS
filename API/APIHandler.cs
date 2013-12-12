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
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Numerics;

namespace StormOnDemandAPI
{
	/// <summary>
	/// API Encoding types
	/// </summary>
	public enum EncodeType
	{
		JSON,
		//XML,
		YAML }
	;

	/// <summary>
	/// API handler handles the post and return of data to the API
	/// </summary>
	public class APIHandler
	{
		/// <summary>
		/// The API Version to to use ie: v1, bleed
		/// </summary>
		public static string Version = "v1";

		/// <summary>
		/// The environment/base URI string.
		/// </summary>
		public static string Environment = "https://api.stormondemand.com/";

		/// <summary>
		/// Posts/returns the specified decode based on object type, method, parameters and encoding.
		/// </summary>
		/// <returns>
		/// The JSON response string returned from the API.
		/// </returns>
		private static T Post<T> (Func<string, T> decode, string method, string parameters, EncodeType encoding = EncodeType.JSON)
		{
			// Use this to ignore cert warning when running through your IDE
			ServicePointManager.ServerCertificateValidationCallback = ( se, cert, chain, sslerror ) => { return true; };

			WebRequest _webRequest;
			WebResponse _webResponse;

			T _response = default( T );

			// Build API post URI
			string _url = string.Format ("{0}{1}{2}",APIHandler.Environment, APIHandler.Version, method);

			//if (encoding == EncodeType.XML && !_url.EndsWith (".xml"))
			//	_url += ".xml";

			//Setup web request
			_webRequest = WebRequest.Create (_url);

			_webRequest.ContentType = "application/" + encoding.ToString ().ToLower ();
			_webRequest.Method = "POST";

			// Set API auth information
			_webRequest.Credentials = Auth.Credentials;

			byte[] buffer = Encoding.GetEncoding ("UTF-8").GetBytes (parameters != null ? parameters : string.Empty);

			try {
			//Wrap in using statments to implement IDisposable
			using (Stream stream = _webRequest.GetRequestStream())
				stream.Write (buffer, 0, buffer.Length);
				using (_webResponse = _webRequest.GetResponse()) {
					using (Stream stream = _webResponse.GetResponseStream()) {
						using (StreamReader reader = new StreamReader( stream )) {
							string responseStr = reader.ReadToEnd ();

							if (decode != null)
								_response = decode (responseStr);

							return _response;
						}
					}
				}
			} catch (WebException ex) {
				//Catch a couple web errors for example, or display generic eror by error code
				if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null) {
					var resp = (HttpWebResponse)ex.Response;
					if (resp.StatusCode == HttpStatusCode.NotFound) {
						// 404 Error
						return decode ("404 error");
					} else if (resp.StatusCode == HttpStatusCode.BadRequest) {
						// 400 Error
						return _response = decode ("400 Error");
					}
				}
					// Return unhandled error
				return _response = decode (string.Format ("{0} Error", ex.Status));
			}
		}

		/// <summary>
		/// Posts the specified method, Serializes the parameters object into json and sets encoding type.
		/// </summary>
		/// <returns>
		/// The JSON response string returned from the API.
		/// </returns>
		public static string Post (string method, object parameters , EncodeType encoding = EncodeType.JSON)
		{
			string pars = parameters != null ? JsonConvert.SerializeObject (parameters) : string.Empty;

			// Handle API post based on encoding type
			switch (encoding) {
			case EncodeType.JSON: 
				{					
					Func<string, string> decode = responseStr => {
						return (responseStr); };

					return Post<string> (decode, method, pars, EncodeType.JSON);
				}

//			case EncodeType.XML:
//				{
//					Func<string, string> decode = responseStr =>
//					{
//						Clean the XML sheet of any invalid elements as per the ISO standard
//						 rewrites zone elements such as <10> to <zone_10>
//						return Regex.Replace (responseStr, @"<(/?)([0-9]*)[$>]", String.Format ("<{0}zone_{1}>", "$1", "$2"));
//					};
//
//					return Post<string> (decode, method, pars, EncodeType.XML);
//				}

			case EncodeType.YAML: 
				{
					return "YAML not implemented yet";
				}

			default:
				return "Unrecognized encoding type";
			}
		}

		/// <summary>
		/// Reads the element value.
		/// </summary>
		/// <returns>
		/// The element value.
		/// </returns>
//		public static string ReadElementValue (XPathNavigator nav, string elementName)
//		{
//			XPathNodeIterator element = nav.Select (elementName);
//
//			return element != null && element.MoveNext () ? element.Current.Value : String.Empty;
//		} 
	}
}