using NUnit.Framework;
using System.Threading;
using System.Windows;

namespace dotnet_core_wpf_app.Tests
{
    [TestFixture]
    public class Tests
    {
        private MainWindow _window;

        [SetUp]
        public void Setup()
        {
            _window = new MainWindow();
        }

        [TestCase(TestName = "MainWindow is a sub-class of Window.")]
        [Apartment(ApartmentState.STA)]
        public void UnitTest1()
        {
            Assert.IsInstanceOf(typeof(Window), _window);
        }

        [TestCase(TestName = "MainWindow's Title is set correctly.")]
        [Apartment(ApartmentState.STA)]
        public void UnitTest2()
        {
            Assert.AreEqual("Example .NET Core WPF Application", _window.Title);
        }
    }
}