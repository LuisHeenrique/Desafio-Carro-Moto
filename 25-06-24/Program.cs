Carro c1 = new Carro();

Moto m1 = new Moto();

//criar array de inteiros de tamanho 5
int[] notas = new int[5];
// atribui valores ao array
notas[0] = 90;
notas[1] = 85;
notas[2] = 88;
notas[3] = 92;
notas[4] = 95;

//acessando e imprimindo as notas dos alunos
for (int i = 0; i < notas.Length; i++) 
{
    Console.WriteLine($"Nota do Aluno {i + 1}: {notas[i]}");
}
//Cria uma lista vazia de veiculos
List<Veiculo> veiculos = new List<Veiculo>();

//adicionar veiculos
veiculos.Add(c1);
veiculos.Add(m1);

//remover veiculos



foreach(Veiculo veiculo in veiculos)
{
    veiculo.Acelerar();
    veiculo.ExibirVelocidade();
    veiculo.Frear();
    veiculo.ExibirVelocidade();
}
