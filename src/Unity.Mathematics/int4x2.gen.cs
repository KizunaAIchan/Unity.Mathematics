//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct int4x2 : System.IEquatable<int4x2>, IFormattable
    {
        public int4 c0;
        public int4 c1;

        /// <summary>int4x2 zero value.</summary>
        public static readonly int4x2 zero;

        /// <summary>Constructs a int4x2 matrix from two int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(in int4 c0, in int4 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a int4x2 matrix from 8 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(int m00, int m01,
                      int m10, int m11,
                      int m20, int m21,
                      int m30, int m31)
        {
            this.c0 = new int4(m00, m10, m20, m30);
            this.c1 = new int4(m01, m11, m21, m31);
        }

        /// <summary>Constructs a int4x2 matrix from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(int v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a int4x2 matrix from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(bool v)
        {
            this.c0 = math.select(new int4(0), new int4(1), v);
            this.c1 = math.select(new int4(0), new int4(1), v);
        }

        /// <summary>Constructs a int4x2 matrix from a bool4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(in bool4x2 v)
        {
            this.c0 = math.select(new int4(0), new int4(1), v.c0);
            this.c1 = math.select(new int4(0), new int4(1), v.c1);
        }

        /// <summary>Constructs a int4x2 matrix from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(uint v)
        {
            this.c0 = (int4)v;
            this.c1 = (int4)v;
        }

        /// <summary>Constructs a int4x2 matrix from a uint4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(in uint4x2 v)
        {
            this.c0 = (int4)v.c0;
            this.c1 = (int4)v.c1;
        }

        /// <summary>Constructs a int4x2 matrix from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(float v)
        {
            this.c0 = (int4)v;
            this.c1 = (int4)v;
        }

        /// <summary>Constructs a int4x2 matrix from a float4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(in float4x2 v)
        {
            this.c0 = (int4)v.c0;
            this.c1 = (int4)v.c1;
        }

        /// <summary>Constructs a int4x2 matrix from a single double value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(double v)
        {
            this.c0 = (int4)v;
            this.c1 = (int4)v;
        }

        /// <summary>Constructs a int4x2 matrix from a double4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(in double4x2 v)
        {
            this.c0 = (int4)v.c0;
            this.c1 = (int4)v.c1;
        }


        /// <summary>Implicitly converts a single int value to a int4x2 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4x2(int v) { return new int4x2(v); }

        /// <summary>Explicitly converts a single bool value to a int4x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(bool v) { return new int4x2(v); }

        /// <summary>Explicitly converts a bool4x2 matrix to a int4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(in bool4x2 v) { return new int4x2(v); }

        /// <summary>Explicitly converts a single uint value to a int4x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(uint v) { return new int4x2(v); }

        /// <summary>Explicitly converts a uint4x2 matrix to a int4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(in uint4x2 v) { return new int4x2(v); }

        /// <summary>Explicitly converts a single float value to a int4x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(float v) { return new int4x2(v); }

        /// <summary>Explicitly converts a float4x2 matrix to a int4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(in float4x2 v) { return new int4x2(v); }

        /// <summary>Explicitly converts a single double value to a int4x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(double v) { return new int4x2(v); }

        /// <summary>Explicitly converts a double4x2 matrix to a int4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(in double4x2 v) { return new int4x2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator * (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator * (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 * rhs, lhs.c1 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator * (int lhs, int4x2 rhs) { return new int4x2 (lhs * rhs.c0, lhs * rhs.c1); }


        /// <summary>Returns the result of a componentwise addition operation on two int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator + (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }

        /// <summary>Returns the result of a componentwise addition operation on an int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator + (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 + rhs, lhs.c1 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator + (int lhs, int4x2 rhs) { return new int4x2 (lhs + rhs.c0, lhs + rhs.c1); }


        /// <summary>Returns the result of a componentwise subtraction operation on two int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator - (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator - (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 - rhs, lhs.c1 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator - (int lhs, int4x2 rhs) { return new int4x2 (lhs - rhs.c0, lhs - rhs.c1); }


        /// <summary>Returns the result of a componentwise division operation on two int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator / (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }

        /// <summary>Returns the result of a componentwise division operation on an int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator / (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 / rhs, lhs.c1 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator / (int lhs, int4x2 rhs) { return new int4x2 (lhs / rhs.c0, lhs / rhs.c1); }


        /// <summary>Returns the result of a componentwise modulus operation on two int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator % (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }

        /// <summary>Returns the result of a componentwise modulus operation on an int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator % (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 % rhs, lhs.c1 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator % (int lhs, int4x2 rhs) { return new int4x2 (lhs % rhs.c0, lhs % rhs.c1); }


        /// <summary>Returns the result of a componentwise increment operation on an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator ++ (int4x2 val) { return new int4x2 (++val.c0, ++val.c1); }


        /// <summary>Returns the result of a componentwise decrement operation on an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator -- (int4x2 val) { return new int4x2 (--val.c0, --val.c1); }


        /// <summary>Returns the result of a componentwise less than operation on two int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (int4x2 lhs, int4x2 rhs) { return new bool4x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }

        /// <summary>Returns the result of a componentwise less than operation on an int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (int4x2 lhs, int rhs) { return new bool4x2 (lhs.c0 < rhs, lhs.c1 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (int lhs, int4x2 rhs) { return new bool4x2 (lhs < rhs.c0, lhs < rhs.c1); }


        /// <summary>Returns the result of a componentwise less or equal operation on two int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (int4x2 lhs, int4x2 rhs) { return new bool4x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (int4x2 lhs, int rhs) { return new bool4x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (int lhs, int4x2 rhs) { return new bool4x2 (lhs <= rhs.c0, lhs <= rhs.c1); }


        /// <summary>Returns the result of a componentwise greater than operation on two int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (int4x2 lhs, int4x2 rhs) { return new bool4x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }

        /// <summary>Returns the result of a componentwise greater than operation on an int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (int4x2 lhs, int rhs) { return new bool4x2 (lhs.c0 > rhs, lhs.c1 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (int lhs, int4x2 rhs) { return new bool4x2 (lhs > rhs.c0, lhs > rhs.c1); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (int4x2 lhs, int4x2 rhs) { return new bool4x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (int4x2 lhs, int rhs) { return new bool4x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (int lhs, int4x2 rhs) { return new bool4x2 (lhs >= rhs.c0, lhs >= rhs.c1); }


        /// <summary>Returns the result of a componentwise unary minus operation on an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator - (int4x2 val) { return new int4x2 (-val.c0, -val.c1); }


        /// <summary>Returns the result of a componentwise unary plus operation on an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator + (int4x2 val) { return new int4x2 (+val.c0, +val.c1); }


        /// <summary>Returns the result of a componentwise left shift operation on an int4x2 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator << (in int4x2 x, int n) { return new int4x2 (x.c0 << n, x.c1 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an int4x2 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator >> (in int4x2 x, int n) { return new int4x2 (x.c0 >> n, x.c1 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (int4x2 lhs, int4x2 rhs) { return new bool4x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }

        /// <summary>Returns the result of a componentwise equality operation on an int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (int4x2 lhs, int rhs) { return new bool4x2 (lhs.c0 == rhs, lhs.c1 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an int value and an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (int lhs, int4x2 rhs) { return new bool4x2 (lhs == rhs.c0, lhs == rhs.c1); }


        /// <summary>Returns the result of a componentwise not equal operation on two int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (int4x2 lhs, int4x2 rhs) { return new bool4x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }

        /// <summary>Returns the result of a componentwise not equal operation on an int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (int4x2 lhs, int rhs) { return new bool4x2 (lhs.c0 != rhs, lhs.c1 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an int value and an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (int lhs, int4x2 rhs) { return new bool4x2 (lhs != rhs.c0, lhs != rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator ~ (int4x2 val) { return new int4x2 (~val.c0, ~val.c1); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator & (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator & (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 & rhs, lhs.c1 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator & (int lhs, int4x2 rhs) { return new int4x2 (lhs & rhs.c0, lhs & rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator | (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator | (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 | rhs, lhs.c1 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator | (int lhs, int4x2 rhs) { return new int4x2 (lhs | rhs.c0, lhs | rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator ^ (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator ^ (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator ^ (int lhs, int4x2 rhs) { return new int4x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }



        /// <summary>Returns the int4 element at a specified index.</summary>
        unsafe public ref int4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (int4x2* array = &this) { return ref ((int4*)array)[index]; }
            }
        }

        /// <summary>Returns true if the int4x2 is equal to a given int4x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(int4x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

        /// <summary>Returns true if the int4x2 is equal to a given int4x2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((int4x2)o); }


        /// <summary>Returns a hash code for the int4x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the int4x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("int4x2({0}, {1},  {2}, {3},  {4}, {5},  {6}, {7})", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z, c0.w, c1.w);
        }

        /// <summary>Returns a string representation of the int4x2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("int4x2({0}, {1},  {2}, {3},  {4}, {5},  {6}, {7})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a int4x2 matrix constructed from two int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(in int4 c0, in int4 c1) { return new int4x2(c0, c1); }

        /// <summary>Returns a int4x2 matrix constructed from from 8 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(int m00, int m01,
                                    int m10, int m11,
                                    int m20, int m21,
                                    int m30, int m31)
        {
            return new int4x2(m00, m01,
                              m10, m11,
                              m20, m21,
                              m30, m31);
        }

        /// <summary>Returns a int4x2 matrix constructed from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(int v) { return new int4x2(v); }

        /// <summary>Returns a int4x2 matrix constructed from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(bool v) { return new int4x2(v); }

        /// <summary>Return a int4x2 matrix constructed from a bool4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(in bool4x2 v) { return new int4x2(v); }

        /// <summary>Returns a int4x2 matrix constructed from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(uint v) { return new int4x2(v); }

        /// <summary>Return a int4x2 matrix constructed from a uint4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(in uint4x2 v) { return new int4x2(v); }

        /// <summary>Returns a int4x2 matrix constructed from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(float v) { return new int4x2(v); }

        /// <summary>Return a int4x2 matrix constructed from a float4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(in float4x2 v) { return new int4x2(v); }

        /// <summary>Returns a int4x2 matrix constructed from a single double value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(double v) { return new int4x2(v); }

        /// <summary>Return a int4x2 matrix constructed from a double4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(in double4x2 v) { return new int4x2(v); }

        /// <summary>Return the int2x4 transpose of a int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 transpose(in int4x2 v)
        {
            return int2x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w);
        }

        /// <summary>Returns a uint hash code of a int4x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(in int4x2 v)
        {
            return csum(asuint(v.c0) * uint4(0xFAAF07DDu, 0x625C45BDu, 0xC9F27FCBu, 0x6D2523B1u) +
                        asuint(v.c1) * uint4(0x6E2BF6A9u, 0xCC74B3B7u, 0x83B58237u, 0x833E3E29u)) + 0xA9D919BFu;
        }

        /// <summary>
        /// Returns a uint4 vector hash code of a int4x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hashwide(in int4x2 v)
        {
            return (asuint(v.c0) * uint4(0xC3EC1D97u, 0xB8B208C7u, 0x5D3ED947u, 0x4473BBB1u) +
                    asuint(v.c1) * uint4(0xCBA11D5Fu, 0x685835CFu, 0xC3D32AE1u, 0xB966942Fu)) + 0xFE9856B3u;
        }

    }
}
