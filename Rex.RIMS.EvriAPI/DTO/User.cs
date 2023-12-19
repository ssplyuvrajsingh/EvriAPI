using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class User
{
    public Guid Pkid { get; set; }

    public string Username { get; set; } = null!;

    public string? Firstname { get; set; }

    public string? Surname { get; set; }

    public string ApplicationName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Comment { get; set; }

    public string Password { get; set; } = null!;

    public string? PasswordQuestion { get; set; }

    public string? PasswordAnswer { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public DateTime? LastPasswordChangedDate { get; set; }

    public DateTime? CreationDate { get; set; }

    public bool? IsOnLine { get; set; }

    public bool? IsLockedOut { get; set; }

    public DateTime? LastLockedOutDate { get; set; }

    public int? FailedPasswordAttemptCount { get; set; }

    public int? FailedPasswordAnswerAttemptCount { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public byte[] TlsVersionId { get; set; } = null!;

    public bool? IsShowUser { get; set; }

    public string Theme { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<ImportedOrder> ImportedOrderPackers { get; set; } = new List<ImportedOrder>();

    public virtual ICollection<ImportedOrder> ImportedOrderPickers { get; set; } = new List<ImportedOrder>();

    public virtual ICollection<StockRetailStringLanguageChangeLog> StockRetailStringLanguageChangeLogs { get; set; } = new List<StockRetailStringLanguageChangeLog>();

    public virtual ICollection<StockStringLanguageChangeLog> StockStringLanguageChangeLogs { get; set; } = new List<StockStringLanguageChangeLog>();

    public virtual ICollection<UserCompany> UserCompanies { get; set; } = new List<UserCompany>();
}
