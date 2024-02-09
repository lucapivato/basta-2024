using Wisej.Ext.ClientFileSystem;
using Wisej.Web;

namespace LocalFileSystem
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private async void button1_Click(object sender, System.EventArgs e)
		{
			var directory = await ClientFileSystem.ShowDirectoryPickerAsync();
			var files = await directory.GetFilesAsync("*.*");

			this.listView1.Items.Clear();
			foreach (var file in files)
			{
				var item = this.listView1.Items.Add(file.Name);
				item.SubItems.Add(file.Size.ToString());
				item.SubItems.Add(file.LastModified.ToString());
				item.UserData.File = file;
			}
		}

		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			var item = this.listView1.FocusedItem;
			if (item != null)
			{
				this.button2.Enabled = this.button3.Enabled = item.Text.EndsWith(".txt");
			}
		}

		private async void button2_Click(object sender, System.EventArgs e)
		{
			var item = this.listView1.FocusedItem;
			var file = (File)item.UserData.File;
			var text = await file.ReadTextAsync();
			AlertBox.Show(text);
		}

		private async void button3_Click(object sender, System.EventArgs e)
		{
			var item = this.listView1.FocusedItem;
			var file = (File)item.UserData.File;
			await file.WriteTextAsync("Hello, World!", 0);
			AlertBox.Show($"{file.Name} written successfully!");
		}
	}
}
