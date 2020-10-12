using _6.gyakorlat.Entities;
using _6.gyakorlat.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.gyakorlat
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        public Form1()
        {
            InitializeComponent();

            ExchangeRates();

            dataGridView1.DataSource = Rates;

        }
        public void ExchangeRates()
        {
            var mbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;
        }
    }
}
