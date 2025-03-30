// THIS FILE IS AUTOMATICALLY GENERATED BY SPACETIMEDB. EDITS TO THIS FILE
// WILL NOT BE SAVED. MODIFY TABLES IN YOUR MODULE SOURCE CODE INSTEAD.

#nullable enable

using System;
using SpacetimeDB.ClientApi;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SpacetimeDB.Types
{
    public sealed partial class RemoteReducers : RemoteBase
    {
        public delegate void ConnectHandler(ReducerEventContext ctx);
        public event ConnectHandler? OnConnect;

        public bool InvokeConnect(ReducerEventContext ctx, Reducer.Connect args)
        {
            if (OnConnect == null) return false;
            OnConnect(
                ctx
            );
            return true;
        }
    }

    public abstract partial class Reducer
    {
        [SpacetimeDB.Type]
        [DataContract]
        public sealed partial class Connect : Reducer, IReducerArgs
        {
            string IReducerArgs.ReducerName => "connect";
        }
    }
}
