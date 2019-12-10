using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

namespace XamUIChallenges.ViewModels
{
    /// <summary>
    /// A Base ViewModel
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        bool isBusy = false;
        /// <summary>
        /// is it busy? i.e. doing something that may take long time
        /// </summary>
        public bool IsBusy
        {
            get { return isBusy; }
            set => SetProperty(ref isBusy, value);
        }

        string title = string.Empty;
        /// <summary>
        /// View Title
        /// </summary>
        public string Title
        {
            get { return title; }
            set => SetProperty(ref title, value);
        }

        /// <summary>
        /// A reference to Navigation to Push and Pop pages
        /// </summary>
        public INavigation Navigation { get; }

        public BaseViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }

        /// <summary>
        /// set the property and notify the change
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="backingStore">local variable (field)</param>
        /// <param name="value">new value</param>
        /// <param name="propertyName">property name</param>
        /// <param name="onChanged">action to raise</param>
        /// <returns>was is successful?</returns>
        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName]string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}