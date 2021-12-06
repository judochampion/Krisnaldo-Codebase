using KNDPlayerDataAccess;
using RestSharp;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppOct5.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public ObservableCollection<KNDPlayer> Current_Players { get; set; } = new ObservableCollection<KNDPlayer>();

        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            Load_Players_Command = new Command(async () => await Load_Players());
            Current_Players = new ObservableCollection<KNDPlayer>(new List<KNDPlayer>() { new KNDPlayer() { First_Name = "Wout" } });
        }

        public ICommand OpenWebCommand { get; }
        public ICommand Load_Players_Command { get; }

        //source https://gist.github.com/acamino/51ae7fa45708bc1e8bcda5657374aa48
        public Task<List<KNDPlayer>> Load_Players()
        {
            var client = new RestClient("https://knd-api.azurewebsites.net");

            var request = new RestRequest("Helloworld", Method.GET);
            // Add HTTP headers
            request.AddHeader("User-Agent", "Nothing");

            // Execute the request and automatically deserialize the result.
            var contributors = client.Execute<List<KNDPlayer>>(request);
            contributors.Data.ForEach(x => Current_Players.Add(x));

            Current_Players.Add(new KNDPlayer { First_Name = "Tom" });

            return Task.FromResult<List<KNDPlayer>>(null);
        }
    }
}