using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public abstract class ContextSpec<T>
    {
        protected T Sut { get; set; }
        protected abstract T CreateSut();

        [SetUp]
        public void Setup()
        {
            Sut = CreateSut();
            UnderTheseConditions();
            BecauseOf();
        }

        protected abstract void UnderTheseConditions();
        protected abstract void BecauseOf();
    }
}