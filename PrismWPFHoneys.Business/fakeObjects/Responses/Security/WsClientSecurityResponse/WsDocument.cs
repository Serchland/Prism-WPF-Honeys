using PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.Responses.Security.WsClientSecurityResponse
{
    public class WsDocument
    {
        public string Id { get; set; }
        public TipoMetadatos EniFields { get; set; }
        public WsControlDocumentFields ControlFields { get; set; }
        public WsSartidoFields SartidoFields { get; set; }
        public WsSicresFields SicresFields { get; set; }
        public WsSgdaFields SgdaFields { get; set; }
        public WsEditAction EditAction { get; set; }
        public WsStorageFields StorageFields { get; set; }
        public long AuxId { get; set; }
        public long Fdrid { get; set; }
        public long ParentId { get; set; }
        public string Name { get; set; }
        public string NameFromDb { get; set; }
        public byte[] Content { get; set; }
        public long Order { get; set; }
        public long LogicalOrder { get; set; }
        public string Remarks { get; set; }
        public string Extension { get; set; }
        public DocumentType Type { get; set; }
        public string Code { get; set; }
        public bool CanRename { get; set; }
        public bool CanDelete { get; set; }
        public bool CanShowNotiDetail { get; set; }
        public bool CanShowComuDetail { get; set; }
        public bool CanMove { get; set; }
        public bool IsCopied { get; set; }
        public string divider { get; set; }
        public string subDivider { get; set; }
        public string HashCodeField { get; set; }
        public List<WsMetadatosEniSignature> EniSignatureFields { get; set; }
        public RequireStampMetadata RequireStampMetadataDoc { get; set; } // Requiere sello Metadata
        public StateSignature StateSignature { get; set; }
        public string SignErrorMessage { get; set; }
        public bool XmlConvertedToPdf { get; set; } // Solo SGDA
        public byte[] OriginContent { get; set; }    // Solo SGDA
        public string PathDividers { get; set; }
        public bool IsProtectedWithUserPassword { get; set; } = false;
        public bool CanSendEessi { get; set; } = true;
        public bool MetaDataSetToEni { get; set; } = default(Boolean);
        public bool CanDownloadXml { get; set; } = false;
        public OperationFields OperationFields { get; set; }
        public bool CanDownloadSolicitud { get; set; } = false;
        public WsSgdaMetadata SgdaMetaData { get; set; }
        public WsDocSgdaMetadata DocumentoSgdaMetadata { get; set; }
        public OtherDocumentType OtherDocumentType { get; set; }
        public bool CanChangeSgdaType { get; set; } = false;
        public bool CanTraspasarToDocAux { get; set; } = false;
        public bool ToSgda { get; set; } = false;
        public bool HasSIR { get; set; }
        public string Ticket { get; set; }
    }
}
