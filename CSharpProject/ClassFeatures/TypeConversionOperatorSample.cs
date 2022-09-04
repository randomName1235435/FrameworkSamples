using System;

namespace CSharpProject.ClassFeatures;

public class TypeConversionOperatorSample
{
    public void SampleMethod()
    {
        UserId userId = Guid.NewGuid();
        Guid guid = userId;
        var nextUserId = (UserId)new byte[0];
    }

    public class UserId
    {
        public UserId(Guid guid)
        {
            Id = guid;
        }

        public Guid Id { get; }

        public static implicit operator UserId(Guid from)
        {
            return new UserId(from);
        }

        public static implicit operator Guid(UserId from)
        {
            return from.Id;
        }

        public static explicit operator UserId(byte[] from)
        {
            return new UserId(new Guid(from));
        }
    }
}