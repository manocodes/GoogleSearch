using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;

namespace ConsoleApp1.Helper
{
    public static class GoogleAPIsHelper
    {
        public static Search CustomSearch(string search, int page = 1)
        {
            //Replace the apiKey and cx with your credentials
            string apiKey = "AIzaSyDRMKZp6sVuVPHqRPx-pvelErYHbzDy3MQ";
            string cx = "000420779400315047402:ddap67tihk4";
            string query = search;

            CustomsearchService service = new CustomsearchService(new BaseClientService.Initializer
            {
                ApplicationName = "Google Custom Search Demo",
                ApiKey = apiKey,
            });

            CseResource.ListRequest listRequest = service.Cse.List(query);
            listRequest.Cx = cx;
            listRequest.Start = page;
            Search gSearch = listRequest.Execute();
            
            return gSearch;
        }
    }
}
