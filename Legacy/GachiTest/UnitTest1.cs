using System;
using GachiConsole;
using NUnit.Framework;

namespace GachiTest
{
    public class Tests
    {
        private IAnal _boi;
        private Dick _myDick;
        private Dick _mediumDick;

        [SetUp]
        public void Setup()
        {
            _myDick = new Dick(DigSize.PickupOwner);
            _mediumDick = new Dick(DigSize.Medium);
            _boi = new GachiBoy();
        }

        [Test]
        public void SmallDickTest()
        {           
             string result =  _boi.Inject(_myDick);
             Assert.AreEqual("tuc, tuc, tuc\nAre you inside?",result); 
        }
        [Test]
        public void MediumDickTest()
        {           
             string result =  _boi.Inject(_mediumDick,2);
             Assert.AreEqual("Oh!, Oh!",result); 
        }

        [Test]
        public void ExceptionTest()
        {
            Assert.Throws<ArgumentException>(
                ()=>_boi.Inject(new Dick(DigSize.SmartOwner))
                );
        }
        [Test]
        public void InjectionEventTest()
        {
            _boi.OnInjection += Assert.Pass;
            _boi.Inject(_mediumDick,1);
            Assert.Fail("We didn't call event");
        }

    }
}