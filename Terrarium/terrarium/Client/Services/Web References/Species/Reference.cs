//------------------------------------------------------------------------------
//      Copyright (c) Microsoft Corporation.  All rights reserved.                                                                
//------------------------------------------------------------------------------

//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.573.
// 
namespace Terrarium.Services.Species {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SpeciesServiceSoap", Namespace="http://tempuri.org/")]
    public class SpeciesService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public SpeciesService() {
            this.Url = "http://lhsdkter2/Terrarium/Species/AddSpecies.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Add", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SpeciesServiceStatus Add(string name, string version, string type, string author, string email, string assemblyFullName, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] System.Byte[] assemblyCode) {
            object[] results = this.Invoke("Add", new object[] {
                        name,
                        version,
                        type,
                        author,
                        email,
                        assemblyFullName,
                        assemblyCode});
            return ((SpeciesServiceStatus)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAdd(string name, string version, string type, string author, string email, string assemblyFullName, System.Byte[] assemblyCode, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Add", new object[] {
                        name,
                        version,
                        type,
                        author,
                        email,
                        assemblyFullName,
                        assemblyCode}, callback, asyncState);
        }
        
        /// <remarks/>
        public SpeciesServiceStatus EndAdd(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((SpeciesServiceStatus)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetExtinctSpecies", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetExtinctSpecies(string version, string filter) {
            object[] results = this.Invoke("GetExtinctSpecies", new object[] {
                        version,
                        filter});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetExtinctSpecies(string version, string filter, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetExtinctSpecies", new object[] {
                        version,
                        filter}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetExtinctSpecies(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllSpecies", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetAllSpecies(string version, string filter) {
            object[] results = this.Invoke("GetAllSpecies", new object[] {
                        version,
                        filter});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetAllSpecies(string version, string filter, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetAllSpecies", new object[] {
                        version,
                        filter}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetAllSpecies(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSpeciesAssembly", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public System.Byte[] GetSpeciesAssembly(string name, string version) {
            object[] results = this.Invoke("GetSpeciesAssembly", new object[] {
                        name,
                        version});
            return ((System.Byte[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetSpeciesAssembly(string name, string version, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetSpeciesAssembly", new object[] {
                        name,
                        version}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Byte[] EndGetSpeciesAssembly(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Byte[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ReintroduceSpecies", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public System.Byte[] ReintroduceSpecies(string name, string version, System.Guid peerGuid) {
            object[] results = this.Invoke("ReintroduceSpecies", new object[] {
                        name,
                        version,
                        peerGuid});
            return ((System.Byte[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginReintroduceSpecies(string name, string version, System.Guid peerGuid, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ReintroduceSpecies", new object[] {
                        name,
                        version,
                        peerGuid}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Byte[] EndReintroduceSpecies(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Byte[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetBlacklistedSpecies", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] GetBlacklistedSpecies() {
            object[] results = this.Invoke("GetBlacklistedSpecies", new object[0]);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetBlacklistedSpecies(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetBlacklistedSpecies", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string[] EndGetBlacklistedSpecies(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public enum SpeciesServiceStatus {
        
        /// <remarks/>
        Success,
        
        /// <remarks/>
        AlreadyExists,
        
        /// <remarks/>
        ServerDown,
        
        /// <remarks/>
        VersionIncompatible,
        
        /// <remarks/>
        FiveMinuteThrottle,
        
        /// <remarks/>
        TwentyFourHourThrottle,
        
        /// <remarks/>
        PoliCheckSpeciesNameFailure,
        
        /// <remarks/>
        PoliCheckAuthorNameFailure,
        
        /// <remarks/>
        PoliCheckEmailFailure,
    }
}
