using USIL.BL.BE;
using System.Data;
using System.Data.SqlClient;

namespace USIL.DL.DLAC
{
    public class DocenteDLAC
    {
        private string DocenteID = "@DocenteId";
        private string Codigo = "@Codigo";
        private string Nombres = "@Nombres";
        private string Apellidos_paterno = "@Apellidos_paterno";
        private string Apellidos_materno = "@Apellidos_materno";
        private string Nro_Documento = "@Nro_Documento";
        private string DocumentoID = "@DocumentoID";
        private string CarreraID = "@CarreraID";
        private string Estado = "@Estado";
        private string strCadenaConexion = "Data Source=DESKTOP-QCCGD0O\\SQLEXPRESS01;Initial Catalog=USIL;Integrated Security=True";

        public List<DocenteBE> DocenteListar()
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspDocenteListar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                List<DocenteBE> LstDocenteBE = new List<DocenteBE>();

                Con.Open();
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    DocenteBE objDocenteBE = new DocenteBE();
                    objDocenteBE.DocenteID = Convert.ToInt32(reader[0]);
                    objDocenteBE.Codigo = Convert.ToInt32(reader[1]);
                    objDocenteBE.Nombres = reader[2].ToString();
                    objDocenteBE.Apellidos_paterno = reader[3].ToString();
                    objDocenteBE.Apellidos_materno = reader[4].ToString();
                    objDocenteBE.Nro_Documento = Convert.ToInt32(reader[5]);
                    objDocenteBE.DocumentoID = Convert.ToInt32(reader[6]);
                    objDocenteBE.CarreraID = Convert.ToInt32(reader[7]);

                    LstDocenteBE.Add(objDocenteBE);
                }
                reader.Close();

                return LstDocenteBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DocenteInsertar(DocenteBE objDocenteBE)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspDocenteInsertar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[8];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = DocenteID;
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = objDocenteBE.DocenteID;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = Codigo;
                arrSqlParameter[1].SqlDbType = SqlDbType.Int;
                arrSqlParameter[1].Value = objDocenteBE.Codigo;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = Nombres;
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 20;
                arrSqlParameter[2].Value = objDocenteBE.Nombres;

                arrSqlParameter[3] = new SqlParameter();
                arrSqlParameter[3].ParameterName = Apellidos_paterno;
                arrSqlParameter[3].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[3].Size = 50;
                arrSqlParameter[3].Value = objDocenteBE.Apellidos_paterno;

                arrSqlParameter[4] = new SqlParameter();
                arrSqlParameter[4].ParameterName = Apellidos_materno;
                arrSqlParameter[4].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[4].Size = 50;
                arrSqlParameter[4].Value = objDocenteBE.Apellidos_materno;

                arrSqlParameter[5] = new SqlParameter();
                arrSqlParameter[5].ParameterName = Nro_Documento;
                arrSqlParameter[5].SqlDbType = SqlDbType.Int;
                arrSqlParameter[5].Value = objDocenteBE.Nro_Documento;

                arrSqlParameter[6] = new SqlParameter();
                arrSqlParameter[6].ParameterName = DocumentoID;
                arrSqlParameter[6].SqlDbType = SqlDbType.Int;
                arrSqlParameter[6].Value = objDocenteBE.DocumentoID;

                arrSqlParameter[7] = new SqlParameter();
                arrSqlParameter[7].ParameterName = CarreraID;
                arrSqlParameter[7].SqlDbType = SqlDbType.Int;
                arrSqlParameter[7].Value = objDocenteBE.CarreraID;

                arrSqlParameter[8] = new SqlParameter();
                arrSqlParameter[8].ParameterName = Estado;
                arrSqlParameter[8].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[8].Size = 3;
                arrSqlParameter[8].Value = objDocenteBE.Estado;

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
        public bool DocenteEditar(DocenteBE objDocenteBE)
        {
            try
            { 
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspDocenteEditar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter[] arrSqlParameter = new SqlParameter[8];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = DocenteID;
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = objDocenteBE.DocenteID;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = Codigo;
                arrSqlParameter[1].SqlDbType = SqlDbType.Int;
                arrSqlParameter[1].Value = objDocenteBE.Codigo;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = Nombres;
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 20;
                arrSqlParameter[2].Value = objDocenteBE.Nombres;

                arrSqlParameter[3] = new SqlParameter();
                arrSqlParameter[3].ParameterName = Apellidos_paterno;
                arrSqlParameter[3].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[3].Size = 50;
                arrSqlParameter[3].Value = objDocenteBE.Apellidos_paterno;

                arrSqlParameter[4] = new SqlParameter();
                arrSqlParameter[4].ParameterName = Apellidos_materno;
                arrSqlParameter[4].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[4].Size = 50;
                arrSqlParameter[4].Value = objDocenteBE.Apellidos_materno;

                arrSqlParameter[5] = new SqlParameter();
                arrSqlParameter[5].ParameterName = Nro_Documento;
                arrSqlParameter[5].SqlDbType = SqlDbType.Int;
                arrSqlParameter[5].Value = objDocenteBE.Nro_Documento;

                arrSqlParameter[6] = new SqlParameter();
                arrSqlParameter[6].ParameterName = DocumentoID;
                arrSqlParameter[6].SqlDbType = SqlDbType.Int;
                arrSqlParameter[6].Value = objDocenteBE.DocumentoID;

                arrSqlParameter[7] = new SqlParameter();
                arrSqlParameter[7].ParameterName = CarreraID;
                arrSqlParameter[7].SqlDbType = SqlDbType.Int;
                arrSqlParameter[7].Value = objDocenteBE.CarreraID;

                arrSqlParameter[8] = new SqlParameter();
                arrSqlParameter[8].ParameterName = Estado;
                arrSqlParameter[8].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[8].Size = 3;
                arrSqlParameter[8].Value = objDocenteBE.Estado;

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
        public bool DocenteEliminar(DocenteBE objDocenteBE)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspDocenteEliminar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                SqlParameter arrSqlParameter = new SqlParameter();

                arrSqlParameter.ParameterName = Codigo;
                arrSqlParameter.SqlDbType = SqlDbType.Int;
                arrSqlParameter.Value = objDocenteBE.Codigo;

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