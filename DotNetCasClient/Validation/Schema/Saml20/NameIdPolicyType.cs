﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace DotNetCasClient.Validation.Schema.Saml20
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:tc:SAML:2.0:protocol")]
    [XmlRoot("NameIDPolicy", Namespace="urn:oasis:names:tc:SAML:2.0:protocol", IsNullable=false)]
    public class NameIdPolicyType {
        [XmlAttribute(DataType="anyURI")]
        public string Format
        {
            get;
            set;
        }

        [XmlAttribute("SPNameQualifier")]
        public string SpNameQualifier
        {
            get;
            set;
        }

        [XmlAttribute]
        public bool AllowCreate
        {
            get;
            set;
        }

        [XmlIgnore]
        public bool AllowCreateSpecified
        {
            get;
            set;
        }
    }
}