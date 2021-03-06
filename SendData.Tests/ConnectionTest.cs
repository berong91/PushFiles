// <copyright file="ConnectionTest.cs">Copyright ©  2017</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SendData;

namespace SendData.Tests {
    /// <summary>This class contains parameterized unit tests for Connection</summary>
    [PexClass(typeof(Connection))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ConnectionTest {
        /// <summary>Test stub for Connect(String, Int32)</summary>
        [PexMethod]
        public void ConnectTest(
            [PexAssumeUnderTest] Connection target,
            string ip,
            int port
        ) {
            target.Connect(ip, port);
            // TODO: add assertions to method ConnectionTest.ConnectTest(Connection, String, Int32)
        }
    }
}
