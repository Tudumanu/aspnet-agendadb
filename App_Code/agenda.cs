using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;


public class agenda
{
    private int id;
    private string nome;
    private string telefone;

    // Construtor padrão
    public agenda() { }

    // Construtor Overload
    public agenda(int id, string nome, string telefone)
    {
        // Inicializa valores;
        this.id = id;
        this.nome = nome;
        this.telefone = telefone;
    }

    // Propriedades
    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }

    public string Nome
    {
        get
        {
            return nome;
        }

        set
        {
            nome = value;
        }
    }

    public string Telefone
    {
        get
        {
            return telefone;
        }
        set
        {
            telefone = value;
        }
    }

}