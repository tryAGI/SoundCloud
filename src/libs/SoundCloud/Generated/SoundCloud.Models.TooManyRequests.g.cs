#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TooManyRequests : global::System.IEquatable<TooManyRequests>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::SoundCloud.Error? Error { get; init; }
#else
        public global::SoundCloud.Error? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::SoundCloud.Error? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.Error PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::SoundCloud.TooManyRequestsVariant2? TooManyRequestsVariant2 { get; init; }
#else
        public global::SoundCloud.TooManyRequestsVariant2? TooManyRequestsVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TooManyRequestsVariant2))]
#endif
        public bool IsTooManyRequestsVariant2 => TooManyRequestsVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTooManyRequestsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::SoundCloud.TooManyRequestsVariant2? value)
        {
            value = TooManyRequestsVariant2;
            return IsTooManyRequestsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TooManyRequestsVariant2 PickTooManyRequestsVariant2() => IsTooManyRequestsVariant2
            ? TooManyRequestsVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TooManyRequestsVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TooManyRequests(global::SoundCloud.Error value) => new TooManyRequests((global::SoundCloud.Error?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::SoundCloud.Error?(TooManyRequests @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public TooManyRequests(global::SoundCloud.Error? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TooManyRequests FromError(global::SoundCloud.Error? value) => new TooManyRequests(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TooManyRequests(global::SoundCloud.TooManyRequestsVariant2 value) => new TooManyRequests((global::SoundCloud.TooManyRequestsVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::SoundCloud.TooManyRequestsVariant2?(TooManyRequests @this) => @this.TooManyRequestsVariant2;

        /// <summary>
        ///
        /// </summary>
        public TooManyRequests(global::SoundCloud.TooManyRequestsVariant2? value)
        {
            TooManyRequestsVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TooManyRequests FromTooManyRequestsVariant2(global::SoundCloud.TooManyRequestsVariant2? value) => new TooManyRequests(value);

        /// <summary>
        ///
        /// </summary>
        public TooManyRequests(
            global::SoundCloud.Error? error,
            global::SoundCloud.TooManyRequestsVariant2? tooManyRequestsVariant2
            )
        {
            Error = error;
            TooManyRequestsVariant2 = tooManyRequestsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TooManyRequestsVariant2 as object ??
            Error as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Error?.ToString() ??
            TooManyRequestsVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsError && IsTooManyRequestsVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::SoundCloud.Error, TResult>? error = null,
            global::System.Func<global::SoundCloud.TooManyRequestsVariant2, TResult>? tooManyRequestsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsError && error != null)
            {
                return error(Error!);
            }
            else if (IsTooManyRequestsVariant2 && tooManyRequestsVariant2 != null)
            {
                return tooManyRequestsVariant2(TooManyRequestsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::SoundCloud.Error>? error = null,

            global::System.Action<global::SoundCloud.TooManyRequestsVariant2>? tooManyRequestsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsTooManyRequestsVariant2)
            {
                tooManyRequestsVariant2?.Invoke(TooManyRequestsVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::SoundCloud.Error>? error = null,
            global::System.Action<global::SoundCloud.TooManyRequestsVariant2>? tooManyRequestsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsError)
            {
                error?.Invoke(Error!);
            }
            else if (IsTooManyRequestsVariant2)
            {
                tooManyRequestsVariant2?.Invoke(TooManyRequestsVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Error,
                typeof(global::SoundCloud.Error),
                TooManyRequestsVariant2,
                typeof(global::SoundCloud.TooManyRequestsVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(TooManyRequests other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::SoundCloud.Error?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::SoundCloud.TooManyRequestsVariant2?>.Default.Equals(TooManyRequestsVariant2, other.TooManyRequestsVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TooManyRequests obj1, TooManyRequests obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TooManyRequests>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TooManyRequests obj1, TooManyRequests obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TooManyRequests o && Equals(o);
        }
    }
}
