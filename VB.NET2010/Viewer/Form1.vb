
Imports Viscomsoft.PDFViewer
Public Class Form1


    Dim _pdfviewer As New PDFView



    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "All Supported Files|*.PDF;*.tif;*.tiff;*.jpg;*.png*.oxps| PDF Files (*.PDF)|*.PDF|TIFF Files (*.tif)|*.tif;*.tiff|JPEG File(*.jpg)|*.jpg|PNG File(*.png)|*.png|XPS document(*.oxps)|*.oxps||"

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Dim doc As New PDFDocument
            If doc.open(OpenFileDialog1.FileName) Then
                    _pdfviewer.Document = doc
                _pdfviewer.ContinuousPages = False

                _pdfviewer.gotoPage(1)
              
            
            Else
                doc.close()


            End If
        End If

    End Sub

    Private Sub resizeCanvas()
        If Not IsNothing(_pdfviewer) Then
            _pdfviewer.Canvas.Size = New Size(Me.ClientSize.Width, Me.ClientSize.Height - 24)
        End If

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not IsNothing(_pdfviewer.Document) Then
            _pdfviewer.Document.close()
        End If

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Up Then

            _pdfviewer.zoomIn()

        End If

        If e.KeyCode = Keys.Down Then

            _pdfviewer.zoomOut()

        End If



        If e.KeyCode = Keys.D1 Then _pdfviewer.Zoom = Zoom.Percent25

        If e.KeyCode = Keys.D2 Then _pdfviewer.Zoom = Zoom.Percent50

        If e.KeyCode = Keys.D3 Then _pdfviewer.Zoom = Zoom.Percent100

        If e.KeyCode = Keys.D4 Then _pdfviewer.Zoom = Zoom.Percent200


    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        _pdfviewer.Canvas.Parent = Me

        _pdfviewer.Canvas.Location = New Point(0, 24)
        AddHandler _pdfviewer.PageChanged, AddressOf Me.pdf_PageChanged
        'let scrolling the pdf file using the mouse wheel 
        _pdfviewer.Canvas.Select()


        resizeCanvas()

    End Sub

    Public Sub pdf_PageChanged(ByVal o As Object, ByVal e As EventArgs)
        Dim doc As PDFDocument
        doc = _pdfviewer.Document

        If Not IsNothing(doc) Then
            Me.Text = doc.FileName + " [" + _pdfviewer.CurrentPage.ToString + "/" + doc.PageCount.ToString + "]"

        End If

    End Sub

   

    Private Sub Form1_MenuComplete(sender As Object, e As System.EventArgs) Handles Me.MenuComplete

    End Sub

    Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize

        resizeCanvas()
    End Sub



    Private Sub ExitToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click

        Dim doc As PDFDocument
        doc = _pdfviewer.Document
        If IsNothing(doc) Then
            Exit Sub
        End If

        Dim info As String = "Format: "
        info += doc.PDFVersion.ToString() + Chr(10) + Chr(13)
        info += "Producer: "
        info += doc.PDFProducer + Chr(10) + Chr(13)
        info += "File Name: "
        info += doc.FileName + Chr(10) + Chr(13)
        info += "File Size: "
        info += doc.FileSize.ToString() + Chr(10) + Chr(13)
        info += "Pages: "
        info += doc.PageCount.ToString() + Chr(10) + Chr(13)
        info += "Created: "
        info += doc.Created + Chr(10) + Chr(13)
        info += "Modified: "
        info += doc.Modified + Chr(10) + Chr(13)

        Dim page As New PDFPage(doc)
        page.load(1)
        info += "Page Size: "
        info += page.PageSize

        MessageBox.Show(info)

        page.unload(doc, True)

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        If Not IsNothing(_pdfviewer.Document) Then
            _pdfviewer.Document.print(_pdfviewer.CurrentPage)
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SinglePageToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SinglePageToolStripMenuItem.Click
        uncheckViewMenuItems()
        SinglePageToolStripMenuItem.Checked = True
        _pdfviewer.View = View.SinglePage

    End Sub

    Private Sub FacingToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FacingToolStripMenuItem.Click
        uncheckViewMenuItems()
        FacingToolStripMenuItem.Checked = True
        _pdfviewer.View = View.Facing
    End Sub

    Private Sub uncheckViewMenuItems()
        SinglePageToolStripMenuItem.Checked = False
        FacingToolStripMenuItem.Checked = False
        BookViewToolStripMenuItem.Checked = False
    End Sub

    Private Sub onFitPage(sender As System.Object, e As System.EventArgs) Handles FitPageToolStripMenuItem.Click
        uncheckZoomMenuItems()
        FitPageToolStripMenuItem.Checked = True
        _pdfviewer.Zoom = Zoom.FitPage
    End Sub

    Private Sub onActualSize(sender As System.Object, e As System.EventArgs) Handles ActualSizeToolStripMenuItem.Click
        uncheckZoomMenuItems()
        ActualSizeToolStripMenuItem.Checked = True
        _pdfviewer.Zoom = Zoom.ActualSize
    End Sub

    Private Sub onFitWidth(sender As System.Object, e As System.EventArgs) Handles FitToolStripMenuItem.Click
        uncheckZoomMenuItems()
        FitToolStripMenuItem.Checked = True
        _pdfviewer.Zoom = Zoom.FitWidth
    End Sub

    Private Sub onFitContent(sender As System.Object, e As System.EventArgs) Handles FitContentToolStripMenuItem.Click
        uncheckZoomMenuItems()
        FitContentToolStripMenuItem.Checked = True
        _pdfviewer.Zoom = Zoom.FitContent
    End Sub

    Private Sub onZoom200Percent(sender As System.Object, e As System.EventArgs) Handles MenuItem200Percent.Click
        uncheckZoomMenuItems()
        MenuItem200Percent.Checked = True
        _pdfviewer.Zoom = Zoom.Percent200
    End Sub

    Private Sub onZoom100Percent(sender As System.Object, e As System.EventArgs) Handles MenuItem100Percent.Click
        uncheckZoomMenuItems()
        MenuItem100Percent.Checked = True
        _pdfviewer.Zoom = Zoom.Percent100
    End Sub

    Private Sub onZoom50Percent(sender As System.Object, e As System.EventArgs) Handles MenuItem50Percent.Click
        uncheckZoomMenuItems()
        MenuItem50Percent.Checked = True
        _pdfviewer.Zoom = Zoom.Percent50
    End Sub

    Private Sub onZoom25Percent(sender As System.Object, e As System.EventArgs) Handles MenuItem25Percent.Click
        uncheckZoomMenuItems()
        MenuItem25Percent.Checked = True
        _pdfviewer.Zoom = Zoom.Percent25
    End Sub

    Private Sub onZoomIn(sender As System.Object, e As System.EventArgs) Handles ZoomInToolStripMenuItem.Click
        _pdfviewer.zoomIn()
    End Sub

    Private Sub onZoomOut(sender As System.Object, e As System.EventArgs) Handles ZoomOutToolStripMenuItem.Click
        _pdfviewer.zoomOut()
    End Sub

    Private Sub uncheckZoomMenuItems()
        FitPageToolStripMenuItem.Checked = False
        ActualSizeToolStripMenuItem.Checked = False
        FitToolStripMenuItem.Checked = False
        FitContentToolStripMenuItem.Checked = False
        MenuItem200Percent.Checked = False
        MenuItem100Percent.Checked = False
        MenuItem50Percent.Checked = False
        MenuItem25Percent.Checked = False

    End Sub

    Private Sub onNextPage(sender As System.Object, e As System.EventArgs) Handles NexPageToolStripMenuItem.Click
        _pdfviewer.nextPage()
    End Sub

    Private Sub onPreviousPage(sender As System.Object, e As System.EventArgs) Handles PreviousPageToolStripMenuItem.Click
        _pdfviewer.previousPage()
    End Sub

    Private Sub onFullscreen(sender As System.Object, e As System.EventArgs) Handles FullScreenToolStripMenuItem.Click

        _pdfviewer.fullscreen()

    End Sub

    Private Sub onGotoPage(sender As System.Object, e As System.EventArgs) Handles PageToolStripMenuItem.Click
        Dim frm As New Dialog1()
        frm.ShowDialog()
        _pdfviewer.gotoPage(frm.PageNumber)
    End Sub

    Private Sub BookViewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BookViewToolStripMenuItem.Click
        uncheckViewMenuItems()
        BookViewToolStripMenuItem.Checked = True
        _pdfviewer.View = View.BookView
    End Sub

    Private Sub ContinuousToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContinuousToolStripMenuItem.Click

        If ContinuousToolStripMenuItem.Checked Then
            ContinuousToolStripMenuItem.Checked = False
        Else
            ContinuousToolStripMenuItem.Checked = True

        End If

        _pdfviewer.ContinuousPages = ContinuousToolStripMenuItem.Checked
    End Sub

    Private Sub ZoomToolStripMenuItem_DropDownOpening(sender As System.Object, e As System.EventArgs) Handles ZoomToolStripMenuItem.DropDownOpening
        uncheckZoomMenuItems()
        Select Case _pdfviewer.Zoom
            Case Zoom.FitPage
                FitPageToolStripMenuItem.Checked = True
            Case Zoom.Percent100
            Case Zoom.ActualSize
                ActualSizeToolStripMenuItem.Checked = True
                MenuItem100Percent.Checked = True

            Case Zoom.FitWidth
                FitToolStripMenuItem.Checked = True

            Case Zoom.FitContent
                FitContentToolStripMenuItem.Checked = True

            Case Zoom.Percent200
                MenuItem200Percent.Checked = True

            Case Zoom.Percent50
                MenuItem50Percent.Checked = True

            Case Zoom.Percent25
                MenuItem25Percent.Checked = True


        End Select
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FindToolStripMenuItem.Click
        Dim frm As New FindDialog

        frm._search = _pdfviewer.TextSearch
    
        frm.ShowDialog()

    End Sub

    Private Sub HighlightColorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HighlightColorToolStripMenuItem.Click
        ColorDialog1.Color = _pdfviewer.HighlightColor
        If ColorDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            _pdfviewer.HighlightColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub SaveTextToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveTextToolStripMenuItem.Click

        If IsNothing(_pdfviewer.Document) Then
            Exit Sub
        End If


        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            _pdfviewer.Document.saveText(SaveFileDialog1.FileName)
        End If

        End Sub

    Private Sub ExportAllPageToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportAllPageToolStripMenuItem.Click

        If IsNothing(_pdfviewer.Document) Then
            Exit Sub
        End If

        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If _pdfviewer.Document.ExportAllPages(FolderBrowserDialog1.SelectedPath, 4) Then
                MessageBox.Show("Export all pages completed")
            Else
                MessageBox.Show("Export failed")
            End If

        End If


    End Sub

    Private Sub ExportPageToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExportPageToolStripMenuItem.Click
        Dim ExportPage As New ExportPage
        ExportPage.ShowDialog()


        SaveFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If _pdfviewer.Document.ExportPage(SaveFileDialog1.FileName, ExportPage.iSelPageNumber, 4) Then
                MessageBox.Show("Export pages completed")
            Else
                MessageBox.Show("Export failed")
            End If
        End If


    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim frm As New MergeSplitDeletePDF



        If frm.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Exit Sub


        If frm.iType = 0 Then

            SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then


                If _pdfviewer.MergePDF(frm.strMergeSource1, frm.strMergeSource2, SaveFileDialog1.FileName) Then
                    MessageBox.Show("Merge completed")
                Else
                    MessageBox.Show("Merge failed")


                End If
            End If

        ElseIf frm.iType = 1 Then
            SaveFileDialog1.Filter = "PDF Files 1  (*.pdf)|*.pdf"
            SaveFileDialog2.Filter = "PDF Files 2  (*.pdf)|*.pdf"

            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

                If SaveFileDialog2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

                    If frm.iSplitStartPage = 1 Then frm.iSplitStartPage = 2 'at least split from page 2 


                    If _pdfviewer.SplitPDF(frm.strSplitSource, frm.iSplitStartPage - 1, SaveFileDialog1.FileName, SaveFileDialog2.FileName) Then

                        MessageBox.Show("Split completed")
                    Else
                        MessageBox.Show("Split failed")


                    End If
                End If
            End If


        ElseIf frm.iType = 2 Then

            If _pdfviewer.DeletePDFPage(frm.strDeletePageSource, frm.iDeletePageNo - 1) Then
                MessageBox.Show("Delete Page completed")
            Else
                MessageBox.Show("Delete Page failed")

            End If

        ElseIf frm.iType = 3 Then

            SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then


                If _pdfviewer.RotatePDF(frm.strRotatePageSource, SaveFileDialog1.FileName, frm.iRotatePageNo - 1, frm.iRotateAngle) Then
                    MessageBox.Show("Rotate Page completed")
                Else
                    MessageBox.Show("Rotate Page failed")


                End If
            End If

        ElseIf frm.iType = 4 Then

            SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then


                If _pdfviewer.RotatePDFAllPage(frm.strRotatePageSource, SaveFileDialog1.FileName, frm.iRotateAngle) Then
                    MessageBox.Show("Rotate All Pages completed")
                Else
                    MessageBox.Show("Rotate All Pages failed")


                End If
            End If


        ElseIf frm.iType = 5 Then

            SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then


                If _pdfviewer.CropPDF(frm.strCropSource, frm.iCropLeft, frm.iCropTop, frm.iCropRight, frm.iCropBottom, SaveFileDialog1.FileName) Then
                    MessageBox.Show("Crop PDF completed")
                Else
                    MessageBox.Show("Crop PDF failed")


                End If
            End If


        ElseIf frm.iType = 6 Then

            SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then


                If _pdfviewer.MergePDFWithBookmarks(frm.strMergeSource1, frm.strMergeSource2, SaveFileDialog1.FileName, frm.strMergeRootTitle, frm.strMergeOutline1, frm.strMergeOutline2) Then
                    MessageBox.Show("Merge PDF with bookmark completed")
                Else
                    MessageBox.Show("Merge PDF with bookmark failed")
                End If
            End If

        ElseIf frm.iType = 7 Then

            SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then


                If _pdfviewer.MaskingPDF(frm.strMaskingSource, SaveFileDialog1.FileName, frm.iMaskingStartPage, frm.iMaskingEndPage, frm.iMaskingX, frm.iMaskingY, frm.iMaskingWidth, frm.iMaskingHeight, frm.iMaskingR, frm.iMaskingG, frm.iMaskingB) Then
                    MessageBox.Show("Masking PDF completed")
                Else
                    MessageBox.Show("Masking PDF failed")
                End If
            End If

        End If

    End Sub
End Class
