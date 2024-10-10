namespace HomeControl.Model;
public class Produto{
    public string Nome {get; set;}
    public string Quantidade {get; set;}
    public string Validade {get; set;}
    public string Categoria {get; set;}

    public override string ToString()
    {
        return $"{Nome}, {Quantidade}, {Validade}, {Categoria}";
    }
}