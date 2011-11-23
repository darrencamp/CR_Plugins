namespace CR_ReturnValueNotUsed
{
	partial class CR_ReturnValueNotUsed
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public CR_ReturnValueNotUsed()
		{
			/// <summary>
			/// Required for Windows.Forms Class Composition Designer support
			/// </summary>
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ipReturnValueNotUsed = new DevExpress.CodeRush.Core.IssueProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ipReturnValueNotUsed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// ipReturnValueNotUsed
			// 
			this.ipReturnValueNotUsed.DefaultIssueType = DevExpress.CodeRush.Core.CodeIssueType.CodeSmell;
			this.ipReturnValueNotUsed.Description = "The return result from the method call is not used";
			this.ipReturnValueNotUsed.ProviderName = "ReturnValueNotUsed";
			this.ipReturnValueNotUsed.Register = true;
			this.ipReturnValueNotUsed.CheckCodeIssues += new DevExpress.CodeRush.Core.CheckCodeIssuesEventHandler(this.ipReturnValueNotUsed_CheckCodeIssues);
			((System.ComponentModel.ISupportInitialize)(this.ipReturnValueNotUsed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.CodeRush.Core.IssueProvider ipReturnValueNotUsed;
	}
}