using System.Net;

namespace Mensageria.Console.Models;

public class Mensagem : IEquatable<Mensagem?>, IComparable<Mensagem>
{
    #region Properties
    public string Conteudo { get; set; }

    public DateTimeOffset DataHoraEnvio { get; set; }

    public IPAddress IPAddress { get; set; }
    #endregion

    #region Equality
    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        return this.Equals(obj as Mensagem);
    }

    /// <inheritdoc/>
    public bool Equals(Mensagem? other)
    {
        return other is not null
            && this.DataHoraEnvio.Equals(other.DataHoraEnvio)
            && EqualityComparer<IPAddress>.Default.Equals(this.IPAddress, other.IPAddress);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return HashCode.Combine(this.DataHoraEnvio, this.IPAddress);
    }
    #endregion

    /// <inheritdoc/>
    public int CompareTo(Mensagem? other)
    {
        return other is not null
             ? this.DataHoraEnvio.CompareTo(other.DataHoraEnvio)
             : 1;
    }
}
