using System;
using Gtk;
using StormOnDemandAPI;
using Newtonsoft.Json;
using System.Collections;
using System.Threading;

public partial class MainWindow: Gtk.Window
{	
	private string _username;
	private string _password;
	private string _ip;

	public string Username { get { return _username; } set { _username = value;} }
	public string Password { get { return _password; } set { _password = value;} }
	public string IP { get { return _ip; } set { _ip = value;} }
	public string[] Hostnames;

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void buttonClickedPark (object sender, EventArgs e)
	{
		Auth.username = entryUsername.Text;
		Auth.password = entryPassword.Text;

		IP = entryIP.Text != "" ? entryIP.Text : "127.0.0.1";

		Hostnames = textviewHostnames.Buffer.Text.Split ('\n');

		foreach (string st in Hostnames) {
			Hashtable hash = new Hashtable();
			hash.Add ("name", st);

			if (radiobuttonCreate.Active)
			{
				Hashtable haship = new Hashtable();					
				haship.Add ("ip", IP);
				hash.Add ("zone_data", haship);

				textviewAPIReturn.Buffer.Text += APIMethods.Network.DNS.Zone.Create (hash) + '\n';
			}

			else if (radiobuttonDelete.Active)
					textviewAPIReturn.Buffer.Text += APIMethods.Network.DNS.Zone.Delete (hash) + '\n';

			else if (radiobuttonDelegation.Active)
				textviewAPIReturn.Buffer.Text += string.Format ("{0} : {1}", st, APIMethods.Network.DNS.Zone.Delegation (hash) + '\n');

			else if (radiobuttonDetails.Active)
					textviewAPIReturn.Buffer.Text += APIMethods.Network.DNS.Zone.Details (hash) + '\n';

		}
	}

	protected void buttonClickedClear (object sender, EventArgs e)
	{
		textviewAPIReturn.Buffer.Text = string.Empty;
	}	

	protected void radiobuttonCreateClicked (object sender, EventArgs e)
	{
		entryIP.Visible = true;
		label3.Visible = true;
	}

	protected void radiobuttonDeleteClicked (object sender, EventArgs e)
	{
		entryIP.Visible = false;
		label3.Visible = false;
	}	

	protected void radiobuttonDetailsClicked (object sender, EventArgs e)
	{
		entryIP.Visible = false;
		label3.Visible = false;
	}	

	protected void radiobuttonDelegationClicked (object sender, EventArgs e)
	{
		entryIP.Visible = false;
		label3.Visible = false;
	}
	protected void textviewHostnamesPasteClipboard (object sender, EventArgs e)
	{
		textviewHostnames.Buffer.Text = "";
	}
	
}
