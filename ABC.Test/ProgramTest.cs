using System;
using System.Collections;
using NUnit.Framework;

namespace ABC.test
{
    public class ProgramTest
    {
        static char[] letters = new char[]{ 'A', 'B', 'C', 'D', 'E','F','G' };

        [Test]
        
        public void GivenWordWhenLettersRepeatInInitialArrayResultShouldBeFalse()
        {
            var result = Word.CanMakeWord("BAAD");
            Assert.That(result, Is.EqualTo(false));
        }
        
        [Test]
        
        public void GivenWordWhenLettersAreInInitialArrayResultShouldBeTrue()
        {
            var result = Word.CanMakeWord("BAD");
            result = Word.CanMakeWord("BAD");
            Assert.That(result, Is.EqualTo(true));
        }
        
        [Test]
        
        public void GivenWordWhenLettersAreInInitialArrayResultShouldBeFalse()
        {
            var result = Word.CanMakeWord("HBAAD");
            Assert.That(result, Is.EqualTo(false));
        }
        
        
        
        //Example test format
        [Test]
        public void GivenAStateWhenIDoSomethingItShouldBeSomethingElse()
        {
            // Arrange
            var something = "something";

            // Act
            something += " else";
            
            // Assert
            Assert.AreEqual("something else", something);
        }
    }
}