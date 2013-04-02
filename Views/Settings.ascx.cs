﻿// <copyright file="Settings.ascx.cs" company="Engage Software">
// Engage: Jackrabbit
// Copyright (c) 2004-2013
// by Engage Software ( http://www.engagesoftware.com )
// </copyright>
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.

namespace Engage.Dnn.Jackrabbit
{
    using System;

    using DotNetNuke.UI.Modules;
    using DotNetNuke.Web.Mvp;

    using WebFormsMvp;

    /// <summary>
    /// Displays the module's settings
    /// </summary>
    [PresenterBinding(typeof(SettingsPresenter))]
    public partial class Settings : ModuleView<SettingsViewModel>, ISettingsView, ISettingsControl
    {
        /// <summary>
        /// Occurs when <see cref="ISettingsControl.LoadSettings"/> is called.
        /// </summary>
        public event EventHandler<EventArgs> LoadingSettings = (_, __) => { };

        /// <summary>
        /// Occurs when <see cref="ISettingsControl.UpdateSettings"/> is called.
        /// </summary>
        public event EventHandler<UpdatingSettingsEventArgs> UpdatingSettings = (_, __) => { };

        /// <summary>
        /// Loads the settings.
        /// </summary>
        public void LoadSettings()
        {
            this.LoadingSettings(this, EventArgs.Empty);
        }

        /// <summary>
        /// Updates the settings.
        /// </summary>
        public void UpdateSettings()
        {
            this.UpdatingSettings(this, new UpdatingSettingsEventArgs());
        }
    }
}