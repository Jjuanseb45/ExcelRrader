using System.Data;
using MatBlazor;

namespace WebApplication.Services
{
    public interface IExcelReaderService
    {
        public DataSet Read(string path);
    }
}