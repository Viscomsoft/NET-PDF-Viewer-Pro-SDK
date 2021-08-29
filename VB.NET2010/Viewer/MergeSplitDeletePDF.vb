Public Class MergeSplitDeletePDF

    Dim _itype As Integer
    Dim _strMergeSource1 As String
    Dim _strMergeSource2 As String
    Dim _strSplitSource As String
    Dim _iSplitStartPage As Integer

    Dim _strDeletePageSource As String
    Dim _iDeletePageNo As Integer
    Dim _strRotatePageSource As String

    Dim _iRotatePageNo As Integer
    Dim _iRotateAngle As Integer
    Dim _strCropSource As String
    Dim _iCropLeft As Integer
    Dim _iCropTop As Integer
    Dim _iCropRight As Integer
    Dim _iCropBottom As Integer
    Dim _strMergeRootTitle As String
    Dim _strMergeOutline1 As String
    Dim _strMergeOutline2 As String
    Dim _strMaskingSource As String
    Dim _iMaskingX As Integer
    Dim _iMaskingY As Integer
    Dim _iMaskingWidth As Integer
    Dim _iMaskingHeight As Integer
    Dim _iMaskingR As Integer
    Dim _iMaskingG As Integer
    Dim _iMaskingB As Integer
    Dim _iMaskingStartPage As Integer
    Dim _iMaskingEndPage As Integer




    Public Property iType() As Integer
        Get
            Return _itype
        End Get

        Set(ByVal value As Integer)
            _itype = value
        End Set
    End Property


    Public Property strMergeSource1() As String
        Get
            Return _strMergeSource1
        End Get

        Set(ByVal value As String)
            _strMergeSource1 = value
        End Set
    End Property


    Public Property strMergeSource2() As String
        Get
            Return _strMergeSource2
        End Get

        Set(ByVal value As String)
            _strMergeSource2 = value
        End Set
    End Property



    Public Property strSplitSource() As String
        Get
            Return _strSplitSource
        End Get

        Set(ByVal value As String)
            _strSplitSource = value
        End Set
    End Property

    Public Property iSplitStartPage() As Integer
        Get
            Return _iSplitStartPage
        End Get

        Set(ByVal value As Integer)
            _iSplitStartPage = value
        End Set
    End Property



    Public Property strDeletePageSource() As String
        Get
            Return _strDeletePageSource
        End Get

        Set(ByVal value As String)
            _strDeletePageSource = value
        End Set
    End Property

    Public Property iDeletePageNo() As Integer
        Get
            Return _iDeletePageNo
        End Get

        Set(ByVal value As Integer)
            _iDeletePageNo = value
        End Set
    End Property
    Public Property strRotatePageSource() As String
        Get
            Return _strRotatePageSource
        End Get

        Set(ByVal value As String)
            _strRotatePageSource = value
        End Set
    End Property



    Public Property iRotatePageNo() As Integer
        Get
            Return _iRotatePageNo
        End Get

        Set(ByVal value As Integer)
            _iRotatePageNo = value
        End Set
    End Property


    Public Property iRotateAngle() As Integer
        Get
            Return _iRotateAngle
        End Get

        Set(ByVal value As Integer)
            _iRotateAngle = value
        End Set
    End Property



    Public Property strCropSource() As String
        Get
            Return _strCropSource
        End Get

        Set(ByVal value As String)
            _strCropSource = value
        End Set
    End Property

    Public Property iCropLeft() As Integer
        Get
            Return _iCropLeft
        End Get

        Set(ByVal value As Integer)
            _iCropLeft = value
        End Set
    End Property

    Public Property iCropTop() As Integer
        Get
            Return _iCropTop
        End Get

        Set(ByVal value As Integer)
            _iCropTop = value
        End Set
    End Property

    Public Property iCropRight() As Integer
        Get
            Return _iCropRight
        End Get

        Set(ByVal value As Integer)
            _iCropRight = value
        End Set
    End Property

    Public Property iCropBottom() As Integer
        Get
            Return _iCropBottom
        End Get

        Set(ByVal value As Integer)
            _iCropBottom = value
        End Set
    End Property

    Public Property strMergeRootTitle() As String
        Get
            Return _strMergeRootTitle
        End Get

        Set(ByVal value As String)
            _strMergeRootTitle = value
        End Set
    End Property

    Public Property strMergeOutline1() As String
        Get
            Return _strMergeOutline1
        End Get

        Set(ByVal value As String)
            _strMergeOutline1 = value
        End Set
    End Property

    Public Property strMergeOutline2() As String
        Get
            Return _strMergeOutline2
        End Get

        Set(ByVal value As String)
            _strMergeOutline2 = value
        End Set
    End Property

    Public Property strMaskingSource() As String
        Get
            Return _strMaskingSource
        End Get

        Set(ByVal value As String)
            _strMaskingSource = value
        End Set
    End Property

    Public Property iMaskingX() As Integer
        Get
            Return _iMaskingX
        End Get

        Set(ByVal value As Integer)
            _iMaskingX = value
        End Set
    End Property

    Public Property iMaskingY() As Integer
        Get
            Return _iMaskingY
        End Get

        Set(ByVal value As Integer)
            _iMaskingY = value
        End Set
    End Property

    Public Property iMaskingWidth() As Integer
        Get
            Return _iMaskingWidth
        End Get

        Set(ByVal value As Integer)
            _iMaskingWidth = value
        End Set
    End Property

    Public Property iMaskingHeight() As Integer
        Get
            Return _iMaskingHeight
        End Get

        Set(ByVal value As Integer)
            _iMaskingHeight = value
        End Set
    End Property

    Public Property iMaskingB() As Integer
        Get
            Return _iMaskingB
        End Get

        Set(ByVal value As Integer)
            _iMaskingB = value
        End Set
    End Property

    Public Property iMaskingG() As Integer
        Get
            Return _iMaskingG
        End Get

        Set(ByVal value As Integer)
            _iMaskingG = value
        End Set
    End Property

    Public Property iMaskingR() As Integer
        Get
            Return _iMaskingR
        End Get

        Set(ByVal value As Integer)
            _iMaskingR = value
        End Set
    End Property



    Public Property iMaskingStartPage() As Integer
        Get
            Return _iMaskingStartPage
        End Get

        Set(ByVal value As Integer)
            _iMaskingStartPage = value
        End Set
    End Property


    Public Property iMaskingEndPage() As Integer
        Get
            Return _iMaskingEndPage
        End Get

        Set(ByVal value As Integer)
            _iMaskingEndPage = value
        End Set
    End Property
    Private Sub button1_Click(sender As System.Object, e As System.EventArgs) Handles button1.Click
        openFileDialog1.Filter = "PDF File|*.PDF||"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtmergesource1.Text = openFileDialog1.FileName

        End If
            
    End Sub

    Private Sub button2_Click(sender As System.Object, e As System.EventArgs) Handles button2.Click
        openFileDialog1.Filter = "PDF File|*.PDF||"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtmergesource2.Text = openFileDialog1.FileName

        End If

    End Sub

    Private Sub buttonmerge_Click(sender As System.Object, e As System.EventArgs) Handles buttonmerge.Click
        If txtmergesource1.Text = "" Then
            MessageBox.Show("Please select PDF 1 file")
            Return
        End If


        If txtmergesource2.Text = "" Then
            MessageBox.Show("Please select PDF 2 file")
            Return
        End If


        strMergeSource1 = txtmergesource1.Text
        strMergeSource2 = txtmergesource2.Text
        iType = 0
        DialogResult = System.Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub button3_Click(sender As System.Object, e As System.EventArgs) Handles button3.Click
        openFileDialog1.Filter = "PDF File|*.PDF||"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtsplitsource.Text = openFileDialog1.FileName

        End If

    End Sub

    Private Sub button4_Click(sender As System.Object, e As System.EventArgs) Handles button4.Click
        If txtsplitsource.Text = "" Then

            MessageBox.Show("Please select PDF File")
            Exit Sub
        End If


        strSplitSource = txtsplitsource.Text
        iSplitStartPage = txtsplitfrompage.Text
        DialogResult = System.Windows.Forms.DialogResult.OK
        iType = 1
        Close()
    End Sub

    Private Sub button5_Click(sender As System.Object, e As System.EventArgs) Handles button5.Click
        openFileDialog1.Filter = "PDF File|*.PDF||"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtdeletepagesource.Text = openFileDialog1.FileName

        End If
    End Sub

    Private Sub button6_Click(sender As System.Object, e As System.EventArgs) Handles button6.Click
        If txtdeletepagesource.Text = "" Then

            MessageBox.Show("Please select PDF File")
            Exit Sub
        End If


        strDeletePageSource = txtdeletepagesource.Text
        iDeletePageNo = txtdeletepage.Text
        DialogResult = System.Windows.Forms.DialogResult.OK
        iType = 2
        Close()
    End Sub

    Private Sub button7_Click(sender As System.Object, e As System.EventArgs) Handles button7.Click
        openFileDialog1.Filter = "PDF File|*.PDF||"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtrotatepagesource.Text = openFileDialog1.FileName

        End If

    End Sub

    Private Sub button8_Click(sender As System.Object, e As System.EventArgs) Handles button8.Click
        If txtrotatepagesource.Text = "" Then
            MessageBox.Show("Please select PDF File")
            Exit Sub
        End If


        strRotatePageSource = txtrotatepagesource.Text

        iRotatePageNo = txtrotatepage.Text
        iRotateAngle = txtrotateangle.Text
        DialogResult = System.Windows.Forms.DialogResult.OK
        If chkrotateallpages.Checked Then
            iType = 4
        Else
            iType = 3
        End If

        Close()
    End Sub

    Private Sub button9_Click(sender As System.Object, e As System.EventArgs) Handles button9.Click
        openFileDialog1.Filter = "PDF File|*.PDF||"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtcroppdfsource.Text = openFileDialog1.FileName

        End If
    End Sub

    Private Sub button10_Click(sender As System.Object, e As System.EventArgs) Handles button10.Click

        If txtcroppdfsource.Text = "" Then

            MessageBox.Show("Please select PDF File")
            Exit Sub
        End If

        strCropSource = txtcroppdfsource.Text
        iCropLeft = txtcropleft.Text
        iCropTop = txtcroptop.Text
        iCropRight = txtcropright.Text
        iCropBottom = txtcropbottom.Text

        DialogResult = System.Windows.Forms.DialogResult.OK

        iType = 5

        Close()
    End Sub

    Private Sub button13_Click(sender As System.Object, e As System.EventArgs) Handles button13.Click
        openFileDialog1.Filter = "PDF File|*.PDF||"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtmergebooksource1.Text = openFileDialog1.FileName

        End If
    End Sub

    Private Sub button12_Click(sender As System.Object, e As System.EventArgs) Handles button12.Click
        openFileDialog1.Filter = "PDF File|*.PDF||"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtmergebooksource2.Text = openFileDialog1.FileName

        End If
    End Sub

    Private Sub button11_Click(sender As System.Object, e As System.EventArgs) Handles button11.Click
        If txtmergebooksource1.Text = "" Then

            MessageBox.Show("Please select PDF 1 file")
            Exit Sub
        End If


        If txtmergebooksource2.Text = "" Then

            MessageBox.Show("Please select PDF 2 file")
            Exit Sub
        End If


        strMergeSource1 = txtmergebooksource1.Text
        strMergeSource2 = txtmergebooksource2.Text

        strMergeRootTitle = txtmergeRootTitle.Text
        strMergeOutline1 = txtmergeOutline1.Text
        strMergeOutline2 = txtmergeOutline2.Text

        iType = 6

        DialogResult = System.Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub Button34_Click(sender As System.Object, e As System.EventArgs) Handles Button34.Click
        openFileDialog1.Filter = "PDF File|*.PDF||"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtmaskingpdf.Text = openFileDialog1.FileName

        End If
    End Sub

    Private Sub Button33_Click(sender As System.Object, e As System.EventArgs) Handles Button33.Click
        If txtmaskingpdf.Text = "" Then
            MessageBox.Show("Please select PDF file")
            Return
        End If
            

        strMaskingSource = txtmaskingpdf.Text
        iMaskingX = txtmaskingX.Text
        iMaskingY = txtmaskingY.Text
        iMaskingWidth = txtmaskingWidth.Text
        iMaskingHeight = txtmaskingHeight.Text
        iMaskingR = txtmaskingR.Text
        iMaskingG = txtmaskingG.Text
        iMaskingB = txtmaskingB.Text
        iMaskingStartPage = txtmaskingStartPage.Text - 1 'first page is zero
        iMaskingEndPage = txtmaskingEndPage.Text

        If chkMaskingAllPage.Checked Then
            iMaskingStartPage = -1
            iMaskingEndPage = -1
        End If

        iType = 7
        DialogResult = System.Windows.Forms.DialogResult.OK
        Close()
    End Sub
End Class