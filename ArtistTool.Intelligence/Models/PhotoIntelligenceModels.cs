namespace ArtistTool.Intelligence;

public class TagCategoryResponse
{
    public List<string>? Tags { get; set; }
    public List<string>? Categories { get; set; }
}

public class MarketingContentResponse
{
    public decimal? Price { get; set; }
    public string? Headline { get; set; }
    public string? MarketingCopy { get; set; }
    public string? TwitterText { get; set; }
}

public class MarketingContent
{
    public decimal Price { get; set; }
    public string Headline { get; set; } = string.Empty;
    public string MarketingCopy { get; set; } = string.Empty;
    public string TwitterText { get; set; } = string.Empty;
}


public class CanvasPreviewResult
{
    public string PhotoId { get; set; } = string.Empty;
    public string PathToCanvasPreview { get; set; } = string.Empty;
    public string Headline { get; set; } = string.Empty;
    public string MarketingCopy { get; set; } = string.Empty;
    public string TwitterText { get; set; } = string.Empty;
    public decimal Price { get; set; } = 0;
}

public class PhotoAnalysisResult
{
    public string OriginalFileName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> SuggestedTags { get; set; } = new();
    public List<string> SuggestedCategories { get; set; } = new();
}
