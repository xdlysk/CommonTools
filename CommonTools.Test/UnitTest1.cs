using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTools.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var str = CommonTools.Encryption.RSAKeyConvert.RSAPublicKeyJava2DotNet("MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDJh1WrGiIhXsfm72sCZGHj6uYdJ7VYX5b8x3Ax6hQw/hH2Utmjm8rtXmsB4WfIn4WB/ytN2mX1878f6Mbep8PM6VP0OyjjYSHdE7Md4FU2qi5H/YPsv7XA84P/bzXT5fgFyPDKZEnSHPnHsxI4RNaGRhBKTdhg/kCLxrFxyxIQ4QIDAQAB");

        }
    }
}
