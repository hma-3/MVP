namespace MVP.Views
{
    public interface IView
    {
        string LabelText { get; set; }
        string InputText { get; set; }
        event EventHandler<string>? SetText;
        event EventHandler<string>? ReverseText;
        event EventHandler? ClearText;
    }
}
