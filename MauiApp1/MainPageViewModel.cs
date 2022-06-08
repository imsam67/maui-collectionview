using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1
{
    public class MainPageViewModel : ObservableObject
    {
        public ObservableCollection<Driver> Drivers = new();

        public void Init()
        {
            var car = new Vehicle
            {
                Make = "Subaru",
                Model = "Outback",
                Year = 2019
            };
            var driver = new Driver
            {
                Name = "John Smith",
                Car = car
            };
            Drivers.Add(driver);

            car = new Vehicle
            {
                Make = "Infiniti",
                Model = "Q80",
                Year = 2014
            };
            driver = new Driver
            {
                Name = "John Doe",
                Car = car
            };
            Drivers.Add(driver);

            car = new Vehicle
            {
                Make = "BMW",
                Model = "535i",
                Year = 2011
            };
            driver = new Driver
            {
                Name = "John Doe",
                Car = car
            };
            Drivers.Add(driver);
        }
    }
}