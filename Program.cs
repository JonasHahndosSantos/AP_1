using System.Security.AccessControl;
int idade, opcao;
double altura, IMC, peso;
string nome;
do{
Console.WriteLine("qual seu nome:");
nome = Console.ReadLine();
System.Console.WriteLine("qual sua idade:");
idade = Convert.ToInt32(Console.ReadLine());    
System.Console.WriteLine("qual sua altura:");
altura = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Qual seu peso:");
peso = Convert.ToDouble(Console.ReadLine());//double IMC = peso/(altura*altura);

IMC = Math.Round(peso/(altura*altura), 2);
string maior = "adulto";
    if(idade<11){
             maior = "criança";
        }
    else{
        if (idade>10 && idade <20){
                 maior = "adolesente";      
    }
        else{
            if(idade>19 && idade<60){
        maior = "adulto";
            }
            else{
                maior = "idoso";
            }
        }

    }
 
    if(IMC <19){
        System.Console.WriteLine("O " + nome + " é " + maior + " e tem " + idade + " anos de idade e possui um IMC de "+ IMC + " isso é considerado abaixo do peso");
    }
    else{
        if(IMC >18  && IMC < 25){
            System.Console.WriteLine($"O {nome} é {maior} e tem {idade} anos de idade e possui um IMC de{IMC} isso é considerado peso normal");
        }
        else{
            if (IMC > 24 && IMC <31 ){
                System.Console.WriteLine("O " + nome + " é " + maior + " e tem " + idade + " anos possui um IMC de "+ IMC +" isso é considerado sobre peso " );
            }
            else{
                    System.Console.WriteLine($"O {nome} é {maior} e tem {idade} anos de idade e possui um IMC de{IMC} isso é considerado obeso");                
            }
        }
    }
    
    

    
        System.Console.WriteLine("se deseja fazer outro calculo aperte 1:\nse deseja sair do programa aperte 2:");
        opcao = Convert.ToInt32(Console.ReadLine());
        if(opcao == 1){
            continue;
        }
        else{
            System.Console.WriteLine("tchau");
            break;
        }
}while(true);
        

    
 







