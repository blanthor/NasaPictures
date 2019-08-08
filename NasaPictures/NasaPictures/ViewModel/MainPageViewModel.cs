using NasaPictures.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NasaPictures.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public MainPageViewModel()
        {
            ChosenDate = DateTime.Now;
        }

        private ApodService service;
        public ApodService Service
        {
            get
            {
                if (service == null)
                {
                    service = new ApodService();
                }
                return service;
            }
        }
        private async Task GetNasaImageOfTheDay(DateTime day)
        {
            SpaceImageDTO dto = await Service.GetImage(day);
            if (dto == null)
            {
                //ImageURI = defaultUri;
            }
            else
            {
                ImageURI = new Uri(dto.HdUrl);
                Didactic = dto.Explanation;
                Title = dto.Title;
            }
        }

        private DateTime dateTime;

        public DateTime ChosenDate
        {
            get { return dateTime; }
            set
            {
                if (value != dateTime)
                {
                    dateTime = value;
                    NotifyPropertyChanged();
                    _ = GetNasaImageOfTheDay(dateTime);
                }

            }
        }

        //private string imageSource;

        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                if (value != title)
                {
                    title = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private Uri imageUri;

        public Uri ImageURI
        {
            get { return imageUri; }
            set
            {
                if (imageUri != value)
                {
                    imageUri = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string didactic;

        public string Didactic
        {
            get { return didactic; }
            set
            {
                if (didactic != value)
                {
                    didactic = value;
                    NotifyPropertyChanged();
                }
            }
        }

    }
}
