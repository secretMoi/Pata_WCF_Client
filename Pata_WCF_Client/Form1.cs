using System;
using System.Windows.Forms;
using Pata_WCF_Client.ServiceMaison;

namespace Pata_WCF_Client
{
	public partial class Form1 : Form
	{
		private readonly Service1Client _serveur;

		public Form1()
		{
			InitializeComponent();

			_serveur = new Service1Client();
		}

		private void buttonHelloWorld_Click(object sender, EventArgs e)
		{
			MessageBox.Show(_serveur.HelloWorld());
		}

		private void buttonGetData_Click(object sender, EventArgs e)
		{
			if (int.TryParse(textBoxGetData.Text, out int tmp))
				MessageBox.Show(_serveur.GetData(tmp));
		}

		private void buttonIsbn13_Click(object sender, EventArgs e)
		{
			if (_serveur.VerifierIsbn13(textBoxIsbn13.Text))
				MessageBox.Show(textBoxIsbn13.Text + @" est correct");
			else
				MessageBox.Show(textBoxIsbn13.Text + @" est incorrect");
		}

		private void buttonGetDataUsingContract_Click(object sender, EventArgs e)
		{
			CompositeType type = new CompositeType
			{
				BoolValue = checkBoxGetDataUsingContract.Checked,
				StringValue = textBoxGetDataUsingContract.Text
			};

			MessageBox.Show(textBoxGetDataUsingContract.Text + @" devient " + _serveur.GetDataUsingDataContract(type).StringValue);
		}
	}
}
