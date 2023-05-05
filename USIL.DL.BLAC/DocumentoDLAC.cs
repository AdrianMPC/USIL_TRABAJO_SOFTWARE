using USIL.BL.BE;
using System.Data;
using System.Data.SqlClient;

namespace USIL.DL.DLAC
{
    public class DocumentoDLAC
    {
        private string Codigo = "@Codigo";
        private string Nombres = "@Nombre";
        private string Estado = "@Estado";
        private string strCadenaConexion = "Data Source=DESKTOP-QCCGD0O\\SQLEXPRESS01;Initial Catalog=USIL;Integrated Security=True";

        public List<DocumentoBE> DocumentoListar()
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspTipoDocumentoListar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                List<DocumentoBE> LstDocumentoBE = new List<DocumentoBE>();

                Con.Open();
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    DocumentoBE objDocumentoBE = new DocumentoBE();
                    objDocumentoBE.Codigo = Convert.ToInt32(reader[0]);
                    objDocumentoBE.Nombre = reader[1].ToString();
                    LstDocumentoBE.Add(objDocumentoBE);
                }
                reader.Close();

                return LstDocumentoBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DocumentoInsertar(DocumentoBE objDocumentoBE)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspTipoDocumentoInsertar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[2];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = Codigo;
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = objDocumentoBE.Codigo;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = Nombres;
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 20;
                arrSqlParameter[1].Value = objDocumentoBE.Nombre;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = Estado;
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 3;
                arrSqlParameter[2].Value = objDocumentoBE.Estado;

                Cmd.Parameters.AddRange(arrSqlParameter);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DocumentoEditar(DocumentoBE objDocumentoBE)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspTipoDocumentoEditar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[2];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = Codigo;
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = objDocumentoBE.Codigo;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = Nombres;
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 20;
                arrSqlParameter[1].Value = objDocumentoBE.Nombre;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = Estado;
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 3;
                arrSqlParameter[2].Value = objDocumentoBE.Estado;

                Cmd.Parameters.AddRange(arrSqlParameter);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DocumentoEliminar(DocumentoBE objDocumentoBE)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspTipoDocumentoEliminar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter arrSqlParameter = new SqlParameter();

                arrSqlParameter.ParameterName = Codigo;
                arrSqlParameter.SqlDbType = SqlDbType.Int;
                arrSqlParameter.Value = objDocumentoBE.Codigo;

                Cmd.Parameters.Add(arrSqlParameter);
                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
