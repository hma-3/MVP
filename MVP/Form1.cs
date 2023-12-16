using MVP.Presenter;
using MVP.Views;
using System.Runtime.CompilerServices;

namespace MVP
{
    public partial class Form1 : Form, IView
    {
        public event EventHandler<string>? SetText;
        public event EventHandler<string>? ReverseText;
        public event EventHandler? ClearText;

        readonly TextPresenter? presenter = null;

        public Form1()
        {
            InitializeComponent();
            presenter = new(this);
        }

        private void ButtonSet_Click(object sender, EventArgs e)
        {
            presenter?.SetTextDisplay(InputText);
            SetText?.Invoke(this, InputText);
        }

        private void ButtonReverse_Click(object sender, EventArgs e)
        {
            var currentText = LabelText;
            presenter?.ReverseTextDisplay();
            var newText = InputText;
            ReverseText?.Invoke(this, currentText);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            presenter?.ClearTextDisplay();
            ClearText?.Invoke(this, EventArgs.Empty);
        }

        public string LabelText
        {
            get { return labelTxt.Text; }
            set { labelTxt.Text = value; }
        }

        public string InputText
        {
            get { return inputTxt.Text; }
            set { inputTxt.Text = value; }
        }
    }
}