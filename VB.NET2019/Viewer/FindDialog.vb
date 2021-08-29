Imports System.Windows.Forms

Public Class FindDialog

    Public _search As Viscomsoft.PDFViewer.TextSearch
    Public _StartPageNumber As Integer
    Public _newSearch As Boolean = True

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FindDialog_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        RemoveHandler _search.SearchProgressChanged, AddressOf Me.On_SearchProgressChanged
        RemoveHandler _search.TextFound, AddressOf Me.On_TextFound
        _search.cancelSearch()


    End Sub

    Private Sub FindDialog_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
         AddHandler _search.TextFound, AddressOf Me.On_TextFound

        AddHandler _search.SearchProgressChanged, AddressOf Me.On_SearchProgressChanged

        _search.cancelSearch()
        _StartPageNumber = 1

    End Sub
    Public Sub On_TextFound(ByVal o As Object, ByVal e As EventArgs)
        Me._StartPageNumber = _search.PageNumber

    End Sub
    Public Sub On_SearchProgressChanged(ByVal o As Object, ByVal e As Viscomsoft.PDFViewer.SearchTextEventArgs)

        If e.NotFound Then
            MessageBox.Show("No more occurrence found.", "Find Text")
            _newSearch = True
            _StartPageNumber = 1
        Else
            lblsearching.Text = "Searching: " + e.PageNumber.ToString()

        End If
      
    End Sub

    Private Sub btnnext_Click(sender As System.Object, e As System.EventArgs) Handles btnnext.Click
        If _newSearch Then
            '  _search.findText(txtFind.Text, _StartPageNumber, Viscomsoft.PDFViewer.SearchDirection.SearchForward)
            _search.findText(txtFind.Text, _StartPageNumber, 1)

        Else
            _search.findNext()
        End If
        _newSearch = False
    End Sub

    Private Sub btnprevious_Click(sender As System.Object, e As System.EventArgs) Handles btnprevious.Click
        If _newSearch Then
            _search.findText(txtFind.Text, _StartPageNumber, Viscomsoft.PDFViewer.SearchDirection.SearchBackward)
        Else
            _search.findPrevious()
        End If
        _newSearch = False
    End Sub

  
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class
