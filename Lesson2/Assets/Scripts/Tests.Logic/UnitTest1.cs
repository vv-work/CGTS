using Logic;
using NUnit.Framework;
using NSubstitute;

public class UnitTest1 
{
        private IManager<string> _manager;
        private IData<string> _fakeData;
        private IPickable<string> _fakePickable;

        [SetUp]
        public void Setup()
        {
            _manager = new Manager<string>();
            _fakeData = NSubstitute.Substitute.For<IData<string>>();
            _fakePickable = NSubstitute.Substitute.For<IPickable<string>>();
            _fakePickable.GetData().Returns(_fakeData);

        }

        [Test]
        public void Test1()
        {
            _manager.OnItemPicked += (a) => Assert.Pass();

            _manager.Pick(_fakePickable);
            Assert.Fail();
        }
}
