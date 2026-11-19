<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalculatorForm))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDivInt = New System.Windows.Forms.Button()
        Me.btnDivDec = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnSqrRoot = New System.Windows.Forms.Button()
        Me.btnMIn = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnFloor = New System.Windows.Forms.Button()
        Me.btnPow = New System.Windows.Forms.Button()
        Me.btnCeiling = New System.Windows.Forms.Button()
        Me.btnRnd1 = New System.Windows.Forms.Button()
        Me.btnRnd2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ImageKey = "plus (3).png"
        Me.btnAdd.ImageList = Me.ImageList1
        Me.btnAdd.Location = New System.Drawing.Point(55, 223)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(60, 50)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSub
        '
        Me.btnSub.BackColor = System.Drawing.Color.White
        Me.btnSub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSub.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub.ImageKey = "subtraction logo.png"
        Me.btnSub.ImageList = Me.ImageList1
        Me.btnSub.Location = New System.Drawing.Point(121, 223)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(60, 50)
        Me.btnSub.TabIndex = 3
        Me.btnSub.UseVisualStyleBackColor = False
        '
        'btnMulti
        '
        Me.btnMulti.BackColor = System.Drawing.Color.White
        Me.btnMulti.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulti.ImageKey = "multiplication logo.png"
        Me.btnMulti.ImageList = Me.ImageList1
        Me.btnMulti.Location = New System.Drawing.Point(186, 223)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(60, 50)
        Me.btnMulti.TabIndex = 4
        Me.btnMulti.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "subtraction logo.png")
        Me.ImageList1.Images.SetKeyName(1, "multiplication logo.png")
        Me.ImageList1.Images.SetKeyName(2, "div logo.png")
        Me.ImageList1.Images.SetKeyName(3, "div dec logo.png")
        Me.ImageList1.Images.SetKeyName(4, "plus (3).png")
        '
        'btnDivInt
        '
        Me.btnDivInt.BackColor = System.Drawing.Color.White
        Me.btnDivInt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDivInt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivInt.ImageList = Me.ImageList1
        Me.btnDivInt.Location = New System.Drawing.Point(121, 280)
        Me.btnDivInt.Name = "btnDivInt"
        Me.btnDivInt.Size = New System.Drawing.Size(60, 50)
        Me.btnDivInt.TabIndex = 6
        Me.btnDivInt.Text = "Div"
        Me.btnDivInt.UseVisualStyleBackColor = False
        '
        'btnDivDec
        '
        Me.btnDivDec.BackColor = System.Drawing.Color.White
        Me.btnDivDec.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivDec.ImageKey = "div logo.png"
        Me.btnDivDec.ImageList = Me.ImageList1
        Me.btnDivDec.Location = New System.Drawing.Point(55, 280)
        Me.btnDivDec.Name = "btnDivDec"
        Me.btnDivDec.Size = New System.Drawing.Size(60, 50)
        Me.btnDivDec.TabIndex = 5
        Me.btnDivDec.UseVisualStyleBackColor = False
        '
        'btnMod
        '
        Me.btnMod.BackColor = System.Drawing.Color.White
        Me.btnMod.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod.Location = New System.Drawing.Point(187, 279)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(60, 50)
        Me.btnMod.TabIndex = 7
        Me.btnMod.Text = "Mod"
        Me.btnMod.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(55, 557)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(52, 40)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(194, 557)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(52, 40)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblNumber1
        '
        Me.lblNumber1.AutoSize = True
        Me.lblNumber1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber1.Location = New System.Drawing.Point(112, 91)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(69, 17)
        Me.lblNumber1.TabIndex = 8
        Me.lblNumber1.Text = "Number 1"
        '
        'lblNumber2
        '
        Me.lblNumber2.AutoSize = True
        Me.lblNumber2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber2.Location = New System.Drawing.Point(112, 148)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(69, 17)
        Me.lblNumber2.TabIndex = 9
        Me.lblNumber2.Text = "Number 2"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(126, 499)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(46, 17)
        Me.lblResult.TabIndex = 10
        Me.lblResult.Text = "Result"
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(55, 526)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(191, 25)
        Me.txtResult.TabIndex = 11
        '
        'txtNumber2
        '
        Me.txtNumber2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber2.Location = New System.Drawing.Point(55, 168)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(191, 25)
        Me.txtNumber2.TabIndex = 1
        '
        'txtNumber1
        '
        Me.txtNumber1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber1.Location = New System.Drawing.Point(55, 111)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(191, 25)
        Me.txtNumber1.TabIndex = 0
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(-9, -2)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(311, 72)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Calculator"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSqrRoot
        '
        Me.btnSqrRoot.BackColor = System.Drawing.Color.White
        Me.btnSqrRoot.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSqrRoot.Location = New System.Drawing.Point(186, 335)
        Me.btnSqrRoot.Name = "btnSqrRoot"
        Me.btnSqrRoot.Size = New System.Drawing.Size(60, 50)
        Me.btnSqrRoot.TabIndex = 10
        Me.btnSqrRoot.Text = "Sqrt"
        Me.btnSqrRoot.UseVisualStyleBackColor = False
        '
        'btnMIn
        '
        Me.btnMIn.BackColor = System.Drawing.Color.White
        Me.btnMIn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMIn.ImageList = Me.ImageList1
        Me.btnMIn.Location = New System.Drawing.Point(121, 335)
        Me.btnMIn.Name = "btnMIn"
        Me.btnMIn.Size = New System.Drawing.Size(60, 50)
        Me.btnMIn.TabIndex = 9
        Me.btnMIn.Text = "Min"
        Me.btnMIn.UseVisualStyleBackColor = False
        '
        'btnMax
        '
        Me.btnMax.BackColor = System.Drawing.Color.White
        Me.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMax.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMax.ImageList = Me.ImageList1
        Me.btnMax.Location = New System.Drawing.Point(55, 335)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(60, 50)
        Me.btnMax.TabIndex = 8
        Me.btnMax.Text = "Max"
        Me.btnMax.UseVisualStyleBackColor = False
        '
        'btnFloor
        '
        Me.btnFloor.BackColor = System.Drawing.Color.White
        Me.btnFloor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFloor.Location = New System.Drawing.Point(187, 391)
        Me.btnFloor.Name = "btnFloor"
        Me.btnFloor.Size = New System.Drawing.Size(60, 50)
        Me.btnFloor.TabIndex = 13
        Me.btnFloor.Text = "⌊x⌋"
        Me.btnFloor.UseVisualStyleBackColor = False
        '
        'btnPow
        '
        Me.btnPow.BackColor = System.Drawing.Color.White
        Me.btnPow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPow.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPow.ImageList = Me.ImageList1
        Me.btnPow.Location = New System.Drawing.Point(55, 392)
        Me.btnPow.Name = "btnPow"
        Me.btnPow.Size = New System.Drawing.Size(60, 50)
        Me.btnPow.TabIndex = 11
        Me.btnPow.Text = "^"
        Me.btnPow.UseVisualStyleBackColor = False
        '
        'btnCeiling
        '
        Me.btnCeiling.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCeiling.Location = New System.Drawing.Point(121, 391)
        Me.btnCeiling.Name = "btnCeiling"
        Me.btnCeiling.Size = New System.Drawing.Size(60, 50)
        Me.btnCeiling.TabIndex = 12
        Me.btnCeiling.Text = "⌈x⌉"
        Me.btnCeiling.UseVisualStyleBackColor = True
        '
        'btnRnd1
        '
        Me.btnRnd1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRnd1.Location = New System.Drawing.Point(57, 446)
        Me.btnRnd1.Name = "btnRnd1"
        Me.btnRnd1.Size = New System.Drawing.Size(93, 36)
        Me.btnRnd1.TabIndex = 14
        Me.btnRnd1.Text = "Random(0-100)"
        Me.btnRnd1.UseVisualStyleBackColor = True
        '
        'btnRnd2
        '
        Me.btnRnd2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRnd2.Location = New System.Drawing.Point(156, 446)
        Me.btnRnd2.Name = "btnRnd2"
        Me.btnRnd2.Size = New System.Drawing.Size(90, 36)
        Me.btnRnd2.TabIndex = 15
        Me.btnRnd2.Text = "Random(1-100)"
        Me.btnRnd2.UseVisualStyleBackColor = True
        '
        'CalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 600)
        Me.Controls.Add(Me.btnRnd2)
        Me.Controls.Add(Me.btnRnd1)
        Me.Controls.Add(Me.btnCeiling)
        Me.Controls.Add(Me.btnFloor)
        Me.Controls.Add(Me.btnPow)
        Me.Controls.Add(Me.btnSqrRoot)
        Me.Controls.Add(Me.btnMIn)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblNumber2)
        Me.Controls.Add(Me.lblNumber1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnDivDec)
        Me.Controls.Add(Me.btnDivInt)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnAdd)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CalculatorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CalculatorForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btnMulti As Button
    Friend WithEvents btnDivInt As Button
    Friend WithEvents btnDivDec As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblNumber1 As Label
    Friend WithEvents lblNumber2 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnSqrRoot As Button
    Friend WithEvents btnMIn As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnFloor As Button
    Friend WithEvents btnPow As Button
    Friend WithEvents btnCeiling As Button
    Friend WithEvents btnRnd1 As Button
    Friend WithEvents btnRnd2 As Button
End Class
