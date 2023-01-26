namespace Traningcost
{
    partial class Form1
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
            this.classCHBX = new System.Windows.Forms.CheckedListBox();
            this.outputLB = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // classCHBX
            // 
            this.classCHBX.CheckOnClick = true;
            this.classCHBX.FormattingEnabled = true;
            this.classCHBX.Items.AddRange(new object[] {
            "Handling Stress, 3 Days, $1,000",
            "Time Management, 3 Days, $800",
            "Supervision Skills, 3 Days, $1,500",
            "Negotiation, 5 Days, $1,300",
            "How to Interview, 1 Day, $500"});
            this.classCHBX.Location = new System.Drawing.Point(12, 12);
            this.classCHBX.Name = "classCHBX";
            this.classCHBX.Size = new System.Drawing.Size(201, 94);
            this.classCHBX.TabIndex = 0;
            this.classCHBX.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // outputLB
            // 
            this.outputLB.AutoSize = true;
            this.outputLB.Location = new System.Drawing.Point(188, 109);
            this.outputLB.Name = "outputLB";
            this.outputLB.Size = new System.Drawing.Size(72, 13);
            this.outputLB.TabIndex = 2;
            this.outputLB.Text = "Total cost: $0";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Austin, $150",
            "Chicago, $225",
            "Dallas, $175",
            "Phoenix, $175",
            "Raleigh, $150"});
            this.listBox1.Location = new System.Drawing.Point(219, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(122, 95);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 151);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.outputLB);
            this.Controls.Add(this.classCHBX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox classCHBX;
        private System.Windows.Forms.Label outputLB;
        private System.Windows.Forms.ListBox listBox1;
    }
}

