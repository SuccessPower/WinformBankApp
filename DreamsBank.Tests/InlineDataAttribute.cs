using System;

namespace DreamsBank.Test
{
    internal class InlineDataAttribute : Attribute
    {
        private int v1;
        private int v2;
        private int v3;

        public InlineDataAttribute(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}