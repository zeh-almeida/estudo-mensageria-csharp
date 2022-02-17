using Mensageria.Console.Models;
using Xunit;

namespace UnitTest.Mensageria.Console.Models;

public sealed record MensagemTest
{
    #region Properties
    private Mensagem Subject { get; }
    #endregion

    #region Constructors
    public MensagemTest()
    {
        this.Subject = new Mensagem();
    }
    #endregion

    [Fact]
    public void Equals_Object_IsTrueForMessage()
    {
        Assert.True(this.Subject.Equals(this.Subject));
        Assert.True(this.Subject.Equals(this.Subject as object));
    }

    [Fact]
    public void Equals_Object_IsFalseForNonMessage()
    {
        Mensagem? test = null;

        Assert.False(this.Subject.Equals(test));
        Assert.False(this.Subject.Equals(1));
    }
}