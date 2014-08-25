﻿// --- This file has been automatically generated with the DataRecord.cst template
// --- 2013-06-23 14:40:58Z

using System;
using System.Diagnostics.CodeAnalysis;
using Seemplest.Core.DataAccess.Attributes;
using Seemplest.Core.DataAccess.DataRecords;
using Seemplest.MsSql.DataAccess;

namespace Seemplest.MsSql.Records
{
    [SchemaName("Diagnostics")]
    [TableName("Trace")]
    [ExcludeFromCodeCoverage]
	public class TraceRecord: DataRecord<TraceRecord>
	{
        // --- Fields for data columns
        private Int32 _id;
        private DateTime _timestamp;
        private String _sessionId;
        private String _businessTransactionId;
        private String _operationInstanceId;
        private String _tenantId;
        private String _operationType;
        private String _message;
        private String _detailedMessage;
        private Int32 _type;
        private String _serverName;
        private Int32 _threadId;
        
        // --- Data column properties
        [ColumnName("Id")]
        [PrimaryKey]
        [AutoGenerated]
        public Int32 Id
        {
            get { return _id; }
            set
            {
                _id = Modify(value, "Id");
            }
        }
        
        [ColumnName("Timestamp")]
        public DateTime Timestamp
        {
            get { return _timestamp; }
            set
            {
                _timestamp = Modify(value, "Timestamp");
            }
        }
        
        [ColumnName("SessionId")]
        public String SessionId
        {
            get { return _sessionId; }
            set
            {
                _sessionId = Modify(value, "SessionId");
            }
        }
        
        [ColumnName("BusinessTransactionId")]
        public String BusinessTransactionId
        {
            get { return _businessTransactionId; }
            set
            {
                _businessTransactionId = Modify(value, "BusinessTransactionId");
            }
        }
        
        [ColumnName("OperationInstanceId")]
        public String OperationInstanceId
        {
            get { return _operationInstanceId; }
            set
            {
                _operationInstanceId = Modify(value, "OperationInstanceId");
            }
        }
        
        [ColumnName("TenantId")]
        public String TenantId
        {
            get { return _tenantId; }
            set
            {
                _tenantId = Modify(value, "TenantId");
            }
        }
        
        [ColumnName("OperationType")]
        public String OperationType
        {
            get { return _operationType; }
            set
            {
                _operationType = Modify(value, "OperationType");
            }
        }
        
        [ColumnName("Message")]
        public String Message
        {
            get { return _message; }
            set
            {
                _message = Modify(value, "Message");
            }
        }
        
        [ColumnName("DetailedMessage")]
        public String DetailedMessage
        {
            get { return _detailedMessage; }
            set
            {
                _detailedMessage = Modify(value, "DetailedMessage");
            }
        }
        
        [ColumnName("Type")]
        public Int32 Type
        {
            get { return _type; }
            set
            {
                _type = Modify(value, "Type");
            }
        }
        
        [ColumnName("ServerName")]
        public String ServerName
        {
            get { return _serverName; }
            set
            {
                _serverName = Modify(value, "ServerName");
            }
        }
        
        [ColumnName("ThreadId")]
        public Int32 ThreadId
        {
            get { return _threadId; }
            set
            {
                _threadId = Modify(value, "ThreadId");
            }
        }
    }
}
    