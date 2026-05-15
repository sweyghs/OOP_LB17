using System;

namespace Lab9_Inheritance
{
    public abstract class Pair
    {
        public abstract Pair Add(Pair other);
        public abstract Pair Sub(Pair other);
        public abstract Pair Mul(Pair other);
        public abstract Pair Div(Pair other);
        public abstract void Print();
    }
}