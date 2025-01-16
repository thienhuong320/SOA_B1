using CityWsRef;

namespace CityClient
{
    public partial class Form1 : Form
    {
        // Tạo một đối tượng WebService1SoapClient
        private CityWSSoapClient client;
        public Form1()
        {
            InitializeComponent();
            client = new CityWSSoapClient(CityWSSoapClient.EndpointConfiguration.CityWSSoap);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Phương thức gọi getAllCities và hiển thị kết quả trong DataGridView
        private void btnGetAllCities_Click(object sender, EventArgs e)
        {
            try
            {
                var citiesResponse = client.getAllCitiesAsync();
                var a= citiesResponse.Result;
                dataGridView1.DataSource = a;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Gọi dịch vụ web để lấy thành phố theo tên.
        private async void btnGetCityByName_Click(object sender, EventArgs e)
        {
            
        }

        // Gọi dịch vụ web để lấy tất cả thành phố của một quốc gia.
        private async void btnGetCitiesByCountry_Click(object sender, EventArgs e)
        {
            
        }

        // Gọi dịch vụ web để lấy thông tin quốc gia theo mã.
        private async void btnGetCountryByCode_Click(object sender, EventArgs e)
        {
            
        }

        // Phương thức gọi GetCountriesByPopulation và hiển thị kết quả
        private async void btnGetCountriesByPopulation_Click(object sender, EventArgs e)
        {
            
        }

        // Đảm bảo đóng client khi ứng dụng đóng.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
            {
                client.Close();
            }
        }

    }
}