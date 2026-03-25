using System.Text.Json;

namespace PrototypeDesignPattern.Example1.Models.Abstract;

public abstract class DocumentBase : IDocumentPrototype<DocumentBase>
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime LastModified { get; set; }
    public DocumentMetadata Metadata { get; set; }

    protected DocumentBase()
    {
        Id = Guid.NewGuid().ToString();
        CreatedDate = DateTime.Now;
        LastModified = DateTime.Now;
        Metadata = new DocumentMetadata();
    }

    // Shallow clone: reference-type properties share the same reference
    public virtual DocumentBase Clone()
    {
        var cloned = (DocumentBase)this.MemberwiseClone();
        cloned.Id = Guid.NewGuid().ToString();
        cloned.CreatedDate = DateTime.Now;
        cloned.LastModified = DateTime.Now;
        return cloned;
    }

    // Deep clone via JSON serialization: produces a fully independent copy
    public virtual DocumentBase DeepClone()
    {
        var json = JsonSerializer.Serialize(this, this.GetType());
        var cloned = (DocumentBase)JsonSerializer.Deserialize(json, this.GetType())!;
        cloned.Id = Guid.NewGuid().ToString();
        cloned.CreatedDate = DateTime.Now;
        cloned.LastModified = DateTime.Now;
        return cloned;
    }

    public virtual string GetDocumentInfo() =>
        $"ID: {Id}, Title: {Title}, Type: {GetType().Name}, Created: {CreatedDate:yyyy-MM-dd HH:mm}";

    public abstract bool ValidateDocument();
}