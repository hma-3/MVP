using MVP.Models;
using MVP.Views;
using System.Windows.Forms;

namespace MVP.Presenter
{
    public  class TextPresenter
    {
        private readonly IView _textDisplay;
        public TextPresenter(IView textDisplay)
        {
            _textDisplay = textDisplay;
            textDisplay.SetText += (o, e) => {
                MessageBox.Show("Введений текст: " + e.ToString());
            };

            textDisplay.ReverseText += (o, e) => {
                MessageBox.Show("Початковий текст \"" + e.ToString() + "\" було обернено: " + _textDisplay.LabelText);
            };

            textDisplay.ClearText += (o, e) => {
                MessageBox.Show("Поля очищено");
            };
        }

        public void ReverseTextDisplay()
        {
            TextDisplay textDisplay = new();
            string currentText = _textDisplay.LabelText;
            var reverseText = textDisplay.Reverse(currentText);
            _textDisplay.LabelText = reverseText;
        }

        public void SetTextDisplay(string text)
        {
            _textDisplay.LabelText = text;
        }

        internal void ClearTextDisplay()
        {
            _textDisplay.LabelText = "";
            _textDisplay.InputText = "";
        }
    }
}
