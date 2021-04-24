﻿namespace SPID.AspNetCore.Authentication.Saml
{
    internal class SamlConst
    {
        public const string IdPName = nameof(IdPName);
        public const string SamlAuthnRequestId = nameof(SamlAuthnRequestId);
        public const string SubjectNameId = nameof(SubjectNameId);
        public const string SamlLogoutRequestId = nameof(SamlLogoutRequestId);
        public const string AuthnStatementSessionIndex = nameof(AuthnStatementSessionIndex);
        public const string SignatureMethod = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";
        public const string DigestMethod = "http://www.w3.org/2001/04/xmlenc#sha256";

        public static string Version = "2.0";
        public static string Success = "urn:oasis:names:tc:SAML:2.0:status:Success";
        public static string Requester = "urn:oasis:names:tc:SAML:2.0:status:Requester"; //SC202104
        public static string IssuerFormat = "urn:oasis:names:tc:SAML:2.0:nameid-format:entity";
        public static string ProtocolBinding = "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST";
        public static string NameIDPolicyFormat = "urn:oasis:names:tc:SAML:2.0:nameid-format:transient";
        public static string Saml2pProtocol = "urn:oasis:names:tc:SAML:2.0:protocol";
        public static string LogoutUserProtocol = "urn:oasis:names:tc:SAML:2.0:logout:user";
        public static string samlp = nameof(samlp);
        public static string saml = nameof(saml);
        public static string Saml2Assertion = "urn:oasis:names:tc:SAML:2.0:assertion";
        public static string SpidL1 = "https://www.spid.gov.it/SpidL1";
        public static string SpidL2 = "https://www.spid.gov.it/SpidL2";
        public static string SpidL3 = "https://www.spid.gov.it/SpidL3";
        public static string SpidPP = "urn:oasis:names:tc:SAML:2.0:ac:classes:PasswordProtectedTransport";//SC202104 "SecurityLevel": 4
        public static string SpidExt = "urn:oasis:names:tc:SAML:2.0:ac:classes:SPIDExtended";//SC202104 "SecurityLevel": 5
        public static string Method = "urn:oasis:names:tc:SAML:2.0:cm:bearer";
        public static string name = nameof(name);
        public static string familyName = nameof(familyName);
        public static string fiscalNumber = nameof(fiscalNumber);
        public static string email = nameof(email);
        public static string digitalAddress = nameof(digitalAddress);
        public static string mail = nameof(mail);
        public static string surname = nameof(surname);
        public static string firstname = nameof(firstname);
        public static string address = nameof(address);
        public static string companyName = nameof(companyName);
        public static string countyOfBirth = nameof(countyOfBirth);
        public static string dateOfBirth = nameof(dateOfBirth);
        public static string expirationDate = nameof(expirationDate);
        public static string gender = nameof(gender);
        public static string idCard = nameof(idCard);
        public static string ivaCode = nameof(ivaCode);
        public static string mobilePhone = nameof(mobilePhone);
        public static string placeOfBirth = nameof(placeOfBirth);
        public static string registeredOffice = nameof(registeredOffice);
        public static string spidCode = nameof(spidCode);
        //SC202104 CodiceFiscale (!!) e altri campi ritornati da Shibboleth Cineca
        public static string schacPersonalUniqueID = nameof(schacPersonalUniqueID);
        public static string sn = nameof(sn);
        public static string givenName = nameof(givenName);
        public static string title = nameof(title);
        public static string uid = nameof(uid);
    }
}
