using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CardCarousel
{
    public class CardViewModel
    {
        public ObservableCollection<TouristPlace> Places { get; set; }
        public CardViewModel()
        {
            Places = new ObservableCollection<TouristPlace>()
            {
                new TouristPlace()
                {
                    Image = "paris.jpg",
                    Title = "Eiffel Tower",
                    Country = "Paris, France",
                    Description = "Iconic landmark and city views.",
                    Rating = 4.9,
                    StartingPrice = "$1,250"
                },

                new TouristPlace()
                {
                    Image = "venice.jpg",
                    Title = "Venice Canal",
                    Country = "Venice, Italy",
                    Description = "Romantic waterways and gondola rides.",
                    Rating = 4.8,
                    StartingPrice = "$1,100"
                },

                new TouristPlace()
                {
                    Image = "santorini.jpg",
                    Title = "Santorini",
                    Country = "Greece",
                    Description = "Stunning sunsets and blue-domed villages.",
                    Rating = 4.9,
                    StartingPrice = "$1,450"
                },

                new TouristPlace()
                {
                    Image = "maldives.jpg",
                    Title = "Maldives Beach",
                    Country = "Maldives",
                    Description = "Crystal-clear waters and luxury resorts.",
                    Rating = 5.0,
                    StartingPrice = "$2,200"
                },

                new TouristPlace()
                {
                    Image = "swissalps.jpg",
                    Title = "Swiss Alps",
                    Country = "Switzerland",
                    Description = "Snow-covered mountains and scenic railways.",
                    Rating = 4.8,
                    StartingPrice = "$1,850"
                }
            };
        }
    }
}
