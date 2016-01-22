//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
// Code is generated on: 07.07.2015 09:05:24
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace EFModel.DataDictionary
{

    /// <summary>
    /// Source tables available for Change Data Capture
    /// </summary>
    public partial class DBA_SOURCE_TABLES : ICloneable, INotifyPropertyChanged    {

        public DBA_SOURCE_TABLES()
        {
        }

        #region Properties
    
        /// <summary>
        /// Schema of the source table
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string SOURCE_SCHEMA_NAME
        {
            get
            {
                return _SOURCE_SCHEMA_NAME;
            }
            set
            {
                if (_SOURCE_SCHEMA_NAME != value)
                {
                    _SOURCE_SCHEMA_NAME = value;
                    OnPropertyChanged("SOURCE_SCHEMA_NAME");
                }
            }
        }
        private string _SOURCE_SCHEMA_NAME;

    
        /// <summary>
        /// Name of the source table
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string SOURCE_TABLE_NAME
        {
            get
            {
                return _SOURCE_TABLE_NAME;
            }
            set
            {
                if (_SOURCE_TABLE_NAME != value)
                {
                    _SOURCE_TABLE_NAME = value;
                    OnPropertyChanged("SOURCE_TABLE_NAME");
                }
            }
        }
        private string _SOURCE_TABLE_NAME;


        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            DBA_SOURCE_TABLES obj = new DBA_SOURCE_TABLES();
            obj.SOURCE_SCHEMA_NAME = SOURCE_SCHEMA_NAME;
            obj.SOURCE_TABLE_NAME = SOURCE_TABLE_NAME;
            return obj;
        }

        #endregion
    
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) {

          if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }

}
