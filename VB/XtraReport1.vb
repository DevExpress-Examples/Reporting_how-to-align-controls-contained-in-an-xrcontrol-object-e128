Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraReports.UI
' ...


Namespace ControlsCS
	''' <summary>
	''' Summary description for XtraReport1.
	''' </summary>
	Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrControl1 As DevExpress.XtraReports.UI.XRControl
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			''' <summary>
			''' Required for Windows.Forms Class Composition Designer support
			''' </summary>
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrControl1 = New DevExpress.XtraReports.UI.XRControl()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrControl1, Me.xrLabel3, Me.xrLabel2, Me.xrLabel1})
			Me.Detail.Name = "Detail"
			' 
			' xrControl1
			' 
			Me.xrControl1.Borders = DevExpress.XtraPrinting.BorderSide.All
			Me.xrControl1.Location = New System.Drawing.Point(550, 8)
			Me.xrControl1.Name = "xrControl1"
			Me.xrControl1.ParentStyleUsing.UseBorders = False
			Me.xrControl1.Size = New System.Drawing.Size(100, 25)
			' 
			' xrLabel3
			' 
			Me.xrLabel3.Location = New System.Drawing.Point(408, 33)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.Location = New System.Drawing.Point(267, 50)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Location = New System.Drawing.Point(150, 17)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' PageHeader
			' 
			Me.PageHeader.Height = 30
			Me.PageHeader.Name = "PageHeader"
			' 
			' PageFooter
			' 
			Me.PageFooter.Height = 30
			Me.PageFooter.Name = "PageFooter"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
		#End Region

		Public Sub AlignHorizontally(ByVal container As XRControl)

			' Make sure that the collection is not empty.
			If container.Controls.Count > 0 Then

				' Assign the Y-coordinate of the first control in the collection to a variable.
				Dim height As Integer = container.Controls(0).Top

				' Find the Y-coordinate of the control located above other controls.
				For Each control As XRControl In container.Controls
					If control.Top < height Then
						height = control.Top
					End If
				Next control

				' Align the controls with the topmost control.
				For Each control As XRControl In container.Controls
					control.Location = New Point(control.Left, height)
				Next control
			End If
		End Sub
	End Class
End Namespace
