using System;
using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace WinNetCoreApp.Tests.Unit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            Console.WriteLine(md5.ComputeHash(Encoding.ASCII.GetBytes("test")));

            Assert.True(true);
        }
    }
}
