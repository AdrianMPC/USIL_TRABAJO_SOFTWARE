using System.Data;
using USIL.BL.BE;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;

namespace USIL.DL.DLAC
{
    public class CarreraDLAC
    {
        private string Codigo = "@Codigo";
        private string Nombres = "@Nombre";
        private string Estado = "@Estado";
        private string strCadenaConexion = "Data Source=DESKTOP-QCCGD0O\\SQLEXPRESS01;Initial Catalog=USIL;Integrated Security=True";

        public List<CarreraBE> CarreraListar()
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspCarreraListar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                List<CarreraBE> LstCarreraBE = new List<CarreraBE>();

                Con.Open();
                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    CarreraBE objCarreraBE = new CarreraBE();
                    objCarreraBE.Codigo = Convert.ToInt32(reader[0]);
                    objCarreraBE.Nombre = reader[1].ToString();
                    objCarreraBE.Estado = reader[2].ToString();
                    LstCarreraBE.Add(objCarreraBE);
                }
                reader.Close();

                return LstCarreraBE;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool CarreraInsertar(CarreraBE objCarreraBE)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspCarreraInsertar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] arrSqlParameter = new SqlParameter[3];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = Codigo;
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = objCarreraBE.Codigo;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = Nombres;
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 20;
                arrSqlParameter[1].Value = objCarreraBE.Nombre;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = Estado;
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 3;
                arrSqlParameter[2].Value = objCarreraBE.Estado;

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
        public bool CarreraEditar(CarreraBE objCarreraBE)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspCarreraEditar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] arrSqlParameter = new SqlParameter[3];

                arrSqlParameter[0] = new SqlParameter();
                arrSqlParameter[0].ParameterName = Codigo;
                arrSqlParameter[0].SqlDbType = SqlDbType.Int;
                arrSqlParameter[0].Value = objCarreraBE.Codigo;

                arrSqlParameter[1] = new SqlParameter();
                arrSqlParameter[1].ParameterName = Nombres;
                arrSqlParameter[1].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[1].Size = 20;
                arrSqlParameter[1].Value = objCarreraBE.Nombre;

                arrSqlParameter[2] = new SqlParameter();
                arrSqlParameter[2].ParameterName = Estado;
                arrSqlParameter[2].SqlDbType = SqlDbType.VarChar;
                arrSqlParameter[2].Size = 3;
                arrSqlParameter[2].Value = objCarreraBE.Estado;

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
        public bool CarreraEliminar(CarreraBE objCarreraBE)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspCarreraEliminar";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter arrSqlParameter = new SqlParameter();

                arrSqlParameter.ParameterName = Codigo;
                arrSqlParameter.SqlDbType = SqlDbType.Int;
                arrSqlParameter.Value = objCarreraBE.Codigo;

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

        public CarreraBE CarreraObtener(CarreraBE objCarreraBE)
        {
            try
            {
                SqlConnection Con = new SqlConnection(strCadenaConexion);
                String strSP = "uspCarreraObtener";
                SqlCommand Cmd = new SqlCommand(strSP, Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter arrSqlParameter = new SqlParameter();

                arrSqlParameter.ParameterName = Codigo;
                arrSqlParameter.SqlDbType = SqlDbType.Int;
                arrSqlParameter.Value = objCarreraBE.Codigo;

                CarreraBE carreraobj = new CarreraBE();
                Con.Open();
                Cmd.Parameters.Add(arrSqlParameter);
                Cmd.ExecuteNonQuery();

                SqlDataReader reader = Cmd.ExecuteReader();
                while (reader.Read())
                {
                    carreraobj.Codigo = Convert.ToInt32(reader[0]);
                    carreraobj.Nombre = reader[1].ToString();
                    carreraobj.Estado = reader[2].ToString();
                }
                Con.Close();
                return carreraobj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
