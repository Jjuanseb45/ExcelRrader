using System.Data;
using System.Diagnostics;
using System.IO;
using ExcelDataReader;
using MatBlazor;
using WebApplication.Data.Persona;

namespace WebApplication.Services
{
    public class ExcelReaderService : IExcelReaderService
    {
        public DataSet Read(string path)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            FileStream stream = File.Open(path, FileMode.Open);
            var reader = ExcelReaderFactory.CreateReader(stream,
                new ExcelReaderConfiguration() {FallbackEncoding = System.Text.Encoding.GetEncoding(1252)} );
            return reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_)=> new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });
        }
    }
}
/*
DataTable table = reader.AsDataSet().Tables[0];

DataRow row = table.Rows[0];
string cell = row[0].ToString();

Persona persona = new Persona()
{
    Apellido = row[0].ToString(),
    Aficion = row[1].ToString(),
    Nombre = row[2].ToString()
};

public DataSet Read(IMatFileUploadEntry path)
{
System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
var stream = new MemoryStream();
path.WriteToStreamAsync(stream);
var lector = new StreamReader(stream);
var reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
lector.ReadToEndAsync();
return reader.AsDataSet();
*/