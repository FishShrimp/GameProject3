//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: MessageRetCode.proto
namespace Protocol
{
    [global::ProtoBuf.ProtoContract(Name=@"MessageRetCode")]
    public enum MessageRetCode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"TYPE_OK", Value=0)]
      TYPE_OK = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TYPE_TIMEOUT", Value=1)]
      TYPE_TIMEOUT = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TYPE_DISCONNECT", Value=2)]
      TYPE_DISCONNECT = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TYPE_ERROR_UNKNOW", Value=11)]
      TYPE_ERROR_UNKNOW = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TYPE_ERROE_ID", Value=12)]
      TYPE_ERROE_ID = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TYPE_ERROE_MESSAGE", Value=13)]
      TYPE_ERROE_MESSAGE = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TYPE_ERROE_PARAM", Value=14)]
      TYPE_ERROE_PARAM = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TYPE_ERROE_SERVEREX", Value=15)]
      TYPE_ERROE_SERVEREX = 15
    }
  
}