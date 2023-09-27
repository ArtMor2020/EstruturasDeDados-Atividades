string[,] Matriz = new string[,]{ // Matriz do tabuleiro
    {"_", "_", "_"},
    {"_", "_", "_"},
    {"_", "_", "_"}
};

string jogador = "X";
int rodada = 1;
int var = 0;
int fim_rodada = 0;
int fim_jogador = 0;
int inv = 0;

void tabuleiro(){
    for(int i=0; i < Matriz.GetLength(0); i++){
        for(int j = 0; j < Matriz.GetLength(1); j++){
            Console.Write($"{Matriz[i,j]} ");
        }
        Console.WriteLine("");
    }
}

tabuleiro();

while(fim_jogador == 0 && fim_rodada == 0){ //enquanto tiverem rodadas e nenhum jogador ganhou rodar o jogo da velha

    //para alternar entre os jogadores, caso a posicao nao seja invalida
    if(inv == 0){
        if(var == 0){var = 1; jogador = "X";}
        else if(var == 1){var = 0; jogador = "O";}
    }

    Console.WriteLine("");
    Console.WriteLine($"Turno {rodada} do jodador {jogador}");
    Console.WriteLine("");

    inv = 0;

    //ler posição jogada
    Console.WriteLine("Linha: ");
    int linha = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Coluna: ");
    int coluna = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    //checar se a posição é valida
    if(Matriz[linha-1, coluna-1] == "X" || Matriz[linha-1, coluna-1] == "O"){
        Console.WriteLine("Posição Invalida!");
        Console.WriteLine("");
        inv = 1;
    }
    else{
        Matriz[linha-1, coluna-1] = jogador;
        rodada++;
    }

    //mostrar o tabuleiro no terminal
    tabuleiro();

    //detectar vitoria do jogador X
    for(int i = 0; i < 3; i++){
        if(Matriz[i,0] == "X" && Matriz[i,1] == "X" && Matriz[i,2] == "X"){
            fim_jogador = 1;
        }
        if(Matriz[0,i] == "X" && Matriz[1,i] == "X" && Matriz[2,i] == "X"){
            fim_jogador = 1;
        }
    }
    if(Matriz[0,0] == "X" && Matriz[1,1] == "X" && Matriz[2,2] == "X"){
        fim_jogador = 1;   
    }
    if(Matriz[0,2] == "X" && Matriz[1,1] == "X" && Matriz[2,0] == "X"){
        fim_jogador = 1;        
    }

    //detectar vitoria do jogador O
    for(int i = 0; i < 3; i++){
        if(Matriz[i,0] == "O" && Matriz[i,1] == "O" && Matriz[i,2] == "O"){
            fim_jogador = 1;
        }
        if(Matriz[0,i] == "O" && Matriz[1,i] == "O" && Matriz[2,i] == "O"){
            fim_jogador = 1;
        }
    }
    if(Matriz[0,0] == "O" && Matriz[1,1] == "O" && Matriz[2,2] == "O"){
        fim_jogador = 1;   
    }
    if(Matriz[0,2] == "O" && Matriz[1,1] == "O" && Matriz[2,0] == "O"){
        fim_jogador = 1;        
    }

    //para forçar o fim apos 9 jogadas
    if(rodada ==10 ){
        fim_rodada = 1;
    }
}

//mensagem de empate
if(fim_jogador == 0 && fim_rodada == 1){
    Console.WriteLine("");
    Console.WriteLine("Fim de Jogo");
    Console.WriteLine("Empate!");
}

//mensagem de vitoria
if(fim_jogador == 1){
    Console.WriteLine("");
    Console.WriteLine("Fim de Jogo");
    Console.WriteLine($"Jogador {jogador} venceu!");
}