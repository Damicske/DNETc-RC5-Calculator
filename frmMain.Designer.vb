<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.txtKeysS = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnStartNow = New System.Windows.Forms.Button()
		Me.btnDateStopNow90 = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.chkDateStartNow = New System.Windows.Forms.CheckBox()
		Me.chkDateStopNow = New System.Windows.Forms.CheckBox()
		Me.dtpStart = New System.Windows.Forms.DateTimePicker()
		Me.dtpStop = New System.Windows.Forms.DateTimePicker()
		Me.nupPuTime = New System.Windows.Forms.NumericUpDown()
		Me.lblPuSuTime = New System.Windows.Forms.Label()
		Me.lblSuTime = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtSuBuffOut = New System.Windows.Forms.TextBox()
		Me.lblSuDays = New System.Windows.Forms.Label()
		Me.btn2LineTxt = New System.Windows.Forms.Button()
		Me.btnBuffIn = New System.Windows.Forms.Button()
		Me.chkCpu = New System.Windows.Forms.CheckBox()
		Me.chkDone = New System.Windows.Forms.CheckBox()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.btnTeamPage = New System.Windows.Forms.Button()
		Me.btnDateStopNowStart90 = New System.Windows.Forms.Button()
		Me.lblSuADay = New System.Windows.Forms.Label()
		Me.txtUnits = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.btnCalcBuffIn = New System.Windows.Forms.Button()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.lblOut = New System.Windows.Forms.Label()
		Me.btnAbout = New System.Windows.Forms.Button()
		Me.lblSuPerHour = New System.Windows.Forms.Label()
		Me.cbKeysps = New System.Windows.Forms.ComboBox()
		CType(Me.nupPuTime, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtKeysS
		'
		Me.txtKeysS.Location = New System.Drawing.Point(20, 30)
		Me.txtKeysS.Margin = New System.Windows.Forms.Padding(4)
		Me.txtKeysS.Name = "txtKeysS"
		Me.txtKeysS.Size = New System.Drawing.Size(142, 22)
		Me.txtKeysS.TabIndex = 1
		Me.txtKeysS.Text = "1"
		Me.ToolTip1.SetToolTip(Me.txtKeysS, "Enter your keys/sec as seen on the Dnet client ex. 8,775.76 Mkeys/s")
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(16, 78)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(146, 17)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Cpu/gpu time in hours"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(16, 105)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(70, 17)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Start date"
		'
		'btnStartNow
		'
		Me.btnStartNow.Location = New System.Drawing.Point(20, 178)
		Me.btnStartNow.Margin = New System.Windows.Forms.Padding(4)
		Me.btnStartNow.Name = "btnStartNow"
		Me.btnStartNow.Size = New System.Drawing.Size(267, 28)
		Me.btnStartNow.TabIndex = 5
		Me.btnStartNow.Text = "Date now"
		Me.ToolTip1.SetToolTip(Me.btnStartNow, "Set the start date to the date of today")
		Me.btnStartNow.UseVisualStyleBackColor = True
		'
		'btnDateStopNow90
		'
		Me.btnDateStopNow90.Location = New System.Drawing.Point(20, 282)
		Me.btnDateStopNow90.Margin = New System.Windows.Forms.Padding(4)
		Me.btnDateStopNow90.Name = "btnDateStopNow90"
		Me.btnDateStopNow90.Size = New System.Drawing.Size(268, 28)
		Me.btnDateStopNow90.TabIndex = 8
		Me.btnDateStopNow90.Text = "Date now +90 days"
		Me.ToolTip1.SetToolTip(Me.btnDateStopNow90, "Set the start date 90 days from today")
		Me.btnDateStopNow90.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(16, 212)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(65, 17)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "End date"
		'
		'chkDateStartNow
		'
		Me.chkDateStartNow.AutoSize = True
		Me.chkDateStartNow.Location = New System.Drawing.Point(20, 150)
		Me.chkDateStartNow.Margin = New System.Windows.Forms.Padding(4)
		Me.chkDateStartNow.Name = "chkDateStartNow"
		Me.chkDateStartNow.Size = New System.Drawing.Size(180, 21)
		Me.chkDateStartNow.TabIndex = 4
		Me.chkDateStartNow.Text = "Set date to now on start"
		Me.chkDateStartNow.UseVisualStyleBackColor = True
		'
		'chkDateStopNow
		'
		Me.chkDateStopNow.AutoSize = True
		Me.chkDateStopNow.Location = New System.Drawing.Point(20, 262)
		Me.chkDateStopNow.Margin = New System.Windows.Forms.Padding(4)
		Me.chkDateStopNow.Name = "chkDateStopNow"
		Me.chkDateStopNow.Size = New System.Drawing.Size(208, 21)
		Me.chkDateStopNow.TabIndex = 7
		Me.chkDateStopNow.Text = "Set date to now +90 on start"
		Me.chkDateStopNow.UseVisualStyleBackColor = True
		'
		'dtpStart
		'
		Me.dtpStart.Location = New System.Drawing.Point(20, 125)
		Me.dtpStart.Margin = New System.Windows.Forms.Padding(4)
		Me.dtpStart.Name = "dtpStart"
		Me.dtpStart.Size = New System.Drawing.Size(265, 22)
		Me.dtpStart.TabIndex = 3
		'
		'dtpStop
		'
		Me.dtpStop.Location = New System.Drawing.Point(20, 232)
		Me.dtpStop.Margin = New System.Windows.Forms.Padding(4)
		Me.dtpStop.Name = "dtpStop"
		Me.dtpStop.Size = New System.Drawing.Size(265, 22)
		Me.dtpStop.TabIndex = 6
		'
		'nupPuTime
		'
		Me.nupPuTime.Location = New System.Drawing.Point(172, 78)
		Me.nupPuTime.Margin = New System.Windows.Forms.Padding(4)
		Me.nupPuTime.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
		Me.nupPuTime.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
		Me.nupPuTime.Name = "nupPuTime"
		Me.nupPuTime.Size = New System.Drawing.Size(115, 22)
		Me.nupPuTime.TabIndex = 2
		Me.nupPuTime.Value = New Decimal(New Integer() {5, 0, 0, 0})
		'
		'lblPuSuTime
		'
		Me.lblPuSuTime.Location = New System.Drawing.Point(309, 94)
		Me.lblPuSuTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblPuSuTime.Name = "lblPuSuTime"
		Me.lblPuSuTime.Size = New System.Drawing.Size(292, 42)
		Me.lblPuSuTime.TabIndex = 15
		Me.lblPuSuTime.Text = "SU's in amount of CPU/GPU time"
		Me.lblPuSuTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'lblSuTime
		'
		Me.lblSuTime.Location = New System.Drawing.Point(311, 11)
		Me.lblSuTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblSuTime.Name = "lblSuTime"
		Me.lblSuTime.Size = New System.Drawing.Size(290, 34)
		Me.lblSuTime.TabIndex = 16
		Me.lblSuTime.Text = "Time of 1 SU 0:00:00:000"
		Me.lblSuTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(309, 146)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(184, 17)
		Me.Label5.TabIndex = 17
		Me.Label5.Text = "SU's that allready are done:"
		'
		'txtSuBuffOut
		'
		Me.txtSuBuffOut.Location = New System.Drawing.Point(500, 140)
		Me.txtSuBuffOut.Margin = New System.Windows.Forms.Padding(4)
		Me.txtSuBuffOut.Name = "txtSuBuffOut"
		Me.txtSuBuffOut.Size = New System.Drawing.Size(102, 22)
		Me.txtSuBuffOut.TabIndex = 18
		Me.txtSuBuffOut.Text = "999.999.999"
		Me.ToolTip1.SetToolTip(Me.txtSuBuffOut, "Your buffer out")
		'
		'lblSuDays
		'
		Me.lblSuDays.AutoSize = True
		Me.lblSuDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblSuDays.Location = New System.Drawing.Point(309, 234)
		Me.lblSuDays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblSuDays.Name = "lblSuDays"
		Me.lblSuDays.Size = New System.Drawing.Size(142, 17)
		Me.lblSuDays.TabIndex = 19
		Me.lblSuDays.Text = "SU's after 90 days"
		'
		'btn2LineTxt
		'
		Me.btn2LineTxt.Enabled = False
		Me.btn2LineTxt.Location = New System.Drawing.Point(315, 285)
		Me.btn2LineTxt.Margin = New System.Windows.Forms.Padding(4)
		Me.btn2LineTxt.Name = "btn2LineTxt"
		Me.btn2LineTxt.Size = New System.Drawing.Size(141, 28)
		Me.btn2LineTxt.TabIndex = 20
		Me.btn2LineTxt.Text = "2 Line text"
		Me.ToolTip1.SetToolTip(Me.btn2LineTxt, "Gives a output text in 2 lines with al the infoGives a output text in 2 lines wit" &
		"h al the infoGives a output text in 2 lines with al the info")
		Me.btn2LineTxt.UseVisualStyleBackColor = True
		'
		'btnBuffIn
		'
		Me.btnBuffIn.Location = New System.Drawing.Point(460, 285)
		Me.btnBuffIn.Margin = New System.Windows.Forms.Padding(4)
		Me.btnBuffIn.Name = "btnBuffIn"
		Me.btnBuffIn.Size = New System.Drawing.Size(141, 28)
		Me.btnBuffIn.TabIndex = 21
		Me.btnBuffIn.Text = "Empty buff-in >>"
		Me.btnBuffIn.UseVisualStyleBackColor = True
		'
		'chkCpu
		'
		Me.chkCpu.AutoSize = True
		Me.chkCpu.Location = New System.Drawing.Point(313, 196)
		Me.chkCpu.Margin = New System.Windows.Forms.Padding(4)
		Me.chkCpu.Name = "chkCpu"
		Me.chkCpu.Size = New System.Drawing.Size(201, 21)
		Me.chkCpu.TabIndex = 22
		Me.chkCpu.Text = "Calculate with cpu/gpu time"
		Me.ToolTip1.SetToolTip(Me.chkCpu, "Calc based on CPU-time otherwise calc based on days")
		Me.chkCpu.UseVisualStyleBackColor = True
		'
		'chkDone
		'
		Me.chkDone.AutoSize = True
		Me.chkDone.Location = New System.Drawing.Point(313, 167)
		Me.chkDone.Margin = New System.Windows.Forms.Padding(4)
		Me.chkDone.Name = "chkDone"
		Me.chkDone.Size = New System.Drawing.Size(148, 21)
		Me.chkDone.TabIndex = 23
		Me.chkDone.Text = "Add the done SU's"
		Me.ToolTip1.SetToolTip(Me.chkDone, "Add he allready done SU's")
		Me.chkDone.UseVisualStyleBackColor = True
		'
		'btnTeamPage
		'
		Me.btnTeamPage.Location = New System.Drawing.Point(315, 318)
		Me.btnTeamPage.Margin = New System.Windows.Forms.Padding(4)
		Me.btnTeamPage.Name = "btnTeamPage"
		Me.btnTeamPage.Size = New System.Drawing.Size(141, 28)
		Me.btnTeamPage.TabIndex = 32
		Me.btnTeamPage.Text = "Team Page"
		Me.ToolTip1.SetToolTip(Me.btnTeamPage, "The best team of the lower lands in Europe")
		Me.btnTeamPage.UseVisualStyleBackColor = True
		'
		'btnDateStopNowStart90
		'
		Me.btnDateStopNowStart90.Location = New System.Drawing.Point(20, 318)
		Me.btnDateStopNowStart90.Margin = New System.Windows.Forms.Padding(4)
		Me.btnDateStopNowStart90.Name = "btnDateStopNowStart90"
		Me.btnDateStopNowStart90.Size = New System.Drawing.Size(267, 28)
		Me.btnDateStopNowStart90.TabIndex = 34
		Me.btnDateStopNowStart90.Text = "Start date +90 days"
		Me.ToolTip1.SetToolTip(Me.btnDateStopNowStart90, "Set the start date 90 days from today")
		Me.btnDateStopNowStart90.UseVisualStyleBackColor = True
		'
		'lblSuADay
		'
		Me.lblSuADay.AutoSize = True
		Me.lblSuADay.Location = New System.Drawing.Point(309, 68)
		Me.lblSuADay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblSuADay.Name = "lblSuADay"
		Me.lblSuADay.Size = New System.Drawing.Size(76, 17)
		Me.lblSuADay.TabIndex = 24
		Me.lblSuADay.Text = "SU's a day"
		Me.lblSuADay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txtUnits
		'
		Me.txtUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtUnits.Location = New System.Drawing.Point(670, 46)
		Me.txtUnits.Margin = New System.Windows.Forms.Padding(4)
		Me.txtUnits.Name = "txtUnits"
		Me.txtUnits.Size = New System.Drawing.Size(162, 26)
		Me.txtUnits.TabIndex = 25
		Me.txtUnits.Text = "1000000"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(613, 28)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(137, 17)
		Me.Label6.TabIndex = 26
		Me.Label6.Text = "Stats units in buff-in:"
		'
		'Label7
		'
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(611, 75)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(293, 158)
		Me.Label7.TabIndex = 27
		Me.Label7.Text = "Is your key rate filled in correctly? Is your CPU-Time correct, then you may calc" &
	"ulate how long its gonna take to do your SU's"
		'
		'btnCalcBuffIn
		'
		Me.btnCalcBuffIn.Location = New System.Drawing.Point(708, 224)
		Me.btnCalcBuffIn.Margin = New System.Windows.Forms.Padding(4)
		Me.btnCalcBuffIn.Name = "btnCalcBuffIn"
		Me.btnCalcBuffIn.Size = New System.Drawing.Size(100, 28)
		Me.btnCalcBuffIn.TabIndex = 28
		Me.btnCalcBuffIn.Text = "Calculate"
		Me.btnCalcBuffIn.UseVisualStyleBackColor = True
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(626, 6)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(233, 20)
		Me.Label8.TabIndex = 29
		Me.Label8.Text = "How long till empty Buff-In"
		'
		'lblOut
		'
		Me.lblOut.Location = New System.Drawing.Point(613, 256)
		Me.lblOut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblOut.Name = "lblOut"
		Me.lblOut.Size = New System.Drawing.Size(291, 85)
		Me.lblOut.TabIndex = 30
		Me.ToolTip1.SetToolTip(Me.lblOut, "Click me to copy to clipboard")
		'
		'btnAbout
		'
		Me.btnAbout.Location = New System.Drawing.Point(460, 318)
		Me.btnAbout.Margin = New System.Windows.Forms.Padding(4)
		Me.btnAbout.Name = "btnAbout"
		Me.btnAbout.Size = New System.Drawing.Size(141, 28)
		Me.btnAbout.TabIndex = 31
		Me.btnAbout.Text = "About"
		Me.btnAbout.UseVisualStyleBackColor = True
		'
		'lblSuPerHour
		'
		Me.lblSuPerHour.AutoSize = True
		Me.lblSuPerHour.Location = New System.Drawing.Point(309, 46)
		Me.lblSuPerHour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblSuPerHour.Name = "lblSuPerHour"
		Me.lblSuPerHour.Size = New System.Drawing.Size(95, 17)
		Me.lblSuPerHour.TabIndex = 33
		Me.lblSuPerHour.Text = "SU's per hour"
		Me.lblSuPerHour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'cbKeysps
		'
		Me.cbKeysps.FormattingEnabled = True
		Me.cbKeysps.Items.AddRange(New Object() {"keys/s", "kkeys/s", "Mkeys/s", "Gkeys/s", "Tkeys/s", "Pkeys/s"})
		Me.cbKeysps.Location = New System.Drawing.Point(172, 30)
		Me.cbKeysps.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.cbKeysps.Name = "cbKeysps"
		Me.cbKeysps.Size = New System.Drawing.Size(108, 24)
		Me.cbKeysps.TabIndex = 35
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(920, 356)
		Me.Controls.Add(Me.cbKeysps)
		Me.Controls.Add(Me.btnDateStopNowStart90)
		Me.Controls.Add(Me.lblSuPerHour)
		Me.Controls.Add(Me.btnTeamPage)
		Me.Controls.Add(Me.btnAbout)
		Me.Controls.Add(Me.lblOut)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.btnCalcBuffIn)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtUnits)
		Me.Controls.Add(Me.lblSuADay)
		Me.Controls.Add(Me.chkDone)
		Me.Controls.Add(Me.chkCpu)
		Me.Controls.Add(Me.btnBuffIn)
		Me.Controls.Add(Me.btn2LineTxt)
		Me.Controls.Add(Me.lblSuDays)
		Me.Controls.Add(Me.txtSuBuffOut)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.lblSuTime)
		Me.Controls.Add(Me.lblPuSuTime)
		Me.Controls.Add(Me.nupPuTime)
		Me.Controls.Add(Me.dtpStop)
		Me.Controls.Add(Me.dtpStart)
		Me.Controls.Add(Me.chkDateStopNow)
		Me.Controls.Add(Me.chkDateStartNow)
		Me.Controls.Add(Me.btnDateStopNow90)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.btnStartNow)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtKeysS)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.Name = "frmMain"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.Text = "RC5 SU Calculator"
		CType(Me.nupPuTime, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents txtKeysS As System.Windows.Forms.TextBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents btnStartNow As System.Windows.Forms.Button
	Friend WithEvents btnDateStopNow90 As System.Windows.Forms.Button
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents chkDateStartNow As System.Windows.Forms.CheckBox
	Friend WithEvents chkDateStopNow As System.Windows.Forms.CheckBox
	Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpStop As System.Windows.Forms.DateTimePicker
	Friend WithEvents nupPuTime As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblPuSuTime As System.Windows.Forms.Label
	Friend WithEvents lblSuTime As System.Windows.Forms.Label
	Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents txtSuBuffOut As System.Windows.Forms.TextBox
	Friend WithEvents lblSuDays As System.Windows.Forms.Label
	Friend WithEvents btn2LineTxt As System.Windows.Forms.Button
	Friend WithEvents btnBuffIn As System.Windows.Forms.Button
	Friend WithEvents chkCpu As System.Windows.Forms.CheckBox
	Friend WithEvents chkDone As System.Windows.Forms.CheckBox
	Friend WithEvents lblSuADay As System.Windows.Forms.Label
	Friend WithEvents txtUnits As System.Windows.Forms.TextBox
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents btnCalcBuffIn As System.Windows.Forms.Button
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents lblOut As System.Windows.Forms.Label
	Friend WithEvents btnAbout As System.Windows.Forms.Button
	Friend WithEvents btnTeamPage As System.Windows.Forms.Button
	Friend WithEvents lblSuPerHour As System.Windows.Forms.Label
	Friend WithEvents btnDateStopNowStart90 As Button
	Friend WithEvents cbKeysps As ComboBox
End Class
