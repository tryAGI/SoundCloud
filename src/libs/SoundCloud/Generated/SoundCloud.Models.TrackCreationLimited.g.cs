#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace SoundCloud
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TrackCreationLimited : global::System.IEquatable<TrackCreationLimited>
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
        public global::SoundCloud.Error PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::SoundCloud.TrackCreationLimitedVariant2? TrackCreationLimitedVariant2 { get; init; }
#else
        public global::SoundCloud.TrackCreationLimitedVariant2? TrackCreationLimitedVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TrackCreationLimitedVariant2))]
#endif
        public bool IsTrackCreationLimitedVariant2 => TrackCreationLimitedVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTrackCreationLimitedVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::SoundCloud.TrackCreationLimitedVariant2? value)
        {
            value = TrackCreationLimitedVariant2;
            return IsTrackCreationLimitedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::SoundCloud.TrackCreationLimitedVariant2 PickTrackCreationLimitedVariant2() => TrackCreationLimitedVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TrackCreationLimitedVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TrackCreationLimited(global::SoundCloud.Error value) => new TrackCreationLimited((global::SoundCloud.Error?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::SoundCloud.Error?(TrackCreationLimited @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public TrackCreationLimited(global::SoundCloud.Error? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TrackCreationLimited FromError(global::SoundCloud.Error? value) => new TrackCreationLimited(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TrackCreationLimited(global::SoundCloud.TrackCreationLimitedVariant2 value) => new TrackCreationLimited((global::SoundCloud.TrackCreationLimitedVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::SoundCloud.TrackCreationLimitedVariant2?(TrackCreationLimited @this) => @this.TrackCreationLimitedVariant2;

        /// <summary>
        ///
        /// </summary>
        public TrackCreationLimited(global::SoundCloud.TrackCreationLimitedVariant2? value)
        {
            TrackCreationLimitedVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TrackCreationLimited FromTrackCreationLimitedVariant2(global::SoundCloud.TrackCreationLimitedVariant2? value) => new TrackCreationLimited(value);

        /// <summary>
        ///
        /// </summary>
        public TrackCreationLimited(
            global::SoundCloud.Error? error,
            global::SoundCloud.TrackCreationLimitedVariant2? trackCreationLimitedVariant2
            )
        {
            Error = error;
            TrackCreationLimitedVariant2 = trackCreationLimitedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TrackCreationLimitedVariant2 as object ??
            Error as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Error?.ToString() ??
            TrackCreationLimitedVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsError && IsTrackCreationLimitedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::SoundCloud.Error, TResult>? error = null,
            global::System.Func<global::SoundCloud.TrackCreationLimitedVariant2, TResult>? trackCreationLimitedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Error is { } __value0 && error != null)
            {
                return error(__value0);
            }
            else if (TrackCreationLimitedVariant2 is { } __value1 && trackCreationLimitedVariant2 != null)
            {
                return trackCreationLimitedVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::SoundCloud.Error>? error = null,

            global::System.Action<global::SoundCloud.TrackCreationLimitedVariant2>? trackCreationLimitedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Error is { } __value0)
            {
                error?.Invoke(__value0);
            }
            else if (TrackCreationLimitedVariant2 is { } __value1)
            {
                trackCreationLimitedVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::SoundCloud.Error>? error = null,
            global::System.Action<global::SoundCloud.TrackCreationLimitedVariant2>? trackCreationLimitedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Error is { } __value0)
            {
                error?.Invoke(__value0);
            }
            else if (TrackCreationLimitedVariant2 is { } __value1)
            {
                trackCreationLimitedVariant2?.Invoke(__value1);
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
                TrackCreationLimitedVariant2,
                typeof(global::SoundCloud.TrackCreationLimitedVariant2),
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
        public bool Equals(TrackCreationLimited other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::SoundCloud.Error?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::SoundCloud.TrackCreationLimitedVariant2?>.Default.Equals(TrackCreationLimitedVariant2, other.TrackCreationLimitedVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TrackCreationLimited obj1, TrackCreationLimited obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrackCreationLimited>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TrackCreationLimited obj1, TrackCreationLimited obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrackCreationLimited o && Equals(o);
        }
    }
}
