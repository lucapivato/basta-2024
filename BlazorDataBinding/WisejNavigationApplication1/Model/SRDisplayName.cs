using System.ComponentModel;
using System.Resources;

namespace WisejNavigationApplication1.Model
{
	/// <summary>
	/// Provides a localized display name for a property, method, or event.
	/// </summary>
	public class SRDisplayNameAttribute : DisplayNameAttribute
	{
		public SRDisplayNameAttribute(string text) : base(text)
		{
		}

		public override string DisplayName
		{
			get
			{
				SR = SR ?? new ResourceManager("WisejNavigationApplication1.Properties.Resource", typeof(SRDisplayNameAttribute).Assembly);

				try
				{
					return SR.GetString(base.DisplayNameValue);
				}
				catch
				{
					return base.DisplayNameValue;
				}
			}
		}
		private static ResourceManager SR;
	}
}
