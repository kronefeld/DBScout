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
    /// Comments on all tables and views in the database
    /// </summary>
    public partial class DBA_TAB_COMMENTS : ICloneable, INotifyPropertyChanged    {

        public DBA_TAB_COMMENTS()
        {
        }

        #region Properties
    
        /// <summary>
        /// Owner of the object
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string OWNER
        {
            get
            {
                return _OWNER;
            }
            set
            {
                if (_OWNER != value)
                {
                    _OWNER = value;
                    OnPropertyChanged("OWNER");
                }
            }
        }
        private string _OWNER;

    
        /// <summary>
        /// Name of the object
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string TABLE_NAME
        {
            get
            {
                return _TABLE_NAME;
            }
            set
            {
                if (_TABLE_NAME != value)
                {
                    _TABLE_NAME = value;
                    OnPropertyChanged("TABLE_NAME");
                }
            }
        }
        private string _TABLE_NAME;

    
        /// <summary>
        /// Type of the object
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public virtual string TABLE_TYPE
        {
            get
            {
                return _TABLE_TYPE;
            }
            set
            {
                if (_TABLE_TYPE != value)
                {
                    _TABLE_TYPE = value;
                    OnPropertyChanged("TABLE_TYPE");
                }
            }
        }
        private string _TABLE_TYPE;

    
        /// <summary>
        /// Comment on the object
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public virtual string COMMENTS
        {
            get
            {
                return _COMMENTS;
            }
            set
            {
                if (_COMMENTS != value)
                {
                    _COMMENTS = value;
                    OnPropertyChanged("COMMENTS");
                }
            }
        }
        private string _COMMENTS;


        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            DBA_TAB_COMMENTS obj = new DBA_TAB_COMMENTS();
            obj.OWNER = OWNER;
            obj.TABLE_NAME = TABLE_NAME;
            obj.TABLE_TYPE = TABLE_TYPE;
            obj.COMMENTS = COMMENTS;
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
