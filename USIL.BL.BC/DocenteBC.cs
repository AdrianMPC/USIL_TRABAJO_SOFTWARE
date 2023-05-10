using USIL.BL.BE;
using USIL.DL.DLAC;

namespace USIL.BL.BC
{
    public class DocenteBC
    {
        public List<DocenteBE> DocenteListar()
        {
            try
            {
                DocenteDLAC objDocenteDALC = new DocenteDLAC();
                return objDocenteDALC.DocenteListar();
            }
            catch (Exception ex)
            {
                return new List<DocenteBE>();
            }

        }

        public bool DocenteInsertar(DocenteBE objDocenteBE)
        {
            try
            {
                DocenteDLAC objDocenteDALC = new DocenteDLAC();
                return objDocenteDALC.DocenteInsertar(objDocenteBE);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool DocenteEditar(DocenteBE objDocenteBE)
        {
            try
            {
                DocenteDLAC objDocenteDALC = new DocenteDLAC();
                return objDocenteDALC.DocenteEditar(objDocenteBE);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool DocenteEliminar(DocenteBE objDocenteBE)
        {
            try
            {
                DocenteDLAC objDocenteDALC = new DocenteDLAC();
                return objDocenteDALC.DocenteEliminar(objDocenteBE);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DocenteBE DocenteObtener(DocenteBE objDocenteBE)
        {
            try
            {
                DocenteDLAC objDocenteDALC = new DocenteDLAC();
                return objDocenteDALC.DocenteObtener(objDocenteBE);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}