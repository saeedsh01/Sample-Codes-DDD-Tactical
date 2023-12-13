﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DDDWorkShop.ValueObjects
{
    public abstract  class BaseValueObject<T> where T :BaseValueObject<T>
    {

        public override bool Equals(object obj)
        {
            var valueObject = obj as T;
            if (ReferenceEquals(valueObject, null))
                return false;
            return IsEqual(valueObject);
        }

        public override int GetHashCode()
        {
            return GetHashCodeCore();
        }

        protected abstract int GetHashCodeCore();

        protected abstract bool IsEqual(T other);        



        public static bool operator ==(BaseValueObject<T> a, BaseValueObject<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }
        public static bool operator !=(BaseValueObject<T> a, BaseValueObject<T> b)
        {
            return !(a == b);
        }



    }
}
