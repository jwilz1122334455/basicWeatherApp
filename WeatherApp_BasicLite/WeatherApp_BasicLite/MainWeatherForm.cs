using Newtonsoft.Json;
using System.Net;
using System.Globalization;

//guided by: https://www.youtube.com/watch?v=zW26MZBV-9o and Copilot

namespace WeatherApp_BasicLite
{
    public partial class MainWeatherForm : Form
    {
        public MainWeatherForm()
        {
            InitializeComponent();
            TxtCity.KeyDown += TxtCity_KeyDown;
            this.Load += MainWeatherForm_Load;
        }

        private System.Windows.Forms.Timer weatherTimer;

        private void MainWeatherForm_Load(object sender, EventArgs e)
        {
            weatherTimer = new System.Windows.Forms.Timer();
            weatherTimer.Interval = 60 * 60 * 1000; // 1 hr interval
            weatherTimer.Tick += WeatherTimer_Tick;
            weatherTimer.Start();
        }

        private string _lastCity;
        private DateTime _lastFetchTime;
        private WeatherData.WeatherResponse _lastWeatherData;

        private void WeatherTimer_Tick(object sender, EventArgs e)
        {
            GetWeather();
        }

        private void TxtCity_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetWeather();
                e.SuppressKeyPress = true;
            }
        }

        string APIKey = "3e2b3c1c3f0d4eb6e559be0207afdfeb";

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetWeather();
            weatherTimer?.Stop();
            weatherTimer?.Start();
        }

        string GetWindDirection(int degrees)
        {
            string[] directions = { "N", "NE", "E", "SE", "S", "SW", "W", "NW" };
            return directions[(int)Math.Round(((double)degrees % 360) / 45)];
        }

        void GetWeather()
        {
            try
            {
                string city = TxtCity.Text.Trim();
                if (string.IsNullOrEmpty(city)) return;

                // Check cache: same city and within 10 minutes
                if (_lastCity != null &&
                    string.Equals(_lastCity, city, StringComparison.OrdinalIgnoreCase) &&
                    (DateTime.Now - _lastFetchTime).TotalMinutes < 60 &&
                    _lastWeatherData != null)
                {
                    // Use cached data
                    DisplayWeatherData(_lastWeatherData);
                    return;
                }
                else
                {
                    using WebClient web = new WebClient();
                    string url = $"https://api.openweathermap.org/data/2.5/weather?q={TxtCity.Text}&appid={APIKey}&units=metric";
                    var json = web.DownloadString(url);
                    WeatherData.WeatherResponse Info = JsonConvert.DeserializeObject<WeatherData.WeatherResponse>(json);

                    _lastCity = city;
                    _lastFetchTime = DateTime.Now;
                    _lastWeatherData = Info;

                    DisplayWeatherData(Info);
                    LblLastUpdate.Text = $"Last updated at {_lastFetchTime:HH:mm}";
                }
            }
            catch (Exception ex)
            {
                if (_lastWeatherData != null)
                {
                    DisplayWeatherData(_lastWeatherData);
                    LblLastUpdate.Text = $"Last updated at {_lastFetchTime:HH:mm} (cached)";
                    
                    MessageBox.Show("Unable to refresh weather data. Showing last cached result.\n\n" + ex.Message,
                        "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // No cached data available
                    MessageBox.Show("Unable to get weather data. Please check the city name or your Internet connection.\n\n" + ex.Message,
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayWeatherData(WeatherData.WeatherResponse Info)
        {
            if (Info == null) return;

            LblCity.Text = Info.name.ToString();
            string countryCode = Info.sys.country;
            RegionInfo region = new RegionInfo(countryCode);
            LblCountry.Text = region.EnglishName;

            LblCondition.Text = Info.weather[0].main;
            LblDetail.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Info.weather[0].description);
            LblWind.Text = $"{Info.wind.speed} m/s, {GetWindDirection((int)Info.wind.deg)}";
            LblPressure.Text = $"{Info.main.pressure} hPa";
            LblHumid.Text = $"{Info.main.humidity}%";

            LblTemp.Text = $"{Info.main.temp:F1} °C";
            PicIcon.ImageLocation = $"https://openweathermap.org/img/w/{Info.weather[0].icon}.png";
            LblTempMin.Text = $"{Info.main.temp_min:F1}°C";
            LblTempMax.Text = $"{Info.main.temp_max:F1}°C";
            LblFeelsLike.Text = $"{Info.main.feels_like:F1}°C";
            LblCloudCover.Text = $"{Info.clouds.all}%";
            LblVisibility.Text = $"{Info.visibility} km";
            LblSunrise.Text = ConvertDateTime(Info.sys.sunrise).ToShortTimeString();
            LblSunset.Text = ConvertDateTime(Info.sys.sunset).ToShortTimeString();
        }

        DateTime ConvertDateTime(long sec)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(sec).ToLocalTime();
        }
    }
}
