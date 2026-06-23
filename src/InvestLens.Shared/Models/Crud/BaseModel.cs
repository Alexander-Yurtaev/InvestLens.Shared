namespace InvestLens.Shared.Models.Crud;

public abstract class BaseModel
{
    protected BaseModel()
    {
        
    }

    protected BaseModel(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}