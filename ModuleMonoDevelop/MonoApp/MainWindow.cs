using System;
using Gtk;
using ModuleStandart;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    /// <summary>
    /// Button click handler.
    /// </summary>
    /// <param name="sender">Sender.</param>
    /// <param name="e">E.</param>
    protected void OnButton3Pressed(object sender, EventArgs e)
    {
        var name = this.entry1.Text;
        var dialog = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "{0}", Greeting.GetGreeting(name));

        dialog.Run();
        dialog.Destroy();
    }
}
