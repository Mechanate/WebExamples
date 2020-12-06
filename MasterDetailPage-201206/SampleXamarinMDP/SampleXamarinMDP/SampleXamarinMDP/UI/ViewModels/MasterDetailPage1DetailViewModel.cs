using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using SampleXamarinMDP.UI.Messages;
using TinyIoC;
using TinyMessenger;

namespace SampleXamarinMDP.UI.ViewModels
{
    public class MasterDetailPage1DetailViewModel : INotifyPropertyChanged
    {
        public MasterDetailPage1DetailViewModel()
        {
            messageHub = TinyIoCContainer.Current.Resolve<ITinyMessengerHub>() as TinyMessengerHub;
            messageHub.Subscribe<ChangeDetailPageRecipeMessage>(OnChangeRecipe);
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }

        TinyMessengerHub messageHub;

        private void OnChangeRecipe(ChangeDetailPageRecipeMessage message)
        {
            Name = message.Recipe.Name;
        }

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
