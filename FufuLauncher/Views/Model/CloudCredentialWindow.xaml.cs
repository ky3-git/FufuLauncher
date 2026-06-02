using Windows.Graphics;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;

namespace FufuLauncher.Views;

public sealed partial class CloudCredentialWindow : Window
{
    private readonly string _uid;

    public CloudCredentialWindow(string uid)
    {
        _uid = uid;
        InitializeComponent();

        ExtendsContentIntoTitleBar = true;
        SetTitleBar(AppTitleBar);
        SystemBackdrop = new MicaBackdrop();
        AppWindow.Resize(new SizeInt32(1280, 720));

        TitleText.Text = $"添加云游戏凭证 - {_uid}";
        InitializeWebViewAsync();
    }

    private async void InitializeWebViewAsync()
    {
        await CloudWebView.EnsureCoreWebView2Async();
        // TODO: 导航到云游戏登录页面，抓取登录凭证
        // CloudWebView.Source = new Uri("...");
    }
}
