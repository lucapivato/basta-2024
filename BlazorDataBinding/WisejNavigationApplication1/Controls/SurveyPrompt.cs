using System;
using Wisej.Web;

namespace WisejNavigationApplication1.Controls
{
	/// <summary>
	/// Represents a reusable survey prompt control.
	/// </summary>
	public class SurveyPrompt : Wisej.Web.FlowLayoutPanel
	{
		private Label labelDescription;
		private LinkLabel linkBriefSurvey;
		private PictureBox pictureBoxEdit;

		public SurveyPrompt()
		{
			InitializeComponent();
		}

		public override string Text
		{
			get => this.labelDescription.Text; set => this.labelDescription.Text = value;
		}

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBoxEdit = new Wisej.Web.PictureBox();
			this.labelDescription = new Wisej.Web.Label();
			this.linkBriefSurvey = new Wisej.Web.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxEdit
			// 
			this.pictureBoxEdit.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/info-circle.svg";
			this.pictureBoxEdit.Location = new System.Drawing.Point(13, 13);
			this.pictureBoxEdit.Name = "pictureBoxEdit";
			this.pictureBoxEdit.Size = new System.Drawing.Size(22, 32);
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelDescription.Location = new System.Drawing.Point(41, 13);
			this.labelDescription.MinimumSize = new System.Drawing.Size(0, 31);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(38, 31);
			this.labelDescription.TabIndex = 6;
			this.labelDescription.Text = "Title";
			this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// linkBriefSurvey
			// 
			this.linkBriefSurvey.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.linkBriefSurvey.LinkArea = new Wisej.Web.LinkArea(16, 12);
			this.linkBriefSurvey.Location = new System.Drawing.Point(85, 13);
			this.linkBriefSurvey.Name = "linkLabel1";
			this.linkBriefSurvey.Size = new System.Drawing.Size(363, 32);
			this.linkBriefSurvey.TabIndex = 7;
			this.linkBriefSurvey.Text = "Please take our brief survey and tell us what you think.";
			this.linkBriefSurvey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkBriefSurvey.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkBriefSurvey_LinkClicked);
			// 
			// SurveyPrompt
			// 
			this.AutoSize = true;
			this.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromName("@gray-200");
			this.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.Controls.Add(this.pictureBoxEdit);
			this.Controls.Add(this.labelDescription);
			this.Controls.Add(this.linkBriefSurvey);
			this.Name = "SurveyPrompt";
			this.Padding = new Wisej.Web.Padding(10);
			this.Size = new System.Drawing.Size(463, 60);
			this.Text = "SurveyPrompt";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxEdit)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private void linkBriefSurvey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Application.Navigate("https://us13.list-manage.com/survey?u=c8bb40d1323838a33db98836b&id=5172de174c&attribution=false", target: "_blank");
		}
	}
}
