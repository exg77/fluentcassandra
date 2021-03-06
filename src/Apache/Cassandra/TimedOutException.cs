/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

using System;
using System.Text;
using FluentCassandra.Thrift;
using FluentCassandra.Thrift.Protocol;

namespace FluentCassandra.Apache.Cassandra
{

  /// <summary>
  /// RPC timeout was exceeded.  either a node failed mid-operation, or load was too high, or the requested op was too large.
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class TimedOutException : TException, TBase
  {
    private int _acknowledged_by;
    private bool _acknowledged_by_batchlog;
    private bool _paxos_in_progress;

    /// <summary>
    /// if a write operation was acknowledged by some replicas but not by enough to
    /// satisfy the required ConsistencyLevel, the number of successful
    /// replies will be given here. In case of atomic_batch_mutate method this field
    /// will be set to -1 if the batch was written to the batchlog and to 0 if it wasn't.
    /// </summary>
    public int Acknowledged_by
    {
      get
      {
        return _acknowledged_by;
      }
      set
      {
        __isset.acknowledged_by = true;
        this._acknowledged_by = value;
      }
    }

    /// <summary>
    /// in case of atomic_batch_mutate method this field tells if the batch
    /// was written to the batchlog.
    /// </summary>
    public bool Acknowledged_by_batchlog
    {
      get
      {
        return _acknowledged_by_batchlog;
      }
      set
      {
        __isset.acknowledged_by_batchlog = true;
        this._acknowledged_by_batchlog = value;
      }
    }

    /// <summary>
    /// for the CAS method, this field tells if we timed out during the paxos
    /// protocol, as opposed to during the commit of our update
    /// </summary>
    public bool Paxos_in_progress
    {
      get
      {
        return _paxos_in_progress;
      }
      set
      {
        __isset.paxos_in_progress = true;
        this._paxos_in_progress = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool acknowledged_by;
      public bool acknowledged_by_batchlog;
      public bool paxos_in_progress;
    }

    public TimedOutException() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I32) {
              Acknowledged_by = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Bool) {
              Acknowledged_by_batchlog = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Bool) {
              Paxos_in_progress = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("TimedOutException");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.acknowledged_by) {
        field.Name = "acknowledged_by";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Acknowledged_by);
        oprot.WriteFieldEnd();
      }
      if (__isset.acknowledged_by_batchlog) {
        field.Name = "acknowledged_by_batchlog";
        field.Type = TType.Bool;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Acknowledged_by_batchlog);
        oprot.WriteFieldEnd();
      }
      if (__isset.paxos_in_progress) {
        field.Name = "paxos_in_progress";
        field.Type = TType.Bool;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Paxos_in_progress);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TimedOutException(");
      sb.Append("Acknowledged_by: ");
      sb.Append(Acknowledged_by);
      sb.Append(",Acknowledged_by_batchlog: ");
      sb.Append(Acknowledged_by_batchlog);
      sb.Append(",Paxos_in_progress: ");
      sb.Append(Paxos_in_progress);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
