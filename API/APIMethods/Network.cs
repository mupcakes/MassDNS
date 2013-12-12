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
using StormOnDemandAPI;
using Newtonsoft.Json.Linq;

namespace APIMethods.Network
{
	public static class DNS
	{
		public static class Domain
		{
			/// <summary>
			/// Returns API documentation on a specific method in Network/DNS/Domain/
			/// </summary>
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Network/DNS/Domain"]["__methods"][method];
			}

			/// <summary>
			/// Returns the list of domain registrations for a given account.
			/// </summary>
			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Domain/list";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Renews a domain by insert it into the renewal queue.
			/// </summary>
			public static string Renew (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Domain/renew";
				return APIHandler.Post (method, options, encoding);
			}
		}

		public static class Record
		{
			/// <summary>
			/// Returns API documentation on a specific method in Network/DNS/Record/
			/// </summary>
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Network/DNS/Record"]["__methods"][method];
			}

			/// <summary>
			/// This method is used to add new resource records (RRs) to a zone.
			/// </summary>
			public static string Create (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Record/create";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// This method is used to delete resource records (RRs) from a zone file
			/// It returns the 'deleted' field, whose value is the records id field.
			/// </summary>
			public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Record/delete";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Retrieve details about a particular resource record.
			/// </summary>
			public static string Details (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Record/details";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// This method is used to get resource records (RRs) from a zone file.
			/// Each entry in the 'items' array referrs to one of the records in the zone.
			/// The details of these entries are further described in the 'details' method.
			/// </summary>
			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Record/list";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// This method is used to update resource records (RRs) in a zone.
			/// </summary>
			public static string Update (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Record/update";
				return APIHandler.Post (method, options, encoding);
			}

			public static class Region
			{
				/// <summary>
				/// Returns API documentation on a specific method in Network/DNS/Record/Region/
				/// </summary>
				public static JObject MethodInfo (string method)
				{
					 return Documentation.docs["Network/DNS/Record/Region"]["__methods"][method];
				}

				/// <summary>
				/// This sub is used to add a new region to a DNS Record.
				/// </summary>
				public static string Create (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Network/DNS/Record/Region/create";
					return APIHandler.Post (method, options, encoding);
				}

				/// <summary>
				/// This subroutine is used to delete unassociated a region from the specified DNS Record
				/// </summary>
				public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Network/DNS/Record/Region/delete";
					return APIHandler.Post (method, options, encoding);
				}

				/// <summary>
				/// This sub is used to update Regions associated with DNS Records.
				/// </summary>
				public static string Update (object options, EncodeType encoding = EncodeType.JSON)
				{
					string method = "/Network/DNS/Record/Region/update";
					return APIHandler.Post (method, options, encoding);
				}
			}
		}

		public static class Reverse
		{
			/// <summary>
			/// Returns API documentation on a specific method in Network/DNS/Reverse/
			/// </summary>
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Network/DNS/Reverse"]["__methods"][method];
			}

			/// <summary>
			/// This method is used to remove reverse DNS records.
			/// </summary>
			public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Reverse/delete";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Updates a ptr record.
			/// </summary>
			public static string Update (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Reverse/update";
				return APIHandler.Post (method, options, encoding);
			}

		}

		public static class Zone
		{
			/// <summary>
			/// Returns API documentation on a specific method in Network/DNS/Zone/
			/// </summary>
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Network/DNS/Zone"]["__methods"][method];
			}

			/// <summary>
			/// Add a new DNS zone
			/// </summary>
			public static string Create (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/create";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// This method can be used to check if a DNS zone is properly delegated to our nameservers.
			/// </summary>
			public static string Delegation (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/delegation";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Remove a DNS zone
			/// </summary>
			public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/delete";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Retrieve details on a particular zone served by our DNS servers.
			/// </summary>
			public static string Details (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/details";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Retrieve a list of zones that are served by our DNS servers for your account.
			/// </summary>
			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/list";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Update the zone features.
			/// </summary>
			public static string Update (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/DNS/Zone/update";
				return APIHandler.Post (method, options, encoding);
			}
		}
	}

	public static class Firewall
	{
		/// <summary>
		/// Returns API documentation on a specific method in Network/Firewall/
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Network/Firewall"]["__methods"][method];
		}

		/// <summary>
		/// Get details about the current firewall settings for a particular server.  If
		/// no firewall is applied, a type of 'none' is returned.  Otherwise, you get the
		/// various firewall types: 'basic', 'advanced', or 'saved', along with relevant
		/// details that apply to that firewall type.
		/// </summary>
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Firewall/details";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Returns a list of options that the basic firewall accepts.
		/// </summary>
		public static string GetBasicOptions (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Firewall/getBasicOptions";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Returns the rules for the given server, regardless of type.
		/// The rules are returned under the rules field, which is an array reference.
		/// </summary>
		public static string Rules (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Firewall/rules";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Updates the firewall setting for a given server.  The argument should mirror
		/// the data structures returned by details, with the addition of the
		/// uniq_id field.
		/// </summary>
		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Firewall/update";
			return APIHandler.Post (method, options, encoding);
		}

		public static class Ruleset
		{
			/// <summary>
			/// Returns API documentation on a specific method in Network/Firewall/Ruleset/
			/// </summary>
			public static JObject MethodInfo (string method)
			{
				 return Documentation.docs["Network/Firewall/Ruleset"]["__methods"][method];
			}

			/// <summary>
			/// Saves the ruleset that the given server is using under the given name.
			/// The server will be set to a firewall type of 'saved', with this ruleset
			/// as its ruleset.
			/// </summary>
			public static string Create (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/Firewall/Ruleset/create";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Returns the rules and valid destinations ips for the given ruleset.
			/// </summary>
			public static string Details (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/Firewall/Ruleset/details";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Returns an array reference of rulesets that have been saved for use
			/// by this account.
			/// </summary>
			public static string List (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/Firewall/Ruleset/list";
				return APIHandler.Post (method, options, encoding);
			}

			/// <summary>
			/// Updates the saved ruleset with the given ruleset.  Returns a list of affected
			/// servers.
			/// </summary>
			public static string Update (object options, EncodeType encoding = EncodeType.JSON)
			{
				string method = "/Network/Firewall/Ruleset/update";
				return APIHandler.Post (method, options, encoding);
			}
		}
	}	/// <summary>
	/// End of Firewall
	/// </summary>

	public static class IP
	{
		/// <summary>
		/// Returns API documentation on a specific method in Network/IP/
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Network/IP"]["__methods"][method];
		}

		/// <summary>
		/// Add a number of IPs to an existing server. If the 'reboot' flag is passed in,
		/// the server will be stopped, have the new IP addresses configured, and then be
		/// rebooted.
		/// </summary>
		public static string Add (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/add";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Gets information about a particular IP.
		/// </summary>
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/details";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Gets a paginationed list of all IPs for a particular server.  More details
		/// about the returned data can be found under network/ip/details
		/// </summary>
		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/list";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Gets a list of public network assignments for all subaccounts for a particular
		/// account, optionally for a specific zone only.  With the include_pools flag,
		/// also includes IPs assigned to IP pools.
		/// </summary>
		public static string ListAccntPublic (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/listAccntPublic";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Gets a paginated list of all public IPs for a particular server.  More details
		/// about the returned data can be found under network/ip/details
		/// </summary>
		public static string ListPublic (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/listPublic";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Remove a specific IP from a server. If the 'reboot' flag is passed in,
		/// the server will be stopped, have the old IP addresses removed, and then be
		/// rebooted.
		/// </summary>
		public static string Remove (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/remove";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Request additional IPs for a server.  Many server types (traditional dedicated
		/// for example) require manual intervention to add IPs.  This method creates a
		/// ticket, requesting that the given number of IPs be added.
		/// </summary>
		public static string Request (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/IP/request";
			return APIHandler.Post (method, options, encoding);
		}

	}

	public static class LoadBalancer
	{
		/// <summary>
		/// Returns API documentation on a specific method in Network/LoadBalancer/
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Network/LoadBalancer"]["__methods"][method];
		}

		/// <summary>
		/// Adds a single node to an existing loadbalancer.
		/// </summary>
		public static string AddNode (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/addNode";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Adds a service to an existing loadbalancer.
		/// </summary>
		public static string AddService (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/addService";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Find out if a loadbalancer name is already in use on an account.  Allows for
		/// preventing DuplicateRecord exceptions when creating new load balancers.
		/// </summary>
		public static string Available (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/available";
			return APIHandler.Post (method, options, encoding);
		}


		/// <summary>
		/// Create a new LoadBalancer.
		/// </summary>
		public static string Create (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/create";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Delete a LoadBalancer.
		/// </summary>
		public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/delete";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Get information about a specific loadbalancer.
		/// </summary>
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/details";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Gets a list of all loadbalancers on an account.
		/// </summary>
		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/list";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Gets a list of all possible Loadbalancer Nodes on an account, regardless of
		/// whether or not they are currently loadbalanced.
		/// </summary>
		public static string PossibleNodes (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/possibleNodes";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Removes a single node from an existing loadbalancer.
		/// </summary>
		public static string RemoveNode (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/removeNode";
			return APIHandler.Post (method, options, encoding);
		}


		/// <summary>
		/// Removes a single service from an existing loadbalancer.
		/// </summary>
		public static string RemoveService (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/removeService";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Get a list of available strategies, with extra descriptive information.
		/// </summary>
		public static string Strategies (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/strategies";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Update an existing loadbalancer.
		/// </summary>
		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/LoadBalancer/update";
			return APIHandler.Post (method, options, encoding);
		}

	}

	public static class Pool
	{
		/// <summary>
		/// Returns API documentation on a specific method in Network/Pool/
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Network/Pool"]["__methods"][method];
		}

		/// <summary>
		/// Create a new IP Pool
		/// </summary>
		public static string Create (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Pool/create";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Deletes the given pool, and all the assignments that are only in the pool.
		/// </summary>
		public static string Delete (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Pool/delete";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Returns the details of a given IP pool.
		/// </summary>
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Pool/details";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Gets a list of network assignments for a particular IP Pool.
		/// </summary>
		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Pool/list";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Update an existing IP Pool
		/// </summary>
		public static string Update (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Pool/update";
			return APIHandler.Post (method, options, encoding);
		}
	}

	public static class Private
	{
		/// <summary>
		/// Returns API documentation on a specific method in Network/Private/
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Network/Private"]["__methods"][method];
		}

		/// <summary>
		/// Attach a given server to your private network.
		/// Note: This will automatically create the private network, if it is not already
		/// created.
		/// </summary>
		public static string Attach (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Private/attach";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Detaches a given server to your private network.
		/// Note: if this is the last server on your private network, the private vlan will
		/// be destroyed, so you will not be guaranteed the same private vlan id, should you
		/// re-enable private networking later.
		/// </summary>
		public static string Detach (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Private/detach";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Gets all of the servers attached to your private network, which zones they are in,
		/// and what IPs they are assigned.
		/// </summary>
		public static string Get (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Private/get";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Gets the current private IP for a particular server, if it has one.
		/// </summary>
		public static string GetIP (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Private/getIP";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Determine whether a given server is currently attached to your private network.
		/// </summary>
		public static string IsAttached (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Private/isAttached";
			return APIHandler.Post (method, options, encoding);
		}
	}

	public static class Zone
	{
		/// <summary>
		/// Returns API documentation on a specific method in Network/Zone/
		/// </summary>
		public static JObject MethodInfo (string method)
		{
			 return Documentation.docs["Network/Zone"]["__methods"][method];
		}

		/// <summary>
		/// Returns details of a given network zone by its name or id field.
		/// </summary>
		public static string Details (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Zone/details";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Returns a list of zones.
		/// </summary>
		public static string List (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Zone/list";
			return APIHandler.Post (method, options, encoding);
		}

		/// <summary>
		/// Sets the default zone for an account.
		/// </summary>
		public static string SetDefault (object options, EncodeType encoding = EncodeType.JSON)
		{
			string method = "/Network/Zone/setDefault";
			return APIHandler.Post (method, options, encoding);
		}
	}
}

