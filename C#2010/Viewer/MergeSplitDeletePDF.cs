using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDFViewerDemo
{
    public partial class MergeSplitDeletePDF : Form
    {
        public int iType { get; set; }
        public string strMergeSource1 { get; set; }
        public string strMergeSource2 { get; set; }

        public string strSplitSource { get; set; }
        public int iSplitStartPage { get; set; }

        public string strDeletePageSource { get; set; }
        public int iDeletePageNo { get; set; }

        public string strRotatePageSource { get; set; }
       
        public int iRotatePageNo { get; set; }
        public int iRotateAngle { get; set; }

        public string strCropSource { get; set; }
        public int iCropLeft { get; set; }
        public int iCropTop { get; set; }
        public int iCropRight { get; set; }
        public int iCropBottom { get; set; }

        public string strMergeRootTitle { get; set; }
        public string strMergeOutline1 { get; set; }
        public string strMergeOutline2 { get; set; }


        public string strMaskingSource { get; set; }
        public int iMaskingX { get; set; }
        public int iMaskingY { get; set; }
        public int iMaskingWidth { get; set; }
        public int iMaskingHeight { get; set; }
        public int iMaskingR { get; set; }
        public int iMaskingG { get; set; }
        public int iMaskingB { get; set; }
        public int iMaskingStartPage { get; set; }
        public int iMaskingEndPage { get; set; }
        








        public MergeSplitDeletePDF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              openFileDialog1.Filter = "PDF File|*.PDF||";
              if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
              {
                  txtmergesource1.Text = openFileDialog1.FileName;
              }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File|*.PDF||";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtmergesource2.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File|*.PDF||";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
              txtsplitsource.Text = openFileDialog1.FileName;
            }
         
        }

        private void buttonmerge_Click(object sender, EventArgs e)
        {
            if (txtmergesource1.Text == "")
            {
                MessageBox.Show("Please select PDF 1 file");
                return;
            }

            if (txtmergesource2.Text == "")
            {
                MessageBox.Show("Please select PDF 2 file");
                return;
            }

            strMergeSource1 = txtmergesource1.Text;
            strMergeSource2 = txtmergesource2.Text;
            iType = 0;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtsplitsource.Text == "")
            {
                MessageBox.Show("Please select PDF File");
                return;
            }

            strSplitSource = this.txtsplitsource.Text;
            iSplitStartPage = Int32.Parse(this.txtsplitfrompage.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            iType = 1;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File|*.PDF||";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtdeletepagesource.Text = openFileDialog1.FileName;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtdeletepagesource.Text == "")
            {
                MessageBox.Show("Please select PDF File");
                return;
            }

            strDeletePageSource = txtdeletepagesource.Text;
            iDeletePageNo = Int32.Parse(this.txtdeletepage.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            iType = 2;
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtrotatepagesource.Text == "")
            {
                MessageBox.Show("Please select PDF File");
                return;
            }

            strRotatePageSource = txtrotatepagesource.Text;

            iRotatePageNo = Int32.Parse(this.txtrotatepage.Text);
            iRotateAngle = Int32.Parse(this.txtrotateangle.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
            if (chkrotateallpages.Checked)
                iType = 4;
            else
                iType = 3;
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File|*.PDF||";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtrotatepagesource.Text = openFileDialog1.FileName;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File|*.PDF||";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtcroppdfsource.Text = openFileDialog1.FileName;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtcroppdfsource.Text == "")
            {
                MessageBox.Show("Please select PDF File");
                return;
            }

            strCropSource = txtcroppdfsource.Text;

            iCropLeft = Int32.Parse(this.txtcropleft.Text);
            iCropTop = Int32.Parse(this.txtcroptop.Text);
            iCropRight = Int32.Parse(this.txtcropright.Text);
            iCropBottom = Int32.Parse(this.txtcropbottom.Text);
            
            DialogResult = System.Windows.Forms.DialogResult.OK;
         
           iType = 5;
          
            this.Close();
        }

      

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtmergebooksource1.Text == "")
            {
                MessageBox.Show("Please select PDF 1 file");
                return;
            }

            if (txtmergebooksource2.Text == "")
            {
                MessageBox.Show("Please select PDF 2 file");
                return;
            }

            strMergeSource1 = txtmergebooksource1.Text;
            strMergeSource2 = txtmergebooksource2.Text;

            strMergeRootTitle = txtmergeRootTitle.Text;
            strMergeOutline1 = txtmergeOutline1.Text;
            strMergeOutline2 = txtmergeOutline2.Text;

            iType = 6;

            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File|*.PDF||";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtmergebooksource1.Text = openFileDialog1.FileName;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File|*.PDF||";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtmergebooksource2.Text = openFileDialog1.FileName;
            }
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PDF File|*.PDF||";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtmaskingpdf.Text = openFileDialog1.FileName;
            }
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            if (txtmaskingpdf.Text == "")
            {
                MessageBox.Show("Please select PDF file");
                return;
            }

            strMaskingSource = txtmaskingpdf.Text;
            iMaskingX = Int32.Parse(txtmaskingX.Text);
            iMaskingY = Int32.Parse(txtmaskingY.Text);
            iMaskingWidth = Int32.Parse(txtmaskingWidth.Text);
            iMaskingHeight = Int32.Parse(txtmaskingHeight.Text);
            iMaskingR = Int32.Parse(txtmaskingR.Text);
            iMaskingG = Int32.Parse(txtmaskingG.Text);
            iMaskingB = Int32.Parse(txtmaskingB.Text);
            iMaskingStartPage = Int32.Parse(txtmaskingStartPage.Text)-1; //first page is zero
            iMaskingEndPage = Int32.Parse(txtmaskingEndPage.Text);

            if (chkMaskingAllPage.Checked)
            {
              
                iMaskingStartPage = -1;
                iMaskingEndPage = -1;
            }




            iType = 7;

            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
