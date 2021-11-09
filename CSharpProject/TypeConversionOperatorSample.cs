using System;

public class TypeConversionOperatorSample
{
    public void SampleMethod() {

        UserId userId = Guid.NewGuid();
        Guid guid = userId;
        UserId nextUserId = (UserId)new byte[0];
    }

    public class UserId
    {
        private readonly Guid id;
        public Guid Id { get { return this.id; } }

        public UserId(Guid guid)
        {
            this.id = guid;
        }

        public static implicit operator UserId(Guid from) {
            return new UserId(from);
        }
        public static implicit operator Guid(UserId from)
        {
            return from.id;
        }

        public static explicit operator UserId(byte[] from)
        {
            return new UserId(new Guid(from));
        }
    }
}