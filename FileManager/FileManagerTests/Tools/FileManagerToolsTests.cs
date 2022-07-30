using FileManager.Configuration;
using FileManager.Percistances;
using FileManager.Tools;
using Microsoft.AspNetCore.Http;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerTests.Tools
{
  [TestFixture]
  public class FileManagerToolsTests
  {

    private Mock<IFormFile> file;

    [SetUp]
    public void SetUp()
    {
      file = new Mock<IFormFile>();
    }

    [Test]
    public void SaveFileAsync_SaveFileSuccessfully_ReturnTupleOfTrueAndFilePath()
    {

      file.SetupGet(file => file.Name).Returns("fileName");
      var result =  FileManagerTools.SaveFileAsync(file.Object, "title", "path").Result;

      Assert.That(result.isSuccessFull,Is.True);
      Assert.That(result.filePath, Does.Contain("fileName"));
      Assert.That(result.filePath, Does.Contain("title"));
      Assert.That(result.filePath, Does.Contain("path"));

    }

    [Test]
    [TestCase(null,null)]
    [TestCase(null, " ")]
    [TestCase(" ", null)]
    [TestCase(" ", " ")]
    public void SaveFileAsync_SavingFileFail_ReturnTupleOfFalseAndErrorMessage(string title , string path)
    {
      var result = FileManagerTools.SaveFileAsync(file.Object, title, path).Result;
      Assert.That(result, Is.EqualTo((false,"", FileIOErrors.FileSavingFailed)));
    }


  }
}
