namespace PDFViewerDemo
{
    partial class FindForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiCancel = new System.Windows.Forms.Button();
            this.uiFindPrev = new System.Windows.Forms.Button();
            this.uiFindNext = new System.Windows.Forms.Button();
            this.uiFindText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiSearching = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uiCancel
            // 
            this.uiCancel.Location = new System.Drawing.Point(309, 111);
            this.uiCancel.Name = "uiCancel";
            this.uiCancel.Size = new System.Drawing.Size(94, 27);
            this.uiCancel.TabIndex = 3;
            this.uiCancel.Text = "Cancel";
            this.uiCancel.UseVisualStyleBackColor = true;
            this.uiCancel.Click += new System.EventHandler(this.uiCancel_Click);
            // 
            // uiFindPrev
            // 
            this.uiFindPrev.Location = new System.Drawing.Point(86, 111);
            this.uiFindPrev.Name = "uiFindPrev";
            this.uiFindPrev.Size = new System.Drawing.Size(94, 27);
            this.uiFindPrev.TabIndex = 1;
            this.uiFindPrev.Text = "Previous";
            this.uiFindPrev.UseVisualStyleBackColor = true;
            this.uiFindPrev.Click += new System.EventHandler(this.uiFindPrev_Click);
            // 
            // uiFindNext
            // 
            this.uiFindNext.Location = new System.Drawing.Point(180, 111);
            this.uiFindNext.Name = "uiFindNext";
            this.uiFindNext.Size = new System.Drawing.Size(94, 27);
            this.uiFindNext.TabIndex = 2;
            this.uiFindNext.Text = "Next";
            this.uiFindNext.UseVisualStyleBackColor = true;
            this.uiFindNext.Click += new System.EventHandler(this.uiFindNext_Click);
            // 
            // uiFindText
            // 
            this.uiFindText.Location = new System.Drawing.Point(86, 25);
            this.uiFindText.Name = "uiFindText";
            this.uiFindText.Size = new System.Drawing.Size(188, 20);
            this.uiFindText.TabIndex = 0;
            this.uiFindText.TextChanged += new System.EventHandler(this.uiFindText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find:";
            // 
            // uiSearching
            // 
            this.uiSearching.AutoSize = true;
            this.uiSearching.Location = new System.Drawing.Point(50, 72);
            this.uiSearching.Name = "uiSearching";
            this.uiSearching.Size = new System.Drawing.Size(58, 13);
            this.uiSearching.TabIndex = 6;
            this.uiSearching.Text = "Searching:";
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 162);
            this.Controls.Add(this.uiSearching);
            this.Controls.Add(this.uiCancel);
            this.Controls.Add(this.uiFindPrev);
            this.Controls.Add(this.uiFindNext);
            this.Controls.Add(this.uiFindText);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.Text = "Find Text";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiCancel;
        private System.Windows.Forms.Button uiFindPrev;
        private System.Windows.Forms.Button uiFindNext;
        private System.Windows.Forms.TextBox uiFindText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uiSearching;

    }
}