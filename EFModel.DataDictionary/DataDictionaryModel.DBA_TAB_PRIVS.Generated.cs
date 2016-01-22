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
    /// All grants on objects in the database
    /// </summary>
    public partial class DBA_TAB_PRIVS : ICloneable, INotifyPropertyChanged    {

        public DBA_TAB_PRIVS()
        {
        }

        #region Properties
    
        /// <summary>
        /// User to whom access was granted
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string GRANTEE
        {
            get
            {
                return _GRANTEE;
            }
            set
            {
                if (_GRANTEE != value)
                {
                    _GRANTEE = value;
                    OnPropertyChanged("GRANTEE");
                }
            }
        }
        private string _GRANTEE;

    
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
        /// Name of the user who performed the grant
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string GRANTOR
        {
            get
            {
                return _GRANTOR;
            }
            set
            {
                if (_GRANTOR != value)
                {
                    _GRANTOR = value;
                    OnPropertyChanged("GRANTOR");
                }
            }
        }
        private string _GRANTOR;

    
        /// <summary>
        /// Table Privilege
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string PRIVILEGE
        {
            get
            {
                return _PRIVILEGE;
            }
            set
            {
                if (_PRIVILEGE != value)
                {
                    _PRIVILEGE = value;
                    OnPropertyChanged("PRIVILEGE");
                }
            }
        }
        private string _PRIVILEGE;

    
        /// <summary>
        /// Privilege is grantable
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public virtual string GRANTABLE
        {
            get
            {
                return _GRANTABLE;
            }
            set
            {
                if (_GRANTABLE != value)
                {
                    _GRANTABLE = value;
                    OnPropertyChanged("GRANTABLE");
                }
            }
        }
        private string _GRANTABLE;

    
        /// <summary>
        /// Privilege is with hierarchy option
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public virtual string HIERARCHY
        {
            get
            {
                return _HIERARCHY;
            }
            set
            {
                if (_HIERARCHY != value)
                {
                    _HIERARCHY = value;
                    OnPropertyChanged("HIERARCHY");
                }
            }
        }
        private string _HIERARCHY;


        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            DBA_TAB_PRIVS obj = new DBA_TAB_PRIVS();
            obj.GRANTEE = GRANTEE;
            obj.OWNER = OWNER;
            obj.TABLE_NAME = TABLE_NAME;
            obj.GRANTOR = GRANTOR;
            obj.PRIVILEGE = PRIVILEGE;
            obj.GRANTABLE = GRANTABLE;
            obj.HIERARCHY = HIERARCHY;
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
