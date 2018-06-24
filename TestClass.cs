using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBarQix
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TranslateNumber1()
        {
            Translator translator = new Translator();
            Assert.AreEqual("1", translator.Translate("1"));
        }

        [Test]
        public void TranslateNumber2()
        {
            Translator translator = new Translator();
            Assert.AreEqual("2", translator.Translate("2"));
        }

        [Test]
        public void TranslateNumber3()
        {
            Translator translator = new Translator();
            Assert.AreEqual("FooFoo", translator.Translate("3"));
        }

        [Test]
        public void TranslateNumber4()
        {
            Translator translator = new Translator();
            Assert.AreEqual("4", translator.Translate("4"));
        }

        [Test]
        public void TranslateNumber5()
        {
            Translator translator = new Translator();
            Assert.AreEqual("BarBar", translator.Translate("5"));
        }

        [Test]
        public void TranslateNumber6()
        {
            Translator translator = new Translator();
            Assert.AreEqual("Foo", translator.Translate("6"));
        }

        [Test]
        public void TranslateNumber7()
        {
            Translator translator = new Translator();
            Assert.AreEqual("QixQix", translator.Translate("7"));
        }

        [Test]
        public void TranslateNumber9()
        {
            Translator translator = new Translator();
            Assert.AreEqual("Foo", translator.Translate("9"));
        }

        [Test]
        public void TranslateNumber10()
        {
            Translator translator = new Translator();
            Assert.AreEqual("Bar*", translator.Translate("10"));
        }

        [Test]
        public void TranslateNumber13()
        {
            Translator translator = new Translator();
            Assert.AreEqual("Foo", translator.Translate("13"));
        }


        [Test]
        public void TranslateNumber15()
        {
            Translator translator = new Translator();
            Assert.AreEqual("FooBarBar", translator.Translate("15"));
        }

        [Test]
        public void TranslateNumber21()
        {
            Translator translator = new Translator();
            Assert.AreEqual("FooQix", translator.Translate("21"));
        }

        [Test]
        public void TranslateNumber33()
        {
            Translator translator = new Translator();
            Assert.AreEqual("FooFooFoo", translator.Translate("33"));
        }

        [Test]
        public void TranslateNumber51()
        {
            Translator translator = new Translator();
            Assert.AreEqual("FooBar", translator.Translate("51"));
        }

        [Test]
        public void TranslateNumber53()
        {
            Translator translator = new Translator();
            Assert.AreEqual("BarFoo", translator.Translate("53"));
        }

        [Test]
        public void TranslateNumber101()
        {
            Translator translator = new Translator();
            Assert.AreEqual("1*1", translator.Translate("101")); 
        }

        [Test]
        public void TranslateNumber303()
        {
            Translator translator = new Translator();
            Assert.AreEqual("FooFoo*Foo", translator.Translate("303")); 
        }

        [Test]
        public void TranslateNumber105()
        {
            Translator translator = new Translator();
            Assert.AreEqual("FooBarQix*Bar", translator.Translate("105"));
        }

        [Test]
        public void TranslateNumber10101()
        {
            Translator translator = new Translator();
            Assert.AreEqual("FooQix**", translator.Translate("10101"));
        }

    }
}
