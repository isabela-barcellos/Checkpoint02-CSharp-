# 1. Conceitos fundamentais

Explique, com suas próprias palavras, os quatro princípios básicos da Orientação a Objetos: **encapsulamento**, **herança**, **polimorfismo** e **abstração**. Para cada princípio, cite um exemplo simples em C# que ilustre seu uso. (Referência aos princípios.)

## Encapsulamento: 

Usamos o encapsulamento para isolar problemas, como o famoso “na minha máquina roda”. Ele é utilizado para deixar o acesso aos dados de uma classe através de métodos, nele esconder detalhes e expor somente o que será usado. Ou seja, ele traz um controle de acesso 

```csharp
public class Funcionario

{

    public string nome;
    private float salario
    

    public float Salario

    {

        get { return salario; }

        set { salario = value; }

    }

}
```

## Herança 

Na herança é onde a classe filho que é estendida de outra que será o pai, irá herdar as propriedades e métodos da classe pai. Isso faz com que não precise criar tudo de novo em outra classe, reutilizando o código. 

```csharp
public class Animal{
	public void Anda(){
		Console.WriteLine("Esse animal anda em quatro patas");
	}
}
public class Porco : Animal{
	public void Come()
	{
		Console.WriteLine("O porco come lavagem");
	}
}

Porco porco = new Porco();
porco Come();
porco Anda();
```

## Polimorfismo

Um método pode ser diferente em cada chamada, como na sobrecarga e sobrescrita dos métodos. Na sobrecarga o método continua com o mesmo nome e carrega parâmetros diferentes e na Sobrescrita terá a substituição de um método na classe que será derivada. 

```csharp

public class Animal
{
    
    public virtual void Anda()
    {
        Console.WriteLine("Esse animal anda em quatro patas.");
    }

    // sobrecarga 
    public void Anda(string tipo)
    {
        Console.WriteLine($"Esse animal anda em {tipo}.");
    }
}

public class Porco : Animal
{
    // Sobrescrita 
    public override void Anda()
    {
        Console.WriteLine("O porco anda com as patas pesadas");
    }

    public void Come()
    {
        Console.WriteLine("O porco come lavagem.");
    }
}

public class Program
{
    public static void Main()
    {
        Porco porco = new Porco();

        porco.Come();
        porco.Anda();

        porco.Anda("com as patas sujas (quando está brincando)");
    }
}

```

## Abstração

Vai trazer apenas a funcionalidade importante, tirando a complexidade do código e trazendo apenas a abstração do que importa

```csharp
public abstract class Animal
{
    public abstract void FazerSom();

    public void Dormir()
    {
        Console.WriteLine("O animal está dormindo...");
    }
}

public class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("O cachorro faz: Au Au!");
    }
}

public class Program
{
    public static void Main()
    {
        Animal cachorro = new Cachorro();

        cachorro.FazerSom(); 
        cachorro.Dormir();   // Método comum a todos os animais
    }
}

```

# 2. Classe vs. objeto

Descreva a diferença entre **classe** e **objeto** em C#. Em seguida, escreva um pequeno trecho de código que declara uma classe simples e cria uma instância (objeto) dessa classe.

A classe será o molde que o objeto irá seguir. Logo temos a classe como uma planta ou estrutura do que teremos e o Objeto o resultado dessa estrutura com os valores atribuídos. 

```csharp
public class Paciente
{
	public string Nome {get; set;}
	public int Idade {get; set;}
	
	public void Saudacoes()
	{
		Console.WriteLine("Seja bem vindo " + Nome)
	}
}

Paciente paciente1 = new Paciente();
paciente1.Nome = "João Pedro";
paciente1.Idade = 1
paciente1.Saudacoes();

```

# 3. Modificadores de acesso A apresentacao de slide menciona diferentes modificadores de acesso em C#: public, private e protected. Explique o significado de cada um e discuta em que situações eles devem ser utilizados ao projetar classes.

**public**: fica publico para qualquer parte do código 

**private**: Ele é privado, então só pode ser acessado dentro da própria classe.

**protected**: Ele será protegido, então ele é acessado dentro da própria classe e suas subclasse. 

O pubic pode ser utilizado em casos o dado não é sensível. 

O private pode ser utilizado em casos onde o dado é sensível e só precisa ser utilizado dentro daquela classe, como por exemplo uma taxa para calcular o salário. 

O protected será usado quando precisamos daquele dados em uma herança que vai passar para as subclasses, mas não queremos que ele fique aberto para todo o restante do código. 

#4. Sobrecarga e sobrescrita

Defina **sobrecarga** (overloading) e **sobrescrita** (overriding) de métodos em C#. Explplique as diferenças entre esses dois mecanismos de polimorfismo e forneça um exemplo de código para cada caso.

Na sobrecarga o método continua com o mesmo nome e carrega parâmetros diferentes e na Sobrescrita terá a substituição de um método na classe que será derivada. 

```csharp

public class Animal
{
    
    public virtual void Anda()
    {
        Console.WriteLine("Esse animal anda em quatro patas.");
    }

    // sobrecarga 
    public void Anda(string tipo)
    {
        Console.WriteLine($"Esse animal anda em {tipo}.");
    }
}

public class Porco : Animal
{
    // Sobrescrita 
    public override void Anda()
    {
        Console.WriteLine("O porco anda com as patas pesadas");
    }

    public void Come()
    {
        Console.WriteLine("O porco come lavagem.");
    }
}

public class Program
{
    public static void Main()
    {
        Porco porco = new Porco();

        porco.Come();
        porco.Anda();

        porco.Anda("com as patas sujas (quando está brincando)");
    }
}

```
