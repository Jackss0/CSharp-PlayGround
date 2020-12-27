using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PlayGround.Tests
{
    public class ReferenceTypesTests
    {
        [Fact]
        public void StringsAreReferenceTypes()
        {
            var word = "test";

            word.ToUpper();

            Assert.NotEqual("TEST", word);
        }

        [Fact]
        public void ArraysAreReferenceTypes()
        {
            var collection = new[] { 3, 4, 5 };

            WipeArray(collection);

            Assert.NotEmpty(collection);
        }

        private void WipeArray(int[] collection) => collection = new int[] { };

        [Fact]
        public void ClassesAreReferenceTypes()
        {
            var exampleClass = new ExampleClass{Name = "Test"};

            WipeClass(exampleClass);

            Assert.NotNull(exampleClass.Name);
        }

        private void WipeClass(ExampleClass exampleClass)
        {
            exampleClass = new ExampleClass();
        }
    }

    public class ExampleClass
    {
        public string Name { get; set; }
    }
}
