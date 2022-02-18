using Mensageria.Console.Models;
using System;
using System.Net;
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

    [Fact]
    public void GetHashCode_IsTrue_SameValues()
    {
        var dataHora = DateTimeOffset.Now;
        var ip = IPAddress.Loopback;

        this.Subject.DataHoraEnvio = dataHora;
        this.Subject.IPAddress = ip;

        var expected = HashCode.Combine(dataHora, ip);

        Assert.Equal(expected, this.Subject.GetHashCode());
    }

    [Fact]
    public void GetHashCode_IsFalse_DifferentDateTime()
    {
        var dataHora = DateTimeOffset.Now;
        var ip = IPAddress.Loopback;

        this.Subject.DataHoraEnvio = dataHora.Subtract(TimeSpan.FromDays(1));
        this.Subject.IPAddress = ip;

        var expected = HashCode.Combine(dataHora, ip);

        Assert.NotEqual(expected, this.Subject.GetHashCode());
    }

    [Fact]
    public void GetHashCode_IsFalse_DifferentIPAddress()
    {
        var dataHora = DateTimeOffset.Now;

        this.Subject.DataHoraEnvio = dataHora;
        this.Subject.IPAddress = IPAddress.Broadcast;

        var expected = HashCode.Combine(dataHora, IPAddress.Loopback);

        Assert.NotEqual(expected, this.Subject.GetHashCode());
    }
}