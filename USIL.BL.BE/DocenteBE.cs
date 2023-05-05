namespace USIL.BL.BE
{
    public class DocenteBE
    {
        public int DocenteID { get; set; }
        public int Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos_paterno { get; set; }
        public string Apellidos_materno { get; set; }
        public int Nro_Documento { get; set; }
        public int DocumentoID { get; set; }
        public int CarreraID { get; set; }
        public string Estado { get; set; }
    }
}