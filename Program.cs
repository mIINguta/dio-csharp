﻿using System.Dynamic;
using ExemplosFundamentos.Models;


string apresentacao = "Olá, seja bem vindo!";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;


Console.WriteLine("Valor da variável: " + apresentacao);
Console.WriteLine("Valor da variável: " + quantidade);
Console.WriteLine("Valor da variável: " + altura.ToString("0.00")); // tratamento manual para aumentar as casas decimais
Console.WriteLine("Valor da variável: " + preco);
Console.WriteLine("Valor da variável: " + condicao);

Pessoa p = new Pessoa();

p.Nome = "Gustavo Minguta";
p.Idade = 23;


//p.Apresentar();