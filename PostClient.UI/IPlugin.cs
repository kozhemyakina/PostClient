﻿using System;
using System.Windows.Forms;

namespace PostClient.UI
{
    public interface IPlugin : IDisposable
    {
        void DoActions(Form form, ListView inboxListView, ListView sentListView, ListView pluginListView);
    }
}