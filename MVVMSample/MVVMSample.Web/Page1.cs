using Wisej.Web;
using WpfApplication1;

namespace MVVMSample.Web
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		public Model DataContext
		{
			get; 
			private set;
		}

		private void Page1_Load(object sender, System.EventArgs e)
		{
			this.DataContext = new Model();

			this.textBox1.DataBindings.Add("Text", this.DataContext, "CurrentName", false, DataSourceUpdateMode.OnPropertyChanged);
			this.labelCurrentName.DataBindings.Add("Text", this.DataContext, "CurrentName", false, DataSourceUpdateMode.Never);
			this.button1.DataBindings.Add("Command", this.DataContext, "AddCommand");
			this.listBox1.DataBindings.Add("DataSource", this.DataContext, "AddedNames");

			// enable live updates from the textbox.
			this.textBox1.ModifiedChanged += TextBox1_ModifiedChanged;

		}

		private void TextBox1_ModifiedChanged(object sender, System.EventArgs e)
		{
		}
	}
}
