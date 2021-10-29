using NewsTime_APIRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsTime_APIRest.Data.Services
{
    interface IHistoryService
    {
        Histories[] GetHistories();
        Task<History> GetHistory(int historyId);
        bool AddHistory(History history);
        Task<History> UpdateHistory(History history);
    }
}
