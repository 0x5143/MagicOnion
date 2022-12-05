/// <auto-generated />
#nullable disable
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace MagicOnion.Integration.Tests.Generated
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::MagicOnion;
    using global::MagicOnion.Client;

    public static partial class MagicOnionInitializer
    {
        static bool isRegistered = false;

        public static void Register()
        {
            if(isRegistered) return;
            isRegistered = true;

            MagicOnionClientRegistry<global::MagicOnion.Integration.Tests.IClientFilterTestService>.Register((x, y) => new MagicOnion.Integration.Tests.ClientFilterTestServiceClient(x, y));
            MagicOnionClientRegistry<global::MagicOnion.Integration.Tests.IDynamicArgumentTupleService>.Register((x, y) => new MagicOnion.Integration.Tests.DynamicArgumentTupleServiceClient(x, y));
            MagicOnionClientRegistry<global::MagicOnion.Integration.Tests.IStreamingTestService>.Register((x, y) => new MagicOnion.Integration.Tests.StreamingTestServiceClient(x, y));

            StreamingHubClientRegistry<global::MagicOnion.Integration.Tests.IStreamingHubTestHub, global::MagicOnion.Integration.Tests.IStreamingHubTestHubReceiver>.Register((a, _, b, c, d, e) => new MagicOnion.Integration.Tests.StreamingHubTestHubClient(a, b, c, d, e));
        }
    }
}

#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace MagicOnion.Integration.Tests.Generated.Resolvers
{
    using System;
    using MessagePack;

    public class MagicOnionResolver : global::MessagePack.IFormatterResolver
    {
        public static readonly global::MessagePack.IFormatterResolver Instance = new MagicOnionResolver();

        MagicOnionResolver()
        {

        }

        public global::MessagePack.Formatters.IMessagePackFormatter<T> GetFormatter<T>()
        {
            return FormatterCache<T>.formatter;
        }

        static class FormatterCache<T>
        {
            public static readonly global::MessagePack.Formatters.IMessagePackFormatter<T> formatter;

            static FormatterCache()
            {
                var f = MagicOnionResolverGetFormatterHelper.GetFormatter(typeof(T));
                if (f != null)
                {
                    formatter = (global::MessagePack.Formatters.IMessagePackFormatter<T>)f;
                }
            }
        }
    }

    internal static class MagicOnionResolverGetFormatterHelper
    {
        static readonly global::System.Collections.Generic.Dictionary<Type, int> lookup;

        static MagicOnionResolverGetFormatterHelper()
        {
            lookup = new global::System.Collections.Generic.Dictionary<Type, int>(4)
            {
                {typeof(global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32>), 0 },
                {typeof(global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.Int32>), 1 },
                {typeof(global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String, global::System.Boolean>), 2 },
                {typeof(global::System.ValueTuple<global::System.Int32, global::System.Int32>), 3 },
            };
        }

        internal static object GetFormatter(Type t)
        {
            int key;
            if (!lookup.TryGetValue(t, out key))
            {
                return null;
            }

            switch (key)
            {
                case 0: return new global::MagicOnion.DynamicArgumentTupleFormatter<global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32>(default(global::System.Int32), default(global::System.Int32), default(global::System.Int32), default(global::System.Int32), default(global::System.Int32), default(global::System.Int32), default(global::System.Int32), default(global::System.Int32), default(global::System.Int32), default(global::System.Int32), default(global::System.Int32), default(global::System.Int32), default(global::System.Int32), default(global::System.Int32), default(global::System.Int32));
                case 1: return new global::MagicOnion.DynamicArgumentTupleFormatter<global::System.Int32, global::System.Int32>(default(global::System.Int32), default(global::System.Int32));
                case 2: return new global::MagicOnion.DynamicArgumentTupleFormatter<global::System.Int32, global::System.String, global::System.Boolean>(default(global::System.Int32), default(global::System.String), default(global::System.Boolean));
                case 3: return new global::MessagePack.Formatters.ValueTupleFormatter<global::System.Int32, global::System.Int32>();
                default: return null;
            }
        }
    }
}

#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace MagicOnion.Integration.Tests
{
    using global::System;
    using global::Grpc.Core;
    using global::MagicOnion;
    using global::MagicOnion.Client;
    using global::MessagePack;
    
    [global::MagicOnion.Ignore]
    public class ClientFilterTestServiceClient : global::MagicOnion.Client.MagicOnionClientBase<global::MagicOnion.Integration.Tests.IClientFilterTestService>, global::MagicOnion.Integration.Tests.IClientFilterTestService
    {
        class ClientCore
        {
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.Int32>, global::System.Int32> Unary1;
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::MessagePack.Nil, global::MessagePack.Nil> HeaderEcho;
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::MessagePack.Nil, global::MessagePack.Nil> AlwaysError;
            public ClientCore(global::MessagePack.MessagePackSerializerOptions serializerOptions)
            {
                this.Unary1 = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_ValueType_ValueType<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.Int32>, global::System.Int32>(global::Grpc.Core.MethodType.Unary, "IClientFilterTestService", "Unary1", serializerOptions);
                this.HeaderEcho = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_ValueType_ValueType<global::MessagePack.Nil, global::MessagePack.Nil>(global::Grpc.Core.MethodType.Unary, "IClientFilterTestService", "HeaderEcho", serializerOptions);
                this.AlwaysError = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_ValueType_ValueType<global::MessagePack.Nil, global::MessagePack.Nil>(global::Grpc.Core.MethodType.Unary, "IClientFilterTestService", "AlwaysError", serializerOptions);
            }
        }
        
        readonly ClientCore core;
        
        public ClientFilterTestServiceClient(global::MagicOnion.Client.MagicOnionClientOptions options, global::MessagePack.MessagePackSerializerOptions serializerOptions) : base(options)
        {
            this.core = new ClientCore(serializerOptions);
        }
        
        private ClientFilterTestServiceClient(global::MagicOnion.Client.MagicOnionClientOptions options, ClientCore core) : base(options)
        {
            this.core = core;
        }
        
        protected override global::MagicOnion.Client.MagicOnionClientBase<IClientFilterTestService> Clone(global::MagicOnion.Client.MagicOnionClientOptions options)
            => new ClientFilterTestServiceClient(options, core);
        
        public global::MagicOnion.UnaryResult<global::System.Int32> Unary1(global::System.Int32 x, global::System.Int32 y)
            => this.core.Unary1.InvokeUnary(this, "IClientFilterTestService/Unary1", new global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.Int32>(x, y));
        public global::MagicOnion.UnaryResult<global::MessagePack.Nil> HeaderEcho()
            => this.core.HeaderEcho.InvokeUnary(this, "IClientFilterTestService/HeaderEcho", global::MessagePack.Nil.Default);
        public global::MagicOnion.UnaryResult<global::MessagePack.Nil> AlwaysError()
            => this.core.AlwaysError.InvokeUnary(this, "IClientFilterTestService/AlwaysError", global::MessagePack.Nil.Default);
    }
}

namespace MagicOnion.Integration.Tests
{
    using global::System;
    using global::Grpc.Core;
    using global::MagicOnion;
    using global::MagicOnion.Client;
    using global::MessagePack;
    
    [global::MagicOnion.Ignore]
    public class DynamicArgumentTupleServiceClient : global::MagicOnion.Client.MagicOnionClientBase<global::MagicOnion.Integration.Tests.IDynamicArgumentTupleService>, global::MagicOnion.Integration.Tests.IDynamicArgumentTupleService
    {
        class ClientCore
        {
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32>, global::System.Int32> Unary1;
            public ClientCore(global::MessagePack.MessagePackSerializerOptions serializerOptions)
            {
                this.Unary1 = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_ValueType_ValueType<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32>, global::System.Int32>(global::Grpc.Core.MethodType.Unary, "IDynamicArgumentTupleService", "Unary1", serializerOptions);
            }
        }
        
        readonly ClientCore core;
        
        public DynamicArgumentTupleServiceClient(global::MagicOnion.Client.MagicOnionClientOptions options, global::MessagePack.MessagePackSerializerOptions serializerOptions) : base(options)
        {
            this.core = new ClientCore(serializerOptions);
        }
        
        private DynamicArgumentTupleServiceClient(global::MagicOnion.Client.MagicOnionClientOptions options, ClientCore core) : base(options)
        {
            this.core = core;
        }
        
        protected override global::MagicOnion.Client.MagicOnionClientBase<IDynamicArgumentTupleService> Clone(global::MagicOnion.Client.MagicOnionClientOptions options)
            => new DynamicArgumentTupleServiceClient(options, core);
        
        public global::MagicOnion.UnaryResult<global::System.Int32> Unary1(global::System.Int32 arg0, global::System.Int32 arg1, global::System.Int32 arg2, global::System.Int32 arg3, global::System.Int32 arg4, global::System.Int32 arg5, global::System.Int32 arg6, global::System.Int32 arg7, global::System.Int32 arg8, global::System.Int32 arg9, global::System.Int32 arg10, global::System.Int32 arg11, global::System.Int32 arg12, global::System.Int32 arg13, global::System.Int32 arg14)
            => this.core.Unary1.InvokeUnary(this, "IDynamicArgumentTupleService/Unary1", new global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32, global::System.Int32>(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14));
    }
}

namespace MagicOnion.Integration.Tests
{
    using global::System;
    using global::Grpc.Core;
    using global::MagicOnion;
    using global::MagicOnion.Client;
    using global::MessagePack;
    
    [global::MagicOnion.Ignore]
    public class StreamingTestServiceClient : global::MagicOnion.Client.MagicOnionClientBase<global::MagicOnion.Integration.Tests.IStreamingTestService>, global::MagicOnion.Integration.Tests.IStreamingTestService
    {
        class ClientCore
        {
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::System.ValueTuple<global::System.Int32, global::System.Int32>, global::System.Int32> ClientStreaming;
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.Int32>, global::System.Int32> ServerStreaming;
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::System.ValueTuple<global::System.Int32, global::System.Int32>, global::System.Int32> DuplexStreaming;
            public ClientCore(global::MessagePack.MessagePackSerializerOptions serializerOptions)
            {
                this.ClientStreaming = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_ValueType_ValueType<global::System.ValueTuple<global::System.Int32, global::System.Int32>, global::System.Int32>(global::Grpc.Core.MethodType.ClientStreaming, "IStreamingTestService", "ClientStreaming", serializerOptions);
                this.ServerStreaming = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_ValueType_ValueType<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.Int32>, global::System.Int32>(global::Grpc.Core.MethodType.ServerStreaming, "IStreamingTestService", "ServerStreaming", serializerOptions);
                this.DuplexStreaming = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_ValueType_ValueType<global::System.ValueTuple<global::System.Int32, global::System.Int32>, global::System.Int32>(global::Grpc.Core.MethodType.DuplexStreaming, "IStreamingTestService", "DuplexStreaming", serializerOptions);
            }
        }
        
        readonly ClientCore core;
        
        public StreamingTestServiceClient(global::MagicOnion.Client.MagicOnionClientOptions options, global::MessagePack.MessagePackSerializerOptions serializerOptions) : base(options)
        {
            this.core = new ClientCore(serializerOptions);
        }
        
        private StreamingTestServiceClient(global::MagicOnion.Client.MagicOnionClientOptions options, ClientCore core) : base(options)
        {
            this.core = core;
        }
        
        protected override global::MagicOnion.Client.MagicOnionClientBase<IStreamingTestService> Clone(global::MagicOnion.Client.MagicOnionClientOptions options)
            => new StreamingTestServiceClient(options, core);
        
        public global::System.Threading.Tasks.Task<global::MagicOnion.ClientStreamingResult<global::System.ValueTuple<global::System.Int32, global::System.Int32>, global::System.Int32>> ClientStreaming()
            => this.core.ClientStreaming.InvokeClientStreaming(this, "IStreamingTestService/ClientStreaming");
        public global::System.Threading.Tasks.Task<global::MagicOnion.ServerStreamingResult<global::System.Int32>> ServerStreaming(global::System.Int32 arg0, global::System.Int32 arg1)
            => this.core.ServerStreaming.InvokeServerStreaming(this, "IStreamingTestService/ServerStreaming", new global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.Int32>(arg0, arg1));
        public global::System.Threading.Tasks.Task<global::MagicOnion.DuplexStreamingResult<global::System.ValueTuple<global::System.Int32, global::System.Int32>, global::System.Int32>> DuplexStreaming()
            => this.core.DuplexStreaming.InvokeDuplexStreaming(this, "IStreamingTestService/DuplexStreaming");
    }
}


#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

namespace MagicOnion.Integration.Tests {
    using Grpc.Core;
    using MagicOnion;
    using MagicOnion.Client;
    using MessagePack;
    using System;
    using System.Threading.Tasks;

    [Ignore]
    public class StreamingHubTestHubClient : StreamingHubClientBase<global::MagicOnion.Integration.Tests.IStreamingHubTestHub, global::MagicOnion.Integration.Tests.IStreamingHubTestHubReceiver>, global::MagicOnion.Integration.Tests.IStreamingHubTestHub
    {
        static readonly Method<byte[], byte[]> method = new Method<byte[], byte[]>(MethodType.DuplexStreaming, "IStreamingHubTestHub", "Connect", MagicOnionMarshallers.ThroughMarshaller, MagicOnionMarshallers.ThroughMarshaller);

        protected override Method<byte[], byte[]> DuplexStreamingAsyncMethod { get { return method; } }

        readonly global::MagicOnion.Integration.Tests.IStreamingHubTestHub __fireAndForgetClient;

        public StreamingHubTestHubClient(CallInvoker callInvoker, string host, CallOptions option, MessagePackSerializerOptions serializerOptions, IMagicOnionClientLogger logger)
            : base(callInvoker, host, option, serializerOptions, logger)
        {
            this.__fireAndForgetClient = new FireAndForgetClient(this);
        }
        
        public global::MagicOnion.Integration.Tests.IStreamingHubTestHub FireAndForget()
        {
            return __fireAndForgetClient;
        }

        protected override void OnBroadcastEvent(int methodId, ArraySegment<byte> data)
        {
            switch (methodId)
            {
                case 1445325235: // Receiver_Parameter_Zero
                {
                    var result = MessagePackSerializer.Deserialize<global::MessagePack.Nil>(data, serializerOptions);
                    receiver.Receiver_Parameter_Zero(); break;
                }
                case 1150128799: // Receiver_Parameter_One
                {
                    var result = MessagePackSerializer.Deserialize<global::System.Int32>(data, serializerOptions);
                    receiver.Receiver_Parameter_One(result); break;
                }
                case 283674770: // Receiver_Parameter_Many
                {
                    var result = MessagePackSerializer.Deserialize<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String, global::System.Boolean>>(data, serializerOptions);
                    receiver.Receiver_Parameter_Many(result.Item1, result.Item2, result.Item3); break;
                }
                default:
                    break;
            }
        }

        protected override void OnResponseEvent(int methodId, object taskCompletionSource, ArraySegment<byte> data)
        {
            switch (methodId)
            {
                case -933634881: // NoReturn_Parameter_Zero
                {
                    var result = MessagePackSerializer.Deserialize<global::MessagePack.Nil>(data, serializerOptions);
                    ((TaskCompletionSource<global::MessagePack.Nil>)taskCompletionSource).TrySetResult(result);
                    break;
                }
                case 1561818363: // NoReturn_Parameter_One
                {
                    var result = MessagePackSerializer.Deserialize<global::MessagePack.Nil>(data, serializerOptions);
                    ((TaskCompletionSource<global::MessagePack.Nil>)taskCompletionSource).TrySetResult(result);
                    break;
                }
                case -423495298: // NoReturn_Parameter_Many
                {
                    var result = MessagePackSerializer.Deserialize<global::MessagePack.Nil>(data, serializerOptions);
                    ((TaskCompletionSource<global::MessagePack.Nil>)taskCompletionSource).TrySetResult(result);
                    break;
                }
                case 1994667803: // Parameter_Zero
                {
                    var result = MessagePackSerializer.Deserialize<global::System.Int32>(data, serializerOptions);
                    ((TaskCompletionSource<global::System.Int32>)taskCompletionSource).TrySetResult(result);
                    break;
                }
                case 1979862359: // Parameter_One
                {
                    var result = MessagePackSerializer.Deserialize<global::System.Int32>(data, serializerOptions);
                    ((TaskCompletionSource<global::System.Int32>)taskCompletionSource).TrySetResult(result);
                    break;
                }
                case 1287160778: // Parameter_Many
                {
                    var result = MessagePackSerializer.Deserialize<global::System.Int32>(data, serializerOptions);
                    ((TaskCompletionSource<global::System.Int32>)taskCompletionSource).TrySetResult(result);
                    break;
                }
                case -686867585: // CallReceiver_Parameter_Zero
                {
                    var result = MessagePackSerializer.Deserialize<global::MessagePack.Nil>(data, serializerOptions);
                    ((TaskCompletionSource<global::MessagePack.Nil>)taskCompletionSource).TrySetResult(result);
                    break;
                }
                case -283979077: // CallReceiver_Parameter_One
                {
                    var result = MessagePackSerializer.Deserialize<global::MessagePack.Nil>(data, serializerOptions);
                    ((TaskCompletionSource<global::MessagePack.Nil>)taskCompletionSource).TrySetResult(result);
                    break;
                }
                case -601288642: // CallReceiver_Parameter_Many
                {
                    var result = MessagePackSerializer.Deserialize<global::MessagePack.Nil>(data, serializerOptions);
                    ((TaskCompletionSource<global::MessagePack.Nil>)taskCompletionSource).TrySetResult(result);
                    break;
                }
                case -1291900119: // Never
                {
                    var result = MessagePackSerializer.Deserialize<global::MessagePack.Nil>(data, serializerOptions);
                    ((TaskCompletionSource<global::MessagePack.Nil>)taskCompletionSource).TrySetResult(result);
                    break;
                }
                case 2074829953: // Never_With_Return
                {
                    var result = MessagePackSerializer.Deserialize<global::System.Int32>(data, serializerOptions);
                    ((TaskCompletionSource<global::System.Int32>)taskCompletionSource).TrySetResult(result);
                    break;
                }
                default:
                    break;
            }
        }
   
        public global::System.Threading.Tasks.Task NoReturn_Parameter_Zero()
        {
            return WriteMessageWithResponseAsync<global::MessagePack.Nil, global::MessagePack.Nil>(-933634881, global::MessagePack.Nil.Default);
        }

        public global::System.Threading.Tasks.Task NoReturn_Parameter_One(global::System.Int32 arg0)
        {
            return WriteMessageWithResponseAsync<global::System.Int32, global::MessagePack.Nil>(1561818363, arg0);
        }

        public global::System.Threading.Tasks.Task NoReturn_Parameter_Many(global::System.Int32 arg0, global::System.String arg1, global::System.Boolean arg2)
        {
            return WriteMessageWithResponseAsync<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String, global::System.Boolean>, global::MessagePack.Nil>(-423495298, new global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String, global::System.Boolean>(arg0, arg1, arg2));
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> Parameter_Zero()
        {
            return WriteMessageWithResponseAsync<global::MessagePack.Nil, global::System.Int32>(1994667803, global::MessagePack.Nil.Default);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> Parameter_One(global::System.Int32 arg0)
        {
            return WriteMessageWithResponseAsync<global::System.Int32, global::System.Int32>(1979862359, arg0);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> Parameter_Many(global::System.Int32 arg0, global::System.String arg1, global::System.Boolean arg2)
        {
            return WriteMessageWithResponseAsync<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String, global::System.Boolean>, global::System.Int32>(1287160778, new global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String, global::System.Boolean>(arg0, arg1, arg2));
        }

        public global::System.Threading.Tasks.Task CallReceiver_Parameter_Zero()
        {
            return WriteMessageWithResponseAsync<global::MessagePack.Nil, global::MessagePack.Nil>(-686867585, global::MessagePack.Nil.Default);
        }

        public global::System.Threading.Tasks.Task CallReceiver_Parameter_One(global::System.Int32 arg0)
        {
            return WriteMessageWithResponseAsync<global::System.Int32, global::MessagePack.Nil>(-283979077, arg0);
        }

        public global::System.Threading.Tasks.Task CallReceiver_Parameter_Many(global::System.Int32 arg0, global::System.String arg1, global::System.Boolean arg2)
        {
            return WriteMessageWithResponseAsync<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String, global::System.Boolean>, global::MessagePack.Nil>(-601288642, new global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String, global::System.Boolean>(arg0, arg1, arg2));
        }

        public global::System.Threading.Tasks.Task Never()
        {
            return WriteMessageWithResponseAsync<global::MessagePack.Nil, global::MessagePack.Nil>(-1291900119, global::MessagePack.Nil.Default);
        }

        public global::System.Threading.Tasks.Task<global::System.Int32> Never_With_Return()
        {
            return WriteMessageWithResponseAsync<global::MessagePack.Nil, global::System.Int32>(2074829953, global::MessagePack.Nil.Default);
        }


        [Ignore]
        class FireAndForgetClient : global::MagicOnion.Integration.Tests.IStreamingHubTestHub
        {
            readonly StreamingHubTestHubClient __parent;

            public FireAndForgetClient(StreamingHubTestHubClient parentClient)
            {
                this.__parent = parentClient;
            }

            public global::MagicOnion.Integration.Tests.IStreamingHubTestHub FireAndForget()
            {
                throw new NotSupportedException();
            }

            public Task DisposeAsync()
            {
                throw new NotSupportedException();
            }

            public Task WaitForDisconnect()
            {
                throw new NotSupportedException();
            }

            public global::System.Threading.Tasks.Task NoReturn_Parameter_Zero()
            {
                return __parent.WriteMessageWithResponseAsync<global::MessagePack.Nil, global::MessagePack.Nil>(-933634881, global::MessagePack.Nil.Default);
            }

            public global::System.Threading.Tasks.Task NoReturn_Parameter_One(global::System.Int32 arg0)
            {
                return __parent.WriteMessageWithResponseAsync<global::System.Int32, global::MessagePack.Nil>(1561818363, arg0);
            }

            public global::System.Threading.Tasks.Task NoReturn_Parameter_Many(global::System.Int32 arg0, global::System.String arg1, global::System.Boolean arg2)
            {
                return __parent.WriteMessageWithResponseAsync<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String, global::System.Boolean>, global::MessagePack.Nil>(-423495298, new global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String, global::System.Boolean>(arg0, arg1, arg2));
            }

            public global::System.Threading.Tasks.Task<global::System.Int32> Parameter_Zero()
            {
                return __parent.WriteMessageWithResponseAsync<global::MessagePack.Nil, global::System.Int32>(1994667803, global::MessagePack.Nil.Default);
            }

            public global::System.Threading.Tasks.Task<global::System.Int32> Parameter_One(global::System.Int32 arg0)
            {
                return __parent.WriteMessageWithResponseAsync<global::System.Int32, global::System.Int32>(1979862359, arg0);
            }

            public global::System.Threading.Tasks.Task<global::System.Int32> Parameter_Many(global::System.Int32 arg0, global::System.String arg1, global::System.Boolean arg2)
            {
                return __parent.WriteMessageWithResponseAsync<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String, global::System.Boolean>, global::System.Int32>(1287160778, new global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String, global::System.Boolean>(arg0, arg1, arg2));
            }

            public global::System.Threading.Tasks.Task CallReceiver_Parameter_Zero()
            {
                return __parent.WriteMessageWithResponseAsync<global::MessagePack.Nil, global::MessagePack.Nil>(-686867585, global::MessagePack.Nil.Default);
            }

            public global::System.Threading.Tasks.Task CallReceiver_Parameter_One(global::System.Int32 arg0)
            {
                return __parent.WriteMessageWithResponseAsync<global::System.Int32, global::MessagePack.Nil>(-283979077, arg0);
            }

            public global::System.Threading.Tasks.Task CallReceiver_Parameter_Many(global::System.Int32 arg0, global::System.String arg1, global::System.Boolean arg2)
            {
                return __parent.WriteMessageWithResponseAsync<global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String, global::System.Boolean>, global::MessagePack.Nil>(-601288642, new global::MagicOnion.DynamicArgumentTuple<global::System.Int32, global::System.String, global::System.Boolean>(arg0, arg1, arg2));
            }

            public global::System.Threading.Tasks.Task Never()
            {
                return __parent.WriteMessageWithResponseAsync<global::MessagePack.Nil, global::MessagePack.Nil>(-1291900119, global::MessagePack.Nil.Default);
            }

            public global::System.Threading.Tasks.Task<global::System.Int32> Never_With_Return()
            {
                return __parent.WriteMessageWithResponseAsync<global::MessagePack.Nil, global::System.Int32>(2074829953, global::MessagePack.Nil.Default);
            }

        }
    }
}

#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612
