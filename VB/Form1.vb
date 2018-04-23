Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace ControlsCS
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
	  Private WithEvents button1 As System.Windows.Forms.Button
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
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

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
		 Me.button1 = New System.Windows.Forms.Button()
		 Me.SuspendLayout()
		 ' 
		 ' button1
		 ' 
		 Me.button1.Location = New System.Drawing.Point(104, 80)
		 Me.button1.Name = "button1"
		 Me.button1.TabIndex = 0
		 Me.button1.Text = "button1"
'		 Me.button1.Click += New System.EventHandler(Me.button1_Click);
		 ' 
		 ' Form1
		 ' 
		 Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		 Me.ClientSize = New System.Drawing.Size(292, 266)
		 Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.button1})
		 Me.Name = "Form1"
		 Me.Text = "Form1"
		 Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

	  Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
		 Dim report As XtraReport1 = New XtraReport1()
		 report.AlignHorizontally(report.Detail)
		 report.ShowPreview()
	  End Sub
	End Class
End Namespace
