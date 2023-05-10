using USIL.BL.BE;
using USIL.DL.DLAC;

namespace USIL.BL.BC
{
    public class CarreraBC
    {
        public List<CarreraBE> CarreraListar()
        {
            try
            {
                CarreraDLAC objCarreraDALC = new CarreraDLAC();
                return objCarreraDALC.CarreraListar();
            }
            catch (Exception ex)
            {
                return new List<CarreraBE>();
            }

        }

        public bool CarreraInsertar(CarreraBE objCarreraBE)
        {
            try
            {
                CarreraDLAC objCarreraDALC = new CarreraDLAC();
                return objCarreraDALC.CarreraInsertar(objCarreraBE);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool CarreraEditar(CarreraBE objCarreraBE)
        {
            try
            {
                CarreraDLAC objCarreraDALC = new CarreraDLAC();
                return objCarreraDALC.CarreraEditar(objCarreraBE);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool CarreraEliminar(CarreraBE objCarreraBE)
        {
            try
            {
                CarreraDLAC objCarreraDALC = new CarreraDLAC();
                return objCarreraDALC.CarreraEliminar(objCarreraBE);
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public DocenteBE CarreraObtener(CarreraBE objCarreraBE)
        {
            try
            {
                CarreraDLAC objCarreraDALC = new CarreraDLAC();
                return objCarreraDALC.CarreraObtener(objCarreraBE);
            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}
