﻿using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AGTkDemo.ViewModels;
using AGTkDemo.Views;
using System.IO;
using System.Linq;
using CefNet;
using System.Threading.Tasks;
using Avalonia.Threading;
using System.Threading;

namespace AGTkDemo
{
    public class App : Application
    {

        private CefAppImpl app;
        private Timer messagePump;
        private int messagePumpDelay = 10;

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
                desktop.Startup += Desktop_Startup;
            }

            base.OnFrameworkInitializationCompleted();
        }

        private void Desktop_Startup(object sender, ControlledApplicationLifetimeStartupEventArgs e)
        {
            string cefPath;
            bool externalMessagePump = e.Args.Contains("--external-message-pump");

            if (PlatformInfo.IsMacOS)
            {
                externalMessagePump = true;
                cefPath = Path.Combine(GetProjectPath(), "Contents", "Frameworks", "Chromium Embedded Framework.framework");
            }
            else
            {
                //string p1 = Path.GetDirectoryName(GetProjectPath());
                //cefPath = Path.Combine(Path.GetDirectoryName(p1), "CommonDLL", "cef");
                //路径 输出目录
                cefPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Cef");
            }

            var settings = new CefSettings();
            settings.MultiThreadedMessageLoop = !externalMessagePump;
            settings.ExternalMessagePump = externalMessagePump;
            settings.NoSandbox = true;
            settings.WindowlessRenderingEnabled = true;
            settings.LocalesDirPath = Path.Combine(cefPath, "Resources", "locales");
            settings.ResourcesDirPath = Path.Combine(cefPath, "Resources");
            settings.LogSeverity = CefLogSeverity.Warning;
            settings.IgnoreCertificateErrors = true;
            settings.UncaughtExceptionStackSize = 8;

            app = new CefAppImpl();
            app.ScheduleMessagePumpWorkCallback = OnScheduleMessagePumpWork;
            app.Initialize(PlatformInfo.IsMacOS ? cefPath : Path.Combine(cefPath, "ReleaseFile"), settings);

            if (externalMessagePump)
            {
                messagePump = new Timer(_ => Dispatcher.UIThread.Post(CefApi.DoMessageLoopWork), null, messagePumpDelay, messagePumpDelay);
            }
        }


        private async void OnScheduleMessagePumpWork(long delayMs)
        {
            await Task.Delay((int)delayMs);
            Dispatcher.UIThread.Post(CefApi.DoMessageLoopWork);
        }

        private static string GetProjectPath()
        {
            string projectPath = Path.GetDirectoryName(typeof(App).Assembly.Location);
            string projectName = PlatformInfo.IsMacOS ? "AGTkDemo.app" : "AGTkDemo";
            string rootPath = Path.GetPathRoot(projectPath);
            while (Path.GetFileName(projectPath) != projectName)
            {
                if (projectPath == rootPath)
                    throw new DirectoryNotFoundException("Could not find the project directory.");
                projectPath = Path.GetDirectoryName(projectPath);
            }
            return projectPath;
        }

    }

}
