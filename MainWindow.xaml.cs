using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows;

namespace RealmLauncher
{
    //Enum For Launcher Status
    enum launcherStatus
    {
        ready,
        failed,
        downloadingGame,
        updatingGame
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //String Component for file path
        string rootPath;
        string versionFile;
        string gameZip;
        string gameExe;

        public MainWindow()
        {
            InitializeComponent();

            rootPath = Directory.GetCurrentDirectory();
            versionFile = Path.Combine(rootPath, "Version.txt");
            gameZip = Path.Combine(rootPath, "build.zip");
            versionFile = Path.Combine(rootPath, "Not Declared Yet", "Same");
             
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {

        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
