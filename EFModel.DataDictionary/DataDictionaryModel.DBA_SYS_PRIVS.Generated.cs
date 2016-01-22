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
    /// System privileges granted to users and roles
    /// </summary>
    public partial class DBA_SYS_PRIVS : ICloneable, INotifyPropertyChanged    {

        public DBA_SYS_PRIVS()
        {
        }

        #region Properties
    
        /// <summary>
        /// Grantee Name, User or Role receiving the grant
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
        /// System privilege
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
        /// Grant was with the ADMIN option
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public virtual string ADMIN_OPTION
        {
            get
            {
                return _ADMIN_OPTION;
            }
            set
            {
                if (_ADMIN_OPTION != value)
                {
                    _ADMIN_OPTION = value;
                    OnPropertyChanged("ADMIN_OPTION");
                }
            }
        }
        private string _ADMIN_OPTION;


        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            DBA_SYS_PRIVS obj = new DBA_SYS_PRIVS();
            obj.GRANTEE = GRANTEE;
            obj.PRIVILEGE = PRIVILEGE;
            obj.ADMIN_OPTION = ADMIN_OPTION;
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
