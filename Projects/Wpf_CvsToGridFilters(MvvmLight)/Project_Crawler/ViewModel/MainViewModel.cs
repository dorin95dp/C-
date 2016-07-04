using GalaSoft.MvvmLight;
using Microsoft.Win32;
using Project_Crawler.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Project_Crawler.Service;

namespace Project_Crawler.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private List<PersonModel> _employees;
        private List<FilterElement> _filters;
        public List<PersonModel> Employees
        {
            get { return _employees; }
            set
            {
                if (_employees != value)
                {
                    _employees = value;
                    RaisePropertyChanged(() => Employees);
                }
            }
        }
        public List<FilterElement> Filters
        {
            get { return _filters; }
            set
            {
                if (_filters != value)
                {
                    _filters = value;
                    RaisePropertyChanged(() => Filters);
                }
            }
        }

        private ICommand _loadEmployeesCommand;
        private ICommand _loadFilterCommand;
        public ICommand LoadEmployeesCommand
        {
            get
            {
                return _loadEmployeesCommand ?? (_loadEmployeesCommand = new RelayCommand(LoadEmployees));
            }
        }
        public ICommand LoadFilterCommand
        {
            get
            {
                return _loadFilterCommand ?? (_loadFilterCommand = new RelayCommand(LoadFilter));
            }
        }
        public void LoadEmployees()
        {
            var opendialog = new OpenFileDialog();
            if (opendialog.ShowDialog() == true)
            {
                var filename = opendialog.FileName;
                var loader = new CsvLoader();
                Employees = loader.LoadEmployees(filename);
            }
        }
        public void LoadFilter()
        {
            Filters = new List<FilterElement>
            {
                new FilterElement
                {
                    Element = "First name",
                    FindType = FindType.Use
                },
                new FilterElement
                {
                    Element = "Last name",
                    FindType = FindType.Use
                },
                new FilterElement
                {
                    Element = "Company",
                    FindType = FindType.Use
                }
            };
        }
    }
}