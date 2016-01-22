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
    /// There are no comments for EFModel.DataDictionary.DBA_TAB_PARTITIONS in the schema.
    /// </summary>
    public partial class DBA_TAB_PARTITIONS : ICloneable, INotifyPropertyChanged    {

        public DBA_TAB_PARTITIONS()
        {
        }

        #region Properties
    
        /// <summary>
        /// There are no comments for TABLE_OWNER in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        [System.ComponentModel.DataAnnotations.Required()]
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
        /// There are no comments for COMPOSITE in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public virtual string COMPOSITE
        {
            get
            {
                return _COMPOSITE;
            }
            set
            {
                if (_COMPOSITE != value)
                {
                    _COMPOSITE = value;
                    OnPropertyChanged("COMPOSITE");
                }
            }
        }
        private string _COMPOSITE;

    
        /// <summary>
        /// There are no comments for PARTITION_NAME in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        [System.ComponentModel.DataAnnotations.Required()]
        public virtual string PARTITION_NAME
        {
            get
            {
                return _PARTITION_NAME;
            }
            set
            {
                if (_PARTITION_NAME != value)
                {
                    _PARTITION_NAME = value;
                    OnPropertyChanged("PARTITION_NAME");
                }
            }
        }
        private string _PARTITION_NAME;

    
        /// <summary>
        /// There are no comments for SUBPARTITION_COUNT in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> SUBPARTITION_COUNT
        {
            get
            {
                return _SUBPARTITION_COUNT;
            }
            set
            {
                if (_SUBPARTITION_COUNT != value)
                {
                    _SUBPARTITION_COUNT = value;
                    OnPropertyChanged("SUBPARTITION_COUNT");
                }
            }
        }
        private global::System.Nullable<decimal> _SUBPARTITION_COUNT;

    
        /// <summary>
        /// There are no comments for HIGH_VALUE in the schema.
        /// </summary>
        public virtual string HIGH_VALUE
        {
            get
            {
                return _HIGH_VALUE;
            }
            set
            {
                if (_HIGH_VALUE != value)
                {
                    _HIGH_VALUE = value;
                    OnPropertyChanged("HIGH_VALUE");
                }
            }
        }
        private string _HIGH_VALUE;

    
        /// <summary>
        /// There are no comments for HIGH_VALUE_LENGTH in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> HIGH_VALUE_LENGTH
        {
            get
            {
                return _HIGH_VALUE_LENGTH;
            }
            set
            {
                if (_HIGH_VALUE_LENGTH != value)
                {
                    _HIGH_VALUE_LENGTH = value;
                    OnPropertyChanged("HIGH_VALUE_LENGTH");
                }
            }
        }
        private global::System.Nullable<decimal> _HIGH_VALUE_LENGTH;

    
        /// <summary>
        /// There are no comments for PARTITION_POSITION in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> PARTITION_POSITION
        {
            get
            {
                return _PARTITION_POSITION;
            }
            set
            {
                if (_PARTITION_POSITION != value)
                {
                    _PARTITION_POSITION = value;
                    OnPropertyChanged("PARTITION_POSITION");
                }
            }
        }
        private global::System.Nullable<decimal> _PARTITION_POSITION;

    
        /// <summary>
        /// There are no comments for TABLESPACE_NAME in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(30)]
        public virtual string TABLESPACE_NAME
        {
            get
            {
                return _TABLESPACE_NAME;
            }
            set
            {
                if (_TABLESPACE_NAME != value)
                {
                    _TABLESPACE_NAME = value;
                    OnPropertyChanged("TABLESPACE_NAME");
                }
            }
        }
        private string _TABLESPACE_NAME;

    
        /// <summary>
        /// There are no comments for PCT_FREE in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> PCT_FREE
        {
            get
            {
                return _PCT_FREE;
            }
            set
            {
                if (_PCT_FREE != value)
                {
                    _PCT_FREE = value;
                    OnPropertyChanged("PCT_FREE");
                }
            }
        }
        private global::System.Nullable<decimal> _PCT_FREE;

    
        /// <summary>
        /// There are no comments for PCT_USED in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> PCT_USED
        {
            get
            {
                return _PCT_USED;
            }
            set
            {
                if (_PCT_USED != value)
                {
                    _PCT_USED = value;
                    OnPropertyChanged("PCT_USED");
                }
            }
        }
        private global::System.Nullable<decimal> _PCT_USED;

    
        /// <summary>
        /// There are no comments for INI_TRANS in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> INI_TRANS
        {
            get
            {
                return _INI_TRANS;
            }
            set
            {
                if (_INI_TRANS != value)
                {
                    _INI_TRANS = value;
                    OnPropertyChanged("INI_TRANS");
                }
            }
        }
        private global::System.Nullable<decimal> _INI_TRANS;

    
        /// <summary>
        /// There are no comments for MAX_TRANS in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> MAX_TRANS
        {
            get
            {
                return _MAX_TRANS;
            }
            set
            {
                if (_MAX_TRANS != value)
                {
                    _MAX_TRANS = value;
                    OnPropertyChanged("MAX_TRANS");
                }
            }
        }
        private global::System.Nullable<decimal> _MAX_TRANS;

    
        /// <summary>
        /// There are no comments for INITIAL_EXTENT in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> INITIAL_EXTENT
        {
            get
            {
                return _INITIAL_EXTENT;
            }
            set
            {
                if (_INITIAL_EXTENT != value)
                {
                    _INITIAL_EXTENT = value;
                    OnPropertyChanged("INITIAL_EXTENT");
                }
            }
        }
        private global::System.Nullable<decimal> _INITIAL_EXTENT;

    
        /// <summary>
        /// There are no comments for NEXT_EXTENT in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> NEXT_EXTENT
        {
            get
            {
                return _NEXT_EXTENT;
            }
            set
            {
                if (_NEXT_EXTENT != value)
                {
                    _NEXT_EXTENT = value;
                    OnPropertyChanged("NEXT_EXTENT");
                }
            }
        }
        private global::System.Nullable<decimal> _NEXT_EXTENT;

    
        /// <summary>
        /// There are no comments for MIN_EXTENT in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> MIN_EXTENT
        {
            get
            {
                return _MIN_EXTENT;
            }
            set
            {
                if (_MIN_EXTENT != value)
                {
                    _MIN_EXTENT = value;
                    OnPropertyChanged("MIN_EXTENT");
                }
            }
        }
        private global::System.Nullable<decimal> _MIN_EXTENT;

    
        /// <summary>
        /// There are no comments for MAX_EXTENT in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> MAX_EXTENT
        {
            get
            {
                return _MAX_EXTENT;
            }
            set
            {
                if (_MAX_EXTENT != value)
                {
                    _MAX_EXTENT = value;
                    OnPropertyChanged("MAX_EXTENT");
                }
            }
        }
        private global::System.Nullable<decimal> _MAX_EXTENT;

    
        /// <summary>
        /// There are no comments for PCT_INCREASE in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> PCT_INCREASE
        {
            get
            {
                return _PCT_INCREASE;
            }
            set
            {
                if (_PCT_INCREASE != value)
                {
                    _PCT_INCREASE = value;
                    OnPropertyChanged("PCT_INCREASE");
                }
            }
        }
        private global::System.Nullable<decimal> _PCT_INCREASE;

    
        /// <summary>
        /// There are no comments for FREELISTS in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> FREELISTS
        {
            get
            {
                return _FREELISTS;
            }
            set
            {
                if (_FREELISTS != value)
                {
                    _FREELISTS = value;
                    OnPropertyChanged("FREELISTS");
                }
            }
        }
        private global::System.Nullable<decimal> _FREELISTS;

    
        /// <summary>
        /// There are no comments for FREELIST_GROUPS in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> FREELIST_GROUPS
        {
            get
            {
                return _FREELIST_GROUPS;
            }
            set
            {
                if (_FREELIST_GROUPS != value)
                {
                    _FREELIST_GROUPS = value;
                    OnPropertyChanged("FREELIST_GROUPS");
                }
            }
        }
        private global::System.Nullable<decimal> _FREELIST_GROUPS;

    
        /// <summary>
        /// There are no comments for LOGGING in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(7)]
        public virtual string LOGGING
        {
            get
            {
                return _LOGGING;
            }
            set
            {
                if (_LOGGING != value)
                {
                    _LOGGING = value;
                    OnPropertyChanged("LOGGING");
                }
            }
        }
        private string _LOGGING;

    
        /// <summary>
        /// There are no comments for COMPRESSION in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(8)]
        public virtual string COMPRESSION
        {
            get
            {
                return _COMPRESSION;
            }
            set
            {
                if (_COMPRESSION != value)
                {
                    _COMPRESSION = value;
                    OnPropertyChanged("COMPRESSION");
                }
            }
        }
        private string _COMPRESSION;

    
        /// <summary>
        /// There are no comments for NUM_ROWS in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> NUM_ROWS
        {
            get
            {
                return _NUM_ROWS;
            }
            set
            {
                if (_NUM_ROWS != value)
                {
                    _NUM_ROWS = value;
                    OnPropertyChanged("NUM_ROWS");
                }
            }
        }
        private global::System.Nullable<decimal> _NUM_ROWS;

    
        /// <summary>
        /// There are no comments for BLOCKS in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> BLOCKS
        {
            get
            {
                return _BLOCKS;
            }
            set
            {
                if (_BLOCKS != value)
                {
                    _BLOCKS = value;
                    OnPropertyChanged("BLOCKS");
                }
            }
        }
        private global::System.Nullable<decimal> _BLOCKS;

    
        /// <summary>
        /// There are no comments for EMPTY_BLOCKS in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> EMPTY_BLOCKS
        {
            get
            {
                return _EMPTY_BLOCKS;
            }
            set
            {
                if (_EMPTY_BLOCKS != value)
                {
                    _EMPTY_BLOCKS = value;
                    OnPropertyChanged("EMPTY_BLOCKS");
                }
            }
        }
        private global::System.Nullable<decimal> _EMPTY_BLOCKS;

    
        /// <summary>
        /// There are no comments for AVG_SPACE in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> AVG_SPACE
        {
            get
            {
                return _AVG_SPACE;
            }
            set
            {
                if (_AVG_SPACE != value)
                {
                    _AVG_SPACE = value;
                    OnPropertyChanged("AVG_SPACE");
                }
            }
        }
        private global::System.Nullable<decimal> _AVG_SPACE;

    
        /// <summary>
        /// There are no comments for CHAIN_CNT in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> CHAIN_CNT
        {
            get
            {
                return _CHAIN_CNT;
            }
            set
            {
                if (_CHAIN_CNT != value)
                {
                    _CHAIN_CNT = value;
                    OnPropertyChanged("CHAIN_CNT");
                }
            }
        }
        private global::System.Nullable<decimal> _CHAIN_CNT;

    
        /// <summary>
        /// There are no comments for AVG_ROW_LEN in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> AVG_ROW_LEN
        {
            get
            {
                return _AVG_ROW_LEN;
            }
            set
            {
                if (_AVG_ROW_LEN != value)
                {
                    _AVG_ROW_LEN = value;
                    OnPropertyChanged("AVG_ROW_LEN");
                }
            }
        }
        private global::System.Nullable<decimal> _AVG_ROW_LEN;

    
        /// <summary>
        /// There are no comments for SAMPLE_SIZE in the schema.
        /// </summary>
        public virtual global::System.Nullable<decimal> SAMPLE_SIZE
        {
            get
            {
                return _SAMPLE_SIZE;
            }
            set
            {
                if (_SAMPLE_SIZE != value)
                {
                    _SAMPLE_SIZE = value;
                    OnPropertyChanged("SAMPLE_SIZE");
                }
            }
        }
        private global::System.Nullable<decimal> _SAMPLE_SIZE;

    
        /// <summary>
        /// There are no comments for LAST_ANALYZED in the schema.
        /// </summary>
        public virtual global::System.Nullable<System.DateTime> LAST_ANALYZED
        {
            get
            {
                return _LAST_ANALYZED;
            }
            set
            {
                if (_LAST_ANALYZED != value)
                {
                    _LAST_ANALYZED = value;
                    OnPropertyChanged("LAST_ANALYZED");
                }
            }
        }
        private global::System.Nullable<System.DateTime> _LAST_ANALYZED;

    
        /// <summary>
        /// There are no comments for BUFFER_POOL in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(7)]
        public virtual string BUFFER_POOL
        {
            get
            {
                return _BUFFER_POOL;
            }
            set
            {
                if (_BUFFER_POOL != value)
                {
                    _BUFFER_POOL = value;
                    OnPropertyChanged("BUFFER_POOL");
                }
            }
        }
        private string _BUFFER_POOL;

    
        /// <summary>
        /// There are no comments for GLOBAL_STATS in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public virtual string GLOBAL_STATS
        {
            get
            {
                return _GLOBAL_STATS;
            }
            set
            {
                if (_GLOBAL_STATS != value)
                {
                    _GLOBAL_STATS = value;
                    OnPropertyChanged("GLOBAL_STATS");
                }
            }
        }
        private string _GLOBAL_STATS;

    
        /// <summary>
        /// There are no comments for USER_STATS in the schema.
        /// </summary>
        [System.ComponentModel.DataAnnotations.StringLength(3)]
        public virtual string USER_STATS
        {
            get
            {
                return _USER_STATS;
            }
            set
            {
                if (_USER_STATS != value)
                {
                    _USER_STATS = value;
                    OnPropertyChanged("USER_STATS");
                }
            }
        }
        private string _USER_STATS;


        #endregion
    
        #region ICloneable Members

        public virtual object Clone()
        {
            DBA_TAB_PARTITIONS obj = new DBA_TAB_PARTITIONS();
            obj.TABLE_OWNER = TABLE_OWNER;
            obj.TABLE_NAME = TABLE_NAME;
            obj.COMPOSITE = COMPOSITE;
            obj.PARTITION_NAME = PARTITION_NAME;
            obj.SUBPARTITION_COUNT = SUBPARTITION_COUNT;
            obj.HIGH_VALUE = HIGH_VALUE;
            obj.HIGH_VALUE_LENGTH = HIGH_VALUE_LENGTH;
            obj.PARTITION_POSITION = PARTITION_POSITION;
            obj.TABLESPACE_NAME = TABLESPACE_NAME;
            obj.PCT_FREE = PCT_FREE;
            obj.PCT_USED = PCT_USED;
            obj.INI_TRANS = INI_TRANS;
            obj.MAX_TRANS = MAX_TRANS;
            obj.INITIAL_EXTENT = INITIAL_EXTENT;
            obj.NEXT_EXTENT = NEXT_EXTENT;
            obj.MIN_EXTENT = MIN_EXTENT;
            obj.MAX_EXTENT = MAX_EXTENT;
            obj.PCT_INCREASE = PCT_INCREASE;
            obj.FREELISTS = FREELISTS;
            obj.FREELIST_GROUPS = FREELIST_GROUPS;
            obj.LOGGING = LOGGING;
            obj.COMPRESSION = COMPRESSION;
            obj.NUM_ROWS = NUM_ROWS;
            obj.BLOCKS = BLOCKS;
            obj.EMPTY_BLOCKS = EMPTY_BLOCKS;
            obj.AVG_SPACE = AVG_SPACE;
            obj.CHAIN_CNT = CHAIN_CNT;
            obj.AVG_ROW_LEN = AVG_ROW_LEN;
            obj.SAMPLE_SIZE = SAMPLE_SIZE;
            obj.LAST_ANALYZED = LAST_ANALYZED;
            obj.BUFFER_POOL = BUFFER_POOL;
            obj.GLOBAL_STATS = GLOBAL_STATS;
            obj.USER_STATS = USER_STATS;
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
