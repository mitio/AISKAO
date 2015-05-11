// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>TechnoLogica.Eservices.InformationObjects</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net40</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>ASCII</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace TechnoLogica.Eservices.InformationObjects {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/R-1012")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ereg.egov.bg/segment/R-1012", IsNullable=true)]
    public partial class CROZResultInformationPeriodData : InformationObject<CROZResultInformationPeriodData> {
        
        private System.DateTime periodStartDateField;
        
        private bool periodStartDateFieldSpecified;
        
        private System.DateTime periodEndDateField;
        
        private bool periodEndDateFieldSpecified;
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=0)]
        public System.DateTime PeriodStartDate {
            get {
                return this.periodStartDateField;
            }
            set {
                if ((periodStartDateField.Equals(value) != true)) {
                    this.periodStartDateField = value;
                    this.OnPropertyChanged("PeriodStartDate");
                }
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PeriodStartDateSpecified {
            get {
                return this.periodStartDateFieldSpecified;
            }
            set {
                if ((periodStartDateFieldSpecified.Equals(value) != true)) {
                    this.periodStartDateFieldSpecified = value;
                    this.OnPropertyChanged("PeriodStartDateSpecified");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime PeriodEndDate {
            get {
                return this.periodEndDateField;
            }
            set {
                if ((periodEndDateField.Equals(value) != true)) {
                    this.periodEndDateField = value;
                    this.OnPropertyChanged("PeriodEndDate");
                }
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PeriodEndDateSpecified {
            get {
                return this.periodEndDateFieldSpecified;
            }
            set {
                if ((periodEndDateFieldSpecified.Equals(value) != true)) {
                    this.periodEndDateFieldSpecified = value;
                    this.OnPropertyChanged("PeriodEndDateSpecified");
                }
            }
        }
    }
}