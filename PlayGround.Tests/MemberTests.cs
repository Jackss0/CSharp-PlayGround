using System;
using Xunit;

namespace PlayGound.Tests
{
    public class MemberTests
    {
        [Fact]
        public void String_ShouldBeInmutable()
        {
            string name = "Pepe";

            MakeStrinUpperCase(name);

            Assert.Equal("Pepe", name);
        }

        [Fact]
        public void String_CanBeReplaced()
        {
            string name = "Pepe";

            name = "PEPE";

            Assert.Equal("PEPE", name);
        }

        private void MakeStrinUpperCase(string parameter)
        {
            parameter.ToUpper();
        }

        [Fact]
        public void Class_ShouldBeInmutable()
        {
            ExampleClass exampleClass = new ExampleClass { Name = "Inmutable1" };

            CleanClass(exampleClass);

            Assert.False(string.IsNullOrWhiteSpace(exampleClass.Name));
        }

        [Fact]
        public void Class_ShouldBeReplaced()
        {
            ExampleClass exampleClass = new ExampleClass { Name = "Inmutable1" };

            exampleClass = new ExampleClass();

            Assert.True(string.IsNullOrWhiteSpace(exampleClass.Name));
        }

        private void CleanClass(ExampleClass exampleClass) => exampleClass = new ExampleClass();

        [Fact]
        public void UsingStaticsClass() 
        {
            var nestedStruct = new StaticClass.NestedStruct
            {
                StructInteger = 1
            };
        }

        [Fact]
        public void UsingDelegates()
        {
            StaticClass.StringDelegate stringDelegate = ReturnText;

            StaticClass.VoidDelegate voidDelegate = (a) => Console.WriteLine("A");

            stringDelegate += (b) => "raaa";

            voidDelegate += (a) => Console.WriteLine("B");

            var text = stringDelegate("Delegate return a string!");

            Assert.Equal("raaa", text);
        }

        string ReturnText(string text) => text;
    }

    public class ExampleClass
    {
        public string Name { get; set; }

        public ExampleClass()
        {
        }
    }

    //Default for class is internal 
    static class StaticClass
    {
        //Default for members is private, even for nested Classes and structs
        internal static string TestString { get; set; }

        internal static int TestInt { get; set; }

        internal static NestedStruct nestedStruct { get; set; }

        internal static NestedClass nestedClass { get; set; }

        internal delegate string StringDelegate(string message);

        internal delegate void VoidDelegate(string message);

        internal struct NestedStruct
        {
            internal int StructInteger { get; set; }
        }

        internal class NestedClass
        {
            
        }
    }
}