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
    /// All triggers in the database
    /// </summary>
    public partial class DBA_TRIGGERS : ICloneable, INotifyPropertyChanged    {

        public DBA_TRIGGERS()
        {
        }

        #region Properties
    
        /// <summary>
        /// Owner of the trigger
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
        /// Name of the trigger
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string TRIGGER_NAME
        {
            get
            {
                return _TRIGGER_NAME;
            }
            set
            {
                if (_TRIGGER_NAME != value)
                {
                    _TRIGGER_NAME = value;
                    OnPropertyChanged("TRIGGER_NAME");
                }
            }
        }
        private string _TRIGGER_NAME;

    
        /// <summary>
        /// When the trigger fires - BEFORE/AFTER and STATEMENT/ROW
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(16)]
        public virtual string TRIGGER_TYPE
        {
            get
            {
                return _TRIGGER_TYPE;
            }
            set
            {
                if (_TRIGGER_TYPE != value)
                {
                    _TRIGGER_TYPE = value;
                    OnPropertyChanged("TRIGGER_TYPE");
                }
            }
        }
        private string _TRIGGER_TYPE;

    
        /// <summary>
        /// Statement that will fire the trigger - INSERT, UPDATE and/or DELETE
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(227)]
        public virtual string TRIGGERING_EVENT
        {
            get
            {
                return _TRIGGERING_EVENT;
            }
            set
            {
                if (_TRIGGERING_EVENT != value)
                {
                    _TRIGGERING_EVENT = value;
                    OnPropertyChanged("TRIGGERING_EVENT");
                }
            }
        }
        private string _TRIGGERING_EVENT;

    
        /// <summary>
        /// Owner of the table that this trigger is associated with
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        public virtual string TABLE_OWNER
        {
            get
            {
                return _TABLE_OWNER;
            }
            set
            {
                if (_TABLE_OWNER != value)
                {
                    _TABLE_OWNER = value;
                    OnPropertyChanged("TABLE_OWNER");
                }
            }
        }
        private string _TABLE_OWNER;

    
        /// <summary>
        /// There are no comments for BASE_OBJECT_TYPE in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(16)]
        public virtual string BASE_OBJECT_TYPE
        {
            get
            {
                return _BASE_OBJECT_TYPE;
            }
            set
            {
                if (_BASE_OBJECT_TYPE != value)
                {
                    _BASE_OBJECT_TYPE = value;
                    OnPropertyChanged("BASE_OBJECT_TYPE");
                }
            }
        }
        private string _BASE_OBJECT_TYPE;

    
        /// <summary>
        /// Name of the table that this trigger is associated with
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(30)]
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
        /// The name of the column on which the trigger is defined over 
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public virtual string COLUMN_NAME
        {
            get
            {
                return _COLUMN_NAME;
            }
            set
            {
                if (_COLUMN_NAME != value)
                {
                    _COLUMN_NAME = value;
                    OnPropertyChanged("COLUMN_NAME");
                }
            }
        }
        private string _COLUMN_NAME;

    
        /// <summary>
        /// Names used for referencing to OLD and NEW values within the trigger
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(128)]
        public virtual string REFERENCING_NAMES
        {
            get
            {
                return _REFERENCING_NAMES;
            }
            set
            {
                if (_REFERENCING_NAMES != value)
                {
                    _REFERENCING_NAMES = value;
                    OnPropertyChanged("REFERENCING_NAMES");
                }
            }
        }
        private string _REFERENCING_NAMES;

    
        /// <summary>
        /// WHEN clause must evaluate to true in order for triggering body to execute
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public virtual string WHEN_CLAUSE
        {
            get
            {
                return _WHEN_CLAUSE;
            }
            set
            {
                if (_WHEN_CLAUSE != value)
                {
                    _WHEN_CLAUSE = value;
                    OnPropertyChanged("WHEN_CLAUSE");
                }
            }
        }
        private string _WHEN_CLAUSE;

    
        /// <summary>
        /// If DISABLED then trigger will not fire
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(8)]
        public virtual string STATUS
        {
            get
            {
                return _STATUS;
            }
            set
            {
                if (_STATUS != value)
                {
                    _STATUS = value;
                    OnPropertyChanged("STATUS");
                }
            }
        }
        private string _STATUS;

    
        /// <summary>
        /// Trigger description, useful for re-creating trigger creation statement
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public virtual string DESCRIPTION
        {
            get
            {
                return _DESCRIPTION;
            }
            set
            {
                if (_DESCRIPTION != value)
                {
                    _DESCRIPTION = value;
                    OnPropertyChanged("DESCRIPTION");
                }
            }
        }
        private string _DESCRIPTION;

    
        /// <summary>
        /// There are no comments for ACTION_TYPE in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(11)]
        public virtual string ACTION_TYPE
        {
            get
            {
                return _ACTION_TYPE;
            }
            set
            {
                if (_ACTION_TYPE != value)
                {
                    _ACTION_TYPE = value;
                    OnPropertyChanged("ACTION_TYPE");
                }
            }
        }
        private string _ACTION_TYPE;

    
        /// <summary>
        /// Action taken by this trigger when it fires
        /// </summary>
        public virtual string TRIGGER_BODY
        {
            get
            {
                return _TRIGGER_BODY;
            }
            set
            {
                if (_TRIGGER_BODY != value)
                {
                    _TRIGGER_BODY = value;
                    OnPropertyChanged("TRIGGER_BODY");
                }
            }
        }
        private string _TRIGGER_BODY;


        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            DBA_TRIGGERS obj = new DBA_TRIGGERS();
            obj.OWNER = OWNER;
            obj.TRIGGER_NAME = TRIGGER_NAME;
            obj.TRIGGER_TYPE = TRIGGER_TYPE;
            obj.TRIGGERING_EVENT = TRIGGERING_EVENT;
            obj.TABLE_OWNER = TABLE_OWNER;
            obj.BASE_OBJECT_TYPE = BASE_OBJECT_TYPE;
            obj.TABLE_NAME = TABLE_NAME;
            obj.COLUMN_NAME = COLUMN_NAME;
            obj.REFERENCING_NAMES = REFERENCING_NAMES;
            obj.WHEN_CLAUSE = WHEN_CLAUSE;
            obj.STATUS = STATUS;
            obj.DESCRIPTION = DESCRIPTION;
            obj.ACTION_TYPE = ACTION_TYPE;
            obj.TRIGGER_BODY = TRIGGER_BODY;
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
