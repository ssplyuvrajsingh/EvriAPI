using System;
using System.Collections.Generic;

namespace Rex.RIMS.EvriAPI.DTO;

public partial class CategoryByProductView
{
    public int? CategoryId { get; set; }

    public int? ParentCategoryId { get; set; }

    public bool? Visable { get; set; }

    public string? CategoryImageName { get; set; }

    public int? Tid { get; set; }

    public int? NameStringId { get; set; }

    public string? NameEnglish { get; set; }

    public int? IntroTextStringId { get; set; }

    public int? SortOrder { get; set; }

    public bool? IsHiddenRexInter { get; set; }

    public bool? IsHiddenDotCom { get; set; }

    public Guid? XfsSynchronizationKeyId { get; set; }

    public string? Path { get; set; }
}
