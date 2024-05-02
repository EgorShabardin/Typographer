namespace Typographer
{
    partial class TypographerMainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypographerMainForm));
            typographerRichTextBox = new RichTextBox();
            typographerButton = new Button();
            SuspendLayout();
            // 
            // typographerRichTextBox
            // 
            typographerRichTextBox.BackColor = SystemColors.Window;
            typographerRichTextBox.BorderStyle = BorderStyle.FixedSingle;
            typographerRichTextBox.Cursor = Cursors.IBeam;
            typographerRichTextBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            typographerRichTextBox.Location = new Point(67, 39);
            typographerRichTextBox.Margin = new Padding(0);
            typographerRichTextBox.Name = "typographerRichTextBox";
            typographerRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            typographerRichTextBox.Size = new Size(851, 382);
            typographerRichTextBox.TabIndex = 0;
            typographerRichTextBox.TabStop = false;
            typographerRichTextBox.Text = "";
            // 
            // typographerButton
            // 
            typographerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            typographerButton.BackColor = Color.DeepSkyBlue;
            typographerButton.Cursor = Cursors.Hand;
            typographerButton.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            typographerButton.Location = new Point(376, 453);
            typographerButton.Margin = new Padding(0);
            typographerButton.Name = "typographerButton";
            typographerButton.Size = new Size(254, 71);
            typographerButton.TabIndex = 0;
            typographerButton.TabStop = false;
            typographerButton.Text = "Оттипографить";
            typographerButton.UseVisualStyleBackColor = false;
            typographerButton.Click += TypographerButtonClick;
            // 
            // TypographerMainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(982, 553);
            Controls.Add(typographerButton);
            Controls.Add(typographerRichTextBox);
            Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "TypographerMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Типограф";
            ResumeLayout(false);
        }
        #endregion

        private RichTextBox typographerRichTextBox;
        private Button typographerButton;
    }
}