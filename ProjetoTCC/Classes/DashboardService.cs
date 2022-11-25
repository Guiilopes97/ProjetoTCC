using Newtonsoft.Json;
using Debug = System.Diagnostics.Debug;


namespace ProjetoTCC.Classes
{
    public class DashboardService
    {
        HttpClient _client;

        public async Task<CovidData> GetCovidData(string query)
        {
            CovidData data = null;
            try
            {

                _client = new HttpClient();
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<CovidData>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            return data;
        }
    }
}
