using System.Drawing;
using DevExpress.XtraReports.UI;
// ...


namespace ControlsCS {
	/// <summary>
	/// Summary description for XtraReport1.
	/// </summary>
	public class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
		public DevExpress.XtraReports.UI.DetailBand Detail;
		private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel3;
		private DevExpress.XtraReports.UI.XRControl xrControl1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public XtraReport1() {
			/// <summary>
			/// Required for Windows.Forms Class Composition Designer support
			/// </summary>
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.xrControl1 = new DevExpress.XtraReports.UI.XRControl();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
																						this.xrControl1,
																						this.xrLabel3,
																						this.xrLabel2,
																						this.xrLabel1});
			this.Detail.Name = "Detail";
			// 
			// xrControl1
			// 
			this.xrControl1.Borders = DevExpress.XtraPrinting.BorderSide.All;
			this.xrControl1.Location = new System.Drawing.Point(550, 8);
			this.xrControl1.Name = "xrControl1";
			this.xrControl1.ParentStyleUsing.UseBorders = false;
			this.xrControl1.Size = new System.Drawing.Size(100, 25);
			// 
			// xrLabel3
			// 
			this.xrLabel3.Location = new System.Drawing.Point(408, 33);
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Size = new System.Drawing.Size(100, 25);
			this.xrLabel3.Text = "xrLabel3";
			// 
			// xrLabel2
			// 
			this.xrLabel2.Location = new System.Drawing.Point(267, 50);
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Size = new System.Drawing.Size(100, 25);
			this.xrLabel2.Text = "xrLabel2";
			// 
			// xrLabel1
			// 
			this.xrLabel1.Location = new System.Drawing.Point(150, 17);
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Size = new System.Drawing.Size(100, 25);
			this.xrLabel1.Text = "xrLabel1";
			// 
			// PageHeader
			// 
			this.PageHeader.Height = 30;
			this.PageHeader.Name = "PageHeader";
			// 
			// PageFooter
			// 
			this.PageFooter.Height = 30;
			this.PageFooter.Name = "PageFooter";
			// 
			// XtraReport1
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
																		 this.Detail,
																		 this.PageHeader,
																		 this.PageFooter});
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
		#endregion

		public void AlignHorizontally(XRControl container) {

			// Make sure that the collection is not empty.
			if(container.Controls.Count > 0) {

				// Assign the Y-coordinate of the first control in the collection to a variable.
				int height = container.Controls[0].Top;

				// Find the Y-coordinate of the control located above other controls.
				foreach(XRControl control in container.Controls) 
					if(control.Top < height)
						height = control.Top;
         
				// Align the controls with the topmost control.
				foreach(XRControl control in container.Controls) 
					control.Location = new Point(control.Left, height);
			}
		}
	}
}
