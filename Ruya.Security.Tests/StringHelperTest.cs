using System.Text;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ruya.Security;

namespace Ruya.Security.Tests
{
    /// <summary>This class contains parameterized unit tests for StringHelper</summary>
    [TestClass]
    [PexClass(typeof(StringHelper))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StringHelperTest
    {

        /// <summary>Test stub for ToMD5(String, Encoding)</summary>
        [PexMethod]
        public string ToMD5Test(string input, Encoding encoding)
        {
            string result = StringHelper.ToMD5(input, encoding);
            return result;
            // TODO: add assertions to method StringHelperTest.ToMD5Test(String, Encoding)
        }
    }
}
