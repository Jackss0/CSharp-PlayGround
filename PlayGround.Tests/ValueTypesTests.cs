using Xunit;

namespace PlayGround.Tests
{
    public class ValueTypesTests
    {
        //Value types hold directly the value in memory and can be change for other value of he same type

        [Fact]
        public void IntegersAreValueTypes()
        {
            var number = 4;

            number *= 2;

            Assert.Equal(8, number);
        }

        [Fact]
        public void BooleansAreValueTypes()
        {
            var fact = true;

            fact = false;

            Assert.False(fact);
        }
        // The following are value types
        //bool
        //byte
        //char
        //decimal
        //double
        //enum
        //float
        //int
        //long
        //sbyte
        //short
        //struct
        //uint
        //ulong
        //ushort
    }
}