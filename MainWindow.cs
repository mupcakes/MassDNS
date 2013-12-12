using System;
using Gtk;
using StormOnDemandAPI;
using Newtonsoft.Json;
using System.Collections;

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
		IP = entryIP.Text;

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
			textviewAPIReturn.Buffer.Text += APIMethods.Network.DNS.Zone.Delegation (hash) + '\n';

						else if (radiobuttonDetails.Active)
			textviewAPIReturn.Buffer.Text += APIMethods.Network.DNS.Zone.Details (hash) + '\n';

		}
	}	

	protected void buttonClickedClear (object sender, EventArgs e)
	{
		//textviewHostnames.Buffer.Text = string.Empty;
		textviewAPIReturn.Buffer.Text = string.Empty;

		//entryUsername.Text = string.Empty;
		//entryPassword.Text = string.Empty;
		//entryIP.Text = string.Empty;
	}


}
