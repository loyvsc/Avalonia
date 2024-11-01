﻿using System;
using Avalonia.Controls.Platform;
using Avalonia.Input;
using Avalonia.Metadata;

namespace Avalonia.Platform
{
    [Unstable]
    public interface ITrayIconImpl : IDisposable
    {
        /// <summary>
        /// Sets the icon of this tray icon.
        /// </summary>
        void SetIcon(IWindowIconImpl? icon);

        /// <summary>
        /// Sets the icon of this tray icon.
        /// </summary>
        void SetToolTipText(string? text);

        /// <summary>
        /// Sets if the tray icon is visible or not.
        /// </summary>
        void SetIsVisible(bool visible);

        /// <summary>
        /// Gets the MenuExporter to allow native menus to be exported to the TrayIcon.
        /// </summary>
        INativeMenuExporter? MenuExporter { get; }

        event EventHandler<MouseEventArgs>? MouseLeftButtonDown;
        event EventHandler<MouseEventArgs>? MouseRightButtonDown;
    }

    [Unstable]
    public interface ITrayIconWithIsTemplateImpl : ITrayIconImpl
    {
        /// <summary>
        /// Sets if the tray icon has a template/monochrome icon or not.
        /// </summary>
        void SetIsTemplateIcon(bool isTemplateIcon);
    }
}
