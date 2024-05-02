namespace Typographer
{
    public partial class TypographerMainForm : Form
    {
        #region �������
        private void TypographerButtonClick(object sender, EventArgs e)
        {
            typographerRichTextBox.Text = RulesOfTypographer.RemovingExtraSpaces(typographerRichTextBox.Text);
            typographerRichTextBox.Text = RulesOfTypographer.EditingPunctuationMarks(typographerRichTextBox.Text);
            typographerRichTextBox.Text = RulesOfTypographer.EditingHyphen(typographerRichTextBox.Text);
            typographerRichTextBox.Text = RulesOfTypographer.EditingQuotes(typographerRichTextBox.Text);
            typographerRichTextBox.Text = RulesOfTypographer.EditingEllipsis(typographerRichTextBox.Text);

            typographerRichTextBox.Text = RulesOfTypographer.ChangingSpellingLetter_C(typographerRichTextBox.Text);
            typographerRichTextBox.Text = RulesOfTypographer.ChangingBracketToSmiley(typographerRichTextBox.Text);
        }
        #endregion

        #region ������������
        public TypographerMainForm()
        {
            InitializeComponent();
        }
        #endregion
    }
}