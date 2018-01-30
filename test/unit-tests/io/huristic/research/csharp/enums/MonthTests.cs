using System;
using NUnit.Framework;

namespace Io.huristic.research.csharp.enums {
    public class MonthTests {

        [Test]
        public void sameMonthsShouldBeEqual() {

            Month m1 = Month.April;
            Month m2 = Month.April;

            Assert.True(m1.Equals(m2));
            Assert.AreEqual(m1, m2);
            Assert.True(m1 == m2);
        }

        [Test]
        public void monthShouldBePassedByReference() {
            var m1 = Month.December;
            var m2 = Month.January;

            //Since the two month variables are not equal we expect this assertion to pass
            Assert.AreNotEqual(m1, m2);

            //We assign value of m1 to new variable m3
            //Since Month is a struct this assignment should be a copy by value not copy by reference
            //So m3 is expected to have the same value of m1, but it's stored on the stack and is not
            //just a new reference to the same memory location of where the value of m1 is stored
            var m3 = m1;

            //We validate once more that m2 and m3 are not the same because m3 contains the value of m1
            Assert.AreNotEqual(m2, m3);

            //Here's the most important bit. We change the value of m1 to January (same as m2)
            m1 = Month.January;

            //We validate now that m2 and m1 are equal as both contain value for Month.January
            Assert.AreEqual(m2, m1);

            //Since Month is a struct, m3 will still not be equal to m2 because m3 contains the old
            //value of m1 before the new assignment (Month.December) and since m3 is not just a reference
            //to m1's value it did not receive the updated Month.January value.
            Assert.AreNotEqual(m2, m3);
            
            //Might as well run this assertion to check for reference inequality
            Assert.AreNotSame(m1, m3);
        }

        [Test]
        public void monthShouldBeNullableValueType() {
            Month? month = null;

            Assert.False(month.HasValue);
            Assert.IsNull(month);
        }

        [Test]
        public void monthShouldHaveADefaultValue() {
            Month m1 = default(Month);
            Month m2 = new Month();

            Assert.AreEqual(m1, m2);
            Assert.IsTrue(m1.IsDefault);
            Assert.IsTrue(m2.IsDefault);
        }

        [Test]
        public void defaultMonthShouldNotBeSameAsNonDefault() {
            Month m1 = default(Month);
            Month m2 = Month.July;

            Assert.AreNotEqual(m1, m2);
        }
    }
}
