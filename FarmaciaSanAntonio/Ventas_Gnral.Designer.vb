﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas_Gnral
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelMT = New System.Windows.Forms.Panel()
        Me.tppag = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnre3 = New System.Windows.Forms.Button()
        Me.modTP = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comboV = New System.Windows.Forms.ComboBox()
        Me.PanelEM = New System.Windows.Forms.Panel()
        Me.btnmodImg = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.datadetvm = New System.Windows.Forms.DataGridView()
        Me.btnre2 = New System.Windows.Forms.Button()
        Me.btnre = New System.Windows.Forms.Button()
        Me.panelP = New System.Windows.Forms.Panel()
        Me.ELIMINA = New System.Windows.Forms.Button()
        Me.modV = New System.Windows.Forms.Button()
        Me.elimP = New System.Windows.Forms.Button()
        Me.elimM = New System.Windows.Forms.Button()
        Me.salirV = New System.Windows.Forms.Button()
        Me.consultav = New System.Windows.Forms.Button()
        Me.FECHA = New System.Windows.Forms.TextBox()
        Me.TIPOP = New System.Windows.Forms.TextBox()
        Me.IVA = New System.Windows.Forms.TextBox()
        Me.SUBTOTAL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CVEVTA = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelEP = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.datavtapro = New System.Windows.Forms.DataGridView()
        Me.btnre11 = New System.Windows.Forms.Button()
        Me.btnEDP = New System.Windows.Forms.Button()
        Me.panelET = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnre16 = New System.Windows.Forms.Button()
        Me.btneTodo = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.comboventa = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PanelMT.SuspendLayout()
        Me.PanelEM.SuspendLayout()
        CType(Me.datadetvm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelP.SuspendLayout()
        Me.panelEP.SuspendLayout()
        CType(Me.datavtapro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelET.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMT
        '
        Me.PanelMT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelMT.BackColor = System.Drawing.Color.Lavender
        Me.PanelMT.Controls.Add(Me.tppag)
        Me.PanelMT.Controls.Add(Me.Label8)
        Me.PanelMT.Controls.Add(Me.btnre3)
        Me.PanelMT.Controls.Add(Me.modTP)
        Me.PanelMT.Controls.Add(Me.Label7)
        Me.PanelMT.Controls.Add(Me.Label6)
        Me.PanelMT.Controls.Add(Me.comboV)
        Me.PanelMT.Location = New System.Drawing.Point(801, 20)
        Me.PanelMT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelMT.Name = "PanelMT"
        Me.PanelMT.Size = New System.Drawing.Size(364, 483)
        Me.PanelMT.TabIndex = 48
        Me.PanelMT.Visible = False
        '
        'tppag
        '
        Me.tppag.FormattingEnabled = True
        Me.tppag.Items.AddRange(New Object() {"EFECTIVO" & Global.Microsoft.VisualBasic.ChrW(9), "TARJETA DE DEBITO", "TARJETA DE CREDITO"})
        Me.tppag.Location = New System.Drawing.Point(120, 142)
        Me.tppag.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tppag.MaxLength = 20
        Me.tppag.Name = "tppag"
        Me.tppag.Size = New System.Drawing.Size(223, 28)
        Me.tppag.TabIndex = 51
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 146)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "TIPOPAG:"
        '
        'btnre3
        '
        Me.btnre3.BackColor = System.Drawing.Color.DarkCyan
        Me.btnre3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnre3.ForeColor = System.Drawing.Color.White
        Me.btnre3.Location = New System.Drawing.Point(72, 294)
        Me.btnre3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnre3.Name = "btnre3"
        Me.btnre3.Size = New System.Drawing.Size(232, 55)
        Me.btnre3.TabIndex = 48
        Me.btnre3.Text = "REGRESAR"
        Me.btnre3.UseVisualStyleBackColor = False
        '
        'modTP
        '
        Me.modTP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.modTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modTP.ForeColor = System.Drawing.Color.DarkCyan
        Me.modTP.Location = New System.Drawing.Point(46, 214)
        Me.modTP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.modTP.Name = "modTP"
        Me.modTP.Size = New System.Drawing.Size(304, 54)
        Me.modTP.TabIndex = 47
        Me.modTP.Text = "MODIFICAR"
        Me.modTP.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(96, 32)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "MOD. TIPO DE PAGO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 77)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "CVEVTA:"
        '
        'comboV
        '
        Me.comboV.FormattingEnabled = True
        Me.comboV.Location = New System.Drawing.Point(152, 72)
        Me.comboV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.comboV.Name = "comboV"
        Me.comboV.Size = New System.Drawing.Size(92, 28)
        Me.comboV.TabIndex = 34
        '
        'PanelEM
        '
        Me.PanelEM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEM.BackColor = System.Drawing.Color.Lavender
        Me.PanelEM.Controls.Add(Me.btnmodImg)
        Me.PanelEM.Controls.Add(Me.Label9)
        Me.PanelEM.Controls.Add(Me.datadetvm)
        Me.PanelEM.Controls.Add(Me.btnre2)
        Me.PanelEM.Controls.Add(Me.btnre)
        Me.PanelEM.Location = New System.Drawing.Point(405, 56)
        Me.PanelEM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelEM.Name = "PanelEM"
        Me.PanelEM.Size = New System.Drawing.Size(785, 512)
        Me.PanelEM.TabIndex = 49
        Me.PanelEM.Visible = False
        '
        'btnmodImg
        '
        Me.btnmodImg.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnmodImg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodImg.ForeColor = System.Drawing.Color.Black
        Me.btnmodImg.Location = New System.Drawing.Point(46, 439)
        Me.btnmodImg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnmodImg.Name = "btnmodImg"
        Me.btnmodImg.Size = New System.Drawing.Size(288, 55)
        Me.btnmodImg.TabIndex = 51
        Me.btnmodImg.Text = "MOD IMG. RECETA"
        Me.btnmodImg.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 14)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(381, 20)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "ELIMINACION DE MEDICAMENTOS EN LA VENTA"
        '
        'datadetvm
        '
        Me.datadetvm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datadetvm.Location = New System.Drawing.Point(46, 54)
        Me.datadetvm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.datadetvm.Name = "datadetvm"
        Me.datadetvm.RowHeadersWidth = 62
        Me.datadetvm.Size = New System.Drawing.Size(722, 231)
        Me.datadetvm.TabIndex = 49
        '
        'btnre2
        '
        Me.btnre2.BackColor = System.Drawing.Color.Navy
        Me.btnre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnre2.ForeColor = System.Drawing.Color.White
        Me.btnre2.Location = New System.Drawing.Point(46, 374)
        Me.btnre2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnre2.Name = "btnre2"
        Me.btnre2.Size = New System.Drawing.Size(288, 55)
        Me.btnre2.TabIndex = 48
        Me.btnre2.Text = "REGRESAR"
        Me.btnre2.UseVisualStyleBackColor = False
        '
        'btnre
        '
        Me.btnre.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnre.ForeColor = System.Drawing.Color.Black
        Me.btnre.Location = New System.Drawing.Point(46, 309)
        Me.btnre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnre.Name = "btnre"
        Me.btnre.Size = New System.Drawing.Size(288, 55)
        Me.btnre.TabIndex = 47
        Me.btnre.Text = "ELIMINAR DET."
        Me.btnre.UseVisualStyleBackColor = False
        '
        'panelP
        '
        Me.panelP.BackColor = System.Drawing.Color.Transparent
        Me.panelP.Controls.Add(Me.ELIMINA)
        Me.panelP.Controls.Add(Me.modV)
        Me.panelP.Controls.Add(Me.elimP)
        Me.panelP.Controls.Add(Me.elimM)
        Me.panelP.Controls.Add(Me.salirV)
        Me.panelP.Controls.Add(Me.consultav)
        Me.panelP.Controls.Add(Me.FECHA)
        Me.panelP.Controls.Add(Me.TIPOP)
        Me.panelP.Controls.Add(Me.IVA)
        Me.panelP.Controls.Add(Me.SUBTOTAL)
        Me.panelP.Controls.Add(Me.Label5)
        Me.panelP.Controls.Add(Me.Label4)
        Me.panelP.Controls.Add(Me.Label3)
        Me.panelP.Controls.Add(Me.Label2)
        Me.panelP.Controls.Add(Me.CVEVTA)
        Me.panelP.Controls.Add(Me.Label1)
        Me.panelP.Location = New System.Drawing.Point(5, 56)
        Me.panelP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelP.Name = "panelP"
        Me.panelP.Size = New System.Drawing.Size(380, 645)
        Me.panelP.TabIndex = 50
        '
        'ELIMINA
        '
        Me.ELIMINA.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ELIMINA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ELIMINA.ForeColor = System.Drawing.Color.Black
        Me.ELIMINA.Location = New System.Drawing.Point(4, 512)
        Me.ELIMINA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ELIMINA.Name = "ELIMINA"
        Me.ELIMINA.Size = New System.Drawing.Size(370, 55)
        Me.ELIMINA.TabIndex = 68
        Me.ELIMINA.Text = "ELIMINAR VTA"
        Me.ELIMINA.UseVisualStyleBackColor = False
        '
        'modV
        '
        Me.modV.BackColor = System.Drawing.Color.CornflowerBlue
        Me.modV.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modV.ForeColor = System.Drawing.Color.Black
        Me.modV.Location = New System.Drawing.Point(4, 318)
        Me.modV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.modV.Name = "modV"
        Me.modV.Size = New System.Drawing.Size(370, 55)
        Me.modV.TabIndex = 67
        Me.modV.Text = "MOD TIPOPAG"
        Me.modV.UseVisualStyleBackColor = False
        '
        'elimP
        '
        Me.elimP.BackColor = System.Drawing.Color.CornflowerBlue
        Me.elimP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elimP.ForeColor = System.Drawing.Color.Black
        Me.elimP.Location = New System.Drawing.Point(4, 448)
        Me.elimP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.elimP.Name = "elimP"
        Me.elimP.Size = New System.Drawing.Size(370, 55)
        Me.elimP.TabIndex = 66
        Me.elimP.Text = "DET PRODUCTO"
        Me.elimP.UseVisualStyleBackColor = False
        '
        'elimM
        '
        Me.elimM.BackColor = System.Drawing.Color.CornflowerBlue
        Me.elimM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elimM.ForeColor = System.Drawing.Color.Black
        Me.elimM.Location = New System.Drawing.Point(4, 383)
        Me.elimM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.elimM.Name = "elimM"
        Me.elimM.Size = New System.Drawing.Size(370, 55)
        Me.elimM.TabIndex = 65
        Me.elimM.Text = "DET MEDICAMENTO"
        Me.elimM.UseVisualStyleBackColor = False
        '
        'salirV
        '
        Me.salirV.BackColor = System.Drawing.Color.Navy
        Me.salirV.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salirV.ForeColor = System.Drawing.Color.White
        Me.salirV.Location = New System.Drawing.Point(4, 577)
        Me.salirV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.salirV.Name = "salirV"
        Me.salirV.Size = New System.Drawing.Size(368, 55)
        Me.salirV.TabIndex = 64
        Me.salirV.Text = "SALIR"
        Me.salirV.UseVisualStyleBackColor = False
        '
        'consultav
        '
        Me.consultav.BackColor = System.Drawing.Color.CornflowerBlue
        Me.consultav.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consultav.ForeColor = System.Drawing.Color.Black
        Me.consultav.Location = New System.Drawing.Point(4, 254)
        Me.consultav.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.consultav.Name = "consultav"
        Me.consultav.Size = New System.Drawing.Size(370, 55)
        Me.consultav.TabIndex = 63
        Me.consultav.Text = "CONSULTAR"
        Me.consultav.UseVisualStyleBackColor = False
        '
        'FECHA
        '
        Me.FECHA.Location = New System.Drawing.Point(136, 180)
        Me.FECHA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FECHA.Name = "FECHA"
        Me.FECHA.Size = New System.Drawing.Size(236, 26)
        Me.FECHA.TabIndex = 62
        '
        'TIPOP
        '
        Me.TIPOP.Location = New System.Drawing.Point(136, 145)
        Me.TIPOP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TIPOP.Name = "TIPOP"
        Me.TIPOP.Size = New System.Drawing.Size(236, 26)
        Me.TIPOP.TabIndex = 61
        '
        'IVA
        '
        Me.IVA.Location = New System.Drawing.Point(136, 100)
        Me.IVA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IVA.Name = "IVA"
        Me.IVA.Size = New System.Drawing.Size(236, 26)
        Me.IVA.TabIndex = 60
        '
        'SUBTOTAL
        '
        Me.SUBTOTAL.Location = New System.Drawing.Point(136, 62)
        Me.SUBTOTAL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SUBTOTAL.Name = "SUBTOTAL"
        Me.SUBTOTAL.Size = New System.Drawing.Size(236, 26)
        Me.SUBTOTAL.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 185)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "FECHAVTA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 148)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "TIPOPAG:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "IVA ($)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "SUBTOTAL ($)"
        '
        'CVEVTA
        '
        Me.CVEVTA.FormattingEnabled = True
        Me.CVEVTA.Location = New System.Drawing.Point(136, 20)
        Me.CVEVTA.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CVEVTA.Name = "CVEVTA"
        Me.CVEVTA.Size = New System.Drawing.Size(180, 28)
        Me.CVEVTA.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "CVEVTA:"
        '
        'panelEP
        '
        Me.panelEP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelEP.BackColor = System.Drawing.Color.Lavender
        Me.panelEP.Controls.Add(Me.Label10)
        Me.panelEP.Controls.Add(Me.datavtapro)
        Me.panelEP.Controls.Add(Me.btnre11)
        Me.panelEP.Controls.Add(Me.btnEDP)
        Me.panelEP.Location = New System.Drawing.Point(421, 55)
        Me.panelEP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelEP.Name = "panelEP"
        Me.panelEP.Size = New System.Drawing.Size(770, 546)
        Me.panelEP.TabIndex = 51
        Me.panelEP.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(56, 14)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(352, 20)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "ELIMINACION DE PRODUCTOS EN LA VENTA"
        '
        'datavtapro
        '
        Me.datavtapro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datavtapro.Location = New System.Drawing.Point(46, 54)
        Me.datavtapro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.datavtapro.Name = "datavtapro"
        Me.datavtapro.RowHeadersWidth = 62
        Me.datavtapro.Size = New System.Drawing.Size(722, 231)
        Me.datavtapro.TabIndex = 49
        '
        'btnre11
        '
        Me.btnre11.BackColor = System.Drawing.Color.DarkBlue
        Me.btnre11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnre11.ForeColor = System.Drawing.Color.White
        Me.btnre11.Location = New System.Drawing.Point(46, 374)
        Me.btnre11.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnre11.Name = "btnre11"
        Me.btnre11.Size = New System.Drawing.Size(288, 55)
        Me.btnre11.TabIndex = 48
        Me.btnre11.Text = "REGRESAR"
        Me.btnre11.UseVisualStyleBackColor = False
        '
        'btnEDP
        '
        Me.btnEDP.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEDP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEDP.ForeColor = System.Drawing.Color.Black
        Me.btnEDP.Location = New System.Drawing.Point(46, 309)
        Me.btnEDP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEDP.Name = "btnEDP"
        Me.btnEDP.Size = New System.Drawing.Size(288, 55)
        Me.btnEDP.TabIndex = 47
        Me.btnEDP.Text = "ELIMINAR DET."
        Me.btnEDP.UseVisualStyleBackColor = False
        '
        'panelET
        '
        Me.panelET.BackColor = System.Drawing.Color.Lavender
        Me.panelET.Controls.Add(Me.Label12)
        Me.panelET.Controls.Add(Me.btnre16)
        Me.panelET.Controls.Add(Me.btneTodo)
        Me.panelET.Controls.Add(Me.Label11)
        Me.panelET.Controls.Add(Me.comboventa)
        Me.panelET.Location = New System.Drawing.Point(777, 55)
        Me.panelET.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelET.Name = "panelET"
        Me.panelET.Size = New System.Drawing.Size(414, 326)
        Me.panelET.TabIndex = 52
        Me.panelET.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(130, 37)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 20)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "ELIMINAR VENTAS"
        '
        'btnre16
        '
        Me.btnre16.BackColor = System.Drawing.Color.DarkBlue
        Me.btnre16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnre16.ForeColor = System.Drawing.Color.White
        Me.btnre16.Location = New System.Drawing.Point(66, 229)
        Me.btnre16.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnre16.Name = "btnre16"
        Me.btnre16.Size = New System.Drawing.Size(288, 55)
        Me.btnre16.TabIndex = 58
        Me.btnre16.Text = "REGRESAR"
        Me.btnre16.UseVisualStyleBackColor = False
        '
        'btneTodo
        '
        Me.btneTodo.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btneTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneTodo.ForeColor = System.Drawing.Color.Black
        Me.btneTodo.Location = New System.Drawing.Point(66, 152)
        Me.btneTodo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btneTodo.Name = "btneTodo"
        Me.btneTodo.Size = New System.Drawing.Size(288, 55)
        Me.btneTodo.TabIndex = 57
        Me.btneTodo.Text = "ELIMINAR"
        Me.btneTodo.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(52, 102)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 20)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "CVEVTA:"
        '
        'comboventa
        '
        Me.comboventa.FormattingEnabled = True
        Me.comboventa.Location = New System.Drawing.Point(168, 97)
        Me.comboventa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.comboventa.Name = "comboventa"
        Me.comboventa.Size = New System.Drawing.Size(180, 28)
        Me.comboventa.TabIndex = 55
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 52)
        Me.Panel1.TabIndex = 80
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(5, 1)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(436, 46)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Farmacia San Antonio"
        '
        'Ventas_Gnral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 707)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelET)
        Me.Controls.Add(Me.panelEP)
        Me.Controls.Add(Me.panelP)
        Me.Controls.Add(Me.PanelEM)
        Me.Controls.Add(Me.PanelMT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Ventas_Gnral"
        Me.Text = "Ventas"
        Me.PanelMT.ResumeLayout(False)
        Me.PanelMT.PerformLayout()
        Me.PanelEM.ResumeLayout(False)
        Me.PanelEM.PerformLayout()
        CType(Me.datadetvm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelP.ResumeLayout(False)
        Me.panelP.PerformLayout()
        Me.panelEP.ResumeLayout(False)
        Me.panelEP.PerformLayout()
        CType(Me.datavtapro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelET.ResumeLayout(False)
        Me.panelET.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMT As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents comboV As ComboBox
    Friend WithEvents btnre3 As Button
    Friend WithEvents modTP As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tppag As ComboBox
    Friend WithEvents PanelEM As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents datadetvm As DataGridView
    Friend WithEvents btnre2 As Button
    Friend WithEvents btnre As Button
    Friend WithEvents panelP As Panel
    Friend WithEvents modV As Button
    Friend WithEvents elimP As Button
    Friend WithEvents elimM As Button
    Friend WithEvents salirV As Button
    Friend WithEvents consultav As Button
    Friend WithEvents FECHA As TextBox
    Friend WithEvents TIPOP As TextBox
    Friend WithEvents IVA As TextBox
    Friend WithEvents SUBTOTAL As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CVEVTA As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents panelEP As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents datavtapro As DataGridView
    Friend WithEvents btnre11 As Button
    Friend WithEvents btnEDP As Button
    Friend WithEvents ELIMINA As Button
    Friend WithEvents panelET As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents btnre16 As Button
    Friend WithEvents btneTodo As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents comboventa As ComboBox
    Friend WithEvents btnmodImg As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
End Class
