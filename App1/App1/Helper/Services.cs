using App1.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Text;

namespace App1.Helper
{
    /// <summary>
    /// Implementation of WebAPI service to be displayed.
    /// </summary>
    public class WebAPIService
    {
        #region Fields 

        System.Net.Http.HttpClient client;

        #endregion

        #region Properties 

        public ObservableCollection<FlyList> Items
        {
            get; private set;
        }

        public string WebAPIUrl
        {
            get; private set;
        }

        #endregion

        #region Constructor
        public WebAPIService()
        {
            client = new System.Net.Http.HttpClient();
        }

        #endregion

        #region Methods
        public async System.Threading.Tasks.Task<ObservableCollection<FlyList>> RefreshDataAsync()
        {
            WebAPIUrl = "https://heaspws.sgairport.com/HEAS-WSRV-Rest-6-0/heas_s1/heas_pgt_park_srv/list_pgt_flight_heas_test"; // Set your REST API url here
            var uri = new Uri(WebAPIUrl);
            try
            {
                var response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {

                    var content = await response.Content.ReadAsStringAsync();
                  
                    Items = new ObservableCollection<FlyList>();

                    var FromJson = JsonConvert.DeserializeObject<Rootobject>(content);
                    
                    foreach (FlyList dto in FromJson.FlyList)
                    {
                        //Console.WriteLine(dto.PgtId);
                        Items.Add(dto);
                    }
                    
                    
                                  
                    return Items;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(".................................................Erorr:" + ex);
            }
            return null;
        }

        #endregion

        
    }



}
