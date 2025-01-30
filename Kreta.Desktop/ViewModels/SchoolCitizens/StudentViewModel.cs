﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.HttpService.Services;
using Kreta.Desktop.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using Kreta.Shared.Models.Entites.SchoolCitizens;
using Kreta.Shared.Extensions;

namespace Kreta.Desktop.ViewModels.SchoolCitizens
{
    public partial class StudentViewModel : BaseViewModel
    {
        private readonly IStudentHttpService _httpService;

        [ObservableProperty]
        private Student _selectedStudent = new Student();

        [ObservableProperty]
        private List<string> _educationLevels = new List<string> { "érettségi", "szakmai érettségi", "szakmai vizsga" };

        [ObservableProperty]
        private ObservableCollection<Student> _students = new ObservableCollection<Student>();

        public StudentViewModel()
        {
            _selectedStudent = new Student();
            SelectedStudent.BirthDay = DateTime.Now.AddYears(-14);
            _httpService = new StudentHttpService();
        }

        public StudentViewModel(IStudentHttpService? httpService)
        {
            _httpService = httpService ?? throw new ArgumentNullException(nameof(httpService));
            _selectedStudent = new Student();
            SelectedStudent.BirthDay = DateTime.Now.AddYears(-14);
        }

        public async override Task InitializeAsync()
        {
            await UpdateViewAsync();
            await base.InitializeAsync();
        }

        [RelayCommand]
        public void DoSave(Student studentDto)
        {
            Students.Add(studentDto);
            ClearForm();
        }

        [RelayCommand]
        public void DoNewStudent()
        {
            ClearForm();
        }

        [RelayCommand]
        public async Task DoDelete(Student student)
        {
            if (student is not null)
            {
                await _httpService.DeleteAsync(student.Id);
                ClearForm();
                await UpdateViewAsync();
            }
        }

        private async Task UpdateViewAsync()
        {
            List<Student> students = await _httpService.GetAllAsync();
            Students = new ObservableCollection<Student>(students);
        }

        private void ClearForm()
        {
            SelectedStudent = new Student();
            SelectedStudent.BirthDay = DateTime.Now.AddYears(-14);
            OnPropertyChanged(nameof(SelectedStudent));
        }
    }
}
