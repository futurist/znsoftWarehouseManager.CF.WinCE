﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:2.0.50727.5477
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Этот исходный текст был создан автоматически: Microsoft.CompactFramework.Design.Data, версия: 2.0.50727.5477.
// 
namespace SmartDeviceProject2.СсылкаНаСервис {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="forTSDSoapBinding", Namespace="http://www.dns-shop.tsd.ru")]
    public partial class forTSD : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public forTSD() {
            this.Url = "http://adm-zheludkov/zheludkov_sklad/ws/TSD.1cws";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.dns-shop.tsd.ru#forTSD:ОбменТСД", RequestNamespace="http://www.dns-shop.tsd.ru", ResponseNamespace="http://www.dns-shop.tsd.ru", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("return")]
        [return: System.Xml.Serialization.XmlArrayItemAttribute("Номенклатура", IsNullable=false)]
        public СтрокаНоменклатуры[] ОбменТСД(string ВидОперации, [System.Xml.Serialization.XmlArrayItemAttribute("Номенклатура", IsNullable=false)] СтрокаНоменклатуры[] Список) {
            object[] results = this.Invoke("ОбменТСД", new object[] {
                        ВидОперации,
                        Список});
            return ((СтрокаНоменклатуры[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginОбменТСД(string ВидОперации, СтрокаНоменклатуры[] Список, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ОбменТСД", new object[] {
                        ВидОперации,
                        Список}, callback, asyncState);
        }
        
        /// <remarks/>
        public СтрокаНоменклатуры[] EndОбменТСД(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((СтрокаНоменклатуры[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.dns-shop.tsd.ru#forTSD:updatefirmware", RequestNamespace="http://www.dns-shop.tsd.ru", ResponseNamespace="http://www.dns-shop.tsd.ru", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", DataType="base64Binary", IsNullable=true)]
        public byte[] updatefirmware([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string version) {
            object[] results = this.Invoke("updatefirmware", new object[] {
                        version});
            return ((byte[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult Beginupdatefirmware(string version, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("updatefirmware", new object[] {
                        version}, callback, asyncState);
        }
        
        /// <remarks/>
        public byte[] Endupdatefirmware(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((byte[])(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.dns-shop.tsd.ru")]
    public partial class СтрокаНоменклатуры {
        
        private string кодField;
        
        private string наименованиеField;
        
        private string количествоField;
        
        /// <remarks/>
        public string Код {
            get {
                return this.кодField;
            }
            set {
                this.кодField = value;
            }
        }
        
        /// <remarks/>
        public string Наименование {
            get {
                return this.наименованиеField;
            }
            set {
                this.наименованиеField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string Количество {
            get {
                return this.количествоField;
            }
            set {
                this.количествоField = value;
            }
        }
    }
}
