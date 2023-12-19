using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class Category
{
    public int CategoryId { get; set; }

    public int? ParentCategoryId { get; set; }

    public bool? Visable { get; set; }

    public string? CategoryImageName { get; set; }

    public int? Tid { get; set; }

    public Guid XfsSynchronizationKeyId { get; set; }

    public Guid TlsSynchronizationKeyId { get; set; }

    public byte[] TlsVersionId { get; set; } = null!;

    public int? NameStringId { get; set; }

    public int? IntroTextStringId { get; set; }

    public int? SortOrder { get; set; }

    public bool IsHiddenRexInter { get; set; }

    public bool IsHiddenDotCom { get; set; }

    public virtual StringMessage? IntroTextString { get; set; }

    public virtual StringMessage? NameString { get; set; }

    public virtual ICollection<Stock> StockCodes { get; set; } = new List<Stock>();
}
