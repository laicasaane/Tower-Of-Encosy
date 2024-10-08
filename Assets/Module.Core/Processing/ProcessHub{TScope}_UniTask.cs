#if UNITASK
#if !(UNITY_EDITOR || DEBUG) || DISABLE_DEBUG
#define __MODULE_CORE_PROCESSING_NO_VALIDATION__
#else
#define __MODULE_CORE_PROCESSING_VALIDATION__
#endif

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Module.Core.Logging;
using Module.Core.Processing.Internals;
using UnityEngine;

namespace Module.Core.Processing
{
    public readonly partial struct ProcessHub<TScope>
    {
        #region    REGISTER - ASYNC
        #endregion ================

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Option<TypeId> Register<TRequest>(Func<TRequest, UniTask> process)
        {
            ThrowIfHandlerIsNull(process);
            return Register(new Internals.Async.AsyncProcessHandler<TRequest>(process));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Option<TypeId> Register<TRequest, TResult>(Func<TRequest, UniTask<TResult>> process)
        {
            ThrowIfHandlerIsNull(process);
            return Register(new Internals.Async.AsyncProcessHandler<TRequest, TResult>(process));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Option<TypeId> Register<TRequest>(Func<TRequest, CancellationToken, UniTask> process)
        {
            ThrowIfHandlerIsNull(process);
            return Register(new Internals.Async.CancellableAsyncProcessHandler<TRequest>(process));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Option<TypeId> Register<TRequest, TResult>(Func<TRequest, CancellationToken, UniTask<TResult>> process)
        {
            ThrowIfHandlerIsNull(process);
            return Register(new Internals.Async.CancellableAsyncProcessHandler<TRequest, TResult>(process));
        }

        #region    UNREGISTER - ASYNC
        #endregion ==================

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Unregister<TRequest>(Func<TRequest, UniTask> _)
        {
            return Unregister(TypeId.Get<Func<TRequest, UniTask>>());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Unregister<TRequest>(Func<TRequest, UniTask<bool>> _)
        {
            return Unregister(TypeId.Get<Func<TRequest, UniTask<bool>>>());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Unregister<TRequest, TResult>(Func<TRequest, UniTask<TResult>> _)
        {
            return Unregister(TypeId.Get<Func<TRequest, UniTask<TResult>>>());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Unregister<TRequest, TResult>(Func<TRequest, UniTask<Option<TResult>>> _)
        {
            return Unregister(TypeId.Get<Func<TRequest, UniTask<Option<TResult>>>>());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Unregister<TRequest>(Func<TRequest, CancellationToken, UniTask> _)
        {
            return Unregister(TypeId.Get<Func<TRequest, CancellationToken, UniTask>>());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Unregister<TRequest>(Func<TRequest, CancellationToken, UniTask<bool>> _)
        {
            return Unregister(TypeId.Get<Func<TRequest, CancellationToken, UniTask<bool>>>());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Unregister<TRequest, TResult>(Func<TRequest, CancellationToken, UniTask<TResult>> _)
        {
            return Unregister(TypeId.Get<Func<TRequest, CancellationToken, UniTask<TResult>>>());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Unregister<TRequest, TResult>(Func<TRequest, CancellationToken, UniTask<Option<TResult>>> _)
        {
            return Unregister(TypeId.Get<Func<TRequest, CancellationToken, UniTask<Option<TResult>>>>());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UniTask ProcessAsync<TRequest>(TRequest request)
        {
            if (TryGet(TypeId.Get<Func<TRequest, UniTask>>(), out var result)
                && result is IAsyncProcessHandler<TRequest> handler
            )
            {
                return handler.ProcessAsync(request, default);
            }

            throw ExceptionNotFound(Scope);

            static InvalidOperationException ExceptionNotFound(TScope scope)
            {
                return new InvalidOperationException(
                    $"Cannot find any process handler for the request {typeof(TRequest)} " +
                    $"which returns a UniTask " +
                    $"inside the scope {typeof(TScope)}({scope})"
                );
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async UniTask<bool> TryProcessAsync<TRequest>(TRequest request, bool silent = false)
        {
            if (TryGet(TypeId.Get<Func<TRequest, UniTask>>(), out var result)
                && result is IAsyncProcessHandler<TRequest> handler
            )
            {
                await handler.ProcessAsync(request, default);
                return true;
            }

            if (silent == false)
            {
                ErrorNotFound(Scope);
            }

            return false;

            [HideInCallstack, DoesNotReturn, Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
            static void ErrorNotFound(TScope scope)
            {
                DevLoggerAPI.LogError(
                    $"Cannot find any process handler for the request {typeof(TRequest)} " +
                    $"which returns a UniTask " +
                    $"inside the scope {typeof(TScope)}({scope})"
                );
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UniTask<TResult> ProcessAsync<TRequest, TResult>(TRequest request)
        {
            if (TryGet(TypeId.Get<Func<TRequest, UniTask<TResult>>>(), out var result)
                && result is IAsyncProcessHandler<TRequest, TResult> handler
            )
            {
                return handler.ProcessAsync(request, default);
            }

            throw ExceptionNotFound(Scope);

            static InvalidOperationException ExceptionNotFound(TScope scope)
            {
                return new InvalidOperationException(
                    $"Cannot find any process handler for the request {typeof(TRequest)} " +
                    $"which returns a UniTask<{typeof(TResult)}> " +
                    $"inside the scope {typeof(TScope)}({scope})"
                );
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public async UniTask<Option<TResult>> TryProcessAsync<TRequest, TResult>(TRequest request, bool silent = false)
        {
            if (TryGet(TypeId.Get<Func<TRequest, UniTask<TResult>>>(), out var result)
                && result is IAsyncProcessHandler<TRequest, TResult> handler
            )
            {
                return await handler.ProcessAsync(request, default);
            }

            if (silent == false)
            {
                ErrorNotFound(Scope);
            }

            return default;

            [HideInCallstack, DoesNotReturn, Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
            static void ErrorNotFound(TScope scope)
            {
                DevLoggerAPI.LogError(
                    $"Cannot find any process handler for the request {typeof(TRequest)} " +
                    $"which returns a UniTask<{typeof(TResult)}> " +
                    $"inside the scope {typeof(TScope)}({scope})"
                );
            }
        }

        public UniTask ProcessAsync<TRequest>(TRequest request, CancellationToken token)
        {
            if (TryGet(TypeId.Get<Func<TRequest, CancellationToken, UniTask>>(), out var result)
                && result is IAsyncProcessHandler<TRequest> handler
            )
            {
                return handler.ProcessAsync(request, token);
            }

            throw ExceptionNotFound(Scope);

            static InvalidOperationException ExceptionNotFound(TScope scope)
            {
                return new InvalidOperationException(
                    $"Cannot find any process handler for the request {typeof(TRequest)} " +
                    $"which returns a UniTask " +
                    $"inside the scope {typeof(TScope)}({scope})"
                );
            }
        }

        public async UniTask<bool> TryProcessAsync<TRequest>(TRequest request, CancellationToken token, bool silent = false)
        {
            if (TryGet(TypeId.Get<Func<TRequest, CancellationToken, UniTask>>(), out var result)
                && result is IAsyncProcessHandler<TRequest> handler
            )
            {
                await handler.ProcessAsync(request, token);
                return true;
            }

            if (silent == false)
            {
                ErrorNotFound(Scope);
            }

            return false;

            [HideInCallstack, DoesNotReturn, Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
            static void ErrorNotFound(TScope scope)
            {
                DevLoggerAPI.LogError(
                    $"Cannot find any process handler for the request {typeof(TRequest)} " +
                    $"which returns a UniTask " +
                    $"inside the scope {typeof(TScope)}({scope})"
                );
            }
        }

        public UniTask<TResult> ProcessAsync<TRequest, TResult>(TRequest request, CancellationToken token)
        {
            if (TryGet(TypeId.Get<Func<TRequest, CancellationToken, UniTask<TResult>>>(), out var result)
                && result is IAsyncProcessHandler<TRequest, TResult> handler
            )
            {
                return handler.ProcessAsync(request, token);
            }

            throw ExceptionNotFound(Scope);

            static InvalidOperationException ExceptionNotFound(TScope scope)
            {
                return new InvalidOperationException(
                    $"Cannot find any process handler for the request {typeof(TRequest)} " +
                    $"which returns a UniTask<{typeof(TResult)}> " +
                    $"inside the scope {typeof(TScope)}({scope})"
                );
            }
        }

        public async UniTask<Option<TResult>> TryProcessAsync<TRequest, TResult>(TRequest request, CancellationToken token, bool silent = false)
        {
            if (TryGet(TypeId.Get<Func<TRequest, CancellationToken, UniTask<TResult>>>(), out var result)
                && result is IAsyncProcessHandler<TRequest, TResult> handler
            )
            {
                return await handler.ProcessAsync(request, token);
            }

            if (silent == false)
            {
                ErrorNotFound(Scope);
            }

            return default;

            [HideInCallstack, DoesNotReturn, Conditional("UNITY_EDITOR"), Conditional("DEVELOPMENT_BUILD")]
            static void ErrorNotFound(TScope scope)
            {
                DevLoggerAPI.LogError(
                    $"Cannot find any process handler for the request {typeof(TRequest)} " +
                    $"which returns a UniTask<{typeof(TResult)}> " +
                    $"inside the scope {typeof(TScope)}({scope})"
                );
            }
        }
    }
}

#endif
