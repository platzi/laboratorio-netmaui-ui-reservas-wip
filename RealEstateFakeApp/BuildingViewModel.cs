using System;
using System.Collections.ObjectModel;

namespace RealEstateFakeApp
{
    public class BuildingViewModel
    {
        private ObservableCollection<Building> buildingCollection;

        public ObservableCollection<Building> BuildingCollection
        {
            get { return buildingCollection; }
            set { this.buildingCollection = value; }
        }

        public BuildingViewModel()
        {
            buildingCollection = new ObservableCollection<Building>();
            buildingCollection.Add(new Building { Picture = "room2", Status = "Premium", StatusColor = Color.FromArgb("#ffa654"), Price = "$449,990", Description = "Exclusive, serviced, all bills included. City View", Beds = "2 beds", Bath = "2 baths", Sqfts = "150 sqfts", BuildingType = "Villa" });
            buildingCollection.Add(new Building { Picture = "room3", Status = "Featured", StatusColor = Color.FromArgb("#7bd944"), Price = "$449,990", Description = "Exclusive, serviced, all bills included. City View", Beds = "2 beds", Bath = "2 baths", Sqfts = "150 sqfts", BuildingType = "Villa" });
    
        }
    }
}

