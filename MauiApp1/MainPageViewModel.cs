using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1
{
    public partial class MainPageViewModel : ObservableObject
    {
        public ObservableCollection<Driver> Drivers { get; } = new();

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

            car = new Vehicle
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 2017
            };
             driver = new Driver
            {
                Name = "Jane Doe",
                Car = car
            };
            Drivers.Add(driver);

            car = new Vehicle
            {
                Make = "Honda",
                Model = "Civic",
                Year = 2011
            };
            driver = new Driver
            {
                Name = "Michael Smith",
                Car = car
            };
            Drivers.Add(driver);

            car = new Vehicle
            {
                Make = "Mercedes",
                Model = "M350",
                Year = 2016
            };
            driver = new Driver
            {
                Name = "Jonathan Green",
                Car = car
            };
            Drivers.Add(driver);
            car = new Vehicle
            {
                Make = "Porsche",
                Model = "911",
                Year = 2022
            };
            driver = new Driver
            {
                Name = "Suzi Brown",
                Car = car
            };
            Drivers.Add(driver);

            car = new Vehicle
            {
                Make = "GMC",
                Model = "Sierra",
                Year = 2021
            };
            driver = new Driver
            {
                Name = "Richard Temple",
                Car = car
            };
            Drivers.Add(driver);

            car = new Vehicle
            {
                Make = "Ford",
                Model = "F150",
                Year = 2020
            };
            driver = new Driver
            {
                Name = "Nathan Blacksmith",
                Car = car
            };
            Drivers.Add(driver);
            car = new Vehicle
            {
                Make = "Nissan",
                Model = "Murano",
                Year = 2005
            };
            driver = new Driver
            {
                Name = "Angelica Brown",
                Car = car
            };
            Drivers.Add(driver);

            car = new Vehicle
            {
                Make = "VW",
                Model = "Rabbit",
                Year = 2015
            };
            driver = new Driver
            {
                Name = "Gema Stone",
                Car = car
            };
            Drivers.Add(driver);

            car = new Vehicle
            {
                Make = "Ford",
                Model = "Mustang",
                Year = 2020
            };
            driver = new Driver
            {
                Name = "Fernando Suarez",
                Car = car
            };
            Drivers.Add(driver);

            car = new Vehicle
            {
                Make = "Saab",
                Model = "9-3",
                Year = 2018
            };
            driver = new Driver
            {
                Name = "George Smith",
                Car = car
            };
            Drivers.Add(driver);

            car = new Vehicle
            {
                Make = "Mercedes",
                Model = "C 250",
                Year = 2019
            };
            driver = new Driver
            {
                Name = "Jimmy Norton",
                Car = car
            };
            Drivers.Add(driver);

            car = new Vehicle
            {
                Make = "Chevrolet",
                Model = "Silverado",
                Year = 2020
            };
            driver = new Driver
            {
                Name = "Clark Kent",
                Car = car
            };
            Drivers.Add(driver);

            car = new Vehicle
            {
                Make = "Honda",
                Model = "Pilot",
                Year = 2021
            };
            driver = new Driver
            {
                Name = "John Morgan",
                Car = car
            };
            Drivers.Add(driver);
        }
    }
}