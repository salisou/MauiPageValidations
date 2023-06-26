using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiPageValidations.MVVM.Models;
using MauiPageValidations.MVVM.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPageValidations.MVVM.ViewModels
{
    public partial class LoginViewModel: BaseViewModel
    {
        #region Propertise
        [ObservableProperty]
        private LoginModel model;
        #endregion

        #region Constructor
        public LoginViewModel()
        {
            Model = new();
        }
        #endregion

        #region Commands
        [RelayCommand]
        private async Task Login()
        {
            if (!Model.Validator.ValidateProperties())
                return;
            await Task.Delay(100);
        }

        [RelayCommand]
        private async Task Registration()
        {
            await Shell.Current.GoToAsync(nameof(RegistrationPage));
        }

        [RelayCommand]
        private async Task ForgotPassword()
        {
            await Task.CompletedTask;
        }
        #endregion
    }
}
