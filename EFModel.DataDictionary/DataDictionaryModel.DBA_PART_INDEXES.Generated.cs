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
    /// There are no comments for EFModel.DataDictionary.DBA_PART_INDEXES in the schema.
    /// </summary>
    public partial class DBA_PART_INDEXES : ICloneable, INotifyPropertyChanged    {

        public DBA_PART_INDEXES()
        {
        }

        #region Properties
    
        /// <summary>
        /// There are no comments for OWNER in the schema.
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
        /// There are no comments for INDEX_NAME in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string INDEX_NAME
        {
            get
            {
                return _INDEX_NAME;
            }
            set
            {
                if (_INDEX_NAME != value)
                {
                    _INDEX_NAME = value;
                    OnPropertyChanged("INDEX_NAME");
                }
            }
        }
        private string _INDEX_NAME;

    
        /// <summary>
        /// There are no comments for TABLE_NAME in the schema.
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
        /// There are no comments for PARTITIONING_TYPE in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(7)]
        public virtual string PARTITIONING_TYPE
        {
            get
            {
                return _PARTITIONING_TYPE;
            }
            set
            {
                if (_PARTITIONING_TYPE != value)
                {
                    _PARTITIONING_TYPE = value;
                    OnPropertyChanged("PARTITIONING_TYPE");
                }
            }
        }
        private string _PARTITIONING_TYPE;

    
        /// <summary>
        /// There are no comments for SUBPARTITIONING_TYPE in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(7)]
        public virtual string SUBPARTITIONING_TYPE
        {
            get
            {
                return _SUBPARTITIONING_TYPE;
            }
            set
            {
                if (_SUBPARTITIONING_TYPE != value)
                {
                    _SUBPARTITIONING_TYPE = value;
                    OnPropertyChanged("SUBPARTITIONING_TYPE");
                }
            }
        }
        private string _SUBPARTITIONING_TYPE;

    
        /// <summary>
        /// There are no comments for PARTITION_COUNT in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual decimal PARTITION_COUNT
        {
            get
            {
                return _PARTITION_COUNT;
            }
            set
            {
                if (_PARTITION_COUNT != value)
                {
                    _PARTITION_COUNT = value;
                    OnPropertyChanged("PARTITION_COUNT");
                }
            }
        }
        private decimal _PARTITION_COUNT;

    
        /// <summary>
        /// There are no comments for DEF_SUBPARTITION_COUNT in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> DEF_SUBPARTITION_COUNT
        {
            get
            {
                return _DEF_SUBPARTITION_COUNT;
            }
            set
            {
                if (_DEF_SUBPARTITION_COUNT != value)
                {
                    _DEF_SUBPARTITION_COUNT = value;
                    OnPropertyChanged("DEF_SUBPARTITION_COUNT");
                }
            }
        }
        private global::System.Nullable<decimal> _DEF_SUBPARTITION_COUNT;

    
        /// <summary>
        /// There are no comments for PARTITIONING_KEY_COUNT in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual decimal PARTITIONING_KEY_COUNT
        {
            get
            {
                return _PARTITIONING_KEY_COUNT;
            }
            set
            {
                if (_PARTITIONING_KEY_COUNT != value)
                {
                    _PARTITIONING_KEY_COUNT = value;
                    OnPropertyChanged("PARTITIONING_KEY_COUNT");
                }
            }
        }
        private decimal _PARTITIONING_KEY_COUNT;

    
        /// <summary>
        /// There are no comments for SUBPARTITIONING_KEY_COUNT in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> SUBPARTITIONING_KEY_COUNT
        {
            get
            {
                return _SUBPARTITIONING_KEY_COUNT;
            }
            set
            {
                if (_SUBPARTITIONING_KEY_COUNT != value)
                {
                    _SUBPARTITIONING_KEY_COUNT = value;
                    OnPropertyChanged("SUBPARTITIONING_KEY_COUNT");
                }
            }
        }
        private global::System.Nullable<decimal> _SUBPARTITIONING_KEY_COUNT;

    
        /// <summary>
        /// There are no comments for LOCALITY in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(6)]
        public virtual string LOCALITY
        {
            get
            {
                return _LOCALITY;
            }
            set
            {
                if (_LOCALITY != value)
                {
                    _LOCALITY = value;
                    OnPropertyChanged("LOCALITY");
                }
            }
        }
        private string _LOCALITY;

    
        /// <summary>
        /// There are no comments for ALIGNMENT in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(12)]
        public virtual string ALIGNMENT
        {
            get
            {
                return _ALIGNMENT;
            }
            set
            {
                if (_ALIGNMENT != value)
                {
                    _ALIGNMENT = value;
                    OnPropertyChanged("ALIGNMENT");
                }
            }
        }
        private string _ALIGNMENT;

    
        /// <summary>
        /// There are no comments for DEF_TABLESPACE_NAME in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        public virtual string DEF_TABLESPACE_NAME
        {
            get
            {
                return _DEF_TABLESPACE_NAME;
            }
            set
            {
                if (_DEF_TABLESPACE_NAME != value)
                {
                    _DEF_TABLESPACE_NAME = value;
                    OnPropertyChanged("DEF_TABLESPACE_NAME");
                }
            }
        }
        private string _DEF_TABLESPACE_NAME;

    
        /// <summary>
        /// There are no comments for DEF_PCT_FREE in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual decimal DEF_PCT_FREE
        {
            get
            {
                return _DEF_PCT_FREE;
            }
            set
            {
                if (_DEF_PCT_FREE != value)
                {
                    _DEF_PCT_FREE = value;
                    OnPropertyChanged("DEF_PCT_FREE");
                }
            }
        }
        private decimal _DEF_PCT_FREE;

    
        /// <summary>
        /// There are no comments for DEF_INI_TRANS in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual decimal DEF_INI_TRANS
        {
            get
            {
                return _DEF_INI_TRANS;
            }
            set
            {
                if (_DEF_INI_TRANS != value)
                {
                    _DEF_INI_TRANS = value;
                    OnPropertyChanged("DEF_INI_TRANS");
                }
            }
        }
        private decimal _DEF_INI_TRANS;

    
        /// <summary>
        /// There are no comments for DEF_MAX_TRANS in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual decimal DEF_MAX_TRANS
        {
            get
            {
                return _DEF_MAX_TRANS;
            }
            set
            {
                if (_DEF_MAX_TRANS != value)
                {
                    _DEF_MAX_TRANS = value;
                    OnPropertyChanged("DEF_MAX_TRANS");
                }
            }
        }
        private decimal _DEF_MAX_TRANS;

    
        /// <summary>
        /// There are no comments for DEF_INITIAL_EXTENT in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public virtual string DEF_INITIAL_EXTENT
        {
            get
            {
                return _DEF_INITIAL_EXTENT;
            }
            set
            {
                if (_DEF_INITIAL_EXTENT != value)
                {
                    _DEF_INITIAL_EXTENT = value;
                    OnPropertyChanged("DEF_INITIAL_EXTENT");
                }
            }
        }
        private string _DEF_INITIAL_EXTENT;

    
        /// <summary>
        /// There are no comments for DEF_NEXT_EXTENT in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public virtual string DEF_NEXT_EXTENT
        {
            get
            {
                return _DEF_NEXT_EXTENT;
            }
            set
            {
                if (_DEF_NEXT_EXTENT != value)
                {
                    _DEF_NEXT_EXTENT = value;
                    OnPropertyChanged("DEF_NEXT_EXTENT");
                }
            }
        }
        private string _DEF_NEXT_EXTENT;

    
        /// <summary>
        /// There are no comments for DEF_MIN_EXTENTS in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public virtual string DEF_MIN_EXTENTS
        {
            get
            {
                return _DEF_MIN_EXTENTS;
            }
            set
            {
                if (_DEF_MIN_EXTENTS != value)
                {
                    _DEF_MIN_EXTENTS = value;
                    OnPropertyChanged("DEF_MIN_EXTENTS");
                }
            }
        }
        private string _DEF_MIN_EXTENTS;

    
        /// <summary>
        /// There are no comments for DEF_MAX_EXTENTS in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public virtual string DEF_MAX_EXTENTS
        {
            get
            {
                return _DEF_MAX_EXTENTS;
            }
            set
            {
                if (_DEF_MAX_EXTENTS != value)
                {
                    _DEF_MAX_EXTENTS = value;
                    OnPropertyChanged("DEF_MAX_EXTENTS");
                }
            }
        }
        private string _DEF_MAX_EXTENTS;

    
        /// <summary>
        /// There are no comments for DEF_PCT_INCREASE in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(40)]
        public virtual string DEF_PCT_INCREASE
        {
            get
            {
                return _DEF_PCT_INCREASE;
            }
            set
            {
                if (_DEF_PCT_INCREASE != value)
                {
                    _DEF_PCT_INCREASE = value;
                    OnPropertyChanged("DEF_PCT_INCREASE");
                }
            }
        }
        private string _DEF_PCT_INCREASE;

    
        /// <summary>
        /// There are no comments for DEF_FREELISTS in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual decimal DEF_FREELISTS
        {
            get
            {
                return _DEF_FREELISTS;
            }
            set
            {
                if (_DEF_FREELISTS != value)
                {
                    _DEF_FREELISTS = value;
                    OnPropertyChanged("DEF_FREELISTS");
                }
            }
        }
        private decimal _DEF_FREELISTS;

    
        /// <summary>
        /// There are no comments for DEF_FREELIST_GROUPS in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual decimal DEF_FREELIST_GROUPS
        {
            get
            {
                return _DEF_FREELIST_GROUPS;
            }
            set
            {
                if (_DEF_FREELIST_GROUPS != value)
                {
                    _DEF_FREELIST_GROUPS = value;
                    OnPropertyChanged("DEF_FREELIST_GROUPS");
                }
            }
        }
        private decimal _DEF_FREELIST_GROUPS;

    
        /// <summary>
        /// There are no comments for DEF_LOGGING in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(7)]
        public virtual string DEF_LOGGING
        {
            get
            {
                return _DEF_LOGGING;
            }
            set
            {
                if (_DEF_LOGGING != value)
                {
                    _DEF_LOGGING = value;
                    OnPropertyChanged("DEF_LOGGING");
                }
            }
        }
        private string _DEF_LOGGING;

    
        /// <summary>
        /// There are no comments for DEF_BUFFER_POOL in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(7)]
        public virtual string DEF_BUFFER_POOL
        {
            get
            {
                return _DEF_BUFFER_POOL;
            }
            set
            {
                if (_DEF_BUFFER_POOL != value)
                {
                    _DEF_BUFFER_POOL = value;
                    OnPropertyChanged("DEF_BUFFER_POOL");
                }
            }
        }
        private string _DEF_BUFFER_POOL;

    
        /// <summary>
        /// There are no comments for DEF_PARAMETERS in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(1000)]
        public virtual string DEF_PARAMETERS
        {
            get
            {
                return _DEF_PARAMETERS;
            }
            set
            {
                if (_DEF_PARAMETERS != value)
                {
                    _DEF_PARAMETERS = value;
                    OnPropertyChanged("DEF_PARAMETERS");
                }
            }
        }
        private string _DEF_PARAMETERS;


        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            DBA_PART_INDEXES obj = new DBA_PART_INDEXES();
            obj.OWNER = OWNER;
            obj.INDEX_NAME = INDEX_NAME;
            obj.TABLE_NAME = TABLE_NAME;
            obj.PARTITIONING_TYPE = PARTITIONING_TYPE;
            obj.SUBPARTITIONING_TYPE = SUBPARTITIONING_TYPE;
            obj.PARTITION_COUNT = PARTITION_COUNT;
            obj.DEF_SUBPARTITION_COUNT = DEF_SUBPARTITION_COUNT;
            obj.PARTITIONING_KEY_COUNT = PARTITIONING_KEY_COUNT;
            obj.SUBPARTITIONING_KEY_COUNT = SUBPARTITIONING_KEY_COUNT;
            obj.LOCALITY = LOCALITY;
            obj.ALIGNMENT = ALIGNMENT;
            obj.DEF_TABLESPACE_NAME = DEF_TABLESPACE_NAME;
            obj.DEF_PCT_FREE = DEF_PCT_FREE;
            obj.DEF_INI_TRANS = DEF_INI_TRANS;
            obj.DEF_MAX_TRANS = DEF_MAX_TRANS;
            obj.DEF_INITIAL_EXTENT = DEF_INITIAL_EXTENT;
            obj.DEF_NEXT_EXTENT = DEF_NEXT_EXTENT;
            obj.DEF_MIN_EXTENTS = DEF_MIN_EXTENTS;
            obj.DEF_MAX_EXTENTS = DEF_MAX_EXTENTS;
            obj.DEF_PCT_INCREASE = DEF_PCT_INCREASE;
            obj.DEF_FREELISTS = DEF_FREELISTS;
            obj.DEF_FREELIST_GROUPS = DEF_FREELIST_GROUPS;
            obj.DEF_LOGGING = DEF_LOGGING;
            obj.DEF_BUFFER_POOL = DEF_BUFFER_POOL;
            obj.DEF_PARAMETERS = DEF_PARAMETERS;
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
