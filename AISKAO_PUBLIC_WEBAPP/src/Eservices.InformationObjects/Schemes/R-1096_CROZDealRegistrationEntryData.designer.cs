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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ereg.egov.bg/segment/R-1096")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://ereg.egov.bg/segment/R-1096", IsNullable=true)]
    public partial class CROZDealRegistrationEntryData : CROZRegistrationEntryBasicData, System.ComponentModel.INotifyPropertyChanged {
        
        private CROZRegistrationEntryCreditorsData cROZRegistrationEntryCreditorsDataField;
        
        private CROZRegistrationEntryDebtorsData cROZRegistrationEntryDebtorsDataField;
        
        /// <summary>
        /// CROZDealRegistrationEntryData class constructor
        /// </summary>
        public CROZDealRegistrationEntryData() {
            this.cROZRegistrationEntryDebtorsDataField = new CROZRegistrationEntryDebtorsData();
            this.cROZRegistrationEntryCreditorsDataField = new CROZRegistrationEntryCreditorsData();
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public CROZRegistrationEntryCreditorsData CROZRegistrationEntryCreditorsData {
            get {
                return this.cROZRegistrationEntryCreditorsDataField;
            }
            set {
                if ((this.cROZRegistrationEntryCreditorsDataField != null)) {
                    if ((cROZRegistrationEntryCreditorsDataField.Equals(value) != true)) {
                        this.cROZRegistrationEntryCreditorsDataField = value;
                        this.OnPropertyChanged("CROZRegistrationEntryCreditorsData");
                    }
                }
                else {
                    this.cROZRegistrationEntryCreditorsDataField = value;
                    this.OnPropertyChanged("CROZRegistrationEntryCreditorsData");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public CROZRegistrationEntryDebtorsData CROZRegistrationEntryDebtorsData {
            get {
                return this.cROZRegistrationEntryDebtorsDataField;
            }
            set {
                if ((this.cROZRegistrationEntryDebtorsDataField != null)) {
                    if ((cROZRegistrationEntryDebtorsDataField.Equals(value) != true)) {
                        this.cROZRegistrationEntryDebtorsDataField = value;
                        this.OnPropertyChanged("CROZRegistrationEntryDebtorsData");
                    }
                }
                else {
                    this.cROZRegistrationEntryDebtorsDataField = value;
                    this.OnPropertyChanged("CROZRegistrationEntryDebtorsData");
                }
            }
        }
    }
}