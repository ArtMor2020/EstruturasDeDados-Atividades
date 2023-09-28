using System.Collections;

Hashtable CPFeNome = new Hashtable();
bool fim = false;

string? cpf = "";
string? name = "";
List<string> KeyList = new List<string>();
int top = 0;

while(!fim)
{
    Console.Write("CPF  - ");
    cpf = Console.ReadLine();
    if(cpf == string.Empty)
    {
        fim = true;
    }
    
    if(!fim)
    {
        Console.Write("Nome - ");
        name = Console.ReadLine();
        if(name == string.Empty)
        {
            fim = true;
        }
        if(!fim)
        {   
            KeyList.Add(cpf);
            top++;
            try{CPFeNome.Add(cpf, name);} catch(Exception){Console.WriteLine("Null Key");}
        }
    }
}

Console.WriteLine("");

for(int i = 0; i < top; i++)
{
    Console.WriteLine($"CPF: {KeyList[i]}   Nome: {CPFeNome[KeyList[i]]}");
}

Console.WriteLine("");