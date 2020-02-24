using System;
using System.Text.RegularExpressions;

namespace RiseFood.Core.DomainObjects
{
    public static class Validations
    {
        public static void ValidateIfEqual(object object1, object object2, string message)
        {
            if (object1.Equals(object2))
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfDiffent(object object1, object object2, string message)
        {
            if (!object1.Equals(object2))
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfDiffent(string pattern, string value, string message)
        {
            var regex = new Regex(pattern);

            if (!regex.IsMatch(value))
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateLength(string value, int max, string message)
        {
            var length = value.Trim().Length;
            if (length > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateLength(string value, int minimo, int maximo, string message)
        {
            var length = value.Trim().Length;
            if (length < minimo || length > maximo)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfEmpty(string value, string message)
        {
            if (value == null || value.Trim().Length == 0)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfNull(object object1, string message)
        {
            if (object1 == null)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateMinimunMax(double value, double minimun, double max, string message)
        {
            if (value < minimun || value > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateMinimunMax(float value, float minimun, float max, string message)
        {
            if (value < minimun || value > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateMinimunMax(int value, int minimum, int max, string message)
        {
            if (value < minimum || value > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateMinimunMax(long value, long minimun, long max, string message)
        {
            if (value < minimun || value > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateMinimunMax(decimal value, decimal minimum, decimal max, string message)
        {
            if (value < minimum || value > max)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfLessThan(long value, long minimum, string message)
        {
            if (value < minimum)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfLessThan(double value, double minimun, string message)
        {
            if (value < minimun)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfLessThan(decimal value, decimal minimum, string message)
        {
            if (value < minimum)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfLessThan(int value, int minimum, string message)
        {
            if (value < minimum)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfLessThan(DateTime value, DateTime minimum, string message)
        {
            if(DateTime.Compare(value, minimum) < 0)
            {
                throw new DomainException(message);
            }
        }
        public static void ValidateIfFalse(bool boolvalue, string message)
        {
            if (!boolvalue)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidateIfTrue(bool boolvalue, string message)
        {
            if (boolvalue)
            {
                throw new DomainException(message);
            }
        }
    }
}
