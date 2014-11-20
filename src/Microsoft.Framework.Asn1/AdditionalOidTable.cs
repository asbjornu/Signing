﻿using System;
using System.Collections.Generic;

namespace Microsoft.Framework.Asn1
{
    internal static class AdditionalOidTable
    {
        public static readonly Dictionary<string, string> OidToName = new Dictionary<string, string>() {
            { "1.3.6.1.4.1.311", "Microsoft OID" },
            { "1.3.6.1.4.1.311.2", "Authenticode" },
            { "1.3.6.1.4.1.311.2.1.4", "SPC_INDIRECT_DATA_OBJID" },
            { "1.3.6.1.4.1.311.2.1.10", "SPC_SP_AGENCY_INFO_OBJID" },
            { "1.3.6.1.4.1.311.2.1.11", "SPC_STATEMENT_TYPE_OBJID" },
            { "1.3.6.1.4.1.311.2.1.12", "SPC_SP_OPUS_INFO_OBJID" },
            { "1.3.6.1.4.1.311.2.1.14", "SPC_CERT_EXTENSIONS_OBJID" },
            { "1.3.6.1.4.1.311.2.1.15", "SPC_PE_IMAGE_DATA_OBJID" },
            { "1.3.6.1.4.1.311.2.1.18", "SPC_RAW_FILE_DATA_OBJID" },
            { "1.3.6.1.4.1.311.2.1.19", "SPC_STRUCTURED_STORAGE_DATA_OBJID" },
            { "1.3.6.1.4.1.311.2.1.20", "SPC_JAVA_CLASS_DATA_OBJID" },
            { "1.3.6.1.4.1.311.2.1.21", "SPC_INDIVIDUAL_SP_KEY_PURPOSE_OBJID" },
            { "1.3.6.1.4.1.311.2.1.22", "SPC_COMMERCIAL_SP_KEY_PURPOSE_OBJID" },
            { "1.3.6.1.4.1.311.2.1.25", "SPC_CAB_DATA_OBJID" },
            { "1.3.6.1.4.1.311.2.1.26", "SPC_MINIMAL_CRITERIA_OBJID" },
            { "1.3.6.1.4.1.311.2.1.27", "SPC_FINANCIAL_CRITERIA_OBJID" },
            { "1.3.6.1.4.1.311.2.1.28", "SPC_LINK_OBJID" },
            { "1.3.6.1.4.1.311.2.1.29", "SPC_HASH_INFO_OBJID" },
            { "1.3.6.1.4.1.311.2.1.30", "SPC_SIPINFO_OBJID" },
            { "1.3.6.1.4.1.311.2.2", "CTL for Software Publishers Trusted CAs" },
            { "1.3.6.1.4.1.311.2.2.1", "szOID_TRUSTED_CODESIGNING_CA_LIST" },
            { "1.3.6.1.4.1.311.2.2.2", "szOID_TRUSTED_CLIENT_AUTH_CA_LIST" },
            { "1.3.6.1.4.1.311.2.2.3", "szOID_TRUSTED_SERVER_AUTH_CA_LIST" },
            { "1.3.6.1.4.1.311.3", "Time Stamping" },
            { "1.3.6.1.4.1.311.3.2.1", "SPC_TIME_STAMP_REQUEST_OBJID" },
            { "1.3.6.1.4.1.311.4", "Permissions" },
            { "1.3.6.1.4.1.311.10", "Crypto 2.0" },
            { "1.3.6.1.4.1.311.10.1", "szOID_CTL" },
            { "1.3.6.1.4.1.311.10.1.1", "szOID_SORTED_CTL" },
            { "1.3.6.1.4.1.311.10.2", "szOID_NEXT_UPDATE_LOCATION" },
            { "1.3.6.1.4.1.311.10.3.1", "szOID_KP_CTL_USAGE_SIGNING" },
            { "1.3.6.1.4.1.311.10.3.2", "szOID_KP_TIME_STAMP_SIGNING" },
            { "1.3.6.1.4.1.311.10.3.3", "szOID_SERVER_GATED_CRYPTO" },
            { "1.3.6.1.4.1.311.10.3.3.1", "szOID_SERIALIZED" },
            { "1.3.6.1.4.1.311.10.3.4", "szOID_EFS_CRYPTO" },
            { "1.3.6.1.4.1.311.10.3.4.1", "szOID_EFS_RECOVERY" },
            { "1.3.6.1.4.1.311.10.3.5", "szOID_WHQL_CRYPTO" },
            { "1.3.6.1.4.1.311.10.3.6", "szOID_NT5_CRYPTO" },
            { "1.3.6.1.4.1.311.10.3.7", "szOID_OEM_WHQL_CRYPTO" },
            { "1.3.6.1.4.1.311.10.3.8", "szOID_EMBEDDED_NT_CRYPTO" },
            { "1.3.6.1.4.1.311.10.3.9", "szOID_ROOT_LIST_SIGNER" },
            { "1.3.6.1.4.1.311.10.3.10", "szOID_KP_QUALIFIED_SUBORDINATION" },
            { "1.3.6.1.4.1.311.10.3.11", "szOID_KP_KEY_RECOVERY" },
            { "1.3.6.1.4.1.311.10.3.12", "szOID_KP_DOCUMENT_SIGNING" },
            { "1.3.6.1.4.1.311.10.4.1", "szOID_YESNO_TRUST_ATTR" },
            { "1.3.6.1.4.1.311.10.5.1", "szOID_DRM" },
            { "1.3.6.1.4.1.311.10.5.2", "szOID_DRM_INDIVIDUALIZATION" },
            { "1.3.6.1.4.1.311.10.6.1", "szOID_LICENSES" },
            { "1.3.6.1.4.1.311.10.6.2", "szOID_LICENSE_SERVER" },
            { "1.3.6.1.4.1.311.10.7", "szOID_MICROSOFT_RDN_PREFIX" },
            { "1.3.6.1.4.1.311.10.7.1", "szOID_KEYID_RDN" },
            { "1.3.6.1.4.1.311.10.8.1", "szOID_REMOVE_CERTIFICATE" },
            { "1.3.6.1.4.1.311.10.9.1", "szOID_CROSS_CERT_DIST_POINTS" },
            { "1.3.6.1.4.1.311.10.10", "Microsoft CMC OIDs" },
            { "1.3.6.1.4.1.311.10.10.1", "szOID_CMC_ADD_ATTRIBUTES" },
            { "1.3.6.1.4.1.311.10.11", "Microsoft certificate property OIDs" },
            { "1.3.6.1.4.1.311.10.12", "CryptUI" },
            { "1.3.6.1.4.1.311.10.12.1", "szOID_ANY_APPLICATION_POLICY" },
            { "1.3.6.1.4.1.311.12", "Catalog" },
            { "1.3.6.1.4.1.311.12.1.1", "szOID_CATALOG_LIST" },
            { "1.3.6.1.4.1.311.12.1.2", "szOID_CATALOG_LIST_MEMBER" },
            { "1.3.6.1.4.1.311.12.2.1", "CAT_NAMEVALUE_OBJID" },
            { "1.3.6.1.4.1.311.12.2.2", "CAT_MEMBERINFO_OBJID" },
            { "1.3.6.1.4.1.311.13", "Microsoft PKCS10 OIDs" },
            { "1.3.6.1.4.1.311.13.1", "szOID_RENEWAL_CERTIFICATE" },
            { "1.3.6.1.4.1.311.13.2.1", "szOID_ENROLLMENT_NAME_VALUE_PAIR" },
            { "1.3.6.1.4.1.311.13.2.2", "szOID_ENROLLMENT_CSP_PROVIDER" },
            { "1.3.6.1.4.1.311.15", "Microsoft Java" },
            { "1.3.6.1.4.1.311.16", "Microsoft Outlook/Exchange" },
            { "1.3.6.1.4.1.311.16.4", "Outlook Express" },
            { "1.3.6.1.4.1.311.17.1", "szOID_LOCAL_MACHINE_KEYSET" },
            { "1.3.6.1.4.1.311.18", "Microsoft Hydra" },
            { "1.3.6.1.4.1.311.19", "Microsoft ISPU Test" },
            { "1.3.6.1.4.1.311.20", "Microsoft Enrollment Infrastructure" },
            { "1.3.6.1.4.1.311.20.1", "szOID_AUTO_ENROLL_CTL_USAGE" },
            { "1.3.6.1.4.1.311.20.2", "szOID_ENROLL_CERTTYPE_EXTENSION" },
            { "1.3.6.1.4.1.311.20.2.1", "szOID_ENROLLMENT_AGENT" },
            { "1.3.6.1.4.1.311.20.2.2", "szOID_KP_SMARTCARD_LOGON" },
            { "1.3.6.1.4.1.311.20.2.3", "szOID_NT_PRINCIPAL_NAME" },
            { "1.3.6.1.4.1.311.20.3", "szOID_CERT_MANIFOLD" },
            { "1.3.6.1.4.1.311.21", "Microsoft CertSrv Infrastructure" },
            { "1.3.6.1.4.1.311.21.1", "szOID_CERTSRV_CA_VERSION" },
            { "1.3.6.1.4.1.311.25", "Microsoft Directory Service" },
            { "1.3.6.1.4.1.311.25.1", "szOID_NTDS_REPLICATION" },
            { "1.3.6.1.4.1.311.30", "IIS" },
            { "1.3.6.1.4.1.311.31", "Windows updates and service packs" },
            { "1.3.6.1.4.1.311.31.1", "szOID_PRODUCT_UPDATE" },
            { "1.3.6.1.4.1.311.40", "Fonts" },
            { "1.3.6.1.4.1.311.41", "Microsoft Licensing and Registration" },
            { "1.3.6.1.4.1.311.42", "Microsoft Corporate PKI (ITG)" },
            { "1.3.6.1.4.1.311.88", "CAPICOM" },
            { "1.3.6.1.4.1.311.88.1", "szOID_CAPICOM_VERSION" },
            { "1.3.6.1.4.1.311.88.2", "szOID_CAPICOM_ATTRIBUTE" },
            { "1.3.6.1.4.1.311.88.2.1", "szOID_CAPICOM_DOCUMENT_NAME" },
            { "1.3.6.1.4.1.311.88.2.2", "szOID_CAPICOM_DOCUMENT_DESCRIPTION" },
            { "1.3.6.1.4.1.311.88.3", "szOID_CAPICOM_ENCRYPTED_DATA" },
            { "1.3.6.1.4.1.311.88.3.1", "szOID_CAPICOM_ENCRYPTED_CONTENT" }
        };
    }
}
