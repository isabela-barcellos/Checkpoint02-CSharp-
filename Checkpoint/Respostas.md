1. Conceitos fundamentais

Explique, com suas pr�prias palavras, os quatro princ�pios b�sicos da Orienta��o a Objetos:�**encapsulamento**,�**heran�a**,�**polimorfismo**�e�**abstra��o**. Para cada princ�pio, cite um exemplo simples em C# que ilustre seu uso. (Refer�ncia aos princ�pios.)

Encapsulamento: 

Usamos o encapsulamento para isolar problemas, como o famoso �na minha m�quina roda�. Ele � utilizado para deixar o acesso aos dados de uma classe atrav�s de m�todos, nele esconder detalhes e expor somente o que ser� usado. Ou seja, ele traz um controle de acesso 

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

Heran�a 

Na heran�a � onde a classe filho que � estendida de outra que ser� o pai, ir� herdar as propriedades e m�todos da classe pai. Isso faz com que n�o precise criar tudo de novo em outra classe, reutilizando o c�digo. 

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

Polimorfismo

Um m�todo pode ser diferente em cada chamada, como na sobrecarga e sobrescrita dos m�todos. Na sobrecarga o m�todo continua com o mesmo nome e carrega par�metros diferentes e na Sobrescrita ter� a substitui��o de um m�todo na classe que ser� derivada. 

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

        porco.Anda("com as patas sujas (quando est� brincando)");
    }
}

```

Abstra��o

Vai trazer apenas a funcionalidade importante, tirando a complexidade do c�digo e trazendo apenas a abstra��o do que importa

```csharp
public abstract class Animal
{
    public abstract void FazerSom();

    public void Dormir()
    {
        Console.WriteLine("O animal est� dormindo...");
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
        cachorro.Dormir();   // M�todo comum a todos os animais
    }
}

```

2. Classe vs. objeto

Descreva a diferen�a entre�**classe**�e�**objeto**�em C#. Em seguida, escreva um pequeno trecho de c�digo que declara uma classe simples e cria uma inst�ncia (objeto) dessa classe.

A classe ser� o molde que o objeto ir� seguir. Logo temos a classe como uma planta ou estrutura do que teremos e o Objeto o resultado dessa estrutura com os valores atribu�dos. 

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
paciente1.Nome = "Jo�o Pedro";
paciente1.Idade = 1
paciente1.Saudacoes();

```

3. Modificadores de acesso�A apresentacao de slide menciona diferentes modificadores de acesso em C#:�public,�private�e�protected. Explique o significado de cada um e discuta em que situa��es eles devem ser utilizados ao projetar classes.

public: fica publico para qualquer parte do c�digo 

private: Ele � privado, ent�o s� pode ser acessado dentro da pr�pria classe.

protected: Ele ser� protegido, ent�o ele � acessado dentro da pr�pria classe e suas subclasse. 

O pubic pode ser utilizado em casos o dado n�o � sens�vel. 

O private pode ser utilizado em casos onde o dado � sens�vel e s� precisa ser utilizado dentro daquela classe, como por exemplo uma taxa para calcular o sal�rio. 

O protected ser� usado quando precisamos daquele dados em uma heran�a que vai passar para as subclasses, mas n�o queremos que ele fique aberto para todo o restante do c�digo. 

4. Sobrecarga e sobrescrita

Defina�**sobrecarga**�(overloading) e�**sobrescrita**�(overriding) de m�todos em C#. Explplique as diferen�as entre esses dois mecanismos de polimorfismo e forne�a um exemplo de c�digo para cada caso.

Na sobrecarga o m�todo continua com o mesmo nome e carrega par�metros diferentes e na Sobrescrita ter� a substitui��o de um m�todo na classe que ser� derivada. 

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

        porco.Anda("com as patas sujas (quando est� brincando)");
    }
}

```