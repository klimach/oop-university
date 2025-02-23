using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Project
{
    abstract class Number
    {
        public abstract Number Add(Number other);
        public abstract Number Subtract(Number other);
        public abstract Number Multiply(Number other);
        public abstract Number Divide(Number other);

        public static Number operator +(Number a, Number b) => a.Add(b);
        public static Number operator -(Number a, Number b) => a.Subtract(b);
        public static Number operator *(Number a, Number b) => a.Multiply(b);
        public static Number operator /(Number a, Number b) => a.Divide(b);
    }

    class Integer(int value) : Number
    {
        public int Value { get; } = value;

        public override Number Add(Number other)
        {
            return other switch
            {
                Integer intNum => new Integer(Value + intNum.Value),
                Real realNum => new Real(Value + realNum.Value),
                _ => throw new ArgumentException("Unsupported number type")
            };
        }

        public override Number Subtract(Number other)
        {
            return other switch
            {
                Integer intNum => new Integer(Value - intNum.Value),
                Real realNum => new Real(Value - realNum.Value),
                _ => throw new ArgumentException("Unsupported number type")
            };
        }

        public override Number Multiply(Number other)
        {
            return other switch
            {
                Integer intNum => new Integer(Value * intNum.Value),
                Real realNum => new Real(Value * realNum.Value),
                _ => throw new ArgumentException("Unsupported number type")
            };
        }

        public override Number Divide(Number other)
        {
            return other switch
            {
                Integer intNum => new Real((double)Value / intNum.Value),
                Real realNum => new Real(Value / realNum.Value),
                _ => throw new ArgumentException("Unsupported number type")
            };
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    class Real(double value) : Number
    {
        public double Value { get; } = value;

        public override Number Add(Number other)
        {
            return other switch
            {
                Integer intNum => new Real(Value + intNum.Value),
                Real realNum => new Real(Value + realNum.Value),
                _ => throw new ArgumentException("Unsupported number type")
            };
        }

        public override Number Subtract(Number other)
        {
            return other switch
            {
                Integer intNum => new Real(Value - intNum.Value),
                Real realNum => new Real(Value - realNum.Value),
                _ => throw new ArgumentException("Unsupported number type")
            };
        }

        public override Number Multiply(Number other)
        {
            return other switch
            {
                Integer intNum => new Real(Value * intNum.Value),
                Real realNum => new Real(Value * realNum.Value),
                _ => throw new ArgumentException("Unsupported number type")
            };
        }

        public override Number Divide(Number other)
        {
            return other switch
            {
                Integer intNum => new Real(Value / intNum.Value),
                Real realNum => new Real(Value / realNum.Value),
                _ => throw new ArgumentException("Unsupported number type")
            };
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
