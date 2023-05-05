using USIL.BL.BE;
using USIL.DL.DLAC;

namespace USIL.BL.BC
{
    public class DocumentoBC
    {
        public List<DocumentoBE> DocumentoListar()
        {
            try
            {
                DocumentoDLAC objDocumentoDALC = new DocumentoDLAC();
                return objDocumentoDALC.DocumentoListar();
            }
            catch (Exception ex)
            {
                return new List<DocumentoBE>();
            }

        }

        public bool DocumentoInsertar(DocumentoBE objDocumentoBE)
        {
            try
            {
                DocumentoDLAC objDocumentoDALC = new DocumentoDLAC();
                return objDocumentoDALC.DocumentoInsertar(objDocumentoBE);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool DocumentoEditar(DocumentoBE objDocumentoBE)
        {
            try
            {
                DocumentoDLAC objDocumentoDALC = new DocumentoDLAC();
                return objDocumentoDALC.DocumentoEditar(objDocumentoBE);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool DocumentoEliminar(DocumentoBE objDocumentoBE)
        {
            try
            {
                DocumentoDLAC objDocumentoDALC = new DocumentoDLAC();
                return objDocumentoDALC.DocumentoEliminar(objDocumentoBE);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
