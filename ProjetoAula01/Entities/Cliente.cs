﻿namespace ProjetoAula01.Entities;
public class Cliente
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }
    public DateTime DataHoraCadastro { get; set; }
}
