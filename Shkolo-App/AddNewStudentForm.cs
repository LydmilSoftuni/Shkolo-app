using System.ComponentModel;

namespace Shkolo_App
{
    public partial class AddNewStudentForm : Form
    {
        public AddNewStudentForm()
        {
            InitializeComponent();
        }

        public string Name { get; set; }

        public int Grade { get; set; }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            if (!IsCorrectInput())
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;
            }

            this.Name = this.textBoxName.Text.Trim();
            this.Grade = int.Parse(this.textBoxGrade.Text.Trim());

            DialogResult = DialogResult.OK;
        }

        private bool IsCorrectInput()
            => CheckIfNameIsNotEmptyString() && IsCorrenctGrade();

        private bool CheckIfNameIsNotEmptyString()
            => !string.IsNullOrWhiteSpace(this.textBoxName.Text);

        private bool IsCorrenctGrade()
        {
            if (string.IsNullOrWhiteSpace(this.textBoxGrade.Text))
            {
                return false;
            }
            else if (double.TryParse(this.textBoxGrade.Text, out double gradeValue))
            {
                return gradeValue >= 1 && gradeValue <= 12;
            }

            return true;
        }

        private void ValidateStudentsName(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxName.Text))
            {
                e.Cancel = true;
                this.textBoxName.Focus();
                this.errorProviderName.SetError(this.textBoxName, "Name should not be empty string!");
                this.labelNameValidation.Visible = true;
            }
            else
            {
                e.Cancel = false;
                this.errorProviderName.SetError(this.textBoxName, string.Empty);
                this.labelNameValidation.Visible = false;
            }
        }

        private void ValidatingGrade(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxGrade.Text))
            {
                e.Cancel = true;
                this.textBoxGrade.Focus();
                this.errorProviderName.SetError(this.textBoxGrade, "Grade should not be empty string!");
                this.labelGradeValidation.Visible = true;
            }
            else if (double.Parse(this.textBoxGrade.Text) < 1 || double.Parse(this.textBoxGrade.Text) > 12)
            {
                e.Cancel = true;
                this.textBoxGrade.Focus();
                this.errorProviderName.SetError(this.textBoxGrade, "Grade should between 1 and 12!");
                this.labelGradeValidation.Visible = true;
            }
            else
            {
                e.Cancel = false;
                this.errorProviderName.SetError(this.textBoxGrade, string.Empty);
                this.labelGradeValidation.Visible = false;
            }
        }
    }
}
