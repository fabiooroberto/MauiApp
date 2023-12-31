namespace Anotacoes.Models
{
    internal class Sobre
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms/maui";
        public string Message => "Este app é escirto em XAML e C# com .NET MAUI.";
    }
}
