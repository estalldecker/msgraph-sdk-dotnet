using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum ChatMessageType {
        [EnumMember(Value = "message")]
        Message,
        [EnumMember(Value = "chatEvent")]
        ChatEvent,
        [EnumMember(Value = "typing")]
        Typing,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "systemEventMessage")]
        SystemEventMessage,
    }
}
