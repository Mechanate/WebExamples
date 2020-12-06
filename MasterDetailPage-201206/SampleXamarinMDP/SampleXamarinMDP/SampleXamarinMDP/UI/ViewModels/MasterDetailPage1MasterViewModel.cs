using SampleXamarinMDP.Domain.Model;
using SampleXamarinMDP.UI.Messages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using TinyIoC;
using TinyMessenger;

namespace SampleXamarinMDP.UI.ViewModels
{
    public class MasterDetailPage1MasterViewModel : INotifyPropertyChanged
    {
        public MasterDetailPage1MasterViewModel()
        {
            loadTestRecipes();

            messageHub = TinyIoCContainer.Current.Resolve<ITinyMessengerHub>() as TinyMessengerHub;
        }

        TinyMessengerHub messageHub;

        private ObservableCollection<Recipe> _Recipes;
        public ObservableCollection<Recipe> Recipes
        {
            get { return _Recipes; }
            set
            {
                _Recipes = value;
                OnPropertyChanged();
            }
        }

        private Recipe _selectedRecipe;
        public Recipe SelectedRecipe
        {
            get { return _selectedRecipe; }
            set
            {
                _selectedRecipe = value;
                OnPropertyChanged();
                OnSelectedRecipeChanged(value);
            }
        }

        private void OnSelectedRecipeChanged(Recipe recipe)
        {
            ChangeDetailPageRecipeMessage message = new ChangeDetailPageRecipeMessage(recipe, this);

            messageHub.Publish<ChangeDetailPageRecipeMessage>(message);
        }

        private void loadTestRecipes()
        {
            Recipes = new ObservableCollection<Recipe>(DataAccess.Common.Load.TestRecipes());
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
