using Questao1;

Cliente c1 = new Cliente("Vitor", "75868134001", "132228166", new DateTime(1999, 8, 21));
Contato contato1 = new Contato(20, "Maria", "(28) 2745-1469", TipoRelacionamento.Amigo);
Contato contato2 = new Contato(9, "Valéria", "(44) 3284-7229", TipoRelacionamento.Mae);
Contato contato3 = new Contato(5, "Jânio", "(63) 2222-6449", TipoRelacionamento.Pai);
Contato contato4 = new Contato(2, "Camargo", "(28) 2745-1469", TipoRelacionamento.Amigo);
Contato contato5 = new Contato(1, "Tobias", "(53) 2965-5802", TipoRelacionamento.Outros);

c1.AdicionarContato(contato1);
c1.AdicionarContato(contato2);
c1.AdicionarContato(contato3);
c1.AdicionarContato(contato4);
c1.AdicionarContato(contato5);

c1.ExibirContatos();

