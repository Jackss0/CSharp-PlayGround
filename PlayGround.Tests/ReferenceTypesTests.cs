using System.Collections.Generic;
using System.Linq;
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

            var similarCollection = new[] { 3, 4, 5 };

            WipeArray(collection);

            Assert.NotEmpty(collection);
            Assert.False(collection == similarCollection);
        }

        [Fact]
        public void ComparingDifferentCollections()
        {
            var list = new List<int> { 3, 4, 5 };
            var similarList = new List<int> { 3, 4, 5 };

            var collection = new[] { 3, 4, 5 };
            var similarCollection = new[] { 3, 4, 5 };


            Assert.True(list.SequenceEqual(similarList));
            Assert.True(collection.SequenceEqual(similarCollection));
            Assert.True(list.SequenceEqual(similarCollection));
        }

        [Fact]
        public void AssignmentCollectionsAreEquals()
        {
            var list = new List<int> { 3, 4, 5 };
            var assignmentList = list;

            var collection = new[] { 3, 4, 5 };
            var assignmentCollection = collection;


            Assert.True(list == assignmentList);
            Assert.True(collection == assignmentCollection);
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
