using Avalonia.Controls;
using Avalonia.Interactivity;

namespace DicomSync;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // ----------------- Global AE -----------------

    private async void OnGlobalEchoClick(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Pinging global AE...";

        // TODO: Call DICOM C-ECHO with AetTitleBox, HostnameBox, PortBox
        await System.Threading.Tasks.Task.Delay(500);

        StatusText.Text = "Global AE echo completed (TODO: real result).";
    }

    private async void OnLeftEchoClick(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Pinging LEFT AE...";
        // TODO: C-ECHO using LeftAeTitleBox, LeftHostnameBox, LeftPortBox
        await System.Threading.Tasks.Task.Delay(500);
        StatusText.Text = "LEFT AE echo completed (TODO: real result).";
    }

    private async void OnRightEchoClick(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Pinging RIGHT AE...";
        // TODO: C-ECHO using RightAeTitleBox, RightHostnameBox, RightPortBox
        await System.Threading.Tasks.Task.Delay(500);
        StatusText.Text = "RIGHT AE echo completed (TODO: real result).";
    }

    // ----------------- Queries -------------------

    private async void OnQueryLeftClick(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Querying LEFT PACS...";

        var fromDate = FromDatePicker.SelectedDate;
        var toDate   = ToDatePicker.SelectedDate;

        bool patient  = PatientCheck.IsChecked ?? false;
        bool study    = StudyCheck.IsChecked ?? false;
        bool series   = SeriesCheck.IsChecked ?? false;
        bool instance = InstanceCheck.IsChecked ?? false;
        bool frame    = FrameCheck.IsChecked ?? false;

        // TODO: Build C-FIND against LEFT AE with these filters.

        await System.Threading.Tasks.Task.Delay(500);

        // TODO: Bind real results to LeftTree.
        StatusText.Text = "LEFT query completed (TODO: bind results to tree).";
    }

    private async void OnQueryRightClick(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Querying RIGHT PACS...";

        var fromDate = FromDatePicker.SelectedDate;
        var toDate   = ToDatePicker.SelectedDate;

        bool patient  = PatientCheck.IsChecked ?? false;
        bool study    = StudyCheck.IsChecked ?? false;
        bool series   = SeriesCheck.IsChecked ?? false;
        bool instance = InstanceCheck.IsChecked ?? false;
        bool frame    = FrameCheck.IsChecked ?? false;

        // TODO: Build C-FIND against RIGHT AE.

        await System.Threading.Tasks.Task.Delay(500);

        // TODO: Bind real results to RightTree.
        StatusText.Text = "RIGHT query completed (TODO: bind results to tree).";
    }

    // ----------------- Moves / Sync -------------

    private async void OnMoveLeftToRightClick(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Moving selection LEFT → RIGHT (C-MOVE/C-STORE)...";

        // TODO: Use current selection(s) in LeftTree as source.

        await System.Threading.Tasks.Task.Delay(500);

        StatusText.Text = "Move LEFT → RIGHT completed (TODO: real result).";
    }

    private async void OnMoveRightToLeftClick(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Moving selection RIGHT → LEFT (C-MOVE/C-STORE)...";

        // TODO: Use current selection(s) in RightTree as source.

        await System.Threading.Tasks.Task.Delay(500);

        StatusText.Text = "Move RIGHT → LEFT completed (TODO: real result).";
    }

    private void OnSyncClick(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Starting sync (TODO: orchestration logic).";

        // TODO: Start background sync job that compares left/right trees
        // and schedules C-MOVE/C-STORE operations.
    }

    private void OnPauseClick(object? sender, RoutedEventArgs e)
    {
        StatusText.Text = "Sync paused (TODO: implement pause/cancel).";

        // TODO: Implement pause/cancel on running sync.
    }
}
