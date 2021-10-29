using NewsTime_APIRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace NewsTime_APIRest.Data.Services
{
    public class HistoryService : IHistoryService
    {
        private readonly IConfiguration _configuration;

        public HistoryService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public bool AddHistory(History history)
        {
            string sql = "INSERT INTO histories (UserID, City, ObservationTime, Temperature, WeatherDescriptions, WindSpeed, WindDegree, WindDir, Pressure, Precip, Humidity, Cloudcover, Feelslike, UvIndex, Visibility) Values (@UserID, @City, @ObservationTime, @Temperature, @WeatherDescriptions, @WindSpeed, @WindDegree, @WindDir, @Pressure, @Precip, @Humidity, @Cloudcover, @Feelslike, @UvIndex, @Visibility);";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("NewsTimeDatabase")))
            {
                int affectedRows = connection.Execute(sql, new { UserID = history.UserID, City = history.City, ObservationTime = history.ObservationTime, Temperature = history.Temperature, WeatherDescriptions = history.WeatherDescriptions, WindSpeed = history.WindSpeed, WindDegree = history.WindDegree, WindDir = history.WindDir, Pressure = history.Pressure, Precip = history.Precip, Humidity = history.Humidity, Cloudcover = history.Cloudcover, Feelslike = history.Feelslike, UvIndex = history.UvIndex, Visibility = history.Visibility });
                
                Console.WriteLine("lines : "+affectedRows);

                //                var customer = connection.Query<Customer>("Select * FROM CUSTOMERS WHERE CustomerName = 'Mark'").ToList();
                return affectedRows > 0;
            }
        }

        public Histories[] GetHistories()
        {
            string sql = "SELECT * FROM histories order by id DESC";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("NewsTimeDatabase")))
            {
                var histories = connection.Query<History>(sql);
                var historiesArray = histories.ToArray();
                Histories[] his = new Histories[historiesArray.Length];
                for (int i = 0; i < his.Length; i++)
                {
                    his[i] = new Histories();
                    his[i].City = historiesArray[i].City;
                    his[i].Info = historiesArray[i];
                }
                return his;
            }
            
        }

        public Task<History> GetHistory(int historyId)
        {
            throw new NotImplementedException();
        }

        public Task<History> UpdateHistory(History history)
        {
            throw new NotImplementedException();
        }
    }
}
