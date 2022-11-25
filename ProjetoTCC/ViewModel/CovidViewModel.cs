using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using ProjetoTCC.Classes;

namespace ProjetoTCC.ViewModel
{
    public partial class CovidViewModel : ObservableObject
    {
        [JsonProperty("data")]
        public Covid covid { get; set; }

        IConnectivity connectivity;

        public CovidViewModel(IConnectivity connectivity)
        {
            this.connectivity = connectivity;

        }

    }
}
