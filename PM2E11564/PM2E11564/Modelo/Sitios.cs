using SQLite;

namespace PM2E11564.Modelo
{
    public class Sitios

    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public byte[] foto { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
        public string descripcion { get; set; }
    }
}
