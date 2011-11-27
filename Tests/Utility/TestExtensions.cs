using NUnit.Framework;

namespace Tests.Utility
{
    public static class TestExtensions
    {
        public static void ShouldBeEqualTo<T>(this T subject,T item)
        {
            Assert.AreEqual(item,subject);
        }
    }
} 