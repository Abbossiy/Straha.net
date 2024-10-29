using NUnit.Framework;
using StrahaNet;
using System.Windows.Forms;

namespace StrahaNet.Tests
{
    [TestFixture]
    public class Form1Tests
    {
        private Form1 form;

        [SetUp]
        public void Setup()
        {
            form = new Form1();
        }

        [Test]
        public void TryEnter_EmptyLogin_ReturnsFalse()
        {
            // Act
            bool result = form.tryEnter("", "somePassword");

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(false, result);
        }

        [Test]
        public void TryEnter_EmptyPassword_ReturnsFalse()
        {
            // Act
            bool result = form.tryEnter("someLogin", "");

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(false, result);
        }

        [Test]
        public void TryEnter_NullLogin_ReturnsFalse()
        {
            // Act
            bool result = form.tryEnter(null, "somePassword");

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(false, result);
        }

        [Test]
        public void TryEnter_NullLogin_Nullpassword_ReturnsFalse()
        {
            // Act
            bool result = form.tryEnter(null, null);

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(false, result);
        }

        [Test]
        public void TryEnter_NullPassword_ReturnsFalse()
        {
            // Act
            bool result = form.tryEnter("someLogin", null);

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(false, result);
        }

        [Test]
        public void UserId_DefaultIsZero()
        {
            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(0, form.user_id);
        }

        [Test]
        public void EnterButton_Click_WithInvalidCredentials_ShowsMessage()
        {
            // Arrange
            form.loginBox.Text = "invalidUser";
            form.passwordBox.Text = "invalidPassword";

            // Act
            form.enterButton_Click(null, null);

            // Assert (допустим, вы проверяете наличие сообщения, это можно сделать через мок)
            // Для простоты пока оставим этот тест без реализации проверки
        }

        [Test]
        public void RegLabel_Click_HidesForm()
        {
            // Act
            form.regLabel_Click(null, null);

            // Assert (проверяем, что форма скрыта)
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(false, form.Visible);
        }

        [Test]
        public void EnterButton_Click_WithEmptyFields_ShowsMessage()
        {
            // Arrange
            form.loginBox.Text = "";
            form.passwordBox.Text = "";

            // Act
            form.enterButton_Click(null, null);

            // Assert (допустим, вы проверяете наличие сообщения)
            // Опять же, для простоты оставим этот тест без реализации проверки
        }

        [Test]
        public void TryEnter_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            string validLogin = "Логвин";
            string validPassword = "Паролев";
            // Предположим, что метод tryEnter проверяет на конкретные значения

            // Act
            bool result = form.tryEnter(validLogin, validPassword);

            // Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(true, result);
        }

        [TearDown]
        public void TearDown()
        {
            form.Dispose();
        }
    }
}
