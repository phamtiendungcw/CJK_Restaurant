using System;
using System.Threading.Tasks;
using CJK.Web.Models;

namespace CJK.Web.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDto responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
