//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.0.719.0
namespace Dev4Agriculture.ISO11783.ISOXML.LinkListFile
{
    
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.719.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ISO11783LinkList", Namespace="", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ISO11783LinkList", Namespace="")]
    public partial class ISO11783LinkListFile
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ISOLinkGroup> _linkGroup;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("LGP")]
        public System.Collections.ObjectModel.Collection<ISOLinkGroup> LinkGroup
        {
            get
            {
                return _linkGroup;
            }
            private set
            {
                _linkGroup = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinkGroupSpecified
        {
            get
            {
                return (this.LinkGroup.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public ISO11783LinkListFile()
        {
            this._linkGroup = new System.Collections.ObjectModel.Collection<ISOLinkGroup>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private ISO11783LinkListFileVersionMajor _versionMajor = Dev4Agriculture.ISO11783.ISOXML.LinkListFile.ISO11783LinkListFileVersionMajor.TheversionofthesecondeditionpublishedasaFinalDraftInternationalStandard;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("VersionMajor")]
        public ISO11783LinkListFileVersionMajor VersionMajor
        {
            get
            {
                return _versionMajor;
            }
            set
            {
                _versionMajor = value;
            }
        }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("VersionMinor")]
        public ISO11783LinkListFileVersionMinor VersionMinor { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(32)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ManagementSoftwareManufacturer")]
        public string ManagementSoftwareManufacturer { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(32)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ManagementSoftwareVersion")]
        public string ManagementSoftwareVersion { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(32)]
        [System.Xml.Serialization.XmlAttributeAttribute("TaskControllerManufacturer")]
        public string TaskControllerManufacturer { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(32)]
        [System.Xml.Serialization.XmlAttributeAttribute("TaskControllerVersion")]
        public string TaskControllerVersion { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(32)]
        [System.Xml.Serialization.XmlAttributeAttribute("FileVersion")]
        public string FileVersion { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("DataTransferOrigin")]
        public ISO11783LinkListFileDataTransferOrigin DataTransferOrigin { get; set; }
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.719.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LGP", Namespace="", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("LGP", Namespace="")]
    public partial class ISOLinkGroup
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ISOLink> _link;
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("LNK")]
        public System.Collections.ObjectModel.Collection<ISOLink> Link
        {
            get
            {
                return _link;
            }
            private set
            {
                _link = value;
            }
        }
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LinkSpecified
        {
            get
            {
                return (this.Link.Count != 0);
            }
        }
        
        /// <summary>
        /// </summary>
        public ISOLinkGroup()
        {
            this._link = new System.Collections.ObjectModel.Collection<ISOLink>();
        }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(4)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(14)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(LGP|LGP-)([0-9])+")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("A")]
        public string LinkGroupId { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("B")]
        public ISOLinkGroupType LinkGroupType { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(64)]
        [System.Xml.Serialization.XmlAttributeAttribute("C")]
        public string ManufacturerGLN { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(255)]
        [System.Xml.Serialization.XmlAttributeAttribute("D")]
        public string LinkGroupNamespace { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(32)]
        [System.Xml.Serialization.XmlAttributeAttribute("E")]
        public string LinkGroupDesignator { get; set; }
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.719.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("LNK", Namespace="", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("LNK", Namespace="")]
    public partial class ISOLink
    {
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(4)]
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(14)]
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(BSN|CCT|CCG|CCL|CLD|CTP|CVT|CPC|CTR|DET|DVC|FRM|GGP|GPN|LSG|OTQ|PFD|PNT|PLN|PDT|" +
            "PGP|TSK|VPN|WKR)(|-)([0-9])+")]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("A")]
        public string ObjectIdRef { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(255)]
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("B")]
        public string LinkValue { get; set; }
        
        /// <summary>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(32)]
        [System.Xml.Serialization.XmlAttributeAttribute("C")]
        public string LinkDesignator { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.719.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ISOLinkGroupB", Namespace="", AnonymousType=true)]
    public enum ISOLinkGroupType
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        UUIDs,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        ManufacturerProprietary,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        UniqueResolvableURIs,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        InformationalResolvableURIs,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.719.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ISO11783LinkListFileVersionMajor", Namespace="", AnonymousType=true)]
    public enum ISO11783LinkListFileVersionMajor
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        TheversionofthesecondeditionpublishedasaFinalDraftInternationalStandard,
    }
    
    /// <summary>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.719.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ISO11783LinkListFileVersionMinor", Namespace="", AnonymousType=true)]
    public enum ISO11783LinkListFileVersionMinor
    {
        
        [System.Xml.Serialization.XmlEnumAttribute("0")]
        Item0,
        
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
        
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
        
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.719.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ISO11783LinkListFileDataTransferOrigin", Namespace="", AnonymousType=true)]
    public enum ISO11783LinkListFileDataTransferOrigin
    {
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        FMIS,
        
        /// <summary>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        MICS,
    }
}
