# POO

## Encapsulamento

Atribui valors privados que só conseguem ser acessados pela classe

    public class ContaBancaria
    {
        private decimal saldo = 20.53m;

        public void Sacar(decimal valor){
            if(valor <= saldo){
                saldo -= valor;
            }else{
                Console.WriteLine($"Saldo insuficiente!!");
            }
        }

        public void MostrarSaldo(){
            Console.WriteLine($"Saldo: {saldo}");
        }
    }

A variável saldo não consegue ser acessada no main, somente os métodos públicos

    ContaBancaria conta = new ContaBancaria();
        
    conta.Sacar(20);
    conta.MostrarSaldo();

## Polimorfismo

Reutilizar/Reescrever

    public class Animal
    {
        public string nome; public string idade; public string raca; public string cor;

        public virtual void emitirSom()
        {
            Console.WriteLine($"O animal faz um som");
        }
    }

Mudando método virtual emitirSom()

    public class Cachorro:Animal
    {
        public override void emitirSom()
        {
            Console.WriteLine($"Au au");
        }
    }

## Abstração

    public abstract class Animal

A classe Animal só poderá ser utilizada como herança (: Animal), e não pode ser instanciada

    public abstract void comer();

Quando criar um método abstract ele é OBRIGATÓRIO ser chamado na classe filho com override

    public class Gato : Animal
    {
        public override void comer()
    }
