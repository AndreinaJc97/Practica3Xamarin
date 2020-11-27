using Practica3Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica3Xamarin.ViewModels
{
    class HomePageViewModel
    {
        public HomeModel BarAndHotelsOption { get; set; } = new HomeModel();
        public HomeModel FineDining { get; set; } = new HomeModel();

        public HomeModel Cafes { get; set; } = new HomeModel();

        public HomeModel Nearby { get; set; } = new HomeModel();

        public HomeModel FastFoods { get; set; } = new HomeModel();

        public HomeModel FeatureFoods { get; set; } = new HomeModel();

        public HomePageViewModel()
        {
            BarAndHotelsOption.Title = "Bars and Hotels";
            FineDining.Title = "Fine Dining";
            Cafes.Title = "Cafes";
            Nearby.Title = "Nearby";
            FastFoods.Title = "Fast Foods";
            FeatureFoods.Title = "Feature Foods";
        }

    }
}
