﻿using System;
using System.Windows.Input;

namespace PersonnelAccounting.ViewModel.Commands
{
    public class CreateCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}