using System.Collections;

Hashtable CPFeNome = new Hashtable();
bool fim = false;
bool pause = false;

string? cpf = "";
string? name = "";
List<string> KeyList = new List<string>();

while(!fim)
{
    Console.Write("CPF  - ");
    cpf = Console.ReadLine();
    if(cpf == string.Empty)
    {
        fim = true;
    }

    for(int i = 0; i < KeyList.Count; i++)
    {
        if(KeyList[i] == cpf)
        {
            Console.WriteLine("CPF já esta na lista.");
            pause = true;
        }
    }
    if(!pause)
    {
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
                try{CPFeNome.Add(cpf, name);} catch(Exception){Console.WriteLine("Null Key");}
            }
        }
    }
    pause = false;
}

Console.WriteLine("");

for(int i = 0; i < KeyList.Count; i++)
{
    Console.WriteLine($"CPF: {KeyList[i]}   Nome: {CPFeNome[KeyList[i]]}");
}

Console.WriteLine("");