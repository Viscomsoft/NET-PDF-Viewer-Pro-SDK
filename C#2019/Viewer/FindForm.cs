using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Viscomsoft.PDFViewer;

namespace PDFViewerDemo
{
    public partial class FindForm : Form
    {
        public int StartPageNumber { get; set; }

        private TextSearch _searcher;
        private bool _newSearch = true;

        public FindForm(TextSearch textSearch)
        {
            InitializeComponent();

            _searcher = textSearch;
            _searcher.SearchProgressChanged += new EventHandler<SearchTextEventArgs>(_searcher_SearchProgressChanged);
            _searcher.TextFound += new EventHandler(_searcher_TextFound);
            uiFindText.Text = _searcher.Text;

            this.StartPageNumber = 1;
        }

        void _searcher_TextFound(object sender, EventArgs e)
        {
            this.StartPageNumber = _searcher.PageNumber;
        }

        void _searcher_SearchProgressChanged(object sender, SearchTextEventArgs e)
        {
            if (e.NotFound)
                showNotFound();
            else
                uiSearching.Text = "Searching: " + e.PageNumber;
        }

        
        private void uiFindPrev_Click(object sender, EventArgs e)
        {
            if (_newSearch)
                _searcher.findText(uiFindText.Text, this.StartPageNumber, SearchDirection.SearchBackward);
            else
                _searcher.findPrevious();

            _newSearch = false;
        }

        private void uiFindNext_Click(object sender, EventArgs e)
        {
            bool result;
            if (_newSearch)
                _searcher.findText(uiFindText.Text, this.StartPageNumber, SearchDirection.SearchForward);
            else
                _searcher.findNext();

            _newSearch = false;
        }

        private void uiCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showNotFound()
        {
            MessageBox.Show("No more occurrence found.", "Find Text");
        }

        private void uiFindText_TextChanged(object sender, EventArgs e)
        {
            _newSearch = true;
        }

        private void FindForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _searcher.SearchProgressChanged -= new EventHandler<SearchTextEventArgs>(_searcher_SearchProgressChanged);
            _searcher.TextFound -= new EventHandler(_searcher_TextFound);
            _searcher.cancelSearch();
        }
    }
}
